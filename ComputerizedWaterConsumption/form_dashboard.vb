Imports MySql.Data.MySqlClient

Public Class frm_dashboard
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim table As New DataTable()
    Dim ID As String

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "  System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_auth_name.Click

    End Sub

    Private Sub frm_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datagrid_transaction.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        datagrid_transaction.MultiSelect = False

        lbl_date.Text = DateTime.Now.ToString("MMM dd, yyyy")
        lbl_greet.Text = get_greetings()
        Timer1.Enabled = True

        Dim columnButton As New DataGridViewButtonColumn
        table.Columns.Add("ID", Type.GetType("System.String"))
        table.Columns.Add("Name", Type.GetType("System.String"))
        table.Columns.Add("Address", Type.GetType("System.String"))
        table.Columns.Add("Contact", Type.GetType("System.String"))
        table.Columns.Add("Status", Type.GetType("System.String"))
        table.Columns.Add("Created At", Type.GetType("System.String"))
        datagrid_transaction.DataSource = table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"

        Try
            get_no_of_user()
            paid_unpaid_users()

            MysqlConn.Open()
            Dim Query As String
            Query = "select * from computerized_water_consumption_db.user where id <> '1' order by created_at desc"
            Dim Adapter As New MySqlDataAdapter(Query, MysqlConn)
            Dim Dataset As New DataSet()
            MysqlConn.Close()

            If Adapter.Fill(Dataset) Then
                For x As Integer = 0 To Dataset.Tables(0).Rows.Count - 1
                    Dim id As String = Dataset.Tables(0).Rows(x)("id").ToString()
                    Dim name As String = Dataset.Tables(0).Rows(x)("fname").ToString() + " " + Dataset.Tables(0).Rows(x)("lname").ToString()
                    Dim address As String = Dataset.Tables(0).Rows(x)("address").ToString()
                    Dim contact_number As String = Dataset.Tables(0).Rows(x)("contact_number").ToString()
                    Dim created_at As String = Dataset.Tables(0).Rows(x)("created_at").ToString()
                    Dim status As String = get_user_status(id)
                    table.Rows.Add(id, name, address, contact_number, status, created_at)

                    If status = "UNPAID" Then
                        datagrid_transaction.Rows(x).Cells(4).Style.ForeColor = Color.LightCoral
                    Else
                        datagrid_transaction.Rows(x).Cells(4).Style.ForeColor = Color.ForestGreen
                    End If
                    'datagrid_transaction.Rows.Add(New String() {id, name, address, contact_number, "", created_at, ""})
                Next

                datagrid_transaction.DataSource = table
                columnButton.Text = "Select"
                columnButton.UseColumnTextForButtonValue = True
                columnButton.Width = 10
                datagrid_transaction.Columns(0).Visible = False
                datagrid_transaction.Columns.Add(columnButton)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_create_account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create_account.Click
        Dim frm = New frm_create_account()

        frm.Show()
        Me.Hide()
    End Sub

    Private Sub datagrid_transaction_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid_transaction.CellContentClick
 
        If (e.RowIndex > -1) Then

            Dim value As Object = datagrid_transaction.Rows(e.RowIndex).Cells(0).Value

            If IsDBNull(value) Then
                Console.WriteLine("")
                btn_view_account.Enabled = False
                btn_view_transaction.Enabled = False
                btn_view_account.BackColor = Color.Gray
                btn_view_transaction.BackColor = Color.Gray
            Else
                If (value = "Select") Then
                    Dim new_value As Object = datagrid_transaction.Rows(e.RowIndex).Cells(1).Value
                    btn_view_account.Enabled = True
                    btn_view_transaction.Enabled = True
                    btn_view_account.BackColor = Color.DodgerBlue
                    btn_view_transaction.BackColor = Color.DodgerBlue
                    ID = CType(new_value, Integer)
                    'Console.WriteLine(CType(new_value, Integer))

                    get_user_info(ID)
                    get_user_transaction(ID)
                Else
                    btn_view_account.Enabled = True
                    btn_view_transaction.Enabled = True
                    btn_view_account.BackColor = Color.DodgerBlue
                    btn_view_transaction.BackColor = Color.DodgerBlue
                    'Console.WriteLine(value)
                    ID = CType(value, Integer)
                    'Console.WriteLine(CType(value, Integer))

                    get_user_info(ID)
                    get_user_transaction(ID)
                End If
            End If
        End If
    End Sub

    Private Sub btn_view_transaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_transaction.Click
        Dim frm = New frm_transaction()

        frm.IDPass = ID

        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_view_account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_account.Click
        Dim frm = New frm_account_details()

        frm.IDPass = ID

        frm.Show()
        Me.Hide()
    End Sub

    Private Sub txt_fname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.Enter
        lbl_search.Visible = False
    End Sub

    Private Sub txt_fname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.Leave
        If (txt_search.Text = "") Then
            lbl_search.Visible = True
        Else
            lbl_search.Visible = False
        End If
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        search()
    End Sub

    Sub search()
        Dim data_view As New DataView(table)
        data_view.RowFilter = String.Format("name Like '%{0}%'", txt_search.Text) + " OR " + String.Format("address Like '%{0}%'", txt_search.Text) + " OR " + String.Format("contact Like '%{0}%'", txt_search.Text) + " OR " + String.Format("status Like '%{0}%'", txt_search.Text)
        Console.WriteLine(data_view.RowFilter)
        datagrid_transaction.DataSource = data_view

    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Sub get_user_info(ByVal user_id)
        MysqlConn.Open()
        Dim Reader As MySqlDataReader
        Dim Query_get_user As String
        Query_get_user = "select * from computerized_water_consumption_db.user where id = '" & user_id & "' "
        Command = New MySqlCommand(Query_get_user, MysqlConn)
        Reader = Command.ExecuteReader

        While Reader.Read
            txt_name.Text = Reader("fname") + " " + Reader("lname")
            Exit While
        End While

        MysqlConn.Close()
    End Sub

    Sub get_user_transaction(ByVal user_id)
        MysqlConn.Open()
        Dim Reader As MySqlDataReader
        Dim Query_get_user As String
        Query_get_user = "select * from computerized_water_consumption_db.meter_transaction where user_id = '" & user_id & "' and status = 'unpaid' order by created_at desc"
        Command = New MySqlCommand(Query_get_user, MysqlConn)
        Reader = Command.ExecuteReader

        Dim total_cubic_meter As New List(Of Decimal)
        Dim total_peso As New List(Of Decimal)
        Dim last_date As New DateTime
        Dim counter As Decimal
        While Reader.Read
            total_cubic_meter.Add(Reader("total_cubic_meter"))
            total_peso.Add(Reader("peso"))
            last_date = Reader("created_at")
            counter += 1
        End While
        MysqlConn.Close()

        If counter = 0 Then
            MysqlConn.Open()
            Dim NewReader As MySqlDataReader
            Dim Query_get_transaction As String
            Query_get_transaction = "select * from computerized_water_consumption_db.meter_transaction where user_id = '" & user_id & "' order by created_at desc"
            Command = New MySqlCommand(Query_get_transaction, MysqlConn)
            NewReader = Command.ExecuteReader
            Dim peso As Decimal
            Dim total As Decimal
            Dim new_counter As Decimal
            While NewReader.Read
                last_date = NewReader("created_at")
                total = NewReader("total_cubic_meter")
                peso = NewReader("peso")
                new_counter += 1
                Exit While
            End While
            MysqlConn.Close()
            If new_counter = 0 Then
                txt_total_meter.Text = "N/A"
                txt_total_peso.Text = "N/A"
                txt_last_meter_date.Text = "N/A"
                txt_months.Text = "N/A"
                txt_status.Text = "N/A"
                btn_update_account_status.Enabled = False
                btn_update_account_status.BackColor = Color.Silver
            Else
                txt_total_meter.Text = total
                txt_total_peso.Text = peso
                txt_last_meter_date.Text = last_date.ToString("MMM dd, yyyy")
                txt_months.Text = 1
                txt_status.Text = "PAID"
                btn_update_account_status.Enabled = False
                btn_update_account_status.BackColor = Color.Silver
            End If
        Else
            txt_total_meter.Text = total_cubic_meter.Sum.ToString
            txt_total_peso.Text = total_peso.Sum.ToString
            txt_last_meter_date.Text = last_date.ToString("MMM dd, yyyy")
            txt_months.Text = counter.ToString
            txt_status.Text = "UNPAID"
            btn_update_account_status.Enabled = True
            btn_update_account_status.BackColor = Color.DodgerBlue
        End If

    End Sub

    Sub get_no_of_user()
        MysqlConn.Open()
        Dim Reader As MySqlDataReader
        Dim Query_get_user As String
        Query_get_user = "select * from computerized_water_consumption_db.user where id <> 1"
        Command = New MySqlCommand(Query_get_user, MysqlConn)
        Reader = Command.ExecuteReader

        Dim counter As Decimal
        While Reader.Read
            counter += 1
        End While

        lbl_no_of_user.Text = counter.ToString

        MysqlConn.Close()
    End Sub

    Private Sub btn_update_account_status_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update_account_status.Click
        Dim result As Integer = MessageBox.Show("You are about to settle an account, this action can no longer be undone. Do you want to proceed ?", "  Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            settle_account(ID)
        End If
    End Sub

    Sub settle_account(ByVal user_id)
        MysqlConn.Open()
        Dim Query_get_user As String
        Dim Reader As MySqlDataReader
        Query_get_user = "update computerized_water_consumption_db.meter_transaction set status='paid' where user_id = '" & user_id & "' and status = 'unpaid'"
        Command = New MySqlCommand(Query_get_user, MysqlConn)
        Reader = Command.ExecuteReader
        MysqlConn.Close()

        Dim frm = New frm_dashboard()
        frm.Show()
        Me.Hide()
    End Sub

    Sub paid_unpaid_users()
        MysqlConn.Open()
        Dim Reader As MySqlDataReader
        Dim Query_get_user As String
        Query_get_user = "select * from computerized_water_consumption_db.meter_transaction where status = 'unpaid' order by created_at desc"
        Command = New MySqlCommand(Query_get_user, MysqlConn)
        Reader = Command.ExecuteReader

        Dim user_ids As New List(Of Integer)
        While Reader.Read
            user_ids.Add(Reader("user_id"))
        End While
        MysqlConn.Close()
        Dim unpaid_user_result As List(Of Integer) = user_ids.Distinct().ToList
        lbl_unpaid.Text = unpaid_user_result.Count

        MysqlConn.Open()
        Dim NewReader As MySqlDataReader
        Dim Query_get_paid As String
        Query_get_paid = "select * from computerized_water_consumption_db.meter_transaction where status = 'paid' order by created_at desc"
        Command = New MySqlCommand(Query_get_paid, MysqlConn)
        NewReader = Command.ExecuteReader

        Dim paid_user_ids As New List(Of Integer)
        While NewReader.Read
            paid_user_ids.Add(NewReader("user_id"))
        End While
        MysqlConn.Close()
        Dim paid_user_result As List(Of Integer) = paid_user_ids.Distinct().ToList
        lbl_paid.Text = paid_user_result.Count - unpaid_user_result.Intersect(paid_user_result).Count
    End Sub

    Function get_user_status(ByVal user_id)
        MysqlConn.Open()
        Dim Reader As MySqlDataReader
        Dim Query_get_user As String
        Query_get_user = "select * from computerized_water_consumption_db.meter_transaction where user_id = '" & user_id & "' and status = 'unpaid' order by created_at desc"
        Command = New MySqlCommand(Query_get_user, MysqlConn)
        Reader = Command.ExecuteReader
        Dim counter As Decimal
        While Reader.Read
            counter += 1
        End While
        MysqlConn.Close()

        If counter = 0 Then
            MysqlConn.Open()
            Dim NewReader As MySqlDataReader
            Dim Query_get_transaction As String
            Query_get_transaction = "select * from computerized_water_consumption_db.meter_transaction where user_id = '" & user_id & "' order by created_at desc"
            Command = New MySqlCommand(Query_get_transaction, MysqlConn)
            NewReader = Command.ExecuteReader
            Dim new_counter As Decimal
            While NewReader.Read
                new_counter += 1
                Exit While
            End While
            MysqlConn.Close()
            If new_counter = 0 Then
                Return "N/A"
            Else
                Return "PAID"
            End If
        Else
            Return "UNPAID"
        End If
    End Function

    Function get_greetings()
        Dim date_now As DateTime
        Dim hour As String
        date_now = DateTime.Now.ToString("MMM dd, yyyy H:mm:ss")
        hour = date_now.Hour.ToString

        If hour < 5 Then
            Return "You woke up early!"
        ElseIf hour < 10 Then
            Return "Good morning!"
        ElseIf hour <= 12 Then
            Return "It's almost lunch!"
        ElseIf hour < 18 Then
            Return "Good afternoon!"
        ElseIf hour <= 22 Then
            Return "Good evening!"
        Else
            Return "You must be working really hard!"
        End If
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_clock.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class frm_dashboard
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim table As New DataTable()
    Dim ID As String

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "  System Message", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub frm_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datagrid_transaction.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        datagrid_transaction.MultiSelect = False

        Dim columnButton As New DataGridViewButtonColumn

        table.Columns.Add("ID", Type.GetType("System.String"))
        table.Columns.Add("Name", Type.GetType("System.String"))
        table.Columns.Add("Address", Type.GetType("System.String"))
        table.Columns.Add("Contact", Type.GetType("System.String"))
        'table.Columns.Add("Account Status", Type.GetType("System.String"))
        table.Columns.Add("Created At", Type.GetType("System.String"))
        datagrid_transaction.DataSource = table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from computerized_water_consumption_db.user where id <> '1' order by created_at desc"
            Dim Adapter As New MySqlDataAdapter(Query, MysqlConn)
            Dim Dataset As New DataSet()

            If Adapter.Fill(Dataset) Then
                For x As Integer = 0 To Dataset.Tables(0).Rows.Count - 1
                    Dim id As String = Dataset.Tables(0).Rows(x)("id").ToString()
                    Dim name As String = Dataset.Tables(0).Rows(x)("fname").ToString() + " " + Dataset.Tables(0).Rows(x)("lname").ToString()
                    Dim address As String = Dataset.Tables(0).Rows(x)("address").ToString()
                    Dim contact_number As String = Dataset.Tables(0).Rows(x)("contact_number").ToString()
                    Dim created_at As String = Dataset.Tables(0).Rows(x)("created_at").ToString()

                    table.Rows.Add(id, name, address, contact_number, created_at)
                    'datagrid_transaction.Rows.Add(New String() {id, name, address, contact_number, "", created_at, ""})
                Next

                datagrid_transaction.DataSource = table
                columnButton.Text = "Select"
                columnButton.UseColumnTextForButtonValue = True
                columnButton.Width = 10
                datagrid_transaction.Columns(0).Visible = True
                datagrid_transaction.Columns.Add(columnButton)
            End If

            MysqlConn.Close()
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
                    Console.WriteLine(CType(new_value, Integer))
                Else
                    btn_view_account.Enabled = True
                    btn_view_transaction.Enabled = True
                    btn_view_account.BackColor = Color.DodgerBlue
                    btn_view_transaction.BackColor = Color.DodgerBlue
                    Console.WriteLine(value)
                    ID = CType(value, Integer)
                    Console.WriteLine(CType(value, Integer))
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
        data_view.RowFilter = String.Format("name Like '%{0}%'", txt_search.Text) + " OR " + String.Format("address Like '%{0}%'", txt_search.Text) + " OR " + String.Format("contact Like '%{0}%'", txt_search.Text)
        Console.WriteLine(data_view.RowFilter)
        datagrid_transaction.DataSource = data_view

    End Sub

End Class
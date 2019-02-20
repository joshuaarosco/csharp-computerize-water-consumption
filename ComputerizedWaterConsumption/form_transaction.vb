Imports MySql.Data.MySqlClient

Public Class frm_transaction

    Public Property IDPass As String

    Dim MysqlConn As MySqlConnection
    Dim table As New DataTable()
    Dim Command As MySqlCommand
    Dim cubic_meter, prev_cubic_meter, used_cubic_meter, new_cubic_meter As Integer

    Private Sub frm_transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datagrid_transaction.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        datagrid_transaction.MultiSelect = False

        table.Columns.Add("ID", Type.GetType("System.String"))
        table.Columns.Add("Previous Cubic Meter", Type.GetType("System.String"))
        table.Columns.Add("Current Cubic Meter", Type.GetType("System.String"))
        table.Columns.Add("Used Cubic Meter", Type.GetType("System.String"))
        table.Columns.Add("Peso", Type.GetType("System.String"))
        table.Columns.Add("Created At", Type.GetType("System.String"))

        datagrid_transaction.DataSource = table

        Console.Write(IDPass)

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"

        Try
            get_account_info()
            get_previous_meter()
            get_meter_track()
            txt_previouscubicmeter.Text = prev_cubic_meter.ToString
            datagrid_transaction.Columns(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub


    Private Sub datagrid_transaction_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid_transaction.CellContentClick

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "  System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_title.Click

    End Sub

    Private Sub btn_calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calculate.Click

        If (txt_cubicmeter.Text().ToString() = "") Then
            MessageBox.Show("Cubic meter field is required")
        ElseIf IsNumeric(txt_cubicmeter.Text().ToString()) Then
            If(Convert.ToInt32(txt_cubicmeter.Text()) < Convert.ToInt32(txt_previouscubicmeter.Text())) Then
                MessageBox.Show("Cubic meter should be higher or equal ")
            Else
                txt_usedcubicmeter.Text() = Convert.ToDecimal(txt_cubicmeter.Text().ToString()) - prev_cubic_meter
                txt_peso.Text() = Convert.ToDecimal(txt_usedcubicmeter.Text().ToString()) * 34.75
                txt_previouscubicmeter.Text() = txt_cubicmeter.Text().ToString()

                create_meter_track(Convert.ToDecimal(prev_cubic_meter.ToString()),
                                Convert.ToDecimal(txt_cubicmeter.Text().ToString()),
                                Convert.ToDecimal(txt_usedcubicmeter.Text().ToString()),
                                Convert.ToDecimal(txt_peso.Text().ToString()))

                table.Rows.Add("",
                               Convert.ToDecimal(prev_cubic_meter.ToString()),
                                Convert.ToDecimal(txt_cubicmeter.Text().ToString()),
                                Convert.ToDecimal(txt_usedcubicmeter.Text().ToString()),
                                Convert.ToDecimal(txt_peso.Text().ToString()),
                                DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))

                prev_cubic_meter = Convert.ToDecimal(txt_cubicmeter.Text().ToString())

                datagrid_transaction.DataSource = table

                'get_total()
            End If
        Else
            MessageBox.Show("Cubic meter field is should be numeric")
        End If

    End Sub

    Private Sub btn_history_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_history.Click
        Dim frm = New frm_history()

        frm.IDPass = IDPass

        frm.Show()
        Me.Hide()
    End Sub


    Sub get_previous_meter()
        Try
            MysqlConn.Open()
            Dim Reader As MySqlDataReader
            Dim Query_get_previous_meter As String
            Query_get_previous_meter = "select current_cubic_meter from computerized_water_consumption_db.meter_tracker where user_id = '" & IDPass & "' order by created_at desc"
            Command = New MySqlCommand(Query_get_previous_meter, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                prev_cubic_meter = Reader("current_cubic_meter")
                Console.WriteLine(prev_cubic_meter)
                Exit While
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub


    Sub get_meter_track()
        MysqlConn.Open()
        Dim Query As String
        Query = "select * from computerized_water_consumption_db.meter_tracker where user_id = '" & IDPass & "' and status is null"
        Dim Adapter As New MySqlDataAdapter(Query, MysqlConn)
        Dim Dataset As New DataSet()

        If Adapter.Fill(Dataset) Then
            For x As Integer = 0 To Dataset.Tables(0).Rows.Count - 1
                Dim id As String = Dataset.Tables(0).Rows(x)("id").ToString()
                Dim prev_cm As String = Dataset.Tables(0).Rows(x)("previous_cubic_meter").ToString()
                Dim curr_cm As String = Dataset.Tables(0).Rows(x)("current_cubic_meter").ToString()
                Dim used_cm As String = Dataset.Tables(0).Rows(x)("used_cubic_meter").ToString()
                Dim peso As String = Dataset.Tables(0).Rows(x)("peso").ToString()
                Dim created_at As String = Dataset.Tables(0).Rows(x)("created_at").ToString()

                table.Rows.Add(id, prev_cm, curr_cm, used_cm, peso, created_at)
            Next

            datagrid_transaction.DataSource = table
        End If
        MysqlConn.Close()
    End Sub

    Sub create_meter_track(ByVal val_previous_meter, ByVal val_current_cubic_meter, ByVal val_used_cubic_meter, ByVal val_peso)

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into computerized_water_consumption_db.meter_tracker (user_id,previous_cubic_meter,current_cubic_meter,used_cubic_meter,peso,created_at) values ('" & IDPass & "','" & val_previous_meter & "','" & val_current_cubic_meter & "','" & val_used_cubic_meter & "','" & val_peso & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Sub get_account_info()
        MysqlConn.Open()
        Dim Reader As MySqlDataReader
        Dim Query_get_previous_meter As String
        Query_get_previous_meter = "select * from computerized_water_consumption_db.user where id = '" & IDPass & "'"
        Command = New MySqlCommand(Query_get_previous_meter, MysqlConn)
        Reader = Command.ExecuteReader

        While Reader.Read
            lbl_title.Text = Reader("fname") + "'s Meter Trail"
            Exit While
        End While

        MysqlConn.Close()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Dim frm = New frm_dashboard()

        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_total.Click
        If datagrid_transaction.Rows.Count = 0 Then
            MessageBox.Show("Ooops! No rows detected", "  System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            btn_total.Enabled = False
            btn_total.BackColor = Color.Silver
            get_total()
        End If
    End Sub

    Sub get_total()
        'If (datagrid_transaction.Rows.Count = 31) Then
        '    Dim total_cubic_used As New List(Of Decimal)
        'Dim total_peso As New List(Of Decimal)
        'For x As Integer = 0 To datagrid_transaction.Rows.Count - 1
        'total_cubic_used.Add(datagrid_transaction.Rows(x).Cells(2).Value())
        'total_peso.Add(datagrid_transaction.Rows(x).Cells(3).Value())
        'Next
        'table.Rows.Add("",
        '            "",
        '            "",
        '            "")

        'table.Rows.Add("total",
        '            "",
        '            total_cubic_used.Sum,
        '            total_peso.Sum)

        'datagrid_transaction.DataSource = table

        'End If

        'Console.Write(datagrid_transaction.Rows.Count)

        Dim result As Integer = MessageBox.Show(datagrid_transaction.Rows.Count.ToString + " rows detected, Get the total and move the data to history?", "  System Message", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Dim total_cubic_used As New List(Of Decimal)
            Dim total_peso As New List(Of Decimal)
            For x As Integer = 0 To datagrid_transaction.Rows.Count - 1
                total_cubic_used.Add(datagrid_transaction.Rows(x).Cells(3).Value())
                total_peso.Add(datagrid_transaction.Rows(x).Cells(4).Value())

                'Dim val_id = datagrid_transaction.Rows(x).Cells(0).Value()
                'Console.WriteLine(val_id)
                create_history()
                update_meter_tracker()
            Next
            table.Rows.Add("",
                        "",
                        "",
                        "",
                        "",
                        "")
            table.Rows.Add("",
                        "Total",
                        "",
                        total_cubic_used.Sum,
                        total_peso.Sum,
                        "")

            datagrid_transaction.DataSource = table
            create_meter_transaction(total_cubic_used.Sum, total_peso.Sum)
        End If
    End Sub

    Sub create_history()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"

        MysqlConn.Open()
        Dim Query As String
        Console.WriteLine("Im here at create history")
        Query = "select * from computerized_water_consumption_db.meter_tracker where user_id = '" & IDPass & "' and status is null"
        Dim Adapter As New MySqlDataAdapter(Query, MysqlConn)
        Dim Dataset As New DataSet()

        If Adapter.Fill(Dataset) Then
            For x As Integer = 0 To Dataset.Tables(0).Rows.Count - 1
                Dim user_id As String = Dataset.Tables(0).Rows(x)("user_id").ToString()
                Dim prev_cm As String = Dataset.Tables(0).Rows(x)("previous_cubic_meter").ToString()
                Dim curr_cm As String = Dataset.Tables(0).Rows(x)("current_cubic_meter").ToString()
                Dim used_cm As String = Dataset.Tables(0).Rows(x)("used_cubic_meter").ToString()
                Dim peso As String = Dataset.Tables(0).Rows(x)("peso").ToString()
                Dim created_at As String = Dataset.Tables(0).Rows(x)("created_at").ToString()

                insert_history(user_id, prev_cm, curr_cm, used_cm, peso, created_at)
            Next

        End If
        MysqlConn.Close()
    End Sub


    Sub insert_history(ByVal ins_user_id, ByVal ins_pcm, ByVal ins_ccm, ByVal ins_ucm, ByVal ins_peso, ByVal ins_created_at)
        Console.WriteLine("Im here at insert history")
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"
        Dim Reader As MySqlDataReader
        Dim oDate As DateTime = Convert.ToDateTime(ins_created_at)
        Dim created_date As String = oDate.Year & "-" & oDate.Month & "-" & oDate.Day & " " & oDate.Hour & ":" & oDate.Minute & ":" & oDate.Millisecond
        Console.WriteLine(created_date)

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into computerized_water_consumption_db.meter_history (user_id,previous_cubic_meter,current_cubic_meter,used_cubic_meter,peso,created_at) values ('" & ins_user_id & "','" & ins_pcm & "','" & ins_ccm & "','" & ins_ucm & "','" & ins_peso & "','" & created_date & "')"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Sub update_meter_tracker()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update computerized_water_consumption_db.meter_tracker set status='moved' where user_id=" & IDPass & " and status is null"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Sub create_meter_transaction(ByVal total_cubic_meter, ByVal peso)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into computerized_water_consumption_db.meter_transaction (user_id,total_cubic_meter,peso,status,created_at) values ('" & IDPass & "', '" & total_cubic_meter & "','" & peso & "', 'unpaid', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
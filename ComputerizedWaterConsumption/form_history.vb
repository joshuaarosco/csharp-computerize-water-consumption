Imports MySql.Data.MySqlClient

Public Class frm_history

    Public Property IDPass As String
    Public Property UserType As String

    Dim table As New DataTable()
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Dim frm = New frm_transaction()

        frm.IDPass = IDPass
        frm.UserType = UserType

        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "  System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frm_history_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Console.WriteLine(IDPass)

        table.Columns.Add("Previous Cubic Meter", Type.GetType("System.String"))
        table.Columns.Add("Current Cubic Meter", Type.GetType("System.String"))
        table.Columns.Add("Used Cubic Meter", Type.GetType("System.String"))
        table.Columns.Add("Peso", Type.GetType("System.String"))
        table.Columns.Add("Created At", Type.GetType("System.String"))

        datagrid_transaction.DataSource = table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"

        Try
            get_meter_history()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Sub get_meter_history()
        MysqlConn.Open()
        Dim Query As String
        Query = "select * from computerized_water_consumption_db.meter_history where user_id = '" & IDPass & "' order by created_at desc"
        Dim Adapter As New MySqlDataAdapter(Query, MysqlConn)
        Dim Dataset As New DataSet()

        If Adapter.Fill(Dataset) Then
            For x As Integer = 0 To Dataset.Tables(0).Rows.Count - 1
                Dim prev_cm As String = Dataset.Tables(0).Rows(x)("previous_cubic_meter").ToString()
                Dim curr_cm As String = Dataset.Tables(0).Rows(x)("current_cubic_meter").ToString()
                Dim used_cm As String = Dataset.Tables(0).Rows(x)("used_cubic_meter").ToString()
                Dim peso As String = Dataset.Tables(0).Rows(x)("peso").ToString()
                Dim created_at As String = Dataset.Tables(0).Rows(x)("created_at").ToString()

                table.Rows.Add(prev_cm, curr_cm, used_cm, peso, created_at)
            Next

            datagrid_transaction.DataSource = table
        End If
        MysqlConn.Close()
    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
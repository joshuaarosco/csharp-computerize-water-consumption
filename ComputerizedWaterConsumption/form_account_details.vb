Imports MySql.Data.MySqlClient

Public Class frm_account_details
    Public Property IDPass As String

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub frm_account_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"

        Try
            MysqlConn.Open()
            Dim Reader As MySqlDataReader
            Dim Query_get_previous_meter As String
            Query_get_previous_meter = "select * from computerized_water_consumption_db.user where id = '" & IDPass & "'"
            Command = New MySqlCommand(Query_get_previous_meter, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                lbl_title.Text = "Update " + Reader("fname") + "'s Information"
                txt_fname.Text = Reader("fname")
                txt_lname.Text = Reader("lname")
                txt_contact_number.Text = Reader("contact_number")
                txt_address.Text = Reader("address")
                Exit While
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "  System Message", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to discard changes?", "  System Message", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim frm = New frm_dashboard()
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update computerized_water_consumption_db.user set fname='" & txt_fname.Text & "',lname='" & txt_lname.Text & "',contact_number='" & txt_contact_number.Text & "',address='" & txt_address.Text & "' WHERE id=" & IDPass
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            Dim result As Integer = MessageBox.Show("Account was successfully updated", "  System Message", MessageBoxButtons.OK)
            If result = DialogResult.OK Then
                Dim frm = New frm_dashboard()
                frm.Show()
                Me.Hide()
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
End Class
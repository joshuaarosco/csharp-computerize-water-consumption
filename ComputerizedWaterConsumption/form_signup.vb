Imports MySql.Data.MySqlClient

Public Class frm_signup

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub frm_create_account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to cancel?", "  System Message", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim frm = New frm_login()
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click
        If (txt_fname.Text = "" Or txt_lname.Text = "" Or txt_contact_number.Text = "" Or txt_address.Text = "" Or txt_username.Text = "" Or txt_password.Text = "" Or txt_confirm_password.Text = "") Then
            MessageBox.Show("All field is required.")
        Else
            If (txt_password.Text <> txt_confirm_password.Text) Then
                MessageBox.Show("Please confirm you password.")
            Else
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString =
                    "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"
                Dim Reader As MySqlDataReader
                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "insert into computerized_water_consumption_db.user (fname,lname,contact_number,address,username,password,created_at) values ('" & txt_fname.Text & "', '" & txt_lname.Text & "', '" & txt_contact_number.Text & "', '" & txt_address.Text & "', '" & txt_username.Text & "', '" & txt_password.Text & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
                    Command = New MySqlCommand(Query, MysqlConn)
                    Reader = Command.ExecuteReader

                    Dim result As Integer = MessageBox.Show("Successfully registered!", "  System Message", MessageBoxButtons.OK)
                    If result = DialogResult.OK Then
                        Dim frm = New frm_login()
                        frm.Show()
                        Me.Hide()
                    End If
                    MysqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            End If
        End If
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "  System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
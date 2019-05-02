Imports MySql.Data.MySqlClient

Public Class frm_login
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim ID As String

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "  System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txt_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=computerized_water_consumption_db"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from computerized_water_consumption_db.user where username = '" & txt_username.Text & "' and password = '" & txt_password.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            Dim count As Integer
            count = 0

            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                'MessageBox.Show("Successfully login!")
                If Reader("user_type") = "user" Then
                    Dim frm = New frm_transaction()
                    
                    frm.IDPass = Reader("id")
                    frm.UserType = Reader("user_type")

                    frm.Show()
                    Me.Hide()
                Else
                    Dim frm = New frm_dashboard()
                    frm.UserType = Reader("user_type")
                    frm.Show()
                    Me.Hide()
                End If

            Else
                MessageBox.Show("Wrong username or password.")
            End If

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.3


        If Me.Opacity >= 1 Then
            Timer1.Enabled = False
            Me.Opacity = 1
        End If

    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lbl_signup_Click(sender As System.Object, e As System.EventArgs) Handles lbl_signup.Click
        Dim frm = New frm_signup()

        frm.Show()
        Me.Hide()
    End Sub
End Class

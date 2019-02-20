Public Class frm_splashscreen

    Private Sub frm_splashscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        lbl_version.Text = "Version 1.0"

        'Copyright info
        lbl_copyright.Text = My.Application.Info.Copyright + ", IskolarCreatives"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pb_loading.Value <= pb_loading.Maximum - 1 Then
            pb_loading.Value += 1
        Else
            Timer1.Enabled = False
            Dim frm = New frm_login()

            frm.Show()
            Me.Hide()
        End If
    End Sub

End Class
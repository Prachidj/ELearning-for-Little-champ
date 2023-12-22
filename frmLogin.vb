Public Class frmLogin

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If txtuser.Text = "admin" And txtpass.Text = "admin" Then
            MessageBox.Show("Login Successfully!!!")

            FrmWelcome.Show()
            Me.Close()
        End If

    End Sub
End Class

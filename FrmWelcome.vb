Public Class FrmWelcome

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progressbar1.Value = 100 Then
            Mainform.Show()

            Me.Close()
            Exit Sub
        End If
        progressbar1.Value = progressbar1.Value + 1

    End Sub
End Class
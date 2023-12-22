Public Class frmsongselection

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If Cmbsong.Text = "Educational Songs" Then
            Frm_Esong.Show()
        ElseIf Cmbsong.Text = "Jingle Toons" Then
            Frm_Jsong.Show()



        End If
    End Sub
End Class
Public Class FrmExam

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If cmbexam.Text = "Numbers" Then
            ExamNum.Show()

        ElseIf cmbexam.Text = "COLORS" Then
            Exam.Show()

        ElseIf cmbexam.Text = "FRUITS" Then
            ExamFruits.Show()

        ElseIf cmbexam.Text = "indiancurrency" Then
            ExamCurrency.Show()

        End If


    End Sub

    Private Sub FrmExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbexam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbexam.SelectedIndexChanged

    End Sub
End Class
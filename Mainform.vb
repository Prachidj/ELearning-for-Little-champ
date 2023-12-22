Imports System.Data.OleDb

Public Class Mainform

    Private Sub btnexam_Click(sender As Object, e As EventArgs) Handles btnexam.Click
        FrmExam.Show()

    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnrstud_Click(sender As Object, e As EventArgs) Handles btnrstud.Click
        Stud_Reg.Show()

    End Sub

    Private Sub btnstudy_Click(sender As Object, e As EventArgs) Handles btnstudy.Click
        Frm_Study.Show()

    End Sub

    Private Sub btnkids_Click(sender As Object, e As EventArgs) Handles btnkids.Click
        frmsongselection.Show()

    End Sub

    Private Sub btntext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnfeed_Click(sender As Object, e As EventArgs)

    End Sub
End Class
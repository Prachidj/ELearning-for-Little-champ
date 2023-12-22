Imports System.Data.OleDb

Public Class Exam
    Dim x As Integer
    Dim ans As String
    Dim y As String

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;data source=D:\LCDB.mdb")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim score As Integer


    Private Sub Exam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()
        AxWindowsMediaPlayer1.URL = "D:\c1.AAc"

        cmd.CommandText = "select *from Exam where Qno=1"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)

        If dr(2) = "yellow" Then
            op1.BackColor = Color.Yellow

        End If

        If dr(3) = "green" Then
            op2.BackColor = Color.Green
        End If

        If dr(4) = "red" Then
            op3.BackColor = Color.Red
        End If
        con.Close()
        x = 1






    End Sub

    Private Sub buttonnext_Click(sender As Object, e As EventArgs) Handles buttonnext.Click
        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        ans = dr(5)
        If y = ans Then
            score = score + 1
            ' AxWindowsMediaPlayer1.URL = "D:\Right.mp3"
        

        End If
        con.Close()
        If x = 6 Then
            MessageBox.Show("End of Exam " & vbCrLf & "Your score is : " & score)
            Me.Close()

            Exit Sub
        End If
        

        x = x + 1
        Select Case x
            Case 2
                AxWindowsMediaPlayer1.URL = "D:\c2.aac"

            Case 3
                AxWindowsMediaPlayer1.URL = "D:\c3.aac"

            Case 4
                AxWindowsMediaPlayer1.URL = "D:\c4.aac"


            Case 5
                AxWindowsMediaPlayer1.URL = "D:\c5.aac"

            Case 6
                AxWindowsMediaPlayer1.URL = "D:\c6.aac"
        End Select

        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)
       




        Select Case dr(2)
            Case "yellow"
                op1.BackColor = Color.Yellow

            Case "green"
                op1.BackColor = Color.Green

            Case "red"
                op1.BackColor = Color.Red

            Case "blue"
                op1.BackColor = Color.Blue

            Case "white"
                op1.BackColor = Color.White
            Case "purple"
                op1.BackColor = Color.Purple

            Case "grey"
                op1.BackColor = Color.Green

            Case "black"
                op1.BackColor = Color.Black



        End Select
        Select Case dr(3)
            Case "yellow"
                op2.BackColor = Color.Yellow

            Case "green"
                op2.BackColor = Color.Green

            Case "red"
                op2.BackColor = Color.Red

            Case "blue"
                op2.BackColor = Color.Blue

            Case "white"
                op2.BackColor = Color.White
            Case "purple"
                op2.BackColor = Color.Purple

            Case "grey"
                op2.BackColor = Color.Green

            Case "black"
                op2.BackColor = Color.Black



        End Select
        Select Case dr(4)
            Case "yellow"
                op3.BackColor = Color.Yellow

            Case "green"
                op3.BackColor = Color.Green

            Case "red"
                op3.BackColor = Color.Red

            Case "blue"
                op3.BackColor = Color.Blue

            Case "white"
                op3.BackColor = Color.White
            Case "purple"
                op3.BackColor = Color.Purple

            Case "grey"
                op3.BackColor = Color.Green

            Case "black"
                op3.BackColor = Color.Black



        End Select
        con.Close()









    End Sub

    Private Sub op1_Click(sender As Object, e As EventArgs) Handles op1.Click
        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()


        y = dr(2)

        con.Close()
        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        ans = dr(5)
        If y = ans Then

            AxWindowsMediaPlayer1.URL = "D:\Right.mp3"
        Else
            AxWindowsMediaPlayer1.URL = "D:\Wrong.mp3"


        End If
        con.Close()
    End Sub

    Private Sub op2_Click(sender As Object, e As EventArgs) Handles op2.Click
        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(3)
        con.Close()
        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        ans = dr(5)
        If y = ans Then

            AxWindowsMediaPlayer1.URL = "D:\Right.mp3"
        Else
            AxWindowsMediaPlayer1.URL = "D:\Wrong.mp3"


        End If
        con.Close()
    End Sub

    Private Sub op3_Click(sender As Object, e As EventArgs) Handles op3.Click
        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(4)
        con.Close()

        con.Open()
        cmd.CommandText = "select * from Exam where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        ans = dr(5)
        If y = ans Then

            AxWindowsMediaPlayer1.URL = "D:\Right.mp3"
        Else
            AxWindowsMediaPlayer1.URL = "D:\Wrong.mp3"


        End If
        con.Close()

    End Sub
End Class
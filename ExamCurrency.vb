Imports System.Data.OleDb
Public Class ExamCurrency
    Dim x As Integer
    Dim ans As String
    Dim y As String
    
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;data source=D:\LCDB.mdb")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim score As Integer


    Private Sub ExamCurrency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "D:\n1.mp3"
        con.Open()
        cmd.CommandText = "select *from Cur where Qno=1"

        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)

        If dr(2) = "1" Then
            op1.BackgroundImage = Image.FromFile("d:\Currency\1.jpg")

        End If

        If dr(3) = "2" Then
            op2.BackgroundImage = Image.FromFile("d:\Currency\2.jpg")
        End If

        If dr(4) = "5" Then
            op3.BackgroundImage = Image.FromFile("d:\Currency\5.jpg")
        End If
        con.Close()
        x = 1



    End Sub

    Private Sub buttonnext_Click(sender As Object, e As EventArgs) Handles buttonnext.Click
        con.Open()
        cmd.CommandText = "select * from Cur where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        ans = dr(5)
        If y = ans Then
            score = score + 1
            ' AxWindowsMediaPlayer1.URL = "D:\Right.mp3"
        End If


        If x = 10 Then
            MessageBox.Show("End of Exam" & vbCrLf & "Your score is : " & score)
            Me.Close()
            Exit Sub
        End If
        x = x + 1

        con.Close()
        Select Case x
            Case 1
                AxWindowsMediaPlayer1.URL = "D:\r2.mp3"

            Case 2
                AxWindowsMediaPlayer1.URL = "D:\r3.mp3"

            Case 3
                AxWindowsMediaPlayer1.URL = "D:\n4.mp3"


            Case 4
                AxWindowsMediaPlayer1.URL = "D:\r5.mp3"

            Case 5
                AxWindowsMediaPlayer1.URL = "D:\r6.mp3"

            Case 6

                AxWindowsMediaPlayer1.URL = "D:\r7.mp3"
            Case 7

                AxWindowsMediaPlayer1.URL = "D:\r8.mp3"
            Case 8

                AxWindowsMediaPlayer1.URL = "D:\r9.mp3"
            Case 9

                AxWindowsMediaPlayer1.URL = "D:\r10.mp3"
        End Select





        con.Open()
        cmd.CommandText = "select * from cur where qno=" & x & ""

        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)


        Select Case dr(2)
            Case "1"
                op1.BackgroundImage = Image.FromFile("d:\Currency\1.jpg")

            Case "2"

                op1.BackgroundImage = Image.FromFile("d:\Currency\2.jpg")

            Case "5"

                op1.BackgroundImage = Image.FromFile("d:\Currency\5.jpg")


            Case "10"
                op1.BackgroundImage = Image.FromFile("d:\Currency\10.jpg")


            Case "20"
                op1.BackgroundImage = Image.FromFile("d:\Currency\20.jpg")

            Case "50"
                op1.BackgroundImage = Image.FromFile("d:\Currency\50.jpg")

            Case "100"
                op1.BackgroundImage = Image.FromFile("d:\Currency\100.jpg")


            Case "200"
                op1.BackgroundImage = Image.FromFile("d:\Currency\200.jpg")


            Case "500"
                op1.BackgroundImage = Image.FromFile("d:\Currency\500.jpg")

            Case "2000"
                op1.BackgroundImage = Image.FromFile("d:\Currency\2000.jpg")




        End Select


        Select Case dr(3)
            Case "1"
                op2.BackgroundImage = Image.FromFile("d:\Currency\1.jpg")

            Case "2"

                op2.BackgroundImage = Image.FromFile("d:\Currency\2.jpg")

            Case "5"

                op2.BackgroundImage = Image.FromFile("d:\Currency\5.jpg")

            Case "10"
                op2.BackgroundImage = Image.FromFile("d:\Currency\10.jpg")


            Case "20"
                op2.BackgroundImage = Image.FromFile("d:\Currency\20.jpg")

            Case "50"
                op2.BackgroundImage = Image.FromFile("d:\Currency\50.jpg")

            Case "100"
                op2.BackgroundImage = Image.FromFile("d:\Currency\100.jpg")


            Case "200"
                op2.BackgroundImage = Image.FromFile("d:\Currency\200.jpg")


            Case "500"
                op2.BackgroundImage = Image.FromFile("d:\Currency\500.jpg")

            Case "2000"
                op2.BackgroundImage = Image.FromFile("d:\Currecy\2000.jpg")



        End Select


        Select Case dr(4)
            Case "1"
                op3.BackgroundImage = Image.FromFile("d:\Currency\1.jpg")

            Case "2"

                op3.BackgroundImage = Image.FromFile("d:\Currency\2.jpg")

            Case "5"
                op3.BackgroundImage = Image.FromFile("d:\Currency\5.jpg")


            Case "10"
                op3.BackgroundImage = Image.FromFile("d:\Currency\10.jpg")

            Case "20"
                op3.BackgroundImage = Image.FromFile("d:\Currency\20.jpg")

            Case "50"
                op3.BackgroundImage = Image.FromFile("d:\Currency\50.jpg")


            Case "100"
                op3.BackgroundImage = Image.FromFile("d:\Currency\100.jpg")


            Case "200"
                op3.BackgroundImage = Image.FromFile("d:\Currency\200.jpg")

            Case "500"
                op3.BackgroundImage = Image.FromFile("d:\Currency\500.jpg")

            Case "2000"
                op3.BackgroundImage = Image.FromFile("d:\Currency\2000.jpg")





        End Select
        con.Close()

    End Sub


    Private Sub op1_Click(sender As Object, e As EventArgs) Handles op1.Click
        con.Open()
        cmd.CommandText = "select * from Cur where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()


        y = dr(2)

        con.Close()
        con.Open()
        cmd.CommandText = "select * from Cur where Qno  =" & x & ""
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
        cmd.CommandText = "select * from Cur where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(3)
        con.Close()
        con.Open()
        cmd.CommandText = "select * from Cur where Qno  =" & x & ""
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
        cmd.CommandText = "select * from Cur where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(4)
        con.Close()

        con.Open()
        cmd.CommandText = "select * from Cur where Qno  =" & x & ""
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

    Private Sub AxWindowsMediaPlayer3_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer3.Enter

    End Sub
End Class
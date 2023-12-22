Imports System.Data.OleDb
Public Class ExamFruits
    Dim x As Integer

    Dim ans As String
    Dim y As String


    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;data source=D:\LCDB.mdb")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim score As Integer



    Private Sub ExamFruits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AxWindowsMediaPlayer1.URL = "D:\f1.mp3"

        con.Open()
        cmd.CommandText = "select *from Fruits where Qno=1"

        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)
        If dr(2) = "Apple" Then
            op1.BackgroundImage = Image.FromFile("d:\Fruits\Apple.jpg")
        End If

        If dr(3) = "Custeredapple" Then
            op2.BackgroundImage = Image.FromFile("d:\Fruits\Custered apple.jpg")
        End If

        If dr(4) = "Pineapple" Then
            op3.BackgroundImage = Image.FromFile("d:\Fruits\pineapple.jpg")
        End If
        con.Close()
        x = 1

    End Sub

    Private Sub buttonnext_Click(sender As Object, e As EventArgs) Handles buttonnext.Click
        con.Open()
        cmd.CommandText = "select * from Fruits where Qno  =" & x & ""
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

            Me.Close()

            Exit Sub
        End If
        x = x + 1

        Select Case x
            Case 1
                AxWindowsMediaPlayer1.URL = "D:\f2.mp3"

            Case 2
                AxWindowsMediaPlayer1.URL = "D:\f3.mp3"

            Case 3
                AxWindowsMediaPlayer1.URL = "D:\f4.mp3"


            Case 4
                AxWindowsMediaPlayer1.URL = "D:\f5.mp3"

            Case 5
                AxWindowsMediaPlayer1.URL = "D:\f6.mp3"

            Case 6

                AxWindowsMediaPlayer1.URL = "D:\f7.mp3"
            Case 7

                AxWindowsMediaPlayer1.URL = "D:\f8.mp3"
            Case 8

                AxWindowsMediaPlayer1.URL = "D:\f9.mp3"
            Case 9

                AxWindowsMediaPlayer1.URL = "D:\f10.mp3"
        End Select
        If x = 10 Then
            MessageBox.Show("End of Exam")
            Exit Sub
        End If


        x = x + 1
        con.Open()
        cmd.CommandText = "select *from Fruits  where Qno = " & x & ""

        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)


        Select Case dr(2)
            Case "Apple"
                op1.BackgroundImage = Image.FromFile("d:\Fruits\Apple.jpg")

            Case "watermelon"

                op1.BackgroundImage = Image.FromFile("d:\Fruits\watermelon.jpg")

            Case "Orange"
                op1.BackgroundImage = Image.FromFile("d:\Fruits\Orange.jpg")


            Case "Grapes"
                op1.BackgroundImage = Image.FromFile("d:\Fruits\Grapes.jpg")

            Case "banana"
                op1.BackgroundImage = Image.FromFile("d:\Fruits\banana.jpg")

            Case "Custredapple"
                op1.BackgroundImage = Image.FromFile("d:\Fruits\Custeredapple.jpg")


            Case "Pineapple"
                op1.BackgroundImage = Image.FromFile("d:\Fruits\Pineapple.jpg")



            Case "Mango"
                op1.BackgroundImage = Image.FromFile("d:\Fruits\Mango.jpg")
            Case "Pomegranate"

                op2.BackgroundImage = Image.FromFile("d:\Fruits\Pomegranate.jpg")

            Case "Maskmelon"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Maskmelon.jpg")







        End Select
        Select Case dr(3)
            Case "Apple"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Apple.jpg")

            Case "watermelon"

                op2.BackgroundImage = Image.FromFile("d:\Fruits\watermelon.jpg")

            Case "Orange"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Orange.jpg")


            Case "Grapes"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Grapes.jpg")

            Case "banana"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\banana.jpg")

            Case "Custredapple"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Custered apple.jpg")


            Case "Pineapple"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Pineapple.jpg")



            Case "Mango"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Mango.jpg")

            Case "Pomegranate"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Pomegranate.jpg")

            Case "Maskmelon"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Maskmelon.jpg")




        End Select
        Select Case dr(4)
            Case "Apple"
                op3.BackgroundImage = Image.FromFile("d:\Fruits\Apple.jpg")

            Case "watermelon"

                op3.BackgroundImage = Image.FromFile("d:\Fruits\watermelon.jpg")

            Case "Orange"
                op3.BackgroundImage = Image.FromFile("d:\Fruits\Orange.jpg")


            Case "Grapes"
                op3.BackgroundImage = Image.FromFile("d:\Fruits\Grapes.jpg")

            Case "banana"
                op3.BackgroundImage = Image.FromFile("d:\Fruits\banana.jpg")

            Case "Custredapple"
                op3.BackgroundImage = Image.FromFile("d:\Fruits\Custered apple.jpg")


            Case "Pineapple"
                op3.BackgroundImage = Image.FromFile("d:\Fruits\Pineapple.jpg")



            Case "Mango"
                op3.BackgroundImage = Image.FromFile("d:\Fruits\Mango.jpg")
            Case "Pomegranate"


                op2.BackgroundImage = Image.FromFile("d:\Fruits\Pomegranate.jpg")

            Case "Maskmelon"
                op2.BackgroundImage = Image.FromFile("d:\Fruits\Maskmelon.jpg")




        End Select
        con.Close()

    End Sub

    Private Sub lblQno_Click(sender As Object, e As EventArgs) Handles lblQno.Click

    End Sub

    Private Sub op1_Click(sender As Object, e As EventArgs) Handles op1.Click
        con.Open()
        cmd.CommandText = "select * from Fruits where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()


        y = dr(2)

        con.Close()
        con.Open()
        cmd.CommandText = "select * from Fruits where Qno  =" & x & ""
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
        cmd.CommandText = "select * from Fruits where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(3)
        con.Close()
        con.Open()
        cmd.CommandText = "select * from Fruits where Qno  =" & x & ""
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
        cmd.CommandText = "select * from Fruits where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(4)
        con.Close()

        con.Open()
        cmd.CommandText = "select * from Fruits where Qno  =" & x & ""
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
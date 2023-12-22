Imports System.Data.OleDb
Public Class ExamNum
    Dim x As Integer
    Dim ans As String
    Dim y As String
    Dim score As Integer


    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;data source=D:\LCDB.mdb")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet


    Private Sub ExamNum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AxWindowsMediaPlayer1.URL = "D:\n1.mp3"





        con.Open()

        cmd.CommandText = "select *from Examnumbers where Qno=1"

        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)
        If dr(2) = "9" Then
            op1.BackgroundImage = Image.FromFile("d:\numbers\9.jpg")
        End If

        If dr(3) = "4" Then
            op2.BackgroundImage = Image.FromFile("d:\numbers\4.jpg")
        End If

        If dr(4) = "1" Then
            op3.BackgroundImage = Image.FromFile("d:\numbers\1.jpg")
        End If
        con.Close()
        x = 1



    End Sub

    Private Sub buttonnext_Click(sender As Object, e As EventArgs) Handles buttonnext.Click
        con.Open()
        cmd.CommandText = "select * from Examnumbers where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        ans = dr(5)
        If y = ans Then
            score = score + 1
        End If
        con.Close()
        ' AxWindowsMediaPlayer1.URL = "D:\Right.mp3"


        If x = 10 Then
            MessageBox.Show("End of Exam" & vbCrLf & "Your score is : " & score)
            Me.Close()
            Exit Sub

        End If



        x = x + 1

        Select Case x
            Case "1"
                AxWindowsMediaPlayer1.URL = "D:\n2.mp3"

            Case "2"
                AxWindowsMediaPlayer1.URL = "D:\n3.mp3"

            Case "3"
                AxWindowsMediaPlayer1.URL = "D:\n4.mp3"


            Case "4"
                AxWindowsMediaPlayer1.URL = "D:\n5.mp3"

            Case "5"
                AxWindowsMediaPlayer1.URL = "D:\n6.mp3"

            Case "6"

                AxWindowsMediaPlayer1.URL = "D:\n7.mp3"
            Case "7"

                AxWindowsMediaPlayer1.URL = "D:\n8.mp3"
            Case "8"

                AxWindowsMediaPlayer1.URL = "D:\n9.mp3"
            Case "9"

                AxWindowsMediaPlayer1.URL = "D:\n0.mp3"

        End Select


        con.Open()
        cmd.CommandText = "select * from Examnumbers where qno=" & x & ""

        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        lblQno.Text = dr(0)
        txtque.Text = dr(1)


        Select Case dr(2)
            Case 2
                op1.BackgroundImage = Image.FromFile("d:\numbers\1.jpg")

            Case 3

                op1.BackgroundImage = Image.FromFile("d:\numbers\2.jpg")

            Case 4
                op1.BackgroundImage = Image.FromFile("d:\numbers\3.jpg")


            Case 5
                op1.BackgroundImage = Image.FromFile("d:\numbers\4.jpg")

            Case 6
                op1.BackgroundImage = Image.FromFile("d:\numbers\5.jpg")

            Case 7
                op1.BackgroundImage = Image.FromFile("d:\numbers\6.jpg")


            Case 8
                op1.BackgroundImage = Image.FromFile("d:\numbers\7.jpg")


            Case 9
                op1.BackgroundImage = Image.FromFile("d:\numbers\8.jpg")

            Case 10
                op1.BackgroundImage = Image.FromFile("d:\numbers\9.jpg")

            Case 11
                op1.BackgroundImage = Image.FromFile("d:\numbers\0.jpg")



        End Select

        Select Case dr(3)
            Case 2
                op2.BackgroundImage = Image.FromFile("d:\numbers\1.jpg")

            Case 3
                op2.BackgroundImage = Image.FromFile("d:\numbers\2.jpg")

            Case 4
                op2.BackgroundImage = Image.FromFile("d:\numbers\3.jpg")

            Case 5
                op2.BackgroundImage = Image.FromFile("d:\numbers\4.jpg")

            Case 6
                op2.BackgroundImage = Image.FromFile("d:\numbers\5.jpg")

            Case 7
                op2.BackgroundImage = Image.FromFile("d:\numbers\6.jpg")

            Case 8
                op2.BackgroundImage = Image.FromFile("d:\numbers\7.jpg")

            Case 9
                op2.BackgroundImage = Image.FromFile("d:\numbers\8.jpg")

            Case 10
                op2.BackgroundImage = Image.FromFile("d:\numbers\9.jpg")

            Case 11
                op2.BackgroundImage = Image.FromFile("d:\numbers\0.jpg")

        End Select
        Select Case dr(4)
            Case 2
                op3.BackgroundImage = Image.FromFile("d:\numbers\1.jpg")

            Case 3
                op3.BackgroundImage = Image.FromFile("d:\numbers\1.jpg")

            Case 4
                op3.BackgroundImage = Image.FromFile("d:\numbers\2.jpg")

            Case 5
                op3.BackgroundImage = Image.FromFile("d:\numbers\3.jpg")

            Case 6
                op3.BackgroundImage = Image.FromFile("d:\numbers\4.jpg")

            Case 7
                op3.BackgroundImage = Image.FromFile("d:\numbers\5.jpg")

            Case 8
                op3.BackgroundImage = Image.FromFile("d:\numbers\6.jpg")

            Case 9
                op3.BackgroundImage = Image.FromFile("d:\numbers\7.jpg")

            Case 10
                op3.BackgroundImage = Image.FromFile("d:\numbers\8.jpg")

            Case 11
                op3.BackgroundImage = Image.FromFile("d:\numbers\9.jpg")




        End Select
        con.Close()

    End Sub
    

    Private Sub op2_Click(sender As Object, e As EventArgs) Handles op2.Click
        con.Open()
        cmd.CommandText = "select * from Examnumbers where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(3)
        con.Close()
        con.Open()
        cmd.CommandText = "select * from Examnumbers where Qno  =" & x & ""
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
        cmd.CommandText = "select * from Examnumbers where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()

        y = dr(4)
        con.Close()

        con.Open()
        cmd.CommandText = "select * from Examnumbers where Qno  =" & x & ""
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

    Private Sub op1_Click(sender As Object, e As EventArgs) Handles op1.Click
        con.Open()
        cmd.CommandText = "select * from Examnumbers where Qno  =" & x & ""
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()


        y = dr(2)

        con.Close()

        con.Open()
        cmd.CommandText = "select * from Examnumbers where Qno  =" & x & ""
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
Imports System.Data.OleDb
Public Class Stud_Reg
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;data source=D:\LCDB.mdb")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim status As String



    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtadd.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtid.Text = "" Then
            MessageBox.Show("please enter the student id:", "ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If txtstudname.Text = "" Then
            MessageBox.Show("please enter student name:", "name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtparent.Text = "" Then
            MessageBox.Show("please enter student parent name:", "parent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtadd.Text = "" Then
            MessageBox.Show("please enter student address:", "address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtcon.Text = "" Then
            MessageBox.Show("please enter student contact:", "contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If txtuser.Text = "" Then
            MessageBox.Show("please enter student username:", "user", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If txtpass.Text = "" Then
            MessageBox.Show("please enter student password:", "password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If txtclass.Text = "" Then
            MessageBox.Show("please enter student class:", "class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If txtdob.Text = "" Then
            MessageBox.Show("please enter student name:", "DOB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If txtdoa.Text = "" Then
            MessageBox.Show("please enter student name:", "DOA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub


        End If
        con.Open()
        If status = "add" Then
            cmd.CommandText = "insert into stud_reg values(" & txtid.Text & ",'" & txtstudname.Text & "','" & txtparent.Text & "','" & txtadd.Text & "' ,'" & txtcon.Text & "','" & txtuser.Text & "','" & txtpass.Text & "','" & txtclass.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')"
        ElseIf status = "edit" Then
            cmd.CommandText = "update stud_reg set id=" & txtid.Text & ",Student name='" & txtstudname.Text & "',parent name='" & txtparent.Text & "',address='" & txtadd.Text & "' ,contact=" & txtcon.Text & ",user name='" & txtuser.Text & "',password=" & txtpass.Text & ",class= " & txtclass.Text & ",date of birth=" & txtdob.Text & ",date of addmission="" & txtdoa.Text & ""
        End If
        cmd.Connection = con

        cmd.ExecuteNonQuery()
        MessageBox.Show("student entry save successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        txtid.Text = ""
        txtstudname.Text = ""
        txtparent.Text = ""
        txtadd.Text = ""
        txtcon.Text = ""
        txtuser.Text = ""
        txtclass.Text = ""
        txtpass.Text = ""
        txtdob.Text = ""
        txtdoa.Text = ""

        txtid.Focus()

        fillgrid()



    End Sub




    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        status = "add"
        con.Open()

        btnsave.Enabled = True
        cmd.CommandText = "select max(studentid) from stud_reg"
        cmd.Connection = con
        Dim x As Integer
        If IsDBNull(cmd.ExecuteScalar) Then
            txtid.Text = 1
        Else
            txtid.Text = cmd.ExecuteScalar + 1

        End If
        con.Close()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim d As DialogResult
        d = MessageBox.Show("Do you want to delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If d = Windows.Forms.DialogResult.Yes Then
            con.Open()
            cmd.CommandText = "delete from stud_id were studentid=" & txtid.Text & ""
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            txtid.Text = ""
            txtstudname.Text = ""
            txtparent.Text = ""
            txtadd.Text = ""
            txtcon.Text = ""
            txtuser.Text = ""
            txtclass.Text = ""
            txtpass.Text = ""
            txtdob.Text = ""
            txtdoa.Text = ""

            txtid.Focus()

        End If

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        status = "Update"

    End Sub
    


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub

    Sub fillgrid()
        con.Open()
        da = New OleDbDataAdapter("select * from stud_reg", con)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        con.Close()


    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        txtid.Text = DataGridView1.SelectedRows(0).Cells(0).Value

        txtstudname.Text = DataGridView1.SelectedRows(0).Cells(1).Value

        txtparent.Text = DataGridView1.SelectedRows(0).Cells(2).Value

        txtadd.Text = DataGridView1.SelectedRows(0).Cells(3).Value

        txtcon.Text = DataGridView1.SelectedRows(0).Cells(4).Value

        txtclass.Text = DataGridView1.SelectedRows(0).Cells(5).Value

        txtuser.Text = DataGridView1.SelectedRows(0).Cells(6).Value

        txtpass.Text = DataGridView1.SelectedRows(0).Cells(7).Value

        txtdob.Text = DataGridView1.SelectedRows(0).Cells(8).Value

        txtdoa.Text = DataGridView1.SelectedRows(0).Cells(9).Value

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class+
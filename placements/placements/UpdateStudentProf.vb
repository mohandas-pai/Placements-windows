Imports System.Data.SqlClient
Public Class UpdateStudentProf

    '' NOTE: A staff can update details of a student belonging only to his/her department

    Private Sub UpdateStudentProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' Search button click

        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        Dim kdate As DateTime

        adp = New SqlDataAdapter("select S.name, S.age, S.dob, S.gender, S.address, S.dept from STUDENT S where S.usn = '" & TextBox1.Text & "'", con)
        dt = New DataTable
        adp.Fill(dt)

        If dt.Rows.Count > 0 Then
            TextBox2.Text = dt.Rows(0).Item(0)
            TextBox3.Text = dt.Rows(0).Item(1)


            DateTimePicker1.Value = dt.Rows(0).Item(2)

            'MsgBox(dt.Rows(0).Item(3).ToString)

            If dt.Rows(0).Item(3).ToString = "male" Then
                RadioButton1.Checked = True
            Else
                RadioButton2.Checked = True
            End If

            adp = New SqlDataAdapter("select * from DEPARTMENT", con)
            dt = New DataTable
            adp.Fill(dt)

            ComboBox1.DataSource = dt
            ComboBox1.ValueMember = "dcode"
            ComboBox1.DisplayMember = "dname"

            'ComboBox1.SelectedValue = 

        Else
            MsgBox("Student with USN " & TextBox1.Text & " does not exist!")
        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
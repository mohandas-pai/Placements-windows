Imports System.Data.SqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' TODO: Validate both the fields

        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        Dim userType As Integer

        adp = New SqlDataAdapter("select * from LOGIN where username = '" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", con)
        dt = New DataTable()
        adp.Fill(dt)

        If dt.Rows.Count > 0 Then
            userType = dt.Rows(0).Item(2)

            If userType = 0 Then
                'MsgBox("Hi student " & dt.Rows(0).Item(1).ToString)
                CurrentSession.NewSession(TextBox1.Text)
                StudentDash.Show()

            Else
                CurrentSession.NewSession(TextBox1.Text)
                StaffDash.Show()

            End If
        Else
            MsgBox("Invalid username or password!")

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.PasswordChar = ControlChars.NullChar
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "•"
    End Sub
End Class
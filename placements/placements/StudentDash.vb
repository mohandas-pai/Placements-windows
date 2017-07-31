Imports System.Data.SqlClient
Public Class StudentDash

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StudentCompanies.Show()
    End Sub

    Private Sub StudentDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adp As SqlDataAdapter
        Dim dt As DataTable



        adp = New SqlDataAdapter("select * from STUDENT where username = '" & CurrentSession.UserName & "'", con)
        dt = New DataTable()
        adp.Fill(dt)

        If dt.Rows.Count > 0 Then
            Label2.Text = dt.Rows(0).Item(1)
            Label2.Text = Label2.Text.ToUpper()
        Else
            MsgBox("Invalid username or password!")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentProfile.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AppliedCompanies.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
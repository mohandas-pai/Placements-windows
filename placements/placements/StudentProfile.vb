Imports System.Data.SqlClient
Public Class StudentProfile


    Private Sub StudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        adp = New SqlDataAdapter("select * from STUDENT where username = '" & CurrentSession.UserName & "'", con)

        dt = New DataTable()
        adp.Fill(dt)

        Label9.Text = dt.Rows(0).Item(0)
        Label10.Text = dt.Rows(0).Item(1)
        Label11.Text = dt.Rows(0).Item(2)
        Label12.Text = dt.Rows(0).Item(3)
        Label13.Text = dt.Rows(0).Item(4)
        Label14.Text = dt.Rows(0).Item(5)
        Label15.Text = dt.Rows(0).Item(6)
        Label16.Text = dt.Rows(0).Item(7)


        '  Dim myGraphics As Graphics

        'Dim myRectangle As Rectangle

        '       Dim myPen As New Pen(Color.Black)

        'return the current form as a drawing surface

        '        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)

        'create a rectangle based on x,y coordinates, width, & height

        '    myRectangle = New Rectangle(x:=124, y:=82, Width:=237, Height:=271)

        'draw rectangle from pen and rectangle objects

        '    myGraphics.DrawRectangle(pen:=myPen, rect:=myRectangle)

        'create a rectangle based on Point and Size objects


    End Sub
End Class
Imports System.Data.SqlClient



Public Class addProducts

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ls As SqlCommand
        Try
            ls = New SqlCommand("insert into products values(" & TextBox1.Text & ",'" & TextBox2.Text & "'," & TextBox3.Text & ",'" & TextBox4.Text & "')", con)
            ls.ExecuteNonQuery()
            MsgBox("Product added Successfully!")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
 

    End Sub
End Class
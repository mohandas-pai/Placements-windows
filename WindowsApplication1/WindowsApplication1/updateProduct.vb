Imports System.Data.SqlClient

Public Class updateProduct

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim ls As SqlCommand

            ls = New SqlCommand("update products set p_id=" & TextBox1.Text & ",p_name='" & TextBox2.Text & "',price=" & TextBox3.Text & ",category='" & TextBox4.Text & "' where p_id=" & TextBox5.Text & "", con)
            ls.ExecuteNonQuery()
            MsgBox("Product Updated Successfully!")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ls As SqlCommand
        ls = New SqlCommand("select p_id from products where p_id=" & TextBox5.Text, con)
        If ls.ExecuteScalar Then
            Label1.Show()
            Label2.Show()
            Label3.Show()
            Label4.Show()
            TextBox1.Show()
            TextBox2.Show()
            TextBox3.Show()
            TextBox4.Show()
            Button2.Show()


        Else
            MsgBox("Product not exist!")
        End If


    End Sub
End Class
Imports System.Data.SqlClient
Public Class removeProduct

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim ls As SqlCommand
            ls = New SqlCommand("delete from products where p_id=" & TextBox1.Text & "", con)
            ls.ExecuteNonQuery()
            MsgBox("Product Successfully Deleted!")
            TextBox1.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class
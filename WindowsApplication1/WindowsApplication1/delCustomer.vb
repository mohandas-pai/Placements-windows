Imports System.Data.SqlClient

Public Class delCustomer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ls As New SqlCommand
        Try
            MsgBox(TextBox1.Text)

            ls = New SqlCommand("delete from customer where c_id  = " & TextBox1.Text & " ", con)
            ls.ExecuteNonQuery()

            MsgBox("Customer Deleted Successfully!")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
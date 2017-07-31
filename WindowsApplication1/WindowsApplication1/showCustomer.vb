

Imports System.Data.SqlClient
Public Class showCustomer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ls As SqlCommand

        ls = New SqlCommand("select c_id from customer where c_id=" & TextBox1.Text & "", con)
        Dim check As Integer
        check = ls.ExecuteScalar

        If check Then
            seeCustomer.Show()
        Else
            MsgBox("User not exist!")
            TextBox1.Clear()


        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
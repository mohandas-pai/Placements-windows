Imports System.Data.SqlClient
Public Class seeOrders

    Dim ls As SqlCommand

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim val As String
        ls = New SqlCommand("Select c_id from orders where o_id=" & TextBox1.Text, con)

        val = ls.ExecuteScalar
        ls = New SqlCommand("Select p_id from orders where o_id=" & TextBox1.Text, con)

        val = val + ls.ExecuteScalar

        ls = New SqlCommand("Select o_date from orders where o_id=" & TextBox1.Text, con)

        val = val + ls.ExecuteScalar

        MsgBox(val)


    End Sub
End Class
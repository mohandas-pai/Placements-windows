
Imports System.Data.SqlClient
Public Class seeCustomer

    Private Sub seeCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ls As New SqlCommand

                Label1.Text = showCustomer.TextBox1.Text
                ls = New SqlCommand("select c_name from customer where c_id=" & showCustomer.TextBox1.Text & "", con)
                Label2.Text = ls.ExecuteScalar()
                ls = New SqlCommand("select c_address from customer where c_id=" & showCustomer.TextBox1.Text & "", con)
                Label3.Text = ls.ExecuteScalar()
                ls = New SqlCommand("select contact_no from customer where c_id=" & showCustomer.TextBox1.Text & "", con)
                Label4.Text = ls.ExecuteScalar

           
        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
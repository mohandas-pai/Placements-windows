Imports System.Data.SqlClient
Module DBConnect
    Public con As SqlConnection

    Public Function connect()
        'con = New SqlConnection("Data Source=(local);Initial Catalog=placements;Integrated Security=True")
        con = New SqlConnection("server=HP\SQLEXPRESS;database=placements;uid=sa;pwd=Fortyfive;")
        Try
            con.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module

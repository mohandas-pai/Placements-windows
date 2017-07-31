Imports System.Data.SqlClient
Module SQLConnect

    Public con As SqlConnection
    Public Function connect()
        Try
            con = New SqlConnection("Server=DEEPNIRMAL\DEEP;database=rdbms;integrated security=true")
            con.Open()
            MsgBox("CONNECTED")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return Nothing

    End Function
End Module



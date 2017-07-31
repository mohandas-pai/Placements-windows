Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class SQLControl
    Public SQLCon As New SqlConnection
    Public SQLCmd As New SqlCommand

    Public Function Connect() As Boolean
        Try
            SQLCon.ConnectionString = "Server=DEEPNIRMAL\DEEP;Database=deep2432; integrated security=true"
            SQLCon.Open()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class

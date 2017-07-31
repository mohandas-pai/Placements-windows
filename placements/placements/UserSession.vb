Public Class UserSession

    Dim username As String
    Dim isLoggedIn As Boolean = False

    Public Sub UserSession(curUsername As String)
        username = curUsername
        isLoggedIn = True
    End Sub

    Public Sub EndSession()
        username = ""
    End Sub

    Public Function GetSessionUname()
        Return username
    End Function

End Class

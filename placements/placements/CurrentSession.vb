Module CurrentSession
    Dim currentSession As UserSession

    Public Sub NewSession(uname As String)
        currentSession = New UserSession
        currentSession.UserSession(uname)
    End Sub

    Public Sub EndSession()
        currentSession.EndSession()
    End Sub

    Public Function UserName()
        Return currentSession.GetSessionUname
    End Function

End Module

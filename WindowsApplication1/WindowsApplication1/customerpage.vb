Public Class customerpage


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub OrderStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderStatusToolStripMenuItem.Click
        orderStatus.Show()


    End Sub

    Private Sub SeeProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeeProfileToolStripMenuItem.Click
        seeProfile.Show()

    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProfileToolStripMenuItem.Click
        editProfile.Show()

    End Sub
End Class
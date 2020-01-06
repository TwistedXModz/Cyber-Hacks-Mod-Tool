Public Class Home
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        chmtadmin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TxMadmin.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UpdaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdaterToolStripMenuItem.Click
        updater.Show()
    End Sub

    Private Sub CHMTAdminPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHMTAdminPanelToolStripMenuItem.Click
        chmtadmin.Show()
    End Sub

    Private Sub TxMcomAdminPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TxMcomAdminPanelToolStripMenuItem.Click
        TxMadmin.Show()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub LiveChatSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiveChatSetupToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\Cyber Hacks Admin Tool\Data\Apps\Live Chat Setup.exe")
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Process.Start("C:\Program Files\tawk.to\tawk.to.exe")
    End Sub

    Private Sub SupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportToolStripMenuItem.Click
        Process.Start("https://www.twistedxmodz.com/index.php?support-tickets/")
    End Sub

    Private Sub DiscordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscordToolStripMenuItem.Click
        Process.Start("https://discord.gg/JnsrD7b")
    End Sub

    Private Sub CHMTSiteAdminPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHMTSiteAdminPanelToolStripMenuItem.Click
        chmtsiteadvb.Show()
    End Sub

    Private Sub TwistedXModzAdminPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwistedXModzAdminPanelToolStripMenuItem.Click
        Botsadmin.Show()
    End Sub

    Private Sub CyberHacksMenuAdminPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CyberHacksMenuAdminPanelToolStripMenuItem.Click
        CHMA.Show()
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        Changelog.Show()
    End Sub
End Class
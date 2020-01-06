Public Class Form1
    Private Sub CyberHacksModToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CyberHacksModToolToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\Cyber Hacks\Data\Apps\Cyber Hacks Mod Tool installer\Cyber Hacks Mod Tool installer.exe")
    End Sub

    Private Sub UpdaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdaterToolStripMenuItem.Click
        updater.Show()
    End Sub
End Class

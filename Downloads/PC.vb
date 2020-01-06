Public Class PC
    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Me.Close()
    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer1.Interval = 700 ' = 1 second
        'Timer1.Enabled = True
        Downloads()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer1.Enabled = False
            Downloads()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub
    Private Sub Downloads()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/WeMod-Setup.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/WeMod Setup/WeMod-Setup.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs) Handles FrostButton2.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer2.Interval = 700 ' = 1 second
        'Timer2.Enabled = True
        Downloads2()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer2.Enabled = False
            Downloads2()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub
    Private Sub Downloads2()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Xenos64.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/Xenos64-GTA/Xenos64.exe")

        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")

        MsgBox("!Windows may say it's a virus but 95% of mod tools are viruses they do mess with the game files so don't worry about it everything is good your PC is safe!")

    End Sub
End Class
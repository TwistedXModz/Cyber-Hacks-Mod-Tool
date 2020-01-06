Public Class XBox
    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Close()

    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer1.Interval = 700 ' = 1 second
        'Timer1.Enabled = True
        Downloads()
    End Sub
    Private Sub Downloads()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/DirectKV%20Checker.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/DirectKV Checker/DirectKV Checker.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer1.Enabled = False
            Downloads()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub

    Private Sub FrostButton10_Click(sender As Object, e As EventArgs) Handles FrostButton10.Click
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
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/GTAV%20100%25%20Save%20Injector.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/GTAV 100% Save Injector.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton13_Click(sender As Object, e As EventArgs) Handles FrostButton13.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer3.Interval = 700 ' = 1 second
        'Timer3.Enabled = True
        Downloads3()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer3.Enabled = False
            Downloads3()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub
    Private Sub Downloads3()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/RGHC.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/RGHC.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton14_Click(sender As Object, e As EventArgs) Handles FrostButton14.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer4.Interval = 700 ' = 1 second
        'Timer4.Enabled = True
        Downloads4()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer4.Enabled = False
            Downloads4()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub
    Private Sub Downloads4()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/XBL%20IP%20Exploit.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/XBL IP Exploit/XBL IP Exploit.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton17_Click(sender As Object, e As EventArgs) Handles FrostButton17.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer5.Interval = 700 ' = 1 second
        'Timer5.Enabled = True
        Downloads5()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer5.Enabled = False
            Downloads5()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub
    Private Sub Downloads5()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/MSP%20Spoofer.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/MSP Spoofer/MSP Spoofer.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton19_Click(sender As Object, e As EventArgs) Handles FrostButton19.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer6.Interval = 700 ' = 1 second
        'Timer6.Enabled = True
        Downloads6()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer6.Enabled = False
            Downloads6()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub
    Private Sub Downloads6()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Xbox%20Live%20Ban%20Tool.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/Xbox Live Ban Tool.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs) Handles FrostButton2.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer6.Interval = 700 ' = 1 second
        'Timer6.Enabled = True
        Downloads7()
    End Sub

    Private Sub Downloads7()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Evasion/Evasion.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/Evasion/Evasion.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton3_Click(sender As Object, e As EventArgs) Handles FrostButton3.Click
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer6.Interval = 700 ' = 1 second
        'Timer6.Enabled = True
        Downloads8()
    End Sub

    Private Sub Downloads8()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/XZP-Tool-v2.0/XzpTool.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/XZP-Tool-v2.0/XzpTool.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub
End Class
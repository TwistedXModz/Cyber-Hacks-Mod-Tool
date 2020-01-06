Public Class Sourcecodes
    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Close()
    End Sub

    Private Sub FrostButton14_Click(sender As Object, e As EventArgs) Handles FrostButton14.Click
        MsgBox("We are Downloading The Source Code For you Now!")
        Downloads1()
    End Sub

    Private Sub Downloads1()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Source%20Codes/Explosive%20Launcher%20source%20codes%20V2.0.rar", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Source Codes/Explosive Launcher source codes V2.0.rar")
        MsgBox("Download Complete! - Hit the open Downloads Button to get your Source Code")
    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        MsgBox("We are Downloading The Source Code For you Now!")
        Downloads2()
    End Sub

    Private Sub Downloads2()
        My.Computer.Network.DownloadFile("http://downloads.twistedxmodz.com/Source%20Codes/SHADOW%20VIP%201.50.zip", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Source Codes/SHADOW VIP Source code.zip")
        MsgBox("Download Complete! - Hit the open Downloads Button to get your Source Code")
    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs) Handles FrostButton2.Click
        MsgBox("We are Downloading The Source Code For you Now!")
        Downloads3()
    End Sub

    Private Sub Downloads3()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Source%20Codes/ModMenuGTA5%201.50.zip", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Source Codes/Mod Menu GTA5 Source code.zip")
        MsgBox("Download Complete! - Hit the open Downloads Button to get your Source Code")
    End Sub

    Private Sub FrostButton3_Click(sender As Object, e As EventArgs) Handles FrostButton3.Click
        Process.Start("explorer.exe", "C:\Program Files (x86)\Cyber Hacks Tool\Data\Source Codes\")
    End Sub
End Class
﻿Public Class updata
    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Me.Close()
    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        MsgBox("Checking For updates Now Please Wait!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer1.Interval = 1000 ' = 1 second
        'Timer1.Enabled = True
        CheckForUpdates()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer1.Enabled = False
            CheckForUpdates()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10

        End If
    End Sub

    Private Sub CheckForUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://updater.twistedxmodz.com/Version")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You are up todate!")
        Else
            MsgBox("There is a new update we, will download it now for you.")
            WebBrowser1.Navigate("https://updater.twistedxmodz.com/Cyber%20Hacks%20Mod%20Tool%20installer.exe")
        End If
    End Sub

    Private Sub FrostTheme1_Click(sender As Object, e As EventArgs) Handles FrostTheme1.Click

    End Sub
End Class
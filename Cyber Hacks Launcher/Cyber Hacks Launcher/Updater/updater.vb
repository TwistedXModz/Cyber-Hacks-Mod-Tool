Public Class updater
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Checking For updates Now Please Wait!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer1.Interval = 1000 ' = 1 second
        'Timer1.Enabled = True
        CheckForUpdates()
    End Sub
    Private Sub CheckForUpdates()
        Dim request As Net.HttpWebRequest = Net.WebRequest.Create("https://updater.twistedxmodz.com/LauncherVersion")
        Dim response As Net.HttpWebResponse = request.GetResponse()
        Dim sr As IO.StreamReader = New IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You are up todate!")
        Else
            MsgBox("There is a new update we, will download it now for you.")
            WebBrowser1.Navigate("http://updater.twistedxmodz.com/Cyber%20Hacks%20Launcherinstaller.exe")
        End If
    End Sub
End Class
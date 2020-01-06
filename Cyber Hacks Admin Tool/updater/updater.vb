Public Class updater
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Checking For updates Now Please Wait!")
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 100
        Timer1.Interval = 1000 ' = 1 second
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer1.Enabled = False
            CheckForUpdates()
        Else
            ProgressBar1.Value = ProgressBar1.Value - 10

        End If
    End Sub

    Private Sub CheckForUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://updater.twistedxmodz.com/Version1")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You are up todate!")
        Else
            MsgBox("There is a new update we, will download it now for you.")
            WebBrowser1.Navigate("https://updater.twistedxmodz.com/Cyber%20Hacks%20Admin%20Tool.exe")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
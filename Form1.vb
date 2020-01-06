Imports System.Management
Imports System.IO
Public Class Form1
    Private Sub FrostButton1_Click(sender As Object, e As EventArgs)
        CAD.Show()
    End Sub

    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Close()

    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs)
        Process.Start("https://shop.twistedxmodz.com/")
    End Sub

    Private Sub FrostButton3_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.twistedxmodz.com/index.php?forums/reviews.57/")
    End Sub

    Private Sub FrostButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrostButton5_Click(sender As Object, e As EventArgs)
        ServerStatus.Show()
    End Sub

    Private Sub FrostButton6_Click(sender As Object, e As EventArgs) Handles FrostButton6.Click
        pinger.Show()
    End Sub

    Private Sub FrostButton7_Click(sender As Object, e As EventArgs)
        Process.Start("https://discord.gg/JYkXwnZ")
    End Sub

    Private Sub FrostButton8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrostButton8_Click_1(sender As Object, e As EventArgs)
        updata.Show()
    End Sub

    Private Sub FrostButton9_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\DirectKV Checker\DirectKV Checker.exe")
    End Sub

    Private Sub FrostButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrostButton1_Click_1(sender As Object, e As EventArgs)
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer1.Interval = 1000 ' = 1 second
        'Timer1.Enabled = True
        Downloads()
    End Sub

    Private Sub Downloads()
        My.Computer.Network.DownloadFile("https://www.twistedxmodz.com/CyberHacksModTool/Apps/DirectKV%20Checker.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/DirectKV Checker/DirectKV Checker.exe")
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

    Private Sub FrostButton11_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\GTAV 100% Save Injector.exe")
    End Sub

    Private Sub FrostButton10_Click_1(sender As Object, e As EventArgs)
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer2.Interval = 1000 ' = 1 second
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
        My.Computer.Network.DownloadFile("https://www.twistedxmodz.com/CyberHacksModTool/Apps/GTAV%20100%25%20Save%20Injector.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/GTAV 100% Save Injector.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton12_Click(sender As Object, e As EventArgs)
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer3.Interval = 1000 ' = 1 second
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
        My.Computer.Network.DownloadFile("https://www.twistedxmodz.com/CyberHacksModTool/Apps/Divergent%20Multi%20Tool/Divergent.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/Divergent.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton13_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\Divergent.exe")
    End Sub

    Private Sub FrostButton12_Click_1(sender As Object, e As EventArgs)
        Login.Show()
    End Sub

    Private Sub FrostButton12_Click_2(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\RGHC.exe")
    End Sub

    Private Sub FrostButton13_Click_1(sender As Object, e As EventArgs)
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer4.Interval = 1000 ' = 1 second
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
        My.Computer.Network.DownloadFile("https://www.twistedxmodz.com/CyberHacksModTool/Apps/RGHC.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/RGHC.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton15_Click(sender As Object, e As EventArgs)
        Site12.Show()
    End Sub

    Private Sub FrostButton4_Click_1(sender As Object, e As EventArgs)
        Changelog.Show()
    End Sub

    Private Sub FrostButton5_Click_1(sender As Object, e As EventArgs)
        HWID.Show()
    End Sub

    Private Sub TabPage8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrostTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage8_Click_1(sender As Object, e As EventArgs)
        'Dim hw As New clsComputerInfo

        'Dim hdd As String
        'Dim cpu As String
        'Dim mb As String
        'Dim mac As String
        'Dim hwid As String

        'cpu = hw.GetProcessorId()
        'hdd = hw.GetVolumeSerial("C")
        'mb = hw.GetMotherBoardID()
        'mac = hw.GetMACAddress()
        'hwid = cpu + hdd + mb + mac

        'Dim hwidEncrypted As String = Strings.UCase(hw.getMD5Hash(cpu & hdd & mb & mac))

        'txtHWID.Text = hwidEncrypted
    End Sub

    Public Class clsComputerInfo

        Friend Function GetProcessorId() As String
            Dim strProcessorId As String = String.Empty
            Dim query As New SelectQuery("Win32_processor")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject

            For Each info In search.Get()
                strProcessorId = info("processorId").ToString()
            Next
            Return strProcessorId

        End Function

        Friend Function GetMACAddress() As String

            Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim MACAddress As String = String.Empty
            For Each mo As ManagementObject In moc

                If (MACAddress.Equals(String.Empty)) Then
                    If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()

                    mo.Dispose()
                End If
                MACAddress = MACAddress.Replace(":", String.Empty)

            Next
            Return MACAddress
        End Function

        Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String

            Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
            disk.Get()
            Return disk("VolumeSerialNumber").ToString()
        End Function

        Friend Function GetMotherBoardID() As String

            Dim strMotherBoardID As String = String.Empty
            Dim query As New SelectQuery("Win32_BaseBoard")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject
            For Each info In search.Get()

                strMotherBoardID = info("product").ToString()

            Next
            Return strMotherBoardID

        End Function


        'Friend Function getMD5Hash(ByVal strToHash As String) As String
        '    Dim md5Obj As New Renci.SshNet.Security.Cryptography.MD5CryptoServiceProvider
        '    Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        '    bytesToHash = md5Obj.ComputeHash(bytesToHash)

        '    Dim strResult As String = ""

        '    For Each b As Byte In bytesToHash
        '        strResult += b.ToString("x2")
        '    Next

        '    Return strResult
        'End Function

    End Class

    Private Sub FrostButton14_Click(sender As Object, e As EventArgs)
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer5.Interval = 1000 ' = 1 second
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
        My.Computer.Network.DownloadFile("https://www.twistedxmodz.com/CyberHacksModTool/Apps/XBL%20IP%20Exploit.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/XBL IP Exploit/XBL IP Exploit.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton16_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\XBL IP Exploit\XBL IP Exploit.exe")
    End Sub

    Private Sub FrostButton18_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\MSP Spoofer\MSP Spoofer.exe")
    End Sub

    Private Sub FrostButton17_Click(sender As Object, e As EventArgs)
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer6.Interval = 1000 ' = 1 second
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
        My.Computer.Network.DownloadFile("https://www.twistedxmodz.com/CyberHacksModTool/Apps/MSP%20Spoofer.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/MSP Spoofer/MSP Spoofer.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton19_Click(sender As Object, e As EventArgs)
        MsgBox("We are Downloading The Add-on Now!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer7.Interval = 1000 ' = 1 second
        'Timer7.Enabled = True
        Downloads7()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer7.Enabled = False
            Downloads7()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10
        End If
    End Sub

    Private Sub Downloads7()
        My.Computer.Network.DownloadFile("https://www.twistedxmodz.com/CyberHacksModTool/Apps/Xbox%20Live%20Ban%20Tool.exe", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Apps/Xbox Live Ban Tool.exe")
        MsgBox("Download Complete! - Go To The Tools Section To Access This Add-on")
    End Sub

    Private Sub FrostButton20_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\Xbox Live Ban Tool.exe")
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TabPage9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdaterToolStripMenuItem.Click

    End Sub

    Private Sub UpdaterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdaterToolStripMenuItem1.Click
        updata.Show()
        'Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\updater.exe")
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        Changelog.Show()
    End Sub

    Private Sub HWIDRestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HWIDRestToolStripMenuItem.Click
        HWID.Show()
    End Sub

    Private Sub ServerStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ServerStatus.Show()
    End Sub

    Private Sub FAQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FAQToolStripMenuItem.Click
        Process.Start("https://www.twistedxmodz.com/index.php?support-tickets/knowledge-base/")
    End Sub

    Private Sub NewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem.Click
        Process.Start("https://www.twistedxmodz.com/index.php?forums/announcements.3/")
    End Sub

    Private Sub DiscordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start("https://discord.gg/JYkXwnZ")
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Site12.Show()
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub OfficeSiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficeSiteToolStripMenuItem.Click

    End Sub

    Private Sub ShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopToolStripMenuItem.Click
        Process.Start("https://shop.twistedxmodz.com/")
    End Sub

    Private Sub ReviewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviewsToolStripMenuItem.Click
        Process.Start("https://www.twistedxmodz.com/index.php?forums/reviews.57/")
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("https://www.twistedxmodz.com/index.php/")
    End Sub

    Private Sub FrostButton2_Click_1(sender As Object, e As EventArgs) Handles FrostButton2.Click
        MsgBox("We are Downloading The Mod Menu Now!")
        'FrostProgressBar2.Maximum = 100
        'FrostProgressBar2.Value = 100
        'Timer8.Interval = 1000 ' = 1 second
        'Timer8.Enabled = True
        Downloads8()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If (FrostProgressBar2.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer8.Enabled = False
            Downloads8()
        Else
            FrostProgressBar2.Value = FrostProgressBar2.Value - 10
        End If
    End Sub

    Private Sub Downloads8()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Mod%20Menus/TheEnforcer.xex", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Mod Menus/TheEnforcer.xex")
        MsgBox("Download Complete! - Hit the open Downloads Button to get your mod menu")
    End Sub

    Private Sub DownloadDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadDirectoryToolStripMenuItem.Click
        Process.Start("explorer.exe", "C:\Program Files (x86)\Cyber Hacks Tool\Data\")
    End Sub

    Private Sub FrostButton3_Click_1(sender As Object, e As EventArgs) Handles FrostButton3.Click
        ModMenus.Show()
    End Sub

    Private Sub FrostButton4_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrostTheme1_Click(sender As Object, e As EventArgs) Handles FrostTheme1.Click

    End Sub

    Private Sub ToolStripContainer3_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer3.ContentPanel.Load

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        PC.Show()
    End Sub

    Private Sub MoreXBox360ToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoreXBox360ToolsToolStripMenuItem.Click
        XBox.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        PS3.Show()
    End Sub

    Private Sub PCModToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PCModToolsToolStripMenuItem.Click
        PCTools.Show()
    End Sub

    Private Sub XBox360ModToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XBox360ModToolsToolStripMenuItem.Click
        XBoxTools.Show()
    End Sub

    Private Sub CyberHacksModToolToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PS3ModToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PS3ModToolsToolStripMenuItem.Click
        PS3Tools.Show()

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub FrostButton4_Click_3(sender As Object, e As EventArgs) Handles FrostButton4.Click
        MsgBox("We are Downloading The Mod Menu Now!")
        'FrostProgressBar2.Maximum = 100
        'FrostProgressBar2.Value = 100
        'Timer9.Interval = 700 ' = 1 second
        'Timer9.Enabled = True
        Downloads9()
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If (FrostProgressBar2.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer9.Enabled = False
            Downloads9()
        Else
            FrostProgressBar2.Value = FrostProgressBar2.Value - 10
        End If
    End Sub

    Private Sub Downloads9()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Mod%20Menus/GTAV%20Mod%20Menu%20Pack.zip", "C:/Program Files (x86)/Cyber Hacks Tool//Data/Mod Menus/GTAV XBox Mod Menu Pack.zip")
        MsgBox("Download Complete! - Hit the open Downloads Button to get your mod menu")
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        If (FrostProgressBar2.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer10.Enabled = False
            Downloads10()
        Else
            FrostProgressBar2.Value = FrostProgressBar2.Value - 10
        End If
    End Sub

    Private Sub Downloads10()
        My.Computer.Network.DownloadFile("https://downloads.twistedxmodz.com/Mod%20Menus/PS3%20GTA%20V%20Mod%20Menu%20Pack.rar", "C:/Program Files (x86)/Cyber Hacks Tool/Data/Mod Menus/PS3 GTA V Mod Menu Pack.rar")
        MsgBox("Download Complete! - Hit the open Downloads Button to get your mod menu")
    End Sub

    Private Sub FrostButton5_Click_2(sender As Object, e As EventArgs) Handles FrostButton5.Click
        MsgBox("We are Downloading The Mod Menu Now!")
        'FrostProgressBar2.Maximum = 100
        'FrostProgressBar2.Value = 100
        'Timer10.Interval = 700 ' = 1 second
        'Timer10.Enabled = True
        Downloads10()
    End Sub

    Private Sub FrostButton7_Click_1(sender As Object, e As EventArgs) Handles FrostButton7.Click
        Changelog.Show()
    End Sub

    Private Sub FrostButton8_Click_2(sender As Object, e As EventArgs) Handles FrostButton8.Click
        Process.Start("https://www.twistedxmodz.com/index.php?forums/announcements.3/")
    End Sub

    Private Sub FrostButton1_Click_2(sender As Object, e As EventArgs) Handles FrostButton1.Click
        PC.Show()
    End Sub

    Private Sub FrostButton9_Click_1(sender As Object, e As EventArgs) Handles FrostButton9.Click
        XBox.Show()
    End Sub

    Private Sub FrostButton10_Click_2(sender As Object, e As EventArgs) Handles FrostButton10.Click
        PS3.Show()
    End Sub

    Private Sub FrostButton11_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub status1()

    End Sub

    Private Sub Label1_Load(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Load(sender As Object, e As EventArgs) Handles Label3.Click
        'Dim WC As New System.Net.WebClient
        'Dim http3 As String = WC.DownloadString("https://auth.twistedxmodz.com/DownloadServer.txt")
    End Sub

    Private Sub FrostTextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrostButton11_Click_2(sender As Object, e As EventArgs) Handles FrostButton11.Click
        Process.Start("https://www.twistedxmodz.com/index.php")
    End Sub

    Private Sub FrostButton12_Click_3(sender As Object, e As EventArgs) Handles FrostButton12.Click
        Process.Start("https://cyberhackstool.twistedxmodz.com/index.php")
    End Sub

    Private Sub FrostButton13_Click_2(sender As Object, e As EventArgs) Handles FrostButton13.Click
        Process.Start("https://shop.twistedxmodz.com/")
    End Sub

    Private Sub FrostGroupBox1_Click(sender As Object, e As EventArgs) Handles FrostGroupBox1.Click

    End Sub

    Private Sub DiscordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiscordToolStripMenuItem1.Click
        Process.Start("https://discord.gg/JYkXwnZ")
    End Sub

    Private Sub FrostButton14_Click_1(sender As Object, e As EventArgs) Handles FrostButton14.Click
        Sourcecodes.Show()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub FrostButton15_Click_1(sender As Object, e As EventArgs) Handles FrostButton15.Click
        Credits.Show()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class

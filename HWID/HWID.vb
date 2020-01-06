Imports System.Management
Imports System.IO
Public Class HWID

    Private Sub FrostTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHWID.TextChanged
        txtHWID.UseSystemPasswordChar = True
    End Sub

    Private Sub FrostTheme1_Click(sender As Object, e As EventArgs) Handles FrostTheme1.Click
        'Generate HWID

        Dim hw As New clsComputerInfo

        Dim hdd As String
        Dim cpu As String
        Dim mb As String
        Dim mac As String
        Dim hwid As String

        cpu = hw.GetProcessorId()
        hdd = hw.GetVolumeSerial("C")
        mb = hw.GetMotherBoardID()
        mac = hw.GetMACAddress()
        hwid = cpu + hdd + mb + mac

        Dim hwidEncrypted As String = Strings.UCase(hw.getMD5Hash(cpu & hdd & mb & mac))

        txtHWID.Text = hwidEncrypted
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


        Friend Function getMD5Hash(ByVal strToHash As String) As String
            Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

            bytesToHash = md5Obj.ComputeHash(bytesToHash)

            Dim strResult As String = ""

            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next

            Return strResult
        End Function
    End Class

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
            'Login using local file
            'Using f As System.IO.FileStream = System.IO.File.OpenRead("hwid.txt")
            'Using s As System.IO.StreamReader = New System.IO.StreamReader(f)
            'While Not s.EndOfStream
            'Dim line As String = s.ReadLine
            'If txtHWID.Text = line Then
            'MsgBox("Access Granted")
            'Else
            'MsgBox("Access Denied")
            'End If
            'End While

            'End Using
            'End Using

            'Network login
            Dim WC As New System.Net.WebClient
            Try
            Dim http3 As String = WC.DownloadString("https://www.twistedxmodz.com/hwid.txt")
            If http3.Contains(txtHWID.Text) Then
                    MsgBox("Access Granted")
                Else
                    MsgBox("Access Denied")
                End If
            Catch
            MsgBox("Connection To The Server Failed Please Check your Internet Connection")

        End Try
        End Sub

    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Close()

    End Sub
End Class
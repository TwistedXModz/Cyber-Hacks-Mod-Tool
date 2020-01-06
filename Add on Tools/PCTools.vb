Public Class PCTools
    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Me.Close()
    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\WeMod Setup\WeMod-Setup.exe")
    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs) Handles FrostButton2.Click
        Process.Start("C:\Program Files (x86)\Cyber Hacks Tool\Data\Apps\Xenos64-GTA\Xenos64.exe")
    End Sub
End Class
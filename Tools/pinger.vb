Public Class pinger
    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        Dim IP As String
        IP = FrostTextBox1.Text
        If My.Computer.Network.Ping(IP) Then
            Label2.Text = "Online"
            Label2.ForeColor = Color.Green
        Else
            Label2.Text = "Offline"
            Label2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
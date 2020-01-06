Public Class ApplicationMainForm

    Private Sub ApplicationMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' transparent black background for panel2
        Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)
        ' transparent blue background for panel3
        Panel3.BackColor = Color.FromArgb(100, 17, 97, 238)

        ButtonClose.BackColor = Color.FromArgb(100, 0, 0, 0)

    End Sub

    Private Sub ButtonClose_MouseEnter(sender As Object, e As EventArgs) Handles ButtonClose.MouseEnter

        ButtonClose.ForeColor = Color.White

    End Sub

    Private Sub ButtonClose_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClose.MouseLeave

        ButtonClose.ForeColor = Color.DarkGray

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub
End Class
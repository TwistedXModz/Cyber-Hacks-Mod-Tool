Imports MySql.Data.MySqlClient
Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Close()
    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrostButton3_Click(sender As Object, e As EventArgs) Handles FrostButton3.Click
        MsgBox("We are loging you in Give us a Minute Thank you!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer1.Interval = 700 ' = 1 second
        'Timer1.Enabled = True
        Login123()
    End Sub

    Private Sub FrostTheme1_Click(sender As Object, e As EventArgs) Handles FrostTheme1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (FrostProgressBar1.Value = 0) Then ' when progressbar reaches zero disable timer and hide splash
            Timer1.Enabled = False
            Login123()
        Else
            FrostProgressBar1.Value = FrostProgressBar1.Value - 10

        End If
    End Sub

    Private Sub Login123()
        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `email`, `password` FROM `users` WHERE `email` = @email AND `password` = @password", conn.getConnection())

        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = FrostTextBox1_UN.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = FrostTextBox2_Pass.Text

        If FrostTextBox1_UN.Text.Trim() = "" Or FrostTextBox1_UN.Text.Trim().ToLower() = "username" Then

            MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf FrostTextBox2_Pass.Text.Trim() = "" Or FrostTextBox2_Pass.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                Me.Hide()
                Dim mainAppForm As New Form1()
                Form1.Show()

            Else

                MessageBox.Show("This Email or Password you Entered is not right if you Forgot your Email or Password Then Please use The Register or Password Rest Feature Thank you! ", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If



        End If


    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=remotemysql.com;userid=7ypUckro3p;password=gZGpuHlCvA;database=7ypUckro3p"

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successful")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Private Sub FrostButton4_Click(sender As Object, e As EventArgs) Handles FrostButton4.Click
        Register.Show()
        'Process.Start("https://www.twistedxmodz.com//CyberHacksModTool/Register/")
    End Sub

    Private Sub FrostTextBox2_Pass_TextChanged(sender As Object, e As EventArgs) Handles FrostTextBox2_Pass.TextChanged
        FrostTextBox2_Pass.UseSystemPasswordChar = True
    End Sub

    Private Sub FrostRadioButton1_CheckedChanged(sender As Object) Handles FrostRadioButton1.CheckedChanged


    End Sub

    Private Sub FrostButton2_Click_1(sender As Object, e As EventArgs) Handles FrostButton2.Click
        MessageBox.Show("Ok Bye")
        Me.Close()
    End Sub

    Private Sub FrostButton5_Click(sender As Object, e As EventArgs) Handles FrostButton5.Click
        PassRest.Show()
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Serialization
Imports MySql.Data.MySqlClient

Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2_Pass.TextChanged
        TextBox2_Pass.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Ok Bye")
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("We are loging you in Give us a Minute Thank you!")
        'FrostProgressBar1.Maximum = 100
        'FrostProgressBar1.Value = 100
        'Timer1.Interval = 700 ' = 1 second
        'Timer1.Enabled = True
        Login1()
    End Sub

    Private Sub Login1()
        Dim conn As New MY_CONNECTION()
        Dim adapter As New SqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `email`, `password` FROM `users` WHERE `email` = @email AND `password` = @password", conn.getConnection())

        command.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox1_UN.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2_Pass.Text

        If TextBox1_UN.Text.Trim() = "" Or TextBox1_UN.Text.Trim().ToLower() = "username" Then

            MessageBox.Show("Enter Your Email To Login", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TextBox2_Pass.Text.Trim() = "" Or TextBox2_Pass.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                Me.Hide()
                Dim mainAppForm As New Home()
                Home.Show()
                MessageBox.Show("Login Successful Thank you!!", "Login Successful", MessageBoxButtons.OK)
            Else

                MessageBox.Show("This Email or Password you Entered is not right if you Forgot your Email or Password Then Please use The Register or Password Rest Feature Thank you! ", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If



        End If
    End Sub

    Private Class MySqlDbType
        Friend Shared Function VarChar() As Object
            Throw New NotImplementedException()
        End Function
    End Class

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' MysqlConn = New MySqlConnection
        ' MysqlConn.ConnectionString =
        '"server=remotemysql.com;userid=7ypUckro3p;password=gZGpuHlCvA;database=7ypUckro3p"

        ' Try
        '     MysqlConn.Open()
        '     MessageBox.Show("Connection Successful")
        '     MysqlConn.Close()

        ' Catch ex As MySqlException
        '     MessageBox.Show(ex.Message)
        ' Finally
        '     MysqlConn.Dispose()

        ' End Try
    End Sub
End Class
Friend Class MySqlException
    Inherits Exception

    Public Sub New()
    End Sub

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(message As String, innerException As Exception)
        MyBase.New(message, innerException)
    End Sub

    Protected Sub New(info As SerializationInfo, context As StreamingContext)
        MyBase.New(info, context)
    End Sub
End Class

Imports MySql.Data.MySqlClient

Public Class RegisterForm

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' transparent black background for panel2
        Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)
        ' transparent blue background for panel3
        Panel3.BackColor = Color.FromArgb(100, 17, 97, 238)

        ButtonClose.BackColor = Color.FromArgb(100, 0, 0, 0)

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub

    Private Sub TextBoxFirstname_Enter(sender As Object, e As EventArgs) Handles TextBoxFirstname.Enter

        LabelFN.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxFirstname_Leave(sender As Object, e As EventArgs) Handles TextBoxFirstname.Leave

        LabelFN.ForeColor = Color.White

    End Sub

    Private Sub TextBoxLastname_Enter(sender As Object, e As EventArgs) Handles TextBoxLastname.Enter

        LabelLN.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxLastname_Leave(sender As Object, e As EventArgs) Handles TextBoxLastname.Leave

        LabelLN.ForeColor = Color.White

    End Sub

    Private Sub TextBoxUsername_Enter(sender As Object, e As EventArgs) Handles TextBoxUsername.Enter

        LabelUN.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave

        LabelUN.ForeColor = Color.White

    End Sub

    Private Sub TextBoxEmail_Enter(sender As Object, e As EventArgs) Handles TextBoxEmail.Enter

        LabelEM.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave

        LabelEM.ForeColor = Color.White

    End Sub

    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter

        LabelPASS1.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave

        LabelPASS1.ForeColor = Color.White

    End Sub

    Private Sub TextBoxConfirmPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Enter

        LabelPASS2.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxConfirmPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Leave

        LabelPASS2.ForeColor = Color.White

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click

        ' check if the fields are empty
        ' check if the password = the confirm password
        ' check if the username already exists

        ' get textboxes values
        Dim fname As String = TextBoxFirstname.Text
        Dim lname As String = TextBoxLastname.Text
        Dim username As String = TextBoxUsername.Text
        Dim email As String = TextBoxEmail.Text
        Dim password As String = TextBoxPassword.Text
        Dim cpassword As String = TextBoxConfirmPassword.Text


        If fname.Trim() = "" Or lname.Trim() = "" Or username.Trim() = "" Or email.Trim() = "" Or password.Trim() = "" Then

            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not String.Equals(password, cpassword) Then

            MessageBox.Show("Wrong Confirmation Password", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf usernameExist(username) Then

            MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            ' add the new user
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO `users`(`first_name`, `last_name`, `email`, `username`, `password`) VALUES (@fn, @ln, @mail, @usn, @pass)", conn.getConnection)

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()

            Else

                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()

            End If


        End If



    End Sub


    ' create a function to check if the username already exists
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false  
        Else

            Return False

        End If

    End Function

    Private Sub ButtonClose_MouseEnter(sender As Object, e As EventArgs) Handles ButtonClose.MouseEnter

        ButtonClose.ForeColor = Color.White

    End Sub

    Private Sub ButtonClose_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClose.MouseLeave

        ButtonClose.ForeColor = Color.Black

    End Sub

    Private Sub LabelGoToSignIn_MouseEnter(sender As Object, e As EventArgs) Handles LabelGoToSignIn.MouseEnter

        LabelGoToSignIn.ForeColor = Color.White

    End Sub

    Private Sub LabelGoToSignIn_MouseLeave(sender As Object, e As EventArgs) Handles LabelGoToSignIn.MouseLeave

        LabelGoToSignIn.ForeColor = Color.Black

    End Sub

    Private Sub LabelGoToSignIn_Click(sender As Object, e As EventArgs) Handles LabelGoToSignIn.Click

        Me.Hide()
        Dim lForm As New Login_Form()
        lForm.Show()

    End Sub
End Class
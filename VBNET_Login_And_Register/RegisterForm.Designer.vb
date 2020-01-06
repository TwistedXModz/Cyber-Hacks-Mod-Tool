<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstname = New System.Windows.Forms.TextBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelFN = New System.Windows.Forms.Label()
        Me.LabelLN = New System.Windows.Forms.Label()
        Me.TextBoxLastname = New System.Windows.Forms.TextBox()
        Me.LabelUN = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LabelEM = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelPASS1 = New System.Windows.Forms.Label()
        Me.LabelPASS2 = New System.Windows.Forms.Label()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelGoToSignIn = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 596)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabelGoToSignIn)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.LabelPASS2)
        Me.Panel2.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Panel2.Controls.Add(Me.LabelPASS1)
        Me.Panel2.Controls.Add(Me.LabelEM)
        Me.Panel2.Controls.Add(Me.TextBoxEmail)
        Me.Panel2.Controls.Add(Me.LabelUN)
        Me.Panel2.Controls.Add(Me.TextBoxUsername)
        Me.Panel2.Controls.Add(Me.LabelLN)
        Me.Panel2.Controls.Add(Me.TextBoxLastname)
        Me.Panel2.Controls.Add(Me.LabelFN)
        Me.Panel2.Controls.Add(Me.TextBoxPassword)
        Me.Panel2.Controls.Add(Me.TextBoxFirstname)
        Me.Panel2.Controls.Add(Me.ButtonRegister)
        Me.Panel2.Controls.Add(Me.ButtonClose)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(695, 572)
        Me.Panel2.TabIndex = 0
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxPassword.Location = New System.Drawing.Point(24, 352)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(300, 38)
        Me.TextBoxPassword.TabIndex = 4
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxFirstname
        '
        Me.TextBoxFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFirstname.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxFirstname.Location = New System.Drawing.Point(24, 118)
        Me.TextBoxFirstname.Name = "TextBoxFirstname"
        Me.TextBoxFirstname.Size = New System.Drawing.Size(300, 38)
        Me.TextBoxFirstname.TabIndex = 3
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.Location = New System.Drawing.Point(24, 438)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(648, 66)
        Me.ButtonRegister.TabIndex = 2
        Me.ButtonRegister.Text = "SIGN UP"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonClose.Location = New System.Drawing.Point(619, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(76, 69)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(622, 69)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(622, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFN
        '
        Me.LabelFN.AutoSize = True
        Me.LabelFN.BackColor = System.Drawing.Color.Transparent
        Me.LabelFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFN.ForeColor = System.Drawing.Color.White
        Me.LabelFN.Location = New System.Drawing.Point(20, 95)
        Me.LabelFN.Name = "LabelFN"
        Me.LabelFN.Size = New System.Drawing.Size(100, 20)
        Me.LabelFN.TabIndex = 5
        Me.LabelFN.Text = "* First Name:"
        '
        'LabelLN
        '
        Me.LabelLN.AutoSize = True
        Me.LabelLN.BackColor = System.Drawing.Color.Transparent
        Me.LabelLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLN.ForeColor = System.Drawing.Color.White
        Me.LabelLN.Location = New System.Drawing.Point(368, 95)
        Me.LabelLN.Name = "LabelLN"
        Me.LabelLN.Size = New System.Drawing.Size(100, 20)
        Me.LabelLN.TabIndex = 7
        Me.LabelLN.Text = "* Last Name:"
        '
        'TextBoxLastname
        '
        Me.TextBoxLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastname.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxLastname.Location = New System.Drawing.Point(372, 118)
        Me.TextBoxLastname.Name = "TextBoxLastname"
        Me.TextBoxLastname.Size = New System.Drawing.Size(300, 38)
        Me.TextBoxLastname.TabIndex = 6
        '
        'LabelUN
        '
        Me.LabelUN.AutoSize = True
        Me.LabelUN.BackColor = System.Drawing.Color.Transparent
        Me.LabelUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUN.ForeColor = System.Drawing.Color.White
        Me.LabelUN.Location = New System.Drawing.Point(20, 173)
        Me.LabelUN.Name = "LabelUN"
        Me.LabelUN.Size = New System.Drawing.Size(97, 20)
        Me.LabelUN.TabIndex = 9
        Me.LabelUN.Text = "* Username:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxUsername.Location = New System.Drawing.Point(24, 196)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(648, 38)
        Me.TextBoxUsername.TabIndex = 8
        '
        'LabelEM
        '
        Me.LabelEM.AutoSize = True
        Me.LabelEM.BackColor = System.Drawing.Color.Transparent
        Me.LabelEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEM.ForeColor = System.Drawing.Color.White
        Me.LabelEM.Location = New System.Drawing.Point(20, 252)
        Me.LabelEM.Name = "LabelEM"
        Me.LabelEM.Size = New System.Drawing.Size(62, 20)
        Me.LabelEM.TabIndex = 11
        Me.LabelEM.Text = "* Email:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxEmail.Location = New System.Drawing.Point(24, 275)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(648, 38)
        Me.TextBoxEmail.TabIndex = 10
        '
        'LabelPASS1
        '
        Me.LabelPASS1.AutoSize = True
        Me.LabelPASS1.BackColor = System.Drawing.Color.Transparent
        Me.LabelPASS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPASS1.ForeColor = System.Drawing.Color.White
        Me.LabelPASS1.Location = New System.Drawing.Point(20, 329)
        Me.LabelPASS1.Name = "LabelPASS1"
        Me.LabelPASS1.Size = New System.Drawing.Size(92, 20)
        Me.LabelPASS1.TabIndex = 12
        Me.LabelPASS1.Text = "* Password:"
        '
        'LabelPASS2
        '
        Me.LabelPASS2.AutoSize = True
        Me.LabelPASS2.BackColor = System.Drawing.Color.Transparent
        Me.LabelPASS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPASS2.ForeColor = System.Drawing.Color.White
        Me.LabelPASS2.Location = New System.Drawing.Point(368, 329)
        Me.LabelPASS2.Name = "LabelPASS2"
        Me.LabelPASS2.Size = New System.Drawing.Size(151, 20)
        Me.LabelPASS2.TabIndex = 14
        Me.LabelPASS2.Text = "* Confirm Password:"
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConfirmPassword.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(372, 352)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(300, 38)
        Me.TextBoxConfirmPassword.TabIndex = 13
        Me.TextBoxConfirmPassword.UseSystemPasswordChar = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Yellow
        Me.Panel4.Location = New System.Drawing.Point(0, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(695, 2)
        Me.Panel4.TabIndex = 15
        '
        'LabelGoToSignIn
        '
        Me.LabelGoToSignIn.AutoSize = True
        Me.LabelGoToSignIn.BackColor = System.Drawing.Color.Transparent
        Me.LabelGoToSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGoToSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoToSignIn.ForeColor = System.Drawing.Color.Black
        Me.LabelGoToSignIn.Location = New System.Drawing.Point(231, 530)
        Me.LabelGoToSignIn.Name = "LabelGoToSignIn"
        Me.LabelGoToSignIn.Size = New System.Drawing.Size(210, 16)
        Me.LabelGoToSignIn.TabIndex = 16
        Me.LabelGoToSignIn.Text = "Already Have an Account? Sign In"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 596)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFirstname As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRegister As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelFN As System.Windows.Forms.Label
    Friend WithEvents LabelLN As System.Windows.Forms.Label
    Friend WithEvents TextBoxLastname As System.Windows.Forms.TextBox
    Friend WithEvents LabelPASS2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelPASS1 As System.Windows.Forms.Label
    Friend WithEvents LabelEM As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents LabelUN As System.Windows.Forms.Label
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelGoToSignIn As System.Windows.Forms.Label
End Class

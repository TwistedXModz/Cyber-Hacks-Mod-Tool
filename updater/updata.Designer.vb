﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updata
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updata))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FrostTheme1 = New Cyber_Hacks_Mod_Tool.FrostTheme()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.FrostProgressBar1 = New Cyber_Hacks_Mod_Tool.FrostProgressBar()
        Me.FrostButton1 = New Cyber_Hacks_Mod_Tool.FrostButton()
        Me.FrostCloseWindow1 = New Cyber_Hacks_Mod_Tool.FrostCloseWindow()
        Me.FrostTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'FrostTheme1
        '
        Me.FrostTheme1.BackColor = System.Drawing.Color.Black
        Me.FrostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.FrostTheme1.Color1 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.FrostTheme1.Color2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FrostTheme1.Color3 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.FrostTheme1.Color4 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FrostTheme1.Color5 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FrostTheme1.Color6 = System.Drawing.Color.Red
        Me.FrostTheme1.Colors = New Cyber_Hacks_Mod_Tool.Bloom(-1) {}
        Me.FrostTheme1.Controls.Add(Me.WebBrowser1)
        Me.FrostTheme1.Controls.Add(Me.FrostProgressBar1)
        Me.FrostTheme1.Controls.Add(Me.FrostButton1)
        Me.FrostTheme1.Controls.Add(Me.FrostCloseWindow1)
        Me.FrostTheme1.Customization = ""
        Me.FrostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrostTheme1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FrostTheme1.Image = Nothing
        Me.FrostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FrostTheme1.Movable = True
        Me.FrostTheme1.Name = "FrostTheme1"
        Me.FrostTheme1.NoRounding = False
        Me.FrostTheme1.Sizable = False
        Me.FrostTheme1.Size = New System.Drawing.Size(232, 86)
        Me.FrostTheme1.SmartBounds = True
        Me.FrostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FrostTheme1.TabIndex = 0
        Me.FrostTheme1.Text = "Updater"
        Me.FrostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FrostTheme1.Transparent = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(549, 311)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(49, 20)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Visible = False
        '
        'FrostProgressBar1
        '
        Me.FrostProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FrostProgressBar1.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FrostProgressBar1.Color2 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FrostProgressBar1.Color3 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FrostProgressBar1.Color4 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.FrostProgressBar1.Color5 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FrostProgressBar1.Color6 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.FrostProgressBar1.Colors = New Cyber_Hacks_Mod_Tool.Bloom(-1) {}
        Me.FrostProgressBar1.Customization = ""
        Me.FrostProgressBar1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FrostProgressBar1.FontColor = System.Drawing.Color.Red
        Me.FrostProgressBar1.Image = Nothing
        Me.FrostProgressBar1.Location = New System.Drawing.Point(44, 76)
        Me.FrostProgressBar1.Maximum = 100
        Me.FrostProgressBar1.Minimum = 0
        Me.FrostProgressBar1.Name = "FrostProgressBar1"
        Me.FrostProgressBar1.NoRounding = False
        Me.FrostProgressBar1.Size = New System.Drawing.Size(12, 23)
        Me.FrostProgressBar1.TabIndex = 2
        Me.FrostProgressBar1.Text = "FrostProgressBar1"
        Me.FrostProgressBar1.Transparent = False
        Me.FrostProgressBar1.Value = 0
        Me.FrostProgressBar1.Visible = False
        '
        'FrostButton1
        '
        Me.FrostButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FrostButton1.ColorDown1 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FrostButton1.ColorDown2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.FrostButton1.ColorDownOutline = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FrostButton1.ColorNone1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.FrostButton1.ColorNone2 = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.FrostButton1.ColorNoneOutline = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FrostButton1.ColorOver1 = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.FrostButton1.ColorOver2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FrostButton1.ColorOverOutline = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FrostButton1.Colors = New Cyber_Hacks_Mod_Tool.Bloom(-1) {}
        Me.FrostButton1.Customization = ""
        Me.FrostButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FrostButton1.FontColor = System.Drawing.Color.Red
        Me.FrostButton1.Image = Nothing
        Me.FrostButton1.Location = New System.Drawing.Point(49, 36)
        Me.FrostButton1.Name = "FrostButton1"
        Me.FrostButton1.NoRounding = False
        Me.FrostButton1.Size = New System.Drawing.Size(132, 32)
        Me.FrostButton1.TabIndex = 1
        Me.FrostButton1.Text = "Check For updates"
        Me.FrostButton1.Transparent = False
        '
        'FrostCloseWindow1
        '
        Me.FrostCloseWindow1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrostCloseWindow1.BackColor = System.Drawing.Color.Red
        Me.FrostCloseWindow1.ColorNone1 = System.Drawing.Color.Red
        Me.FrostCloseWindow1.ColorNone2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FrostCloseWindow1.ColorNoneOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FrostCloseWindow1.ColorOver1 = System.Drawing.Color.Red
        Me.FrostCloseWindow1.ColorOver2 = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FrostCloseWindow1.ColorOverOutline = System.Drawing.Color.Red
        Me.FrostCloseWindow1.Colors = New Cyber_Hacks_Mod_Tool.Bloom(-1) {}
        Me.FrostCloseWindow1.Customization = ""
        Me.FrostCloseWindow1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.FrostCloseWindow1.Image = Nothing
        Me.FrostCloseWindow1.Location = New System.Drawing.Point(189, 16)
        Me.FrostCloseWindow1.MaximumSize = New System.Drawing.Size(25, 7)
        Me.FrostCloseWindow1.Name = "FrostCloseWindow1"
        Me.FrostCloseWindow1.NoRounding = False
        Me.FrostCloseWindow1.Size = New System.Drawing.Size(25, 7)
        Me.FrostCloseWindow1.TabIndex = 0
        Me.FrostCloseWindow1.Text = "FrostCloseWindow1"
        Me.FrostCloseWindow1.Transparent = False
        '
        'updata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 86)
        Me.Controls.Add(Me.FrostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "updata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updater"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FrostTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrostTheme1 As FrostTheme
    Friend WithEvents FrostCloseWindow1 As FrostCloseWindow
    Friend WithEvents FrostButton1 As FrostButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents FrostProgressBar1 As FrostProgressBar
End Class

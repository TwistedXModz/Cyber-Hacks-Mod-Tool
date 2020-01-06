<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAD))
        Me.FrostTheme1 = New Cyber_Hacks_Mod_Tool.FrostTheme()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.FrostCloseWindow1 = New Cyber_Hacks_Mod_Tool.FrostCloseWindow()
        Me.FrostMinWindow1 = New Cyber_Hacks_Mod_Tool.FrostMinWindow()
        Me.FrostTheme1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.FrostTheme1.Controls.Add(Me.FrostCloseWindow1)
        Me.FrostTheme1.Controls.Add(Me.FrostMinWindow1)
        Me.FrostTheme1.Customization = ""
        Me.FrostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrostTheme1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FrostTheme1.Image = Nothing
        Me.FrostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FrostTheme1.Movable = True
        Me.FrostTheme1.Name = "FrostTheme1"
        Me.FrostTheme1.NoRounding = False
        Me.FrostTheme1.Sizable = True
        Me.FrostTheme1.Size = New System.Drawing.Size(1702, 914)
        Me.FrostTheme1.SmartBounds = True
        Me.FrostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FrostTheme1.TabIndex = 0
        Me.FrostTheme1.Text = "FrostTheme1"
        Me.FrostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FrostTheme1.Transparent = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 33)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1678, 869)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("https://cad.twistedxmods.xyz/", System.UriKind.Absolute)
        '
        'FrostCloseWindow1
        '
        Me.FrostCloseWindow1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrostCloseWindow1.ColorNone1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FrostCloseWindow1.ColorNone2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FrostCloseWindow1.ColorNoneOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FrostCloseWindow1.ColorOver1 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FrostCloseWindow1.ColorOver2 = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FrostCloseWindow1.ColorOverOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FrostCloseWindow1.Colors = New Cyber_Hacks_Mod_Tool.Bloom(-1) {}
        Me.FrostCloseWindow1.Customization = ""
        Me.FrostCloseWindow1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.FrostCloseWindow1.Image = Nothing
        Me.FrostCloseWindow1.Location = New System.Drawing.Point(1646, 20)
        Me.FrostCloseWindow1.MaximumSize = New System.Drawing.Size(25, 7)
        Me.FrostCloseWindow1.Name = "FrostCloseWindow1"
        Me.FrostCloseWindow1.NoRounding = False
        Me.FrostCloseWindow1.Size = New System.Drawing.Size(25, 7)
        Me.FrostCloseWindow1.TabIndex = 1
        Me.FrostCloseWindow1.Text = "FrostCloseWindow1"
        Me.FrostCloseWindow1.Transparent = False
        '
        'FrostMinWindow1
        '
        Me.FrostMinWindow1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrostMinWindow1.ColorNone1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FrostMinWindow1.ColorNone2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FrostMinWindow1.ColorNoneOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FrostMinWindow1.ColorOver1 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FrostMinWindow1.ColorOver2 = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FrostMinWindow1.ColorOverOutline = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FrostMinWindow1.Colors = New Cyber_Hacks_Mod_Tool.Bloom(-1) {}
        Me.FrostMinWindow1.Customization = ""
        Me.FrostMinWindow1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.FrostMinWindow1.Image = Nothing
        Me.FrostMinWindow1.Location = New System.Drawing.Point(1613, 20)
        Me.FrostMinWindow1.MaximumSize = New System.Drawing.Size(25, 7)
        Me.FrostMinWindow1.Name = "FrostMinWindow1"
        Me.FrostMinWindow1.NoRounding = False
        Me.FrostMinWindow1.Size = New System.Drawing.Size(25, 7)
        Me.FrostMinWindow1.TabIndex = 0
        Me.FrostMinWindow1.Text = "FrostMinWindow1"
        Me.FrostMinWindow1.Transparent = False
        '
        'CAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1702, 914)
        Me.Controls.Add(Me.FrostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Twisted X Modz RP CAD"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FrostTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrostTheme1 As FrostTheme
    Friend WithEvents FrostMinWindow1 As FrostMinWindow
    Friend WithEvents FrostCloseWindow1 As FrostCloseWindow
    Friend WithEvents WebBrowser1 As WebBrowser
End Class

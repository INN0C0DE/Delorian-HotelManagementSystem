<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_rfid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_rfid))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Me.admin_rfidno = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_rfidno
        '
        Me.admin_rfidno.AcceptsReturn = False
        Me.admin_rfidno.AcceptsTab = False
        Me.admin_rfidno.AnimationSpeed = 200
        Me.admin_rfidno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.admin_rfidno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.admin_rfidno.BackColor = System.Drawing.Color.Transparent
        Me.admin_rfidno.BackgroundImage = CType(resources.GetObject("admin_rfidno.BackgroundImage"), System.Drawing.Image)
        Me.admin_rfidno.BorderColorActive = System.Drawing.Color.DarkGoldenrod
        Me.admin_rfidno.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_rfidno.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.admin_rfidno.BorderColorIdle = System.Drawing.Color.Silver
        Me.admin_rfidno.BorderRadius = 25
        Me.admin_rfidno.BorderThickness = 1
        Me.admin_rfidno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.admin_rfidno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_rfidno.DefaultFont = New System.Drawing.Font("Poppins", 12.0!)
        Me.admin_rfidno.DefaultText = ""
        Me.admin_rfidno.FillColor = System.Drawing.Color.White
        Me.admin_rfidno.HideSelection = True
        Me.admin_rfidno.IconLeft = Nothing
        Me.admin_rfidno.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_rfidno.IconPadding = 10
        Me.admin_rfidno.IconRight = Nothing
        Me.admin_rfidno.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_rfidno.Lines = New String(-1) {}
        Me.admin_rfidno.Location = New System.Drawing.Point(88, 108)
        Me.admin_rfidno.MaxLength = 32767
        Me.admin_rfidno.MinimumSize = New System.Drawing.Size(100, 35)
        Me.admin_rfidno.Modified = False
        Me.admin_rfidno.Multiline = False
        Me.admin_rfidno.Name = "admin_rfidno"
        StateProperties1.BorderColor = System.Drawing.Color.DarkGoldenrod
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.admin_rfidno.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.admin_rfidno.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.admin_rfidno.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.admin_rfidno.OnIdleState = StateProperties4
        Me.admin_rfidno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_rfidno.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.admin_rfidno.PlaceholderText = "RFID NUMBER"
        Me.admin_rfidno.ReadOnly = False
        Me.admin_rfidno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.admin_rfidno.SelectedText = ""
        Me.admin_rfidno.SelectionLength = 0
        Me.admin_rfidno.SelectionStart = 0
        Me.admin_rfidno.ShortcutsEnabled = True
        Me.admin_rfidno.Size = New System.Drawing.Size(238, 35)
        Me.admin_rfidno.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.admin_rfidno.TabIndex = 3
        Me.admin_rfidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.admin_rfidno.TextMarginBottom = 0
        Me.admin_rfidno.TextMarginLeft = 5
        Me.admin_rfidno.TextMarginTop = 0
        Me.admin_rfidno.TextPlaceholder = "RFID NUMBER"
        Me.admin_rfidno.UseSystemPasswordChar = False
        Me.admin_rfidno.Visible = False
        Me.admin_rfidno.WordWrap = True
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(99, 242)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(204, 37)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "TAP RFID TO SCAN"
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.HMS_V1.My.Resources.Resources.rfid_tap
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(62, -20)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(290, 290)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 4
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'admin_rfid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(401, 276)
        Me.Controls.Add(Me.admin_rfidno)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "admin_rfid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELORIAN HOTEL | LOGIN USING RFID"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents admin_rfidno As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
End Class

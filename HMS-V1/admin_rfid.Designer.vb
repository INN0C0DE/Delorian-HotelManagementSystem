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
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.rfid_admintb = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'rfid_admintb
        '
        Me.rfid_admintb.AcceptsReturn = False
        Me.rfid_admintb.AcceptsTab = False
        Me.rfid_admintb.AnimationSpeed = 200
        Me.rfid_admintb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.rfid_admintb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.rfid_admintb.BackColor = System.Drawing.Color.Transparent
        Me.rfid_admintb.BackgroundImage = CType(resources.GetObject("rfid_admintb.BackgroundImage"), System.Drawing.Image)
        Me.rfid_admintb.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.rfid_admintb.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.rfid_admintb.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rfid_admintb.BorderColorIdle = System.Drawing.Color.Silver
        Me.rfid_admintb.BorderRadius = 1
        Me.rfid_admintb.BorderThickness = 1
        Me.rfid_admintb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.rfid_admintb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rfid_admintb.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.rfid_admintb.DefaultText = ""
        Me.rfid_admintb.FillColor = System.Drawing.Color.White
        Me.rfid_admintb.HideSelection = True
        Me.rfid_admintb.IconLeft = Nothing
        Me.rfid_admintb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.rfid_admintb.IconPadding = 10
        Me.rfid_admintb.IconRight = Nothing
        Me.rfid_admintb.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.rfid_admintb.Lines = New String(-1) {}
        Me.rfid_admintb.Location = New System.Drawing.Point(588, 12)
        Me.rfid_admintb.MaxLength = 32767
        Me.rfid_admintb.MinimumSize = New System.Drawing.Size(100, 35)
        Me.rfid_admintb.Modified = False
        Me.rfid_admintb.Multiline = False
        Me.rfid_admintb.Name = "rfid_admintb"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.rfid_admintb.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.rfid_admintb.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.rfid_admintb.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.rfid_admintb.OnIdleState = StateProperties4
        Me.rfid_admintb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rfid_admintb.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.rfid_admintb.PlaceholderText = ""
        Me.rfid_admintb.ReadOnly = False
        Me.rfid_admintb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.rfid_admintb.SelectedText = ""
        Me.rfid_admintb.SelectionLength = 0
        Me.rfid_admintb.SelectionStart = 0
        Me.rfid_admintb.ShortcutsEnabled = True
        Me.rfid_admintb.Size = New System.Drawing.Size(200, 35)
        Me.rfid_admintb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.rfid_admintb.TabIndex = 6
        Me.rfid_admintb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rfid_admintb.TextMarginBottom = 0
        Me.rfid_admintb.TextMarginLeft = 5
        Me.rfid_admintb.TextMarginTop = 0
        Me.rfid_admintb.TextPlaceholder = ""
        Me.rfid_admintb.UseSystemPasswordChar = False
        Me.rfid_admintb.WordWrap = True
        '
        'admin_rfid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(401, 276)
        Me.Controls.Add(Me.rfid_admintb)
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
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents rfid_admintb As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
End Class

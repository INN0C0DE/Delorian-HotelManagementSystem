<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staff_rfid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff_rfid))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.rfid_stafftb = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(100, 239)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(204, 37)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "TAP RFID TO SCAN"
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.HMS_V1.My.Resources.Resources.rfid_tap
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(63, -23)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(290, 290)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 1
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'rfid_stafftb
        '
        Me.rfid_stafftb.AcceptsReturn = False
        Me.rfid_stafftb.AcceptsTab = False
        Me.rfid_stafftb.AnimationSpeed = 200
        Me.rfid_stafftb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.rfid_stafftb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.rfid_stafftb.BackColor = System.Drawing.Color.Transparent
        Me.rfid_stafftb.BackgroundImage = CType(resources.GetObject("rfid_stafftb.BackgroundImage"), System.Drawing.Image)
        Me.rfid_stafftb.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.rfid_stafftb.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.rfid_stafftb.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rfid_stafftb.BorderColorIdle = System.Drawing.Color.Silver
        Me.rfid_stafftb.BorderRadius = 1
        Me.rfid_stafftb.BorderThickness = 1
        Me.rfid_stafftb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.rfid_stafftb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rfid_stafftb.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.rfid_stafftb.DefaultText = ""
        Me.rfid_stafftb.FillColor = System.Drawing.Color.White
        Me.rfid_stafftb.HideSelection = True
        Me.rfid_stafftb.IconLeft = Nothing
        Me.rfid_stafftb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.rfid_stafftb.IconPadding = 10
        Me.rfid_stafftb.IconRight = Nothing
        Me.rfid_stafftb.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.rfid_stafftb.Lines = New String(-1) {}
        Me.rfid_stafftb.Location = New System.Drawing.Point(653, 159)
        Me.rfid_stafftb.MaxLength = 32767
        Me.rfid_stafftb.MinimumSize = New System.Drawing.Size(100, 35)
        Me.rfid_stafftb.Modified = False
        Me.rfid_stafftb.Multiline = False
        Me.rfid_stafftb.Name = "rfid_stafftb"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.rfid_stafftb.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.rfid_stafftb.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.rfid_stafftb.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.rfid_stafftb.OnIdleState = StateProperties4
        Me.rfid_stafftb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rfid_stafftb.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.rfid_stafftb.PlaceholderText = ""
        Me.rfid_stafftb.ReadOnly = False
        Me.rfid_stafftb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.rfid_stafftb.SelectedText = ""
        Me.rfid_stafftb.SelectionLength = 0
        Me.rfid_stafftb.SelectionStart = 0
        Me.rfid_stafftb.ShortcutsEnabled = True
        Me.rfid_stafftb.Size = New System.Drawing.Size(200, 35)
        Me.rfid_stafftb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.rfid_stafftb.TabIndex = 3
        Me.rfid_stafftb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rfid_stafftb.TextMarginBottom = 0
        Me.rfid_stafftb.TextMarginLeft = 5
        Me.rfid_stafftb.TextMarginTop = 0
        Me.rfid_stafftb.TextPlaceholder = ""
        Me.rfid_stafftb.UseSystemPasswordChar = False
        Me.rfid_stafftb.WordWrap = True
        '
        'staff_rfid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(401, 276)
        Me.Controls.Add(Me.rfid_stafftb)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "staff_rfid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELORIAN HOTEL | LOGIN USING RFID"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rfid_stafftb As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
End Class

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
        Me.staff_rfidno = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
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
        'staff_rfidno
        '
        Me.staff_rfidno.AcceptsReturn = False
        Me.staff_rfidno.AcceptsTab = False
        Me.staff_rfidno.AnimationSpeed = 200
        Me.staff_rfidno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.staff_rfidno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.staff_rfidno.BackColor = System.Drawing.Color.Transparent
        Me.staff_rfidno.BackgroundImage = CType(resources.GetObject("staff_rfidno.BackgroundImage"), System.Drawing.Image)
        Me.staff_rfidno.BorderColorActive = System.Drawing.Color.DarkGoldenrod
        Me.staff_rfidno.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.staff_rfidno.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.staff_rfidno.BorderColorIdle = System.Drawing.Color.Silver
        Me.staff_rfidno.BorderRadius = 25
        Me.staff_rfidno.BorderThickness = 1
        Me.staff_rfidno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.staff_rfidno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.staff_rfidno.DefaultFont = New System.Drawing.Font("Poppins", 12.0!)
        Me.staff_rfidno.DefaultText = ""
        Me.staff_rfidno.FillColor = System.Drawing.Color.White
        Me.staff_rfidno.HideSelection = True
        Me.staff_rfidno.IconLeft = Nothing
        Me.staff_rfidno.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.staff_rfidno.IconPadding = 10
        Me.staff_rfidno.IconRight = Nothing
        Me.staff_rfidno.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.staff_rfidno.Lines = New String(-1) {}
        Me.staff_rfidno.Location = New System.Drawing.Point(89, 105)
        Me.staff_rfidno.MaxLength = 32767
        Me.staff_rfidno.MinimumSize = New System.Drawing.Size(100, 35)
        Me.staff_rfidno.Modified = False
        Me.staff_rfidno.Multiline = False
        Me.staff_rfidno.Name = "staff_rfidno"
        StateProperties1.BorderColor = System.Drawing.Color.DarkGoldenrod
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.staff_rfidno.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.staff_rfidno.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.staff_rfidno.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.staff_rfidno.OnIdleState = StateProperties4
        Me.staff_rfidno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.staff_rfidno.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.staff_rfidno.PlaceholderText = "RFID NUMBER"
        Me.staff_rfidno.ReadOnly = False
        Me.staff_rfidno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.staff_rfidno.SelectedText = ""
        Me.staff_rfidno.SelectionLength = 0
        Me.staff_rfidno.SelectionStart = 0
        Me.staff_rfidno.ShortcutsEnabled = True
        Me.staff_rfidno.Size = New System.Drawing.Size(238, 35)
        Me.staff_rfidno.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.staff_rfidno.TabIndex = 0
        Me.staff_rfidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.staff_rfidno.TextMarginBottom = 0
        Me.staff_rfidno.TextMarginLeft = 5
        Me.staff_rfidno.TextMarginTop = 0
        Me.staff_rfidno.TextPlaceholder = "RFID NUMBER"
        Me.staff_rfidno.UseSystemPasswordChar = False
        Me.staff_rfidno.Visible = False
        Me.staff_rfidno.WordWrap = True
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
        'staff_rfid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(401, 276)
        Me.Controls.Add(Me.staff_rfidno)
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

    Friend WithEvents staff_rfidno As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class

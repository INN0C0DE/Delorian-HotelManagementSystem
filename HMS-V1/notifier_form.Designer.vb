<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notifier_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notifier_form))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.close_btn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.send_message = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.notifier_message = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.notifier_number = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuLabel1.Location = New System.Drawing.Point(25, 172)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(143, 36)
        Me.BunifuLabel1.TabIndex = 87
        Me.BunifuLabel1.Text = "Text Message:"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuLabel3.Location = New System.Drawing.Point(27, 75)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(191, 36)
        Me.BunifuLabel3.TabIndex = 86
        Me.BunifuLabel3.Text = "Recepient Number:"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel9
        '
        Me.BunifuLabel9.AutoEllipsis = False
        Me.BunifuLabel9.CursorType = Nothing
        Me.BunifuLabel9.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel9.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.BunifuLabel9.Location = New System.Drawing.Point(25, 15)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(198, 39)
        Me.BunifuLabel9.TabIndex = 85
        Me.BunifuLabel9.Text = "MESSAGE NOTIFIER"
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'close_btn
        '
        Me.close_btn.AllowToggling = False
        Me.close_btn.AnimationSpeed = 200
        Me.close_btn.AutoGenerateColors = False
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.BackColor1 = System.Drawing.Color.BurlyWood
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.close_btn.ButtonText = "CLOSE"
        Me.close_btn.ButtonTextMarginLeft = 0
        Me.close_btn.ColorContrastOnClick = 45
        Me.close_btn.ColorContrastOnHover = 45
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.close_btn.CustomizableEdges = BorderEdges1
        Me.close_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.close_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.close_btn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.close_btn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.close_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.close_btn.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.close_btn.ForeColor = System.Drawing.Color.White
        Me.close_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.IconMarginLeft = 11
        Me.close_btn.IconPadding = 10
        Me.close_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.IdleBorderColor = System.Drawing.Color.BurlyWood
        Me.close_btn.IdleBorderRadius = 25
        Me.close_btn.IdleBorderThickness = 1
        Me.close_btn.IdleFillColor = System.Drawing.Color.BurlyWood
        Me.close_btn.IdleIconLeftImage = Nothing
        Me.close_btn.IdleIconRightImage = Nothing
        Me.close_btn.IndicateFocus = False
        Me.close_btn.Location = New System.Drawing.Point(230, 432)
        Me.close_btn.Name = "close_btn"
        StateProperties1.BorderColor = System.Drawing.Color.Peru
        StateProperties1.BorderRadius = 25
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.Peru
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.close_btn.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.SaddleBrown
        StateProperties2.BorderRadius = 25
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.SaddleBrown
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.close_btn.OnPressedState = StateProperties2
        Me.close_btn.Size = New System.Drawing.Size(149, 45)
        Me.close_btn.TabIndex = 89
        Me.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.close_btn.TextMarginLeft = 0
        Me.close_btn.UseDefaultRadiusAndThickness = True
        '
        'send_message
        '
        Me.send_message.AllowToggling = False
        Me.send_message.AnimationSpeed = 200
        Me.send_message.AutoGenerateColors = False
        Me.send_message.BackColor = System.Drawing.Color.Transparent
        Me.send_message.BackColor1 = System.Drawing.Color.BurlyWood
        Me.send_message.BackgroundImage = CType(resources.GetObject("send_message.BackgroundImage"), System.Drawing.Image)
        Me.send_message.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.send_message.ButtonText = "SEND MESSAGE"
        Me.send_message.ButtonTextMarginLeft = 0
        Me.send_message.ColorContrastOnClick = 45
        Me.send_message.ColorContrastOnHover = 45
        Me.send_message.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.send_message.CustomizableEdges = BorderEdges2
        Me.send_message.DialogResult = System.Windows.Forms.DialogResult.None
        Me.send_message.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.send_message.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.send_message.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.send_message.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.send_message.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.send_message.ForeColor = System.Drawing.Color.White
        Me.send_message.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.send_message.IconMarginLeft = 11
        Me.send_message.IconPadding = 10
        Me.send_message.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.send_message.IdleBorderColor = System.Drawing.Color.BurlyWood
        Me.send_message.IdleBorderRadius = 25
        Me.send_message.IdleBorderThickness = 1
        Me.send_message.IdleFillColor = System.Drawing.Color.BurlyWood
        Me.send_message.IdleIconLeftImage = Nothing
        Me.send_message.IdleIconRightImage = Nothing
        Me.send_message.IndicateFocus = False
        Me.send_message.Location = New System.Drawing.Point(49, 432)
        Me.send_message.Name = "send_message"
        StateProperties3.BorderColor = System.Drawing.Color.Peru
        StateProperties3.BorderRadius = 25
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.Peru
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.send_message.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.SaddleBrown
        StateProperties4.BorderRadius = 25
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.SaddleBrown
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.send_message.OnPressedState = StateProperties4
        Me.send_message.Size = New System.Drawing.Size(149, 45)
        Me.send_message.TabIndex = 88
        Me.send_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.send_message.TextMarginLeft = 0
        Me.send_message.UseDefaultRadiusAndThickness = True
        '
        'notifier_message
        '
        Me.notifier_message.AcceptsReturn = False
        Me.notifier_message.AcceptsTab = False
        Me.notifier_message.AnimationSpeed = 200
        Me.notifier_message.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.notifier_message.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.notifier_message.BackColor = System.Drawing.Color.Transparent
        Me.notifier_message.BackgroundImage = CType(resources.GetObject("notifier_message.BackgroundImage"), System.Drawing.Image)
        Me.notifier_message.BorderColorActive = System.Drawing.Color.DarkGoldenrod
        Me.notifier_message.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.notifier_message.BorderColorHover = System.Drawing.Color.Goldenrod
        Me.notifier_message.BorderColorIdle = System.Drawing.Color.Silver
        Me.notifier_message.BorderRadius = 25
        Me.notifier_message.BorderThickness = 1
        Me.notifier_message.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.notifier_message.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.notifier_message.DefaultFont = New System.Drawing.Font("Poppins", 14.25!)
        Me.notifier_message.DefaultText = ""
        Me.notifier_message.FillColor = System.Drawing.Color.White
        Me.notifier_message.HideSelection = True
        Me.notifier_message.IconLeft = Nothing
        Me.notifier_message.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.notifier_message.IconPadding = 10
        Me.notifier_message.IconRight = Nothing
        Me.notifier_message.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.notifier_message.Lines = New String(-1) {}
        Me.notifier_message.Location = New System.Drawing.Point(25, 201)
        Me.notifier_message.MaxLength = 32767
        Me.notifier_message.MinimumSize = New System.Drawing.Size(100, 35)
        Me.notifier_message.Modified = False
        Me.notifier_message.Multiline = True
        Me.notifier_message.Name = "notifier_message"
        StateProperties5.BorderColor = System.Drawing.Color.DarkGoldenrod
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_message.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.Empty
        StateProperties6.FillColor = System.Drawing.Color.White
        StateProperties6.ForeColor = System.Drawing.Color.Empty
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.notifier_message.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.Goldenrod
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_message.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_message.OnIdleState = StateProperties8
        Me.notifier_message.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.notifier_message.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.notifier_message.PlaceholderText = ""
        Me.notifier_message.ReadOnly = False
        Me.notifier_message.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.notifier_message.SelectedText = ""
        Me.notifier_message.SelectionLength = 0
        Me.notifier_message.SelectionStart = 0
        Me.notifier_message.ShortcutsEnabled = True
        Me.notifier_message.Size = New System.Drawing.Size(374, 214)
        Me.notifier_message.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.notifier_message.TabIndex = 84
        Me.notifier_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.notifier_message.TextMarginBottom = 0
        Me.notifier_message.TextMarginLeft = 5
        Me.notifier_message.TextMarginTop = 0
        Me.notifier_message.TextPlaceholder = ""
        Me.notifier_message.UseSystemPasswordChar = False
        Me.notifier_message.WordWrap = True
        '
        'notifier_number
        '
        Me.notifier_number.AcceptsReturn = False
        Me.notifier_number.AcceptsTab = False
        Me.notifier_number.AnimationSpeed = 200
        Me.notifier_number.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.notifier_number.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.notifier_number.BackColor = System.Drawing.Color.Transparent
        Me.notifier_number.BackgroundImage = CType(resources.GetObject("notifier_number.BackgroundImage"), System.Drawing.Image)
        Me.notifier_number.BorderColorActive = System.Drawing.Color.DarkGoldenrod
        Me.notifier_number.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.notifier_number.BorderColorHover = System.Drawing.Color.Goldenrod
        Me.notifier_number.BorderColorIdle = System.Drawing.Color.Silver
        Me.notifier_number.BorderRadius = 25
        Me.notifier_number.BorderThickness = 1
        Me.notifier_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.notifier_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.notifier_number.DefaultFont = New System.Drawing.Font("Poppins", 14.25!)
        Me.notifier_number.DefaultText = ""
        Me.notifier_number.FillColor = System.Drawing.Color.White
        Me.notifier_number.HideSelection = True
        Me.notifier_number.IconLeft = Nothing
        Me.notifier_number.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.notifier_number.IconPadding = 10
        Me.notifier_number.IconRight = Nothing
        Me.notifier_number.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.notifier_number.Lines = New String(-1) {}
        Me.notifier_number.Location = New System.Drawing.Point(25, 106)
        Me.notifier_number.MaxLength = 32767
        Me.notifier_number.MinimumSize = New System.Drawing.Size(100, 35)
        Me.notifier_number.Modified = False
        Me.notifier_number.Multiline = False
        Me.notifier_number.Name = "notifier_number"
        StateProperties9.BorderColor = System.Drawing.Color.DarkGoldenrod
        StateProperties9.FillColor = System.Drawing.Color.Empty
        StateProperties9.ForeColor = System.Drawing.Color.Empty
        StateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_number.OnActiveState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.Empty
        StateProperties10.FillColor = System.Drawing.Color.White
        StateProperties10.ForeColor = System.Drawing.Color.Empty
        StateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.notifier_number.OnDisabledState = StateProperties10
        StateProperties11.BorderColor = System.Drawing.Color.Goldenrod
        StateProperties11.FillColor = System.Drawing.Color.Empty
        StateProperties11.ForeColor = System.Drawing.Color.Empty
        StateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_number.OnHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.Silver
        StateProperties12.FillColor = System.Drawing.Color.White
        StateProperties12.ForeColor = System.Drawing.Color.Empty
        StateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_number.OnIdleState = StateProperties12
        Me.notifier_number.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.notifier_number.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.notifier_number.PlaceholderText = ""
        Me.notifier_number.ReadOnly = False
        Me.notifier_number.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.notifier_number.SelectedText = ""
        Me.notifier_number.SelectionLength = 0
        Me.notifier_number.SelectionStart = 0
        Me.notifier_number.ShortcutsEnabled = True
        Me.notifier_number.Size = New System.Drawing.Size(374, 40)
        Me.notifier_number.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.notifier_number.TabIndex = 83
        Me.notifier_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.notifier_number.TextMarginBottom = 0
        Me.notifier_number.TextMarginLeft = 5
        Me.notifier_number.TextMarginTop = 0
        Me.notifier_number.TextPlaceholder = ""
        Me.notifier_number.UseSystemPasswordChar = False
        Me.notifier_number.WordWrap = True
        '
        'notifier_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(424, 492)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.send_message)
        Me.Controls.Add(Me.notifier_message)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.notifier_number)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "notifier_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELORIAN HOTEL | MESSAGE NOTIFIER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents close_btn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents send_message As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents notifier_message As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents notifier_number As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel

    Private Sub send_btn_Click(sender As Object, e As EventArgs) Handles send_message.Click

    End Sub

End Class

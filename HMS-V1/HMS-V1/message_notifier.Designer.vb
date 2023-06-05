<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class message_notifier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(message_notifier))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.notifier_number = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.notifier_message = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.send_btn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.closeNotifier_btn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SuspendLayout()
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
        Me.notifier_number.Location = New System.Drawing.Point(24, 103)
        Me.notifier_number.MaxLength = 32767
        Me.notifier_number.MinimumSize = New System.Drawing.Size(100, 35)
        Me.notifier_number.Modified = False
        Me.notifier_number.Multiline = False
        Me.notifier_number.Name = "notifier_number"
        StateProperties1.BorderColor = System.Drawing.Color.DarkGoldenrod
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_number.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.notifier_number.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.Goldenrod
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_number.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.notifier_number.OnIdleState = StateProperties4
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
        Me.notifier_number.TabIndex = 68
        Me.notifier_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.notifier_number.TextMarginBottom = 0
        Me.notifier_number.TextMarginLeft = 5
        Me.notifier_number.TextMarginTop = 0
        Me.notifier_number.TextPlaceholder = ""
        Me.notifier_number.UseSystemPasswordChar = False
        Me.notifier_number.WordWrap = True
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
        Me.notifier_message.Location = New System.Drawing.Point(24, 198)
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
        Me.notifier_message.TabIndex = 69
        Me.notifier_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.notifier_message.TextMarginBottom = 0
        Me.notifier_message.TextMarginLeft = 5
        Me.notifier_message.TextMarginTop = 0
        Me.notifier_message.TextPlaceholder = ""
        Me.notifier_message.UseSystemPasswordChar = False
        Me.notifier_message.WordWrap = True
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuLabel3.Location = New System.Drawing.Point(26, 72)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(191, 36)
        Me.BunifuLabel3.TabIndex = 71
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
        Me.BunifuLabel9.Location = New System.Drawing.Point(24, 12)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(198, 39)
        Me.BunifuLabel9.TabIndex = 70
        Me.BunifuLabel9.Text = "MESSAGE NOTIFIER"
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuLabel1.Location = New System.Drawing.Point(24, 169)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(143, 36)
        Me.BunifuLabel1.TabIndex = 72
        Me.BunifuLabel1.Text = "Text Message:"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'send_btn
        '
        Me.send_btn.AllowToggling = False
        Me.send_btn.AnimationSpeed = 200
        Me.send_btn.AutoGenerateColors = False
        Me.send_btn.BackColor = System.Drawing.Color.Transparent
        Me.send_btn.BackColor1 = System.Drawing.Color.BurlyWood
        Me.send_btn.BackgroundImage = CType(resources.GetObject("send_btn.BackgroundImage"), System.Drawing.Image)
        Me.send_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.send_btn.ButtonText = "SEND MESSAGE"
        Me.send_btn.ButtonTextMarginLeft = 0
        Me.send_btn.ColorContrastOnClick = 45
        Me.send_btn.ColorContrastOnHover = 45
        Me.send_btn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.send_btn.CustomizableEdges = BorderEdges1
        Me.send_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.send_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.send_btn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.send_btn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.send_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.send_btn.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.send_btn.ForeColor = System.Drawing.Color.White
        Me.send_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.send_btn.IconMarginLeft = 11
        Me.send_btn.IconPadding = 10
        Me.send_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.send_btn.IdleBorderColor = System.Drawing.Color.BurlyWood
        Me.send_btn.IdleBorderRadius = 25
        Me.send_btn.IdleBorderThickness = 1
        Me.send_btn.IdleFillColor = System.Drawing.Color.BurlyWood
        Me.send_btn.IdleIconLeftImage = Nothing
        Me.send_btn.IdleIconRightImage = Nothing
        Me.send_btn.IndicateFocus = False
        Me.send_btn.Location = New System.Drawing.Point(48, 429)
        Me.send_btn.Name = "send_btn"
        StateProperties9.BorderColor = System.Drawing.Color.Peru
        StateProperties9.BorderRadius = 25
        StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties9.BorderThickness = 1
        StateProperties9.FillColor = System.Drawing.Color.Peru
        StateProperties9.ForeColor = System.Drawing.Color.White
        StateProperties9.IconLeftImage = Nothing
        StateProperties9.IconRightImage = Nothing
        Me.send_btn.onHoverState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.SaddleBrown
        StateProperties10.BorderRadius = 25
        StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties10.BorderThickness = 1
        StateProperties10.FillColor = System.Drawing.Color.SaddleBrown
        StateProperties10.ForeColor = System.Drawing.Color.White
        StateProperties10.IconLeftImage = Nothing
        StateProperties10.IconRightImage = Nothing
        Me.send_btn.OnPressedState = StateProperties10
        Me.send_btn.Size = New System.Drawing.Size(149, 45)
        Me.send_btn.TabIndex = 81
        Me.send_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.send_btn.TextMarginLeft = 0
        Me.send_btn.UseDefaultRadiusAndThickness = True
        '
        'closeNotifier_btn
        '
        Me.closeNotifier_btn.AllowToggling = False
        Me.closeNotifier_btn.AnimationSpeed = 200
        Me.closeNotifier_btn.AutoGenerateColors = False
        Me.closeNotifier_btn.BackColor = System.Drawing.Color.Transparent
        Me.closeNotifier_btn.BackColor1 = System.Drawing.Color.BurlyWood
        Me.closeNotifier_btn.BackgroundImage = CType(resources.GetObject("closeNotifier_btn.BackgroundImage"), System.Drawing.Image)
        Me.closeNotifier_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.closeNotifier_btn.ButtonText = "CLOSE"
        Me.closeNotifier_btn.ButtonTextMarginLeft = 0
        Me.closeNotifier_btn.ColorContrastOnClick = 45
        Me.closeNotifier_btn.ColorContrastOnHover = 45
        Me.closeNotifier_btn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.closeNotifier_btn.CustomizableEdges = BorderEdges2
        Me.closeNotifier_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.closeNotifier_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.closeNotifier_btn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.closeNotifier_btn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.closeNotifier_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.closeNotifier_btn.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.closeNotifier_btn.ForeColor = System.Drawing.Color.White
        Me.closeNotifier_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.closeNotifier_btn.IconMarginLeft = 11
        Me.closeNotifier_btn.IconPadding = 10
        Me.closeNotifier_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.closeNotifier_btn.IdleBorderColor = System.Drawing.Color.BurlyWood
        Me.closeNotifier_btn.IdleBorderRadius = 25
        Me.closeNotifier_btn.IdleBorderThickness = 1
        Me.closeNotifier_btn.IdleFillColor = System.Drawing.Color.BurlyWood
        Me.closeNotifier_btn.IdleIconLeftImage = Nothing
        Me.closeNotifier_btn.IdleIconRightImage = Nothing
        Me.closeNotifier_btn.IndicateFocus = False
        Me.closeNotifier_btn.Location = New System.Drawing.Point(229, 429)
        Me.closeNotifier_btn.Name = "closeNotifier_btn"
        StateProperties11.BorderColor = System.Drawing.Color.Peru
        StateProperties11.BorderRadius = 25
        StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties11.BorderThickness = 1
        StateProperties11.FillColor = System.Drawing.Color.Peru
        StateProperties11.ForeColor = System.Drawing.Color.White
        StateProperties11.IconLeftImage = Nothing
        StateProperties11.IconRightImage = Nothing
        Me.closeNotifier_btn.onHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.SaddleBrown
        StateProperties12.BorderRadius = 25
        StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties12.BorderThickness = 1
        StateProperties12.FillColor = System.Drawing.Color.SaddleBrown
        StateProperties12.ForeColor = System.Drawing.Color.White
        StateProperties12.IconLeftImage = Nothing
        StateProperties12.IconRightImage = Nothing
        Me.closeNotifier_btn.OnPressedState = StateProperties12
        Me.closeNotifier_btn.Size = New System.Drawing.Size(149, 45)
        Me.closeNotifier_btn.TabIndex = 82
        Me.closeNotifier_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.closeNotifier_btn.TextMarginLeft = 0
        Me.closeNotifier_btn.UseDefaultRadiusAndThickness = True
        '
        'message_notifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(424, 492)
        Me.Controls.Add(Me.closeNotifier_btn)
        Me.Controls.Add(Me.send_btn)
        Me.Controls.Add(Me.notifier_message)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.notifier_number)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "message_notifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELORIAN HOTEL | MESSAGE NOTIFIER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents notifier_number As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents notifier_message As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents send_btn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents closeNotifier_btn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class

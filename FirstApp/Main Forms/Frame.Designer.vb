<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frame))
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.WindowsRestoreButton = New FontAwesome.Sharp.IconButton()
        Me.WindowsMinimizeButton = New FontAwesome.Sharp.IconButton()
        Me.CloseButton = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.SilverRateLabel = New System.Windows.Forms.Label()
        Me.GoldRateLabel = New System.Windows.Forms.Label()
        Me.SilverButton = New FontAwesome.Sharp.IconButton()
        Me.GoldButton = New FontAwesome.Sharp.IconButton()
        Me.UserPhNo = New FontAwesome.Sharp.IconButton()
        Me.ConnectionLabel = New FontAwesome.Sharp.IconButton()
        Me.ServerContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WhatsappWebVisibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanAllSessionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeServerAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SidePanelButton = New FontAwesome.Sharp.IconPictureBox()
        Me.LeftArrowButton = New FontAwesome.Sharp.IconPictureBox()
        Me.RightArrowButton = New FontAwesome.Sharp.IconPictureBox()
        Me.SendMessageButton = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NewCoustmerButton = New FontAwesome.Sharp.IconButton()
        Me.QuickSearchButton = New FontAwesome.Sharp.IconButton()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelTitleBar.SuspendLayout()
        Me.ServerContextMenuStrip.SuspendLayout()
        CType(Me.SidePanelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftArrowButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightArrowButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.WindowsRestoreButton)
        Me.PanelTitleBar.Controls.Add(Me.WindowsMinimizeButton)
        Me.PanelTitleBar.Controls.Add(Me.CloseButton)
        Me.PanelTitleBar.Controls.Add(Me.IconButton3)
        Me.PanelTitleBar.Controls.Add(Me.SilverRateLabel)
        Me.PanelTitleBar.Controls.Add(Me.GoldRateLabel)
        Me.PanelTitleBar.Controls.Add(Me.SilverButton)
        Me.PanelTitleBar.Controls.Add(Me.GoldButton)
        Me.PanelTitleBar.Controls.Add(Me.UserPhNo)
        Me.PanelTitleBar.Controls.Add(Me.ConnectionLabel)
        Me.PanelTitleBar.Controls.Add(Me.SidePanelButton)
        Me.PanelTitleBar.Controls.Add(Me.LeftArrowButton)
        Me.PanelTitleBar.Controls.Add(Me.RightArrowButton)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1924, 63)
        Me.PanelTitleBar.TabIndex = 138
        '
        'WindowsRestoreButton
        '
        Me.WindowsRestoreButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WindowsRestoreButton.BackColor = System.Drawing.Color.Transparent
        Me.WindowsRestoreButton.FlatAppearance.BorderSize = 0
        Me.WindowsRestoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.WindowsRestoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.WindowsRestoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WindowsRestoreButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsRestoreButton.ForeColor = System.Drawing.Color.Linen
        Me.WindowsRestoreButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.WindowsRestoreButton.IconColor = System.Drawing.Color.White
        Me.WindowsRestoreButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.WindowsRestoreButton.IconSize = 32
        Me.WindowsRestoreButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.WindowsRestoreButton.Location = New System.Drawing.Point(1833, -2)
        Me.WindowsRestoreButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WindowsRestoreButton.Name = "WindowsRestoreButton"
        Me.WindowsRestoreButton.Size = New System.Drawing.Size(47, 42)
        Me.WindowsRestoreButton.TabIndex = 266
        Me.WindowsRestoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.WindowsRestoreButton.UseVisualStyleBackColor = False
        '
        'WindowsMinimizeButton
        '
        Me.WindowsMinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WindowsMinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.WindowsMinimizeButton.FlatAppearance.BorderSize = 0
        Me.WindowsMinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.WindowsMinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.WindowsMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WindowsMinimizeButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsMinimizeButton.ForeColor = System.Drawing.Color.Linen
        Me.WindowsMinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.WindowsMinimizeButton.IconColor = System.Drawing.Color.White
        Me.WindowsMinimizeButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.WindowsMinimizeButton.IconSize = 32
        Me.WindowsMinimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.WindowsMinimizeButton.Location = New System.Drawing.Point(1787, -2)
        Me.WindowsMinimizeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WindowsMinimizeButton.Name = "WindowsMinimizeButton"
        Me.WindowsMinimizeButton.Size = New System.Drawing.Size(47, 42)
        Me.WindowsMinimizeButton.TabIndex = 265
        Me.WindowsMinimizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.WindowsMinimizeButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Linen
        Me.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.CloseButton.IconColor = System.Drawing.Color.White
        Me.CloseButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CloseButton.IconSize = 32
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CloseButton.Location = New System.Drawing.Point(1879, -2)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(47, 42)
        Me.CloseButton.TabIndex = 263
        Me.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 25
        Me.IconButton3.Location = New System.Drawing.Point(244, 18)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(45, 33)
        Me.IconButton3.TabIndex = 211
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'SilverRateLabel
        '
        Me.SilverRateLabel.AutoSize = True
        Me.SilverRateLabel.BackColor = System.Drawing.Color.Transparent
        Me.SilverRateLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.SilverRateLabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.SilverRateLabel.Location = New System.Drawing.Point(448, 11)
        Me.SilverRateLabel.Name = "SilverRateLabel"
        Me.SilverRateLabel.Size = New System.Drawing.Size(0, 42)
        Me.SilverRateLabel.TabIndex = 173
        '
        'GoldRateLabel
        '
        Me.GoldRateLabel.AutoSize = True
        Me.GoldRateLabel.BackColor = System.Drawing.Color.Transparent
        Me.GoldRateLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.GoldRateLabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.GoldRateLabel.Location = New System.Drawing.Point(992, 11)
        Me.GoldRateLabel.Name = "GoldRateLabel"
        Me.GoldRateLabel.Size = New System.Drawing.Size(0, 42)
        Me.GoldRateLabel.TabIndex = 172
        '
        'SilverButton
        '
        Me.SilverButton.BackColor = System.Drawing.Color.Transparent
        Me.SilverButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SilverButton.FlatAppearance.BorderSize = 0
        Me.SilverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SilverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SilverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SilverButton.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SilverButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SilverButton.IconChar = FontAwesome.Sharp.IconChar.Coins
        Me.SilverButton.IconColor = System.Drawing.Color.WhiteSmoke
        Me.SilverButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SilverButton.IconSize = 60
        Me.SilverButton.Location = New System.Drawing.Point(283, 3)
        Me.SilverButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SilverButton.Name = "SilverButton"
        Me.SilverButton.Size = New System.Drawing.Size(173, 58)
        Me.SilverButton.TabIndex = 172
        Me.SilverButton.Text = "Silver"
        Me.SilverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SilverButton.UseVisualStyleBackColor = False
        '
        'GoldButton
        '
        Me.GoldButton.BackColor = System.Drawing.Color.Transparent
        Me.GoldButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GoldButton.FlatAppearance.BorderSize = 0
        Me.GoldButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.GoldButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.GoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoldButton.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoldButton.ForeColor = System.Drawing.Color.Gold
        Me.GoldButton.IconChar = FontAwesome.Sharp.IconChar.Coins
        Me.GoldButton.IconColor = System.Drawing.Color.Gold
        Me.GoldButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.GoldButton.IconSize = 60
        Me.GoldButton.Location = New System.Drawing.Point(848, 3)
        Me.GoldButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GoldButton.Name = "GoldButton"
        Me.GoldButton.Size = New System.Drawing.Size(173, 58)
        Me.GoldButton.TabIndex = 171
        Me.GoldButton.Text = "Gold"
        Me.GoldButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GoldButton.UseVisualStyleBackColor = False
        '
        'UserPhNo
        '
        Me.UserPhNo.AutoSize = True
        Me.UserPhNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UserPhNo.BackColor = System.Drawing.Color.Transparent
        Me.UserPhNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.UserPhNo.FlatAppearance.BorderSize = 0
        Me.UserPhNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.UserPhNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.UserPhNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserPhNo.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPhNo.ForeColor = System.Drawing.Color.Green
        Me.UserPhNo.IconChar = FontAwesome.Sharp.IconChar.UserShield
        Me.UserPhNo.IconColor = System.Drawing.Color.Green
        Me.UserPhNo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UserPhNo.IconSize = 60
        Me.UserPhNo.Location = New System.Drawing.Point(1171, 3)
        Me.UserPhNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UserPhNo.Name = "UserPhNo"
        Me.UserPhNo.Size = New System.Drawing.Size(268, 66)
        Me.UserPhNo.TabIndex = 167
        Me.UserPhNo.Text = "9882960863"
        Me.UserPhNo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.UserPhNo.UseVisualStyleBackColor = False
        Me.UserPhNo.Visible = False
        '
        'ConnectionLabel
        '
        Me.ConnectionLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConnectionLabel.ContextMenuStrip = Me.ServerContextMenuStrip
        Me.ConnectionLabel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ConnectionLabel.FlatAppearance.BorderSize = 0
        Me.ConnectionLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ConnectionLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ConnectionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectionLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionLabel.ForeColor = System.Drawing.Color.Red
        Me.ConnectionLabel.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle
        Me.ConnectionLabel.IconColor = System.Drawing.Color.Goldenrod
        Me.ConnectionLabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ConnectionLabel.IconSize = 60
        Me.ConnectionLabel.Location = New System.Drawing.Point(1449, 3)
        Me.ConnectionLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConnectionLabel.Name = "ConnectionLabel"
        Me.ConnectionLabel.Size = New System.Drawing.Size(325, 58)
        Me.ConnectionLabel.TabIndex = 165
        Me.ConnectionLabel.Text = "Not Connected"
        Me.ConnectionLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ConnectionLabel.UseVisualStyleBackColor = False
        '
        'ServerContextMenuStrip
        '
        Me.ServerContextMenuStrip.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ServerContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatsappWebVisibilityToolStripMenuItem, Me.NotificationToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ChangeServerAddressToolStripMenuItem, Me.TestConnectionToolStripMenuItem})
        Me.ServerContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ServerContextMenuStrip.Name = "ServerContextMenuStrip"
        Me.ServerContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ServerContextMenuStrip.Size = New System.Drawing.Size(312, 154)
        '
        'WhatsappWebVisibilityToolStripMenuItem
        '
        Me.WhatsappWebVisibilityToolStripMenuItem.Name = "WhatsappWebVisibilityToolStripMenuItem"
        Me.WhatsappWebVisibilityToolStripMenuItem.Size = New System.Drawing.Size(311, 30)
        Me.WhatsappWebVisibilityToolStripMenuItem.Text = "Change Visibilty"
        '
        'NotificationToolStripMenuItem
        '
        Me.NotificationToolStripMenuItem.Name = "NotificationToolStripMenuItem"
        Me.NotificationToolStripMenuItem.Size = New System.Drawing.Size(311, 30)
        Me.NotificationToolStripMenuItem.Text = "Notifications: Turned On"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartServerToolStripMenuItem, Me.CloseServerToolStripMenuItem, Me.CleanAllSessionsToolStripMenuItem})
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(311, 30)
        Me.RestartToolStripMenuItem.Text = "Server Options"
        '
        'RestartServerToolStripMenuItem
        '
        Me.RestartServerToolStripMenuItem.Name = "RestartServerToolStripMenuItem"
        Me.RestartServerToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.RestartServerToolStripMenuItem.Text = "Restart Server"
        '
        'CloseServerToolStripMenuItem
        '
        Me.CloseServerToolStripMenuItem.Name = "CloseServerToolStripMenuItem"
        Me.CloseServerToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.CloseServerToolStripMenuItem.Text = "Close Server"
        '
        'CleanAllSessionsToolStripMenuItem
        '
        Me.CleanAllSessionsToolStripMenuItem.Name = "CleanAllSessionsToolStripMenuItem"
        Me.CleanAllSessionsToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.CleanAllSessionsToolStripMenuItem.Text = "Clean All Sessions"
        '
        'ChangeServerAddressToolStripMenuItem
        '
        Me.ChangeServerAddressToolStripMenuItem.Name = "ChangeServerAddressToolStripMenuItem"
        Me.ChangeServerAddressToolStripMenuItem.Size = New System.Drawing.Size(311, 30)
        Me.ChangeServerAddressToolStripMenuItem.Text = "Change Server Address"
        '
        'TestConnectionToolStripMenuItem
        '
        Me.TestConnectionToolStripMenuItem.Name = "TestConnectionToolStripMenuItem"
        Me.TestConnectionToolStripMenuItem.Size = New System.Drawing.Size(311, 30)
        Me.TestConnectionToolStripMenuItem.Text = "Test Connection"
        '
        'SidePanelButton
        '
        Me.SidePanelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SidePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SidePanelButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SidePanelButton.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.SidePanelButton.IconColor = System.Drawing.SystemColors.ControlText
        Me.SidePanelButton.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.SidePanelButton.IconSize = 46
        Me.SidePanelButton.Location = New System.Drawing.Point(13, 5)
        Me.SidePanelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SidePanelButton.Name = "SidePanelButton"
        Me.SidePanelButton.Size = New System.Drawing.Size(48, 46)
        Me.SidePanelButton.TabIndex = 141
        Me.SidePanelButton.TabStop = False
        '
        'LeftArrowButton
        '
        Me.LeftArrowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LeftArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftArrowButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LeftArrowButton.IconChar = FontAwesome.Sharp.IconChar.Backward
        Me.LeftArrowButton.IconColor = System.Drawing.SystemColors.ControlText
        Me.LeftArrowButton.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.LeftArrowButton.IconSize = 46
        Me.LeftArrowButton.Location = New System.Drawing.Point(118, 8)
        Me.LeftArrowButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeftArrowButton.Name = "LeftArrowButton"
        Me.LeftArrowButton.Size = New System.Drawing.Size(48, 46)
        Me.LeftArrowButton.TabIndex = 140
        Me.LeftArrowButton.TabStop = False
        '
        'RightArrowButton
        '
        Me.RightArrowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RightArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightArrowButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RightArrowButton.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.RightArrowButton.IconColor = System.Drawing.SystemColors.ControlText
        Me.RightArrowButton.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.RightArrowButton.IconSize = 46
        Me.RightArrowButton.Location = New System.Drawing.Point(175, 8)
        Me.RightArrowButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RightArrowButton.Name = "RightArrowButton"
        Me.RightArrowButton.Size = New System.Drawing.Size(48, 46)
        Me.RightArrowButton.TabIndex = 139
        Me.RightArrowButton.TabStop = False
        '
        'SendMessageButton
        '
        Me.SendMessageButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SendMessageButton.FlatAppearance.BorderSize = 0
        Me.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendMessageButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendMessageButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.SendMessageButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.SendMessageButton.IconColor = System.Drawing.Color.Black
        Me.SendMessageButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SendMessageButton.IconSize = 40
        Me.SendMessageButton.Location = New System.Drawing.Point(0, 436)
        Me.SendMessageButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendMessageButton.Name = "SendMessageButton"
        Me.SendMessageButton.Size = New System.Drawing.Size(340, 91)
        Me.SendMessageButton.TabIndex = 164
        Me.SendMessageButton.Text = "Send Message"
        Me.SendMessageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.SendMessageButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 177)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'NewCoustmerButton
        '
        Me.NewCoustmerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.NewCoustmerButton.FlatAppearance.BorderSize = 0
        Me.NewCoustmerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewCoustmerButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCoustmerButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.NewCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.NewCoustmerButton.IconColor = System.Drawing.Color.Black
        Me.NewCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.NewCoustmerButton.IconSize = 40
        Me.NewCoustmerButton.Location = New System.Drawing.Point(0, 333)
        Me.NewCoustmerButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NewCoustmerButton.Name = "NewCoustmerButton"
        Me.NewCoustmerButton.Size = New System.Drawing.Size(340, 91)
        Me.NewCoustmerButton.TabIndex = 163
        Me.NewCoustmerButton.Text = "Add habitué"
        Me.NewCoustmerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.NewCoustmerButton.UseVisualStyleBackColor = False
        '
        'QuickSearchButton
        '
        Me.QuickSearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.QuickSearchButton.FlatAppearance.BorderSize = 0
        Me.QuickSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuickSearchButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuickSearchButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.QuickSearchButton.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.QuickSearchButton.IconColor = System.Drawing.Color.Black
        Me.QuickSearchButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.QuickSearchButton.IconSize = 40
        Me.QuickSearchButton.Location = New System.Drawing.Point(0, 229)
        Me.QuickSearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QuickSearchButton.Name = "QuickSearchButton"
        Me.QuickSearchButton.Size = New System.Drawing.Size(340, 91)
        Me.QuickSearchButton.TabIndex = 142
        Me.QuickSearchButton.Text = "Insta  Search"
        Me.QuickSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.QuickSearchButton.UseVisualStyleBackColor = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.NewCoustmerButton)
        Me.PanelMenu.Controls.Add(Me.SendMessageButton)
        Me.PanelMenu.Controls.Add(Me.QuickSearchButton)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 63)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(340, 987)
        Me.PanelMenu.TabIndex = 170
        Me.PanelMenu.Visible = False
        '
        'Frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frame"
        Me.Text = "Frame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        Me.ServerContextMenuStrip.ResumeLayout(False)
        CType(Me.SidePanelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftArrowButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightArrowButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents LeftArrowButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents RightArrowButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SidePanelButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ConnectionLabel As FontAwesome.Sharp.IconButton
    Friend WithEvents UserPhNo As FontAwesome.Sharp.IconButton
    Friend WithEvents SendMessageButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NewCoustmerButton As FontAwesome.Sharp.IconButton
    Friend WithEvents QuickSearchButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents GoldRateLabel As Label
    Friend WithEvents SilverButton As FontAwesome.Sharp.IconButton
    Friend WithEvents GoldButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SilverRateLabel As Label
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents CloseButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ServerContextMenuStrip As ContextMenuStrip
    Friend WithEvents WhatsappWebVisibilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsRestoreButton As FontAwesome.Sharp.IconButton
    Friend WithEvents WindowsMinimizeButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ChangeServerAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleanAllSessionsToolStripMenuItem As ToolStripMenuItem
End Class

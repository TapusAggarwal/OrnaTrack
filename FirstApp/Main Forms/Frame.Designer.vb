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
        Me.RoughButton = New FontAwesome.Sharp.IconButton()
        Me.VersionLB = New FontAwesome.Sharp.IconButton()
        Me.ServerContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WhatsappWebVisibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanAllSessionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeServerAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageDownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.WindowsRestoreButton = New FontAwesome.Sharp.IconButton()
        Me.WindowsMinimizeButton = New FontAwesome.Sharp.IconButton()
        Me.CloseButton = New FontAwesome.Sharp.IconButton()
        Me.SilverRateLabel = New System.Windows.Forms.Label()
        Me.GoldRateLabel = New System.Windows.Forms.Label()
        Me.SilverButton = New FontAwesome.Sharp.IconButton()
        Me.UserPhNo = New FontAwesome.Sharp.IconButton()
        Me.ConnectionLabel = New FontAwesome.Sharp.IconButton()
        Me.SidePanelButton = New FontAwesome.Sharp.IconPictureBox()
        Me.LeftArrowButton = New FontAwesome.Sharp.IconPictureBox()
        Me.RightArrowButton = New FontAwesome.Sharp.IconPictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NewCoustmerButton = New FontAwesome.Sharp.IconButton()
        Me.SendMessageButton = New FontAwesome.Sharp.IconButton()
        Me.QuickSearchButton = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.PanelTitleBar.SuspendLayout()
        Me.ServerContextMenuStrip.SuspendLayout()
        CType(Me.SidePanelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftArrowButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightArrowButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.IconButton2)
        Me.PanelTitleBar.Controls.Add(Me.RoughButton)
        Me.PanelTitleBar.Controls.Add(Me.VersionLB)
        Me.PanelTitleBar.Controls.Add(Me.IconButton1)
        Me.PanelTitleBar.Controls.Add(Me.WindowsRestoreButton)
        Me.PanelTitleBar.Controls.Add(Me.WindowsMinimizeButton)
        Me.PanelTitleBar.Controls.Add(Me.CloseButton)
        Me.PanelTitleBar.Controls.Add(Me.SilverRateLabel)
        Me.PanelTitleBar.Controls.Add(Me.GoldRateLabel)
        Me.PanelTitleBar.Controls.Add(Me.SilverButton)
        Me.PanelTitleBar.Controls.Add(Me.UserPhNo)
        Me.PanelTitleBar.Controls.Add(Me.ConnectionLabel)
        Me.PanelTitleBar.Controls.Add(Me.SidePanelButton)
        Me.PanelTitleBar.Controls.Add(Me.LeftArrowButton)
        Me.PanelTitleBar.Controls.Add(Me.RightArrowButton)
        Me.PanelTitleBar.Controls.Add(Me.ProgressBar1)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1924, 63)
        Me.PanelTitleBar.TabIndex = 138
        '
        'RoughButton
        '
        Me.RoughButton.BackColor = System.Drawing.Color.Transparent
        Me.RoughButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RoughButton.FlatAppearance.BorderSize = 0
        Me.RoughButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RoughButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RoughButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoughButton.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoughButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RoughButton.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.RoughButton.IconColor = System.Drawing.Color.WhiteSmoke
        Me.RoughButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RoughButton.IconSize = 60
        Me.RoughButton.Location = New System.Drawing.Point(231, 3)
        Me.RoughButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RoughButton.Name = "RoughButton"
        Me.RoughButton.Size = New System.Drawing.Size(100, 58)
        Me.RoughButton.TabIndex = 269
        Me.RoughButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RoughButton.UseVisualStyleBackColor = False
        '
        'VersionLB
        '
        Me.VersionLB.BackColor = System.Drawing.Color.Transparent
        Me.VersionLB.ContextMenuStrip = Me.ServerContextMenuStrip
        Me.VersionLB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.VersionLB.FlatAppearance.BorderSize = 0
        Me.VersionLB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.VersionLB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.VersionLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VersionLB.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLB.ForeColor = System.Drawing.Color.White
        Me.VersionLB.IconChar = FontAwesome.Sharp.IconChar.CodeBranch
        Me.VersionLB.IconColor = System.Drawing.Color.White
        Me.VersionLB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.VersionLB.IconSize = 60
        Me.VersionLB.Location = New System.Drawing.Point(723, 3)
        Me.VersionLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VersionLB.Name = "VersionLB"
        Me.VersionLB.Size = New System.Drawing.Size(325, 58)
        Me.VersionLB.TabIndex = 268
        Me.VersionLB.Text = "V-1.0.1"
        Me.VersionLB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VersionLB.UseVisualStyleBackColor = False
        Me.VersionLB.Visible = False
        '
        'ServerContextMenuStrip
        '
        Me.ServerContextMenuStrip.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ServerContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatsappWebVisibilityToolStripMenuItem, Me.NotificationToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ChangeServerAddressToolStripMenuItem, Me.TestConnectionToolStripMenuItem, Me.UpdateServerToolStripMenuItem, Me.ImageDownloadToolStripMenuItem})
        Me.ServerContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ServerContextMenuStrip.Name = "ServerContextMenuStrip"
        Me.ServerContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ServerContextMenuStrip.Size = New System.Drawing.Size(312, 214)
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
        'UpdateServerToolStripMenuItem
        '
        Me.UpdateServerToolStripMenuItem.Name = "UpdateServerToolStripMenuItem"
        Me.UpdateServerToolStripMenuItem.Size = New System.Drawing.Size(311, 30)
        Me.UpdateServerToolStripMenuItem.Text = "Update Server"
        '
        'ImageDownloadToolStripMenuItem
        '
        Me.ImageDownloadToolStripMenuItem.Name = "ImageDownloadToolStripMenuItem"
        Me.ImageDownloadToolStripMenuItem.Size = New System.Drawing.Size(311, 30)
        Me.ImageDownloadToolStripMenuItem.Text = "Download Image"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 60
        Me.IconButton1.Location = New System.Drawing.Point(392, 3)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(100, 58)
        Me.IconButton1.TabIndex = 267
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.SilverRateLabel.Visible = False
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
        Me.GoldRateLabel.Visible = False
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
        Me.SilverButton.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.SilverButton.IconColor = System.Drawing.Color.WhiteSmoke
        Me.SilverButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SilverButton.IconSize = 60
        Me.SilverButton.Location = New System.Drawing.Point(500, 3)
        Me.SilverButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SilverButton.Name = "SilverButton"
        Me.SilverButton.Size = New System.Drawing.Size(96, 58)
        Me.SilverButton.TabIndex = 172
        Me.SilverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SilverButton.UseVisualStyleBackColor = False
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(628, 22)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(482, 24)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 172
        Me.ProgressBar1.Visible = False
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
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.IconButton2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 60
        Me.IconButton2.Location = New System.Drawing.Point(316, 3)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(96, 58)
        Me.IconButton2.TabIndex = 270
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
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
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SilverRateLabel As Label
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
    Friend WithEvents UpdateServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents VersionLB As FontAwesome.Sharp.IconButton
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents RoughButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ImageDownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class

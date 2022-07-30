<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KittyModeCoustView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KittyModeCoustView))
        Me.ProfileLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CustomerIdTB = New System.Windows.Forms.TextBox()
        Me.ProfessionLabel = New System.Windows.Forms.Label()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.KittyPanel = New System.Windows.Forms.Panel()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExistingPhNosButton = New FontAwesome.Sharp.IconButton()
        Me.ConnectKittys = New FontAwesome.Sharp.IconButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Prev_SessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartNewReviewSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReviewButton = New FontAwesome.Sharp.IconButton()
        Me.FullName = New System.Windows.Forms.Label()
        Me.PhNoLabel = New System.Windows.Forms.Label()
        Me.Profession = New System.Windows.Forms.Label()
        Me.Region = New System.Windows.Forms.Label()
        Me.RegionLabel = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Married = New System.Windows.Forms.Label()
        Me.MarriedLabel = New System.Windows.Forms.Label()
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.CustomerDetailsButton = New FontAwesome.Sharp.IconButton()
        Me.PhNo = New System.Windows.Forms.Label()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.KittyIdTB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KittyInfoLabel = New System.Windows.Forms.Label()
        Me.NextKittyButton = New FontAwesome.Sharp.IconButton()
        Me.PrevKittyButton = New FontAwesome.Sharp.IconButton()
        Me.BookModeButton = New FontAwesome.Sharp.IconButton()
        Me.AddKittyButton = New FontAwesome.Sharp.IconButton()
        Me.JumpToKittyNoButton = New FontAwesome.Sharp.IconButton()
        Me.DotsButton = New FontAwesome.Sharp.IconPictureBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KittyPanel.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ProfilePanel.SuspendLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DotsButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileLabel
        '
        Me.ProfileLabel.AutoSize = True
        Me.ProfileLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProfileLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ProfileLabel.Location = New System.Drawing.Point(4, 2)
        Me.ProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProfileLabel.Name = "ProfileLabel"
        Me.ProfileLabel.Size = New System.Drawing.Size(86, 30)
        Me.ProfileLabel.TabIndex = 255
        Me.ProfileLabel.Text = "Profile"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.NameLabel.Location = New System.Drawing.Point(11, 286)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(157, 34)
        Me.NameLabel.TabIndex = 189
        Me.NameLabel.Text = "Full Name:"
        '
        'CustomerIdTB
        '
        Me.CustomerIdTB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIdTB.Location = New System.Drawing.Point(16, 1013)
        Me.CustomerIdTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CustomerIdTB.Name = "CustomerIdTB"
        Me.CustomerIdTB.ReadOnly = True
        Me.CustomerIdTB.Size = New System.Drawing.Size(105, 36)
        Me.CustomerIdTB.TabIndex = 256
        Me.CustomerIdTB.Tag = ""
        '
        'ProfessionLabel
        '
        Me.ProfessionLabel.AutoSize = True
        Me.ProfessionLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProfessionLabel.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfessionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProfessionLabel.Location = New System.Drawing.Point(11, 545)
        Me.ProfessionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProfessionLabel.Name = "ProfessionLabel"
        Me.ProfessionLabel.Size = New System.Drawing.Size(156, 34)
        Me.ProfessionLabel.TabIndex = 195
        Me.ProfessionLabel.Text = "Profession:"
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1920, 63)
        Me.PanelTitleBar.TabIndex = 262
        Me.PanelTitleBar.Visible = False
        '
        'KittyPanel
        '
        Me.KittyPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.KittyPanel.Controls.Add(Me.ShowLabel)
        Me.KittyPanel.Location = New System.Drawing.Point(497, 84)
        Me.KittyPanel.Name = "KittyPanel"
        Me.KittyPanel.Size = New System.Drawing.Size(1404, 523)
        Me.KittyPanel.TabIndex = 264
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.BackColor = System.Drawing.Color.Transparent
        Me.ShowLabel.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ShowLabel.Location = New System.Drawing.Point(335, 238)
        Me.ShowLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(732, 47)
        Me.ShowLabel.TabIndex = 266
        Me.ShowLabel.Text = "Click On ""Show Details"" Button Below"
        '
        'ExistingPhNosButton
        '
        Me.ExistingPhNosButton.BackColor = System.Drawing.Color.Transparent
        Me.ExistingPhNosButton.FlatAppearance.BorderSize = 0
        Me.ExistingPhNosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ExistingPhNosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ExistingPhNosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExistingPhNosButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistingPhNosButton.ForeColor = System.Drawing.Color.Transparent
        Me.ExistingPhNosButton.IconChar = FontAwesome.Sharp.IconChar.PersonBooth
        Me.ExistingPhNosButton.IconColor = System.Drawing.Color.Goldenrod
        Me.ExistingPhNosButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ExistingPhNosButton.IconSize = 40
        Me.ExistingPhNosButton.Location = New System.Drawing.Point(413, 344)
        Me.ExistingPhNosButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExistingPhNosButton.Name = "ExistingPhNosButton"
        Me.ExistingPhNosButton.Size = New System.Drawing.Size(33, 35)
        Me.ExistingPhNosButton.TabIndex = 263
        Me.ExistingPhNosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.ExistingPhNosButton, "All Customers Having Same PhNo As This Customer.")
        Me.ExistingPhNosButton.UseVisualStyleBackColor = False
        Me.ExistingPhNosButton.Visible = False
        '
        'ConnectKittys
        '
        Me.ConnectKittys.BackColor = System.Drawing.Color.Transparent
        Me.ConnectKittys.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ConnectKittys.FlatAppearance.BorderSize = 0
        Me.ConnectKittys.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ConnectKittys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ConnectKittys.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectKittys.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectKittys.ForeColor = System.Drawing.Color.MediumPurple
        Me.ConnectKittys.IconChar = FontAwesome.Sharp.IconChar.History
        Me.ConnectKittys.IconColor = System.Drawing.Color.MediumPurple
        Me.ConnectKittys.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ConnectKittys.IconSize = 45
        Me.ConnectKittys.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ConnectKittys.Location = New System.Drawing.Point(1506, 1013)
        Me.ConnectKittys.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConnectKittys.Name = "ConnectKittys"
        Me.ConnectKittys.Size = New System.Drawing.Size(43, 46)
        Me.ConnectKittys.TabIndex = 247
        Me.ConnectKittys.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.ConnectKittys, "Here You Can Connect Kitties With This Customer")
        Me.ConnectKittys.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Prev_SessionToolStripMenuItem, Me.StartNewReviewSessionToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(285, 68)
        '
        'Prev_SessionToolStripMenuItem
        '
        Me.Prev_SessionToolStripMenuItem.Checked = True
        Me.Prev_SessionToolStripMenuItem.CheckOnClick = True
        Me.Prev_SessionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Prev_SessionToolStripMenuItem.Name = "Prev_SessionToolStripMenuItem"
        Me.Prev_SessionToolStripMenuItem.Size = New System.Drawing.Size(284, 32)
        Me.Prev_SessionToolStripMenuItem.Text = "Prev_Session"
        '
        'StartNewReviewSessionToolStripMenuItem
        '
        Me.StartNewReviewSessionToolStripMenuItem.Name = "StartNewReviewSessionToolStripMenuItem"
        Me.StartNewReviewSessionToolStripMenuItem.Size = New System.Drawing.Size(284, 32)
        Me.StartNewReviewSessionToolStripMenuItem.Text = "Start New Review Session"
        '
        'ReviewButton
        '
        Me.ReviewButton.BackColor = System.Drawing.Color.Transparent
        Me.ReviewButton.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ReviewButton.FlatAppearance.BorderSize = 0
        Me.ReviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ReviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReviewButton.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ReviewButton.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.ReviewButton.IconColor = System.Drawing.Color.MediumPurple
        Me.ReviewButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ReviewButton.IconSize = 45
        Me.ReviewButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReviewButton.Location = New System.Drawing.Point(413, 14)
        Me.ReviewButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReviewButton.Name = "ReviewButton"
        Me.ReviewButton.Size = New System.Drawing.Size(43, 46)
        Me.ReviewButton.TabIndex = 2988
        Me.ReviewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.ReviewButton, "Here You Can Connect Kitties With This Customer")
        Me.ReviewButton.UseVisualStyleBackColor = False
        Me.ReviewButton.Visible = False
        '
        'FullName
        '
        Me.FullName.AutoSize = True
        Me.FullName.BackColor = System.Drawing.Color.Transparent
        Me.FullName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FullName.Location = New System.Drawing.Point(160, 290)
        Me.FullName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(170, 30)
        Me.FullName.TabIndex = 265
        Me.FullName.Text = "Tapus Ranjan"
        '
        'PhNoLabel
        '
        Me.PhNoLabel.AutoSize = True
        Me.PhNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhNoLabel.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PhNoLabel.Location = New System.Drawing.Point(11, 342)
        Me.PhNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhNoLabel.Name = "PhNoLabel"
        Me.PhNoLabel.Size = New System.Drawing.Size(95, 34)
        Me.PhNoLabel.TabIndex = 266
        Me.PhNoLabel.Text = "PhNo:"
        '
        'Profession
        '
        Me.Profession.AutoSize = True
        Me.Profession.BackColor = System.Drawing.Color.Transparent
        Me.Profession.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profession.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Profession.Location = New System.Drawing.Point(160, 549)
        Me.Profession.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Profession.Name = "Profession"
        Me.Profession.Size = New System.Drawing.Size(96, 30)
        Me.Profession.TabIndex = 267
        Me.Profession.Text = "Lawyer"
        '
        'Region
        '
        Me.Region.AutoSize = True
        Me.Region.BackColor = System.Drawing.Color.Transparent
        Me.Region.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Region.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Region.Location = New System.Drawing.Point(117, 610)
        Me.Region.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Region.Name = "Region"
        Me.Region.Size = New System.Drawing.Size(171, 30)
        Me.Region.TabIndex = 269
        Me.Region.Text = "Bhojpur Bazar"
        '
        'RegionLabel
        '
        Me.RegionLabel.AutoSize = True
        Me.RegionLabel.BackColor = System.Drawing.Color.Transparent
        Me.RegionLabel.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RegionLabel.Location = New System.Drawing.Point(11, 606)
        Me.RegionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RegionLabel.Name = "RegionLabel"
        Me.RegionLabel.Size = New System.Drawing.Size(118, 34)
        Me.RegionLabel.TabIndex = 268
        Me.RegionLabel.Text = "Region:"
        '
        'Address
        '
        Me.Address.BackColor = System.Drawing.Color.Transparent
        Me.Address.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Address.Location = New System.Drawing.Point(15, 706)
        Me.Address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(444, 118)
        Me.Address.TabIndex = 271
        Me.Address.Text = "Introduced By kamla Kambosh"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddressLabel.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.AddressLabel.Location = New System.Drawing.Point(11, 667)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(129, 34)
        Me.AddressLabel.TabIndex = 270
        Me.AddressLabel.Text = "Address:"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.BackColor = System.Drawing.Color.Transparent
        Me.Gender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Gender.Location = New System.Drawing.Point(129, 428)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(103, 30)
        Me.Gender.TabIndex = 2987
        Me.Gender.Text = "Female"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(11, 423)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 34)
        Me.Label9.TabIndex = 272
        Me.Label9.Text = "Gender:"
        '
        'Married
        '
        Me.Married.AutoSize = True
        Me.Married.BackColor = System.Drawing.Color.Transparent
        Me.Married.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Married.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Married.Location = New System.Drawing.Point(129, 488)
        Me.Married.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Married.Name = "Married"
        Me.Married.Size = New System.Drawing.Size(73, 30)
        Me.Married.TabIndex = 275
        Me.Married.Text = "False"
        '
        'MarriedLabel
        '
        Me.MarriedLabel.AutoSize = True
        Me.MarriedLabel.BackColor = System.Drawing.Color.Transparent
        Me.MarriedLabel.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarriedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MarriedLabel.Location = New System.Drawing.Point(10, 484)
        Me.MarriedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MarriedLabel.Name = "MarriedLabel"
        Me.MarriedLabel.Size = New System.Drawing.Size(126, 34)
        Me.MarriedLabel.TabIndex = 274
        Me.MarriedLabel.Text = "Married:"
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProfilePanel.Controls.Add(Me.ReviewButton)
        Me.ProfilePanel.Controls.Add(Me.ProfileLabel)
        Me.ProfilePanel.Controls.Add(Me.ImageBox)
        Me.ProfilePanel.Controls.Add(Me.Address)
        Me.ProfilePanel.Controls.Add(Me.Region)
        Me.ProfilePanel.Controls.Add(Me.Married)
        Me.ProfilePanel.Controls.Add(Me.Gender)
        Me.ProfilePanel.Controls.Add(Me.Profession)
        Me.ProfilePanel.Controls.Add(Me.CustomerDetailsButton)
        Me.ProfilePanel.Controls.Add(Me.ExistingPhNosButton)
        Me.ProfilePanel.Controls.Add(Me.FullName)
        Me.ProfilePanel.Controls.Add(Me.ProfessionLabel)
        Me.ProfilePanel.Controls.Add(Me.MarriedLabel)
        Me.ProfilePanel.Controls.Add(Me.PhNo)
        Me.ProfilePanel.Controls.Add(Me.NameLabel)
        Me.ProfilePanel.Controls.Add(Me.Label9)
        Me.ProfilePanel.Controls.Add(Me.PhNoLabel)
        Me.ProfilePanel.Controls.Add(Me.AddressLabel)
        Me.ProfilePanel.Controls.Add(Me.RegionLabel)
        Me.ProfilePanel.Location = New System.Drawing.Point(17, 82)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(470, 907)
        Me.ProfilePanel.TabIndex = 251
        '
        'ImageBox
        '
        Me.ImageBox.BackgroundImage = CType(resources.GetObject("ImageBox.BackgroundImage"), System.Drawing.Image)
        Me.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ImageBox.ErrorImage = CType(resources.GetObject("ImageBox.ErrorImage"), System.Drawing.Image)
        Me.ImageBox.InitialImage = CType(resources.GetObject("ImageBox.InitialImage"), System.Drawing.Image)
        Me.ImageBox.Location = New System.Drawing.Point(122, 31)
        Me.ImageBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(226, 233)
        Me.ImageBox.TabIndex = 4
        Me.ImageBox.TabStop = False
        '
        'CustomerDetailsButton
        '
        Me.CustomerDetailsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CustomerDetailsButton.FlatAppearance.BorderSize = 0
        Me.CustomerDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerDetailsButton.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDetailsButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.CustomerDetailsButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.CustomerDetailsButton.IconColor = System.Drawing.Color.Black
        Me.CustomerDetailsButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CustomerDetailsButton.Location = New System.Drawing.Point(69, 833)
        Me.CustomerDetailsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CustomerDetailsButton.Name = "CustomerDetailsButton"
        Me.CustomerDetailsButton.Size = New System.Drawing.Size(333, 60)
        Me.CustomerDetailsButton.TabIndex = 266
        Me.CustomerDetailsButton.Text = "Coustmer Details"
        Me.CustomerDetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CustomerDetailsButton.UseVisualStyleBackColor = False
        '
        'PhNo
        '
        Me.PhNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PhNo.Location = New System.Drawing.Point(101, 344)
        Me.PhNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhNo.Name = "PhNo"
        Me.PhNo.Size = New System.Drawing.Size(294, 67)
        Me.PhNo.TabIndex = 260
        Me.PhNo.Text = "9816057863, 9882960863, 6239631173, 7018362951"
        '
        'PanelView
        '
        Me.PanelView.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelView.Location = New System.Drawing.Point(33, 3)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(1338, 367)
        Me.PanelView.TabIndex = 264
        '
        'KittyIdTB
        '
        Me.KittyIdTB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyIdTB.Location = New System.Drawing.Point(129, 1013)
        Me.KittyIdTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyIdTB.Name = "KittyIdTB"
        Me.KittyIdTB.ReadOnly = True
        Me.KittyIdTB.Size = New System.Drawing.Size(56, 36)
        Me.KittyIdTB.TabIndex = 268
        Me.KittyIdTB.Tag = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PanelView)
        Me.Panel1.Location = New System.Drawing.Point(496, 615)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1405, 374)
        Me.Panel1.TabIndex = 265
        '
        'KittyInfoLabel
        '
        Me.KittyInfoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KittyInfoLabel.AutoSize = True
        Me.KittyInfoLabel.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.KittyInfoLabel.Font = New System.Drawing.Font("Consolas", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyInfoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.KittyInfoLabel.Location = New System.Drawing.Point(898, 1008)
        Me.KittyInfoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.KittyInfoLabel.Name = "KittyInfoLabel"
        Me.KittyInfoLabel.Size = New System.Drawing.Size(454, 51)
        Me.KittyInfoLabel.TabIndex = 2989
        Me.KittyInfoLabel.Text = "500: #598: 587-845"
        Me.KittyInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KittyInfoLabel.Visible = False
        '
        'NextKittyButton
        '
        Me.NextKittyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.NextKittyButton.FlatAppearance.BorderSize = 0
        Me.NextKittyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextKittyButton.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextKittyButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.NextKittyButton.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.NextKittyButton.IconColor = System.Drawing.Color.PaleGreen
        Me.NextKittyButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.NextKittyButton.IconSize = 40
        Me.NextKittyButton.Location = New System.Drawing.Point(650, 1002)
        Me.NextKittyButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextKittyButton.Name = "NextKittyButton"
        Me.NextKittyButton.Size = New System.Drawing.Size(125, 62)
        Me.NextKittyButton.TabIndex = 2991
        Me.NextKittyButton.Text = "Next"
        Me.NextKittyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.NextKittyButton.UseVisualStyleBackColor = False
        Me.NextKittyButton.Visible = False
        '
        'PrevKittyButton
        '
        Me.PrevKittyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PrevKittyButton.FlatAppearance.BorderSize = 0
        Me.PrevKittyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrevKittyButton.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevKittyButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.PrevKittyButton.IconChar = FontAwesome.Sharp.IconChar.Backward
        Me.PrevKittyButton.IconColor = System.Drawing.Color.PaleGreen
        Me.PrevKittyButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PrevKittyButton.IconSize = 40
        Me.PrevKittyButton.Location = New System.Drawing.Point(512, 1002)
        Me.PrevKittyButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrevKittyButton.Name = "PrevKittyButton"
        Me.PrevKittyButton.Size = New System.Drawing.Size(134, 62)
        Me.PrevKittyButton.TabIndex = 2990
        Me.PrevKittyButton.Text = "Back"
        Me.PrevKittyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PrevKittyButton.UseVisualStyleBackColor = False
        Me.PrevKittyButton.Visible = False
        '
        'BookModeButton
        '
        Me.BookModeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BookModeButton.FlatAppearance.BorderSize = 0
        Me.BookModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookModeButton.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookModeButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.BookModeButton.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        Me.BookModeButton.IconColor = System.Drawing.Color.Silver
        Me.BookModeButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BookModeButton.Location = New System.Drawing.Point(223, 1004)
        Me.BookModeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BookModeButton.Name = "BookModeButton"
        Me.BookModeButton.Size = New System.Drawing.Size(264, 60)
        Me.BookModeButton.TabIndex = 2988
        Me.BookModeButton.Text = "Book Mode"
        Me.BookModeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BookModeButton.UseVisualStyleBackColor = False
        '
        'AddKittyButton
        '
        Me.AddKittyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AddKittyButton.FlatAppearance.BorderSize = 0
        Me.AddKittyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddKittyButton.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddKittyButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.AddKittyButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.AddKittyButton.IconColor = System.Drawing.Color.Black
        Me.AddKittyButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddKittyButton.Location = New System.Drawing.Point(1557, 1004)
        Me.AddKittyButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddKittyButton.Name = "AddKittyButton"
        Me.AddKittyButton.Size = New System.Drawing.Size(318, 61)
        Me.AddKittyButton.TabIndex = 267
        Me.AddKittyButton.Text = "Add New Kitty     "
        Me.AddKittyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddKittyButton.UseVisualStyleBackColor = False
        '
        'JumpToKittyNoButton
        '
        Me.JumpToKittyNoButton.BackColor = System.Drawing.Color.Transparent
        Me.JumpToKittyNoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.JumpToKittyNoButton.FlatAppearance.BorderSize = 0
        Me.JumpToKittyNoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.JumpToKittyNoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.JumpToKittyNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JumpToKittyNoButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumpToKittyNoButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.JumpToKittyNoButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.JumpToKittyNoButton.IconColor = System.Drawing.Color.PaleGreen
        Me.JumpToKittyNoButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.JumpToKittyNoButton.IconSize = 50
        Me.JumpToKittyNoButton.Location = New System.Drawing.Point(788, 1013)
        Me.JumpToKittyNoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.JumpToKittyNoButton.Name = "JumpToKittyNoButton"
        Me.JumpToKittyNoButton.Size = New System.Drawing.Size(50, 47)
        Me.JumpToKittyNoButton.TabIndex = 2992
        Me.JumpToKittyNoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.JumpToKittyNoButton.UseVisualStyleBackColor = False
        Me.JumpToKittyNoButton.Visible = False
        '
        'DotsButton
        '
        Me.DotsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DotsButton.BackColor = System.Drawing.Color.Transparent
        Me.DotsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DotsButton.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DotsButton.ForeColor = System.Drawing.Color.Silver
        Me.DotsButton.IconChar = FontAwesome.Sharp.IconChar.EllipsisV
        Me.DotsButton.IconColor = System.Drawing.Color.Silver
        Me.DotsButton.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.DotsButton.IconSize = 47
        Me.DotsButton.Location = New System.Drawing.Point(837, 1012)
        Me.DotsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DotsButton.Name = "DotsButton"
        Me.DotsButton.Size = New System.Drawing.Size(47, 47)
        Me.DotsButton.TabIndex = 2993
        Me.DotsButton.TabStop = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(241, 37)
        '
        'KittyModeCoustView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.DotsButton)
        Me.Controls.Add(Me.JumpToKittyNoButton)
        Me.Controls.Add(Me.NextKittyButton)
        Me.Controls.Add(Me.PrevKittyButton)
        Me.Controls.Add(Me.KittyInfoLabel)
        Me.Controls.Add(Me.BookModeButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.KittyIdTB)
        Me.Controls.Add(Me.AddKittyButton)
        Me.Controls.Add(Me.ProfilePanel)
        Me.Controls.Add(Me.KittyPanel)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.ConnectKittys)
        Me.Controls.Add(Me.CustomerIdTB)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "KittyModeCoustView"
        Me.Text = "Kitty Records"
        Me.KittyPanel.ResumeLayout(False)
        Me.KittyPanel.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ProfilePanel.ResumeLayout(False)
        Me.ProfilePanel.PerformLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DotsButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProfileLabel As Label
    Friend WithEvents ConnectKittys As FontAwesome.Sharp.IconButton
    Friend WithEvents KittysCompleted As Label
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents CustomerIdTB As TextBox
    Friend WithEvents ProfessionLabel As Label
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents ExistingPhNosButton As FontAwesome.Sharp.IconButton
    Friend WithEvents KittyPanel As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FullName As Label
    Friend WithEvents PhNoLabel As Label
    Friend WithEvents Profession As Label
    Friend WithEvents Region As Label
    Friend WithEvents RegionLabel As Label
    Friend WithEvents Address As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Gender As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Married As Label
    Friend WithEvents MarriedLabel As Label
    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents PanelView As Panel
    Friend WithEvents ShowLabel As Label
    Friend WithEvents PhNo As Label
    Friend WithEvents CustomerDetailsButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AddKittyButton As FontAwesome.Sharp.IconButton
    Friend WithEvents KittyIdTB As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BookModeButton As FontAwesome.Sharp.IconButton
    Friend WithEvents KittyInfoLabel As Label
    Friend WithEvents PrevKittyButton As FontAwesome.Sharp.IconButton
    Friend WithEvents NextKittyButton As FontAwesome.Sharp.IconButton
    Friend WithEvents JumpToKittyNoButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Prev_SessionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StartNewReviewSessionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReviewButton As FontAwesome.Sharp.IconButton
    Friend WithEvents DotsButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
End Class

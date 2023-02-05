<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageTemplates
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProfileLabel = New System.Windows.Forms.Label()
        Me.HandsCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolTipChB = New System.Windows.Forms.CheckBox()
        Me.MessageTB = New ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StrikeoutButton = New FontAwesome.Sharp.IconButton()
        Me.UnderlinedButton = New FontAwesome.Sharp.IconButton()
        Me.ItalicButton = New FontAwesome.Sharp.IconButton()
        Me.BoldButton = New FontAwesome.Sharp.IconButton()
        Me.AddMsgBT = New FontAwesome.Sharp.IconButton()
        Me.CancelEditBT = New FontAwesome.Sharp.IconButton()
        Me.EditBT = New FontAwesome.Sharp.IconButton()
        Me.SelectMsgBT = New FontAwesome.Sharp.IconButton()
        Me.GreetButton = New FontAwesome.Sharp.IconButton()
        Me.InstCompletedButton = New FontAwesome.Sharp.IconButton()
        Me.GivenAmountButton = New FontAwesome.Sharp.IconButton()
        Me.PendingAmountButton = New FontAwesome.Sharp.IconButton()
        Me.PendingMonthButton = New FontAwesome.Sharp.IconButton()
        Me.KittyNoButton = New FontAwesome.Sharp.IconButton()
        Me.CompMonthButton = New FontAwesome.Sharp.IconButton()
        Me.KittyTypeButton = New FontAwesome.Sharp.IconButton()
        Me.PendingInstButton = New FontAwesome.Sharp.IconButton()
        Me.PhNoButton = New FontAwesome.Sharp.IconButton()
        Me.CoustNameButton = New FontAwesome.Sharp.IconButton()
        Me.DeleteBT = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(767, 157)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(1000)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(556, 630)
        Me.FlowLayoutPanel1.TabIndex = 10031
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(769, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 3)
        Me.Panel3.TabIndex = 10030
        '
        'ProfileLabel
        '
        Me.ProfileLabel.AutoSize = True
        Me.ProfileLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProfileLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProfileLabel.Location = New System.Drawing.Point(792, 120)
        Me.ProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProfileLabel.Name = "ProfileLabel"
        Me.ProfileLabel.Size = New System.Drawing.Size(218, 30)
        Me.ProfileLabel.TabIndex = 10029
        Me.ProfileLabel.Text = "Saved Templates"
        '
        'HandsCheckBox
        '
        Me.HandsCheckBox.AutoSize = True
        Me.HandsCheckBox.Checked = True
        Me.HandsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HandsCheckBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HandsCheckBox.ForeColor = System.Drawing.Color.Orange
        Me.HandsCheckBox.Location = New System.Drawing.Point(595, 510)
        Me.HandsCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HandsCheckBox.Name = "HandsCheckBox"
        Me.HandsCheckBox.Size = New System.Drawing.Size(153, 27)
        Me.HandsCheckBox.TabIndex = 10024
        Me.HandsCheckBox.Text = "Hands Emoji"
        Me.HandsCheckBox.UseVisualStyleBackColor = True
        '
        'ToolTipChB
        '
        Me.ToolTipChB.AutoSize = True
        Me.ToolTipChB.Location = New System.Drawing.Point(1290, 83)
        Me.ToolTipChB.Name = "ToolTipChB"
        Me.ToolTipChB.Size = New System.Drawing.Size(22, 21)
        Me.ToolTipChB.TabIndex = 10022
        Me.ToolTipChB.UseVisualStyleBackColor = True
        '
        'MessageTB
        '
        Me.MessageTB.AutoWordSelection = True
        Me.MessageTB.BackColor = System.Drawing.Color.Lavender
        Me.MessageTB.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageTB.Location = New System.Drawing.Point(16, 137)
        Me.MessageTB.Name = "MessageTB"
        Me.MessageTB.Size = New System.Drawing.Size(554, 650)
        Me.MessageTB.TabIndex = 10010
        Me.MessageTB.Text = ""
        Me.MessageTB.ZoomFactor = 0.6!
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.StrikeoutButton)
        Me.Panel2.Controls.Add(Me.UnderlinedButton)
        Me.Panel2.Controls.Add(Me.ItalicButton)
        Me.Panel2.Controls.Add(Me.BoldButton)
        Me.Panel2.Location = New System.Drawing.Point(642, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(54, 217)
        Me.Panel2.TabIndex = 10011
        Me.Panel2.Visible = False
        '
        'StrikeoutButton
        '
        Me.StrikeoutButton.BackColor = System.Drawing.Color.Transparent
        Me.StrikeoutButton.FlatAppearance.BorderSize = 0
        Me.StrikeoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.StrikeoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.StrikeoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StrikeoutButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrikeoutButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.StrikeoutButton.IconChar = FontAwesome.Sharp.IconChar.Strikethrough
        Me.StrikeoutButton.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.StrikeoutButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.StrikeoutButton.IconSize = 35
        Me.StrikeoutButton.Location = New System.Drawing.Point(7, 170)
        Me.StrikeoutButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StrikeoutButton.Name = "StrikeoutButton"
        Me.StrikeoutButton.Size = New System.Drawing.Size(37, 44)
        Me.StrikeoutButton.TabIndex = 270
        Me.StrikeoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.StrikeoutButton.UseVisualStyleBackColor = False
        '
        'UnderlinedButton
        '
        Me.UnderlinedButton.BackColor = System.Drawing.Color.Transparent
        Me.UnderlinedButton.FlatAppearance.BorderSize = 0
        Me.UnderlinedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.UnderlinedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.UnderlinedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UnderlinedButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnderlinedButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.UnderlinedButton.IconChar = FontAwesome.Sharp.IconChar.MediumM
        Me.UnderlinedButton.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.UnderlinedButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UnderlinedButton.IconSize = 35
        Me.UnderlinedButton.Location = New System.Drawing.Point(7, 119)
        Me.UnderlinedButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UnderlinedButton.Name = "UnderlinedButton"
        Me.UnderlinedButton.Size = New System.Drawing.Size(37, 44)
        Me.UnderlinedButton.TabIndex = 269
        Me.UnderlinedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UnderlinedButton.UseVisualStyleBackColor = False
        '
        'ItalicButton
        '
        Me.ItalicButton.BackColor = System.Drawing.Color.Transparent
        Me.ItalicButton.FlatAppearance.BorderSize = 0
        Me.ItalicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.ItalicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ItalicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItalicButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItalicButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ItalicButton.IconChar = FontAwesome.Sharp.IconChar.Italic
        Me.ItalicButton.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.ItalicButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ItalicButton.IconSize = 35
        Me.ItalicButton.Location = New System.Drawing.Point(7, 65)
        Me.ItalicButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ItalicButton.Name = "ItalicButton"
        Me.ItalicButton.Size = New System.Drawing.Size(37, 44)
        Me.ItalicButton.TabIndex = 268
        Me.ItalicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ItalicButton.UseVisualStyleBackColor = False
        '
        'BoldButton
        '
        Me.BoldButton.BackColor = System.Drawing.Color.Transparent
        Me.BoldButton.FlatAppearance.BorderSize = 0
        Me.BoldButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.BoldButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BoldButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoldButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.BoldButton.IconChar = FontAwesome.Sharp.IconChar.Bold
        Me.BoldButton.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.BoldButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BoldButton.IconSize = 35
        Me.BoldButton.Location = New System.Drawing.Point(7, 11)
        Me.BoldButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BoldButton.Name = "BoldButton"
        Me.BoldButton.Size = New System.Drawing.Size(37, 44)
        Me.BoldButton.TabIndex = 267
        Me.BoldButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoldButton.UseVisualStyleBackColor = False
        '
        'AddMsgBT
        '
        Me.AddMsgBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddMsgBT.FlatAppearance.BorderSize = 0
        Me.AddMsgBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.AddMsgBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddMsgBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMsgBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMsgBT.ForeColor = System.Drawing.Color.Linen
        Me.AddMsgBT.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.AddMsgBT.IconColor = System.Drawing.Color.White
        Me.AddMsgBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddMsgBT.IconSize = 36
        Me.AddMsgBT.Location = New System.Drawing.Point(595, 401)
        Me.AddMsgBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddMsgBT.Name = "AddMsgBT"
        Me.AddMsgBT.Size = New System.Drawing.Size(152, 44)
        Me.AddMsgBT.TabIndex = 10026
        Me.AddMsgBT.Text = "Add"
        Me.AddMsgBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddMsgBT.UseVisualStyleBackColor = False
        '
        'CancelEditBT
        '
        Me.CancelEditBT.BackColor = System.Drawing.Color.Maroon
        Me.CancelEditBT.FlatAppearance.BorderSize = 0
        Me.CancelEditBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.CancelEditBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CancelEditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEditBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelEditBT.ForeColor = System.Drawing.Color.Linen
        Me.CancelEditBT.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.CancelEditBT.IconColor = System.Drawing.Color.White
        Me.CancelEditBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CancelEditBT.IconSize = 36
        Me.CancelEditBT.Location = New System.Drawing.Point(698, 401)
        Me.CancelEditBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelEditBT.Name = "CancelEditBT"
        Me.CancelEditBT.Size = New System.Drawing.Size(45, 44)
        Me.CancelEditBT.TabIndex = 10034
        Me.CancelEditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelEditBT.UseVisualStyleBackColor = False
        '
        'EditBT
        '
        Me.EditBT.BackColor = System.Drawing.Color.Maroon
        Me.EditBT.FlatAppearance.BorderSize = 0
        Me.EditBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.EditBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBT.ForeColor = System.Drawing.Color.Linen
        Me.EditBT.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.EditBT.IconColor = System.Drawing.Color.White
        Me.EditBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.EditBT.IconSize = 36
        Me.EditBT.Location = New System.Drawing.Point(596, 401)
        Me.EditBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditBT.Name = "EditBT"
        Me.EditBT.Size = New System.Drawing.Size(45, 44)
        Me.EditBT.TabIndex = 10033
        Me.EditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditBT.UseVisualStyleBackColor = False
        '
        'SelectMsgBT
        '
        Me.SelectMsgBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectMsgBT.Enabled = False
        Me.SelectMsgBT.FlatAppearance.BorderSize = 0
        Me.SelectMsgBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.SelectMsgBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectMsgBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectMsgBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectMsgBT.ForeColor = System.Drawing.Color.Linen
        Me.SelectMsgBT.IconChar = FontAwesome.Sharp.IconChar.HandPointer
        Me.SelectMsgBT.IconColor = System.Drawing.Color.White
        Me.SelectMsgBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SelectMsgBT.IconSize = 36
        Me.SelectMsgBT.Location = New System.Drawing.Point(593, 455)
        Me.SelectMsgBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectMsgBT.Name = "SelectMsgBT"
        Me.SelectMsgBT.Size = New System.Drawing.Size(152, 44)
        Me.SelectMsgBT.TabIndex = 10032
        Me.SelectMsgBT.Text = "Select"
        Me.SelectMsgBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SelectMsgBT.UseVisualStyleBackColor = False
        '
        'GreetButton
        '
        Me.GreetButton.AutoSize = True
        Me.GreetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GreetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GreetButton.FlatAppearance.BorderSize = 0
        Me.GreetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GreetButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreetButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.GreetButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart
        Me.GreetButton.IconColor = System.Drawing.Color.White
        Me.GreetButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.GreetButton.IconSize = 30
        Me.GreetButton.Location = New System.Drawing.Point(39, 18)
        Me.GreetButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GreetButton.Name = "GreetButton"
        Me.GreetButton.Size = New System.Drawing.Size(117, 37)
        Me.GreetButton.TabIndex = 10023
        Me.GreetButton.Text = "Greet"
        Me.GreetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GreetButton.UseVisualStyleBackColor = False
        '
        'InstCompletedButton
        '
        Me.InstCompletedButton.AutoSize = True
        Me.InstCompletedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.InstCompletedButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.InstCompletedButton.FlatAppearance.BorderSize = 0
        Me.InstCompletedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InstCompletedButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstCompletedButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.InstCompletedButton.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.InstCompletedButton.IconColor = System.Drawing.Color.White
        Me.InstCompletedButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.InstCompletedButton.IconSize = 40
        Me.InstCompletedButton.Location = New System.Drawing.Point(787, 13)
        Me.InstCompletedButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InstCompletedButton.Name = "InstCompletedButton"
        Me.InstCompletedButton.Size = New System.Drawing.Size(237, 46)
        Me.InstCompletedButton.TabIndex = 10021
        Me.InstCompletedButton.Text = "Inst Completed"
        Me.InstCompletedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InstCompletedButton.UseVisualStyleBackColor = False
        '
        'GivenAmountButton
        '
        Me.GivenAmountButton.AutoSize = True
        Me.GivenAmountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GivenAmountButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GivenAmountButton.FlatAppearance.BorderSize = 0
        Me.GivenAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GivenAmountButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GivenAmountButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.GivenAmountButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd
        Me.GivenAmountButton.IconColor = System.Drawing.Color.White
        Me.GivenAmountButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.GivenAmountButton.IconSize = 40
        Me.GivenAmountButton.Location = New System.Drawing.Point(205, 65)
        Me.GivenAmountButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GivenAmountButton.Name = "GivenAmountButton"
        Me.GivenAmountButton.Size = New System.Drawing.Size(228, 46)
        Me.GivenAmountButton.TabIndex = 10020
        Me.GivenAmountButton.Text = "Given Amount"
        Me.GivenAmountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GivenAmountButton.UseVisualStyleBackColor = False
        '
        'PendingAmountButton
        '
        Me.PendingAmountButton.AutoSize = True
        Me.PendingAmountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PendingAmountButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PendingAmountButton.FlatAppearance.BorderSize = 0
        Me.PendingAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingAmountButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingAmountButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.PendingAmountButton.IconChar = FontAwesome.Sharp.IconChar.Handshake
        Me.PendingAmountButton.IconColor = System.Drawing.Color.White
        Me.PendingAmountButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PendingAmountButton.IconSize = 40
        Me.PendingAmountButton.Location = New System.Drawing.Point(904, 65)
        Me.PendingAmountButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PendingAmountButton.Name = "PendingAmountButton"
        Me.PendingAmountButton.Size = New System.Drawing.Size(252, 46)
        Me.PendingAmountButton.TabIndex = 10019
        Me.PendingAmountButton.Text = "Pending Amount"
        Me.PendingAmountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PendingAmountButton.UseVisualStyleBackColor = False
        '
        'PendingMonthButton
        '
        Me.PendingMonthButton.AutoSize = True
        Me.PendingMonthButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PendingMonthButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PendingMonthButton.FlatAppearance.BorderSize = 0
        Me.PendingMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingMonthButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingMonthButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.PendingMonthButton.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes
        Me.PendingMonthButton.IconColor = System.Drawing.Color.White
        Me.PendingMonthButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PendingMonthButton.IconSize = 40
        Me.PendingMonthButton.Location = New System.Drawing.Point(644, 65)
        Me.PendingMonthButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PendingMonthButton.Name = "PendingMonthButton"
        Me.PendingMonthButton.Size = New System.Drawing.Size(254, 46)
        Me.PendingMonthButton.TabIndex = 10018
        Me.PendingMonthButton.Text = "Inst-Pend.-Month"
        Me.PendingMonthButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PendingMonthButton.UseVisualStyleBackColor = False
        '
        'KittyNoButton
        '
        Me.KittyNoButton.AutoSize = True
        Me.KittyNoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KittyNoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.KittyNoButton.FlatAppearance.BorderSize = 0
        Me.KittyNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KittyNoButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyNoButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.KittyNoButton.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.KittyNoButton.IconColor = System.Drawing.Color.White
        Me.KittyNoButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.KittyNoButton.IconSize = 30
        Me.KittyNoButton.Location = New System.Drawing.Point(646, 18)
        Me.KittyNoButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyNoButton.Name = "KittyNoButton"
        Me.KittyNoButton.Size = New System.Drawing.Size(133, 37)
        Me.KittyNoButton.TabIndex = 10017
        Me.KittyNoButton.Text = "KittyNo"
        Me.KittyNoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KittyNoButton.UseVisualStyleBackColor = False
        '
        'CompMonthButton
        '
        Me.CompMonthButton.AutoSize = True
        Me.CompMonthButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CompMonthButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CompMonthButton.FlatAppearance.BorderSize = 0
        Me.CompMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CompMonthButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompMonthButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.CompMonthButton.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        Me.CompMonthButton.IconColor = System.Drawing.Color.White
        Me.CompMonthButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CompMonthButton.IconSize = 40
        Me.CompMonthButton.Location = New System.Drawing.Point(1032, 14)
        Me.CompMonthButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CompMonthButton.Name = "CompMonthButton"
        Me.CompMonthButton.Size = New System.Drawing.Size(267, 46)
        Me.CompMonthButton.TabIndex = 10016
        Me.CompMonthButton.Text = "Inst-Comp.-Month"
        Me.CompMonthButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CompMonthButton.UseVisualStyleBackColor = False
        '
        'KittyTypeButton
        '
        Me.KittyTypeButton.AutoSize = True
        Me.KittyTypeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KittyTypeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.KittyTypeButton.FlatAppearance.BorderSize = 0
        Me.KittyTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KittyTypeButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyTypeButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.KittyTypeButton.IconChar = FontAwesome.Sharp.IconChar.ListOl
        Me.KittyTypeButton.IconColor = System.Drawing.Color.White
        Me.KittyTypeButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.KittyTypeButton.IconSize = 30
        Me.KittyTypeButton.Location = New System.Drawing.Point(476, 18)
        Me.KittyTypeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyTypeButton.Name = "KittyTypeButton"
        Me.KittyTypeButton.Size = New System.Drawing.Size(162, 37)
        Me.KittyTypeButton.TabIndex = 10015
        Me.KittyTypeButton.Text = "Kitty Type"
        Me.KittyTypeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KittyTypeButton.UseVisualStyleBackColor = False
        '
        'PendingInstButton
        '
        Me.PendingInstButton.AutoSize = True
        Me.PendingInstButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PendingInstButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PendingInstButton.FlatAppearance.BorderSize = 0
        Me.PendingInstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingInstButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingInstButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.PendingInstButton.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.PendingInstButton.IconColor = System.Drawing.Color.White
        Me.PendingInstButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PendingInstButton.IconSize = 40
        Me.PendingInstButton.Location = New System.Drawing.Point(439, 65)
        Me.PendingInstButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PendingInstButton.Name = "PendingInstButton"
        Me.PendingInstButton.Size = New System.Drawing.Size(199, 46)
        Me.PendingInstButton.TabIndex = 10014
        Me.PendingInstButton.Text = "Inst Pending"
        Me.PendingInstButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PendingInstButton.UseVisualStyleBackColor = False
        '
        'PhNoButton
        '
        Me.PhNoButton.AutoSize = True
        Me.PhNoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PhNoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PhNoButton.FlatAppearance.BorderSize = 0
        Me.PhNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PhNoButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNoButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.PhNoButton.IconChar = FontAwesome.Sharp.IconChar.PhoneSquareAlt
        Me.PhNoButton.IconColor = System.Drawing.Color.White
        Me.PhNoButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PhNoButton.IconSize = 30
        Me.PhNoButton.Location = New System.Drawing.Point(359, 18)
        Me.PhNoButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhNoButton.Name = "PhNoButton"
        Me.PhNoButton.Size = New System.Drawing.Size(112, 37)
        Me.PhNoButton.TabIndex = 10013
        Me.PhNoButton.Text = "PhNo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.PhNoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PhNoButton.UseVisualStyleBackColor = False
        '
        'CoustNameButton
        '
        Me.CoustNameButton.AutoSize = True
        Me.CoustNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CoustNameButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CoustNameButton.FlatAppearance.BorderSize = 0
        Me.CoustNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CoustNameButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoustNameButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.CoustNameButton.IconChar = FontAwesome.Sharp.IconChar.Signature
        Me.CoustNameButton.IconColor = System.Drawing.Color.White
        Me.CoustNameButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CoustNameButton.IconSize = 30
        Me.CoustNameButton.Location = New System.Drawing.Point(161, 18)
        Me.CoustNameButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CoustNameButton.Name = "CoustNameButton"
        Me.CoustNameButton.Size = New System.Drawing.Size(193, 37)
        Me.CoustNameButton.TabIndex = 10012
        Me.CoustNameButton.Text = "Coust Name"
        Me.CoustNameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CoustNameButton.UseVisualStyleBackColor = False
        '
        'DeleteBT
        '
        Me.DeleteBT.BackColor = System.Drawing.Color.Maroon
        Me.DeleteBT.FlatAppearance.BorderSize = 0
        Me.DeleteBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.DeleteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.ForeColor = System.Drawing.Color.Linen
        Me.DeleteBT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.DeleteBT.IconColor = System.Drawing.Color.White
        Me.DeleteBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DeleteBT.IconSize = 36
        Me.DeleteBT.Location = New System.Drawing.Point(647, 401)
        Me.DeleteBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(45, 44)
        Me.DeleteBT.TabIndex = 10035
        Me.DeleteBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBT.UseVisualStyleBackColor = False
        '
        'MessageTemplates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1339, 803)
        Me.Controls.Add(Me.AddMsgBT)
        Me.Controls.Add(Me.CancelEditBT)
        Me.Controls.Add(Me.EditBT)
        Me.Controls.Add(Me.SelectMsgBT)
        Me.Controls.Add(Me.ProfileLabel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.HandsCheckBox)
        Me.Controls.Add(Me.GreetButton)
        Me.Controls.Add(Me.ToolTipChB)
        Me.Controls.Add(Me.MessageTB)
        Me.Controls.Add(Me.InstCompletedButton)
        Me.Controls.Add(Me.GivenAmountButton)
        Me.Controls.Add(Me.PendingAmountButton)
        Me.Controls.Add(Me.PendingMonthButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.KittyNoButton)
        Me.Controls.Add(Me.CompMonthButton)
        Me.Controls.Add(Me.KittyTypeButton)
        Me.Controls.Add(Me.PendingInstButton)
        Me.Controls.Add(Me.PhNoButton)
        Me.Controls.Add(Me.CoustNameButton)
        Me.Controls.Add(Me.DeleteBT)
        Me.Name = "MessageTemplates"
        Me.Text = "MessageTemplates"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StrikeoutButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UnderlinedButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ItalicButton As FontAwesome.Sharp.IconButton
    Friend WithEvents BoldButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ProfileLabel As Label
    Friend WithEvents AddMsgBT As FontAwesome.Sharp.IconButton
    Friend WithEvents PreviewBT As FontAwesome.Sharp.IconButton
    Friend WithEvents HandsCheckBox As CheckBox
    Friend WithEvents GreetButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolTipChB As CheckBox
    Friend WithEvents MessageTB As ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl
    Friend WithEvents InstCompletedButton As FontAwesome.Sharp.IconButton
    Friend WithEvents GivenAmountButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PendingAmountButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PendingMonthButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents KittyNoButton As FontAwesome.Sharp.IconButton
    Friend WithEvents CompMonthButton As FontAwesome.Sharp.IconButton
    Friend WithEvents KittyTypeButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PendingInstButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PhNoButton As FontAwesome.Sharp.IconButton
    Friend WithEvents CoustNameButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SelectMsgBT As FontAwesome.Sharp.IconButton
    Friend WithEvents EditBT As FontAwesome.Sharp.IconButton
    Friend WithEvents CancelEditBT As FontAwesome.Sharp.IconButton
    Friend WithEvents DeleteBT As FontAwesome.Sharp.IconButton
End Class

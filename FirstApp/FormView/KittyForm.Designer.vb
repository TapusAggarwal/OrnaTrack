<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KittyForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New FontAwesome.Sharp.IconButton()
        Me.NotificationButton = New FontAwesome.Sharp.IconPictureBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceTB = New System.Windows.Forms.TextBox()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.KittyNoLabel = New System.Windows.Forms.Label()
        Me.LeftAmountTB = New System.Windows.Forms.TextBox()
        Me.RightArrowButton = New FontAwesome.Sharp.IconPictureBox()
        Me.KittyTypeLabel = New System.Windows.Forms.Label()
        Me.GroupLabel = New System.Windows.Forms.Label()
        Me.TotalInstalmentsLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.TotalKittysLB = New System.Windows.Forms.Label()
        Me.DissolveButton = New FontAwesome.Sharp.IconButton()
        Me.Intrestlabel = New System.Windows.Forms.Label()
        Me.PaymentButton = New FontAwesome.Sharp.IconButton()
        Me.KittyTypeCB = New System.Windows.Forms.ComboBox()
        Me.ResetButton = New FontAwesome.Sharp.IconButton()
        Me.EntryAmountLabel = New System.Windows.Forms.Label()
        Me.GivenAmountTB = New System.Windows.Forms.TextBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.EntryTB = New System.Windows.Forms.TextBox()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalInstalmentsTB = New System.Windows.Forms.TextBox()
        Me.KittyNoTB = New System.Windows.Forms.TextBox()
        Me.LeftAmountLabel = New System.Windows.Forms.Label()
        Me.KittyIntrestCB = New System.Windows.Forms.ComboBox()
        Me.GivenAmountLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New FontAwesome.Sharp.IconButton()
        Me.AvailButton = New FontAwesome.Sharp.IconButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainPanel.SuspendLayout()
        CType(Me.NotificationButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightArrowButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.CloseButton)
        Me.MainPanel.Controls.Add(Me.NotificationButton)
        Me.MainPanel.Controls.Add(Me.StatusLabel)
        Me.MainPanel.Controls.Add(Me.Dgv)
        Me.MainPanel.Controls.Add(Me.BalanceTB)
        Me.MainPanel.Controls.Add(Me.BalanceLabel)
        Me.MainPanel.Controls.Add(Me.KittyNoLabel)
        Me.MainPanel.Controls.Add(Me.LeftAmountTB)
        Me.MainPanel.Controls.Add(Me.RightArrowButton)
        Me.MainPanel.Controls.Add(Me.KittyTypeLabel)
        Me.MainPanel.Controls.Add(Me.GroupLabel)
        Me.MainPanel.Controls.Add(Me.TotalInstalmentsLabel)
        Me.MainPanel.Controls.Add(Me.SaveButton)
        Me.MainPanel.Controls.Add(Me.TotalKittysLB)
        Me.MainPanel.Controls.Add(Me.DissolveButton)
        Me.MainPanel.Controls.Add(Me.Intrestlabel)
        Me.MainPanel.Controls.Add(Me.PaymentButton)
        Me.MainPanel.Controls.Add(Me.KittyTypeCB)
        Me.MainPanel.Controls.Add(Me.ResetButton)
        Me.MainPanel.Controls.Add(Me.EntryAmountLabel)
        Me.MainPanel.Controls.Add(Me.GivenAmountTB)
        Me.MainPanel.Controls.Add(Me.DateLabel)
        Me.MainPanel.Controls.Add(Me.EntryTB)
        Me.MainPanel.Controls.Add(Me.DatePicker)
        Me.MainPanel.Controls.Add(Me.TotalInstalmentsTB)
        Me.MainPanel.Controls.Add(Me.KittyNoTB)
        Me.MainPanel.Controls.Add(Me.LeftAmountLabel)
        Me.MainPanel.Controls.Add(Me.KittyIntrestCB)
        Me.MainPanel.Controls.Add(Me.GivenAmountLabel)
        Me.MainPanel.Controls.Add(Me.DeleteButton)
        Me.MainPanel.Controls.Add(Me.AvailButton)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1404, 523)
        Me.MainPanel.TabIndex = 203
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.CloseButton.IconColor = System.Drawing.Color.DarkRed
        Me.CloseButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CloseButton.IconSize = 45
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CloseButton.Location = New System.Drawing.Point(1356, 2)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(43, 42)
        Me.CloseButton.TabIndex = 203
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'NotificationButton
        '
        Me.NotificationButton.BackColor = System.Drawing.Color.Transparent
        Me.NotificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NotificationButton.ForeColor = System.Drawing.Color.DarkRed
        Me.NotificationButton.IconChar = FontAwesome.Sharp.IconChar.BellSlash
        Me.NotificationButton.IconColor = System.Drawing.Color.DarkRed
        Me.NotificationButton.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.NotificationButton.IconSize = 47
        Me.NotificationButton.Location = New System.Drawing.Point(1292, 155)
        Me.NotificationButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NotificationButton.Name = "NotificationButton"
        Me.NotificationButton.Size = New System.Drawing.Size(47, 47)
        Me.NotificationButton.TabIndex = 202
        Me.NotificationButton.TabStop = False
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.Peru
        Me.StatusLabel.Location = New System.Drawing.Point(683, 390)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(99, 30)
        Me.StatusLabel.TabIndex = 201
        Me.StatusLabel.Text = "Status:"
        Me.StatusLabel.Visible = False
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AllowUserToResizeColumns = False
        Me.Dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column6, Me.Column2, Me.Column4, Me.Column5})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv.DefaultCellStyle = DataGridViewCellStyle7
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Left
        Me.Dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dgv.Location = New System.Drawing.Point(0, 0)
        Me.Dgv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dgv.MultiSelect = False
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(643, 523)
        Me.Dgv.TabIndex = 136
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 35
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "SrNo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 63
        '
        'Column6
        '
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Month"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column2
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 135
        '
        'Column4
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "Amount Paid"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 165
        '
        'Column5
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "KittyType"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 136
        '
        'BalanceTB
        '
        Me.BalanceTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BalanceTB.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BalanceTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTB.ForeColor = System.Drawing.SystemColors.Menu
        Me.BalanceTB.Location = New System.Drawing.Point(1240, 317)
        Me.BalanceTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BalanceTB.Name = "BalanceTB"
        Me.BalanceTB.ReadOnly = True
        Me.BalanceTB.Size = New System.Drawing.Size(148, 36)
        Me.BalanceTB.TabIndex = 199
        Me.BalanceTB.Text = "0"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceLabel.ForeColor = System.Drawing.Color.Peru
        Me.BalanceLabel.Location = New System.Drawing.Point(1070, 319)
        Me.BalanceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(113, 30)
        Me.BalanceLabel.TabIndex = 198
        Me.BalanceLabel.Text = "Balance"
        '
        'KittyNoLabel
        '
        Me.KittyNoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KittyNoLabel.AutoSize = True
        Me.KittyNoLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyNoLabel.ForeColor = System.Drawing.Color.Peru
        Me.KittyNoLabel.Location = New System.Drawing.Point(1024, 93)
        Me.KittyNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.KittyNoLabel.Name = "KittyNoLabel"
        Me.KittyNoLabel.Size = New System.Drawing.Size(131, 30)
        Me.KittyNoLabel.TabIndex = 137
        Me.KittyNoLabel.Text = "Kitty No*"
        '
        'LeftAmountTB
        '
        Me.LeftAmountTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeftAmountTB.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LeftAmountTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftAmountTB.ForeColor = System.Drawing.SystemColors.Menu
        Me.LeftAmountTB.Location = New System.Drawing.Point(1240, 209)
        Me.LeftAmountTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeftAmountTB.Name = "LeftAmountTB"
        Me.LeftAmountTB.ReadOnly = True
        Me.LeftAmountTB.Size = New System.Drawing.Size(148, 36)
        Me.LeftAmountTB.TabIndex = 197
        Me.LeftAmountTB.Text = "0"
        '
        'RightArrowButton
        '
        Me.RightArrowButton.BackColor = System.Drawing.Color.Transparent
        Me.RightArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightArrowButton.ForeColor = System.Drawing.Color.ForestGreen
        Me.RightArrowButton.IconChar = FontAwesome.Sharp.IconChar.ShareSquare
        Me.RightArrowButton.IconColor = System.Drawing.Color.ForestGreen
        Me.RightArrowButton.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.RightArrowButton.IconSize = 44
        Me.RightArrowButton.Location = New System.Drawing.Point(1231, 155)
        Me.RightArrowButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RightArrowButton.Name = "RightArrowButton"
        Me.RightArrowButton.Size = New System.Drawing.Size(46, 44)
        Me.RightArrowButton.TabIndex = 139
        Me.RightArrowButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RightArrowButton, "Send Kitty Reciept")
        '
        'KittyTypeLabel
        '
        Me.KittyTypeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KittyTypeLabel.AutoSize = True
        Me.KittyTypeLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyTypeLabel.ForeColor = System.Drawing.Color.Peru
        Me.KittyTypeLabel.Location = New System.Drawing.Point(714, 27)
        Me.KittyTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.KittyTypeLabel.Name = "KittyTypeLabel"
        Me.KittyTypeLabel.Size = New System.Drawing.Size(146, 30)
        Me.KittyTypeLabel.TabIndex = 138
        Me.KittyTypeLabel.Text = "Kitty Type"
        '
        'GroupLabel
        '
        Me.GroupLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupLabel.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupLabel.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupLabel.Location = New System.Drawing.Point(1127, 381)
        Me.GroupLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GroupLabel.Name = "GroupLabel"
        Me.GroupLabel.Size = New System.Drawing.Size(277, 48)
        Me.GroupLabel.TabIndex = 195
        Me.GroupLabel.Text = "B20000-1569"
        Me.GroupLabel.Visible = False
        '
        'TotalInstalmentsLabel
        '
        Me.TotalInstalmentsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalInstalmentsLabel.AutoSize = True
        Me.TotalInstalmentsLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalInstalmentsLabel.ForeColor = System.Drawing.Color.Peru
        Me.TotalInstalmentsLabel.Location = New System.Drawing.Point(666, 93)
        Me.TotalInstalmentsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalInstalmentsLabel.Name = "TotalInstalmentsLabel"
        Me.TotalInstalmentsLabel.Size = New System.Drawing.Size(232, 30)
        Me.TotalInstalmentsLabel.TabIndex = 139
        Me.TotalInstalmentsLabel.Text = "Total Instalments"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Linen
        Me.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.SaveButton.IconColor = System.Drawing.Color.White
        Me.SaveButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaveButton.IconSize = 32
        Me.SaveButton.Location = New System.Drawing.Point(1054, 453)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(282, 56)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Save Kitty Data"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'TotalKittysLB
        '
        Me.TotalKittysLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalKittysLB.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TotalKittysLB.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalKittysLB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TotalKittysLB.Location = New System.Drawing.Point(1309, 62)
        Me.TotalKittysLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalKittysLB.Name = "TotalKittysLB"
        Me.TotalKittysLB.Size = New System.Drawing.Size(93, 48)
        Me.TotalKittysLB.TabIndex = 140
        Me.TotalKittysLB.Text = "#1"
        '
        'DissolveButton
        '
        Me.DissolveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DissolveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DissolveButton.FlatAppearance.BorderSize = 0
        Me.DissolveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.DissolveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DissolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DissolveButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DissolveButton.ForeColor = System.Drawing.Color.Linen
        Me.DissolveButton.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.DissolveButton.IconColor = System.Drawing.Color.White
        Me.DissolveButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DissolveButton.IconSize = 32
        Me.DissolveButton.Location = New System.Drawing.Point(716, 453)
        Me.DissolveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DissolveButton.Name = "DissolveButton"
        Me.DissolveButton.Size = New System.Drawing.Size(266, 56)
        Me.DissolveButton.TabIndex = 9
        Me.DissolveButton.Text = "Dissolve Kitty"
        Me.DissolveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DissolveButton.UseVisualStyleBackColor = False
        Me.DissolveButton.Visible = False
        '
        'Intrestlabel
        '
        Me.Intrestlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Intrestlabel.AutoSize = True
        Me.Intrestlabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Intrestlabel.ForeColor = System.Drawing.Color.Peru
        Me.Intrestlabel.Location = New System.Drawing.Point(1044, 30)
        Me.Intrestlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Intrestlabel.Name = "Intrestlabel"
        Me.Intrestlabel.Size = New System.Drawing.Size(98, 30)
        Me.Intrestlabel.TabIndex = 141
        Me.Intrestlabel.Text = "Intrest"
        '
        'PaymentButton
        '
        Me.PaymentButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PaymentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PaymentButton.FlatAppearance.BorderSize = 0
        Me.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PaymentButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.PaymentButton.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.PaymentButton.IconColor = System.Drawing.Color.White
        Me.PaymentButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PaymentButton.IconSize = 32
        Me.PaymentButton.Location = New System.Drawing.Point(790, 375)
        Me.PaymentButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(232, 58)
        Me.PaymentButton.TabIndex = 7
        Me.PaymentButton.Text = "Add Payment"
        Me.PaymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PaymentButton.UseVisualStyleBackColor = False
        '
        'KittyTypeCB
        '
        Me.KittyTypeCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KittyTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KittyTypeCB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyTypeCB.FormattingEnabled = True
        Me.KittyTypeCB.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KittyTypeCB.Location = New System.Drawing.Point(883, 25)
        Me.KittyTypeCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyTypeCB.Name = "KittyTypeCB"
        Me.KittyTypeCB.Size = New System.Drawing.Size(100, 36)
        Me.KittyTypeCB.TabIndex = 1
        '
        'ResetButton
        '
        Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetButton.FlatAppearance.BorderSize = 0
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ResetButton.IconChar = FontAwesome.Sharp.IconChar.UndoAlt
        Me.ResetButton.IconColor = System.Drawing.Color.White
        Me.ResetButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ResetButton.IconSize = 25
        Me.ResetButton.Location = New System.Drawing.Point(671, 180)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(138, 52)
        Me.ResetButton.TabIndex = 183
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'EntryAmountLabel
        '
        Me.EntryAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryAmountLabel.AutoSize = True
        Me.EntryAmountLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntryAmountLabel.ForeColor = System.Drawing.Color.Peru
        Me.EntryAmountLabel.Location = New System.Drawing.Point(666, 251)
        Me.EntryAmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EntryAmountLabel.Name = "EntryAmountLabel"
        Me.EntryAmountLabel.Size = New System.Drawing.Size(149, 30)
        Me.EntryAmountLabel.TabIndex = 150
        Me.EntryAmountLabel.Text = "Entry Amt."
        '
        'GivenAmountTB
        '
        Me.GivenAmountTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GivenAmountTB.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GivenAmountTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GivenAmountTB.ForeColor = System.Drawing.SystemColors.Menu
        Me.GivenAmountTB.Location = New System.Drawing.Point(1240, 263)
        Me.GivenAmountTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GivenAmountTB.Name = "GivenAmountTB"
        Me.GivenAmountTB.ReadOnly = True
        Me.GivenAmountTB.Size = New System.Drawing.Size(148, 36)
        Me.GivenAmountTB.TabIndex = 181
        Me.GivenAmountTB.Text = "0"
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.Color.Peru
        Me.DateLabel.Location = New System.Drawing.Point(737, 323)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(72, 30)
        Me.DateLabel.TabIndex = 151
        Me.DateLabel.Text = "Date"
        '
        'EntryTB
        '
        Me.EntryTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntryTB.Location = New System.Drawing.Point(833, 251)
        Me.EntryTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EntryTB.Name = "EntryTB"
        Me.EntryTB.Size = New System.Drawing.Size(151, 36)
        Me.EntryTB.TabIndex = 5
        '
        'DatePicker
        '
        Me.DatePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePicker.CalendarFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker.Location = New System.Drawing.Point(833, 319)
        Me.DatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(151, 34)
        Me.DatePicker.TabIndex = 6
        '
        'TotalInstalmentsTB
        '
        Me.TotalInstalmentsTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalInstalmentsTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalInstalmentsTB.Location = New System.Drawing.Point(922, 87)
        Me.TotalInstalmentsTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalInstalmentsTB.Name = "TotalInstalmentsTB"
        Me.TotalInstalmentsTB.Size = New System.Drawing.Size(61, 36)
        Me.TotalInstalmentsTB.TabIndex = 3
        '
        'KittyNoTB
        '
        Me.KittyNoTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KittyNoTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyNoTB.Location = New System.Drawing.Point(1164, 87)
        Me.KittyNoTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyNoTB.Name = "KittyNoTB"
        Me.KittyNoTB.Size = New System.Drawing.Size(100, 36)
        Me.KittyNoTB.TabIndex = 4
        '
        'LeftAmountLabel
        '
        Me.LeftAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeftAmountLabel.AutoSize = True
        Me.LeftAmountLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftAmountLabel.ForeColor = System.Drawing.Color.Peru
        Me.LeftAmountLabel.Location = New System.Drawing.Point(1050, 211)
        Me.LeftAmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LeftAmountLabel.Name = "LeftAmountLabel"
        Me.LeftAmountLabel.Size = New System.Drawing.Size(168, 30)
        Me.LeftAmountLabel.TabIndex = 175
        Me.LeftAmountLabel.Text = "Left Amount"
        '
        'KittyIntrestCB
        '
        Me.KittyIntrestCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KittyIntrestCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KittyIntrestCB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyIntrestCB.FormattingEnabled = True
        Me.KittyIntrestCB.Location = New System.Drawing.Point(1164, 25)
        Me.KittyIntrestCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyIntrestCB.Name = "KittyIntrestCB"
        Me.KittyIntrestCB.Size = New System.Drawing.Size(100, 36)
        Me.KittyIntrestCB.TabIndex = 2
        '
        'GivenAmountLabel
        '
        Me.GivenAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GivenAmountLabel.AutoSize = True
        Me.GivenAmountLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GivenAmountLabel.ForeColor = System.Drawing.Color.Peru
        Me.GivenAmountLabel.Location = New System.Drawing.Point(1040, 265)
        Me.GivenAmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GivenAmountLabel.Name = "GivenAmountLabel"
        Me.GivenAmountLabel.Size = New System.Drawing.Size(192, 30)
        Me.GivenAmountLabel.TabIndex = 174
        Me.GivenAmountLabel.Text = "Given Amount"
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.Backspace
        Me.DeleteButton.IconColor = System.Drawing.Color.White
        Me.DeleteButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DeleteButton.IconSize = 25
        Me.DeleteButton.Location = New System.Drawing.Point(851, 180)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(138, 52)
        Me.DeleteButton.TabIndex = 170
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AvailButton
        '
        Me.AvailButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvailButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AvailButton.FlatAppearance.BorderSize = 0
        Me.AvailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AvailButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.AvailButton.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.AvailButton.IconColor = System.Drawing.Color.White
        Me.AvailButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AvailButton.IconSize = 35
        Me.AvailButton.Location = New System.Drawing.Point(785, 375)
        Me.AvailButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AvailButton.Name = "AvailButton"
        Me.AvailButton.Size = New System.Drawing.Size(198, 58)
        Me.AvailButton.TabIndex = 200
        Me.AvailButton.Text = "UnAvailed"
        Me.AvailButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AvailButton.UseVisualStyleBackColor = False
        Me.AvailButton.Visible = False
        '
        'KittyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1404, 523)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "KittyForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.NotificationButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightArrowButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IntrestCheckBox As CheckBox
    Friend WithEvents MainPanel As Panel
    Private WithEvents CloseButton As FontAwesome.Sharp.IconButton
    Friend WithEvents NotificationButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents StatusLabel As Label
    Protected WithEvents Dgv As DataGridView
    Friend WithEvents Column3 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents BalanceTB As TextBox
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents KittyNoLabel As Label
    Friend WithEvents LeftAmountTB As TextBox
    Friend WithEvents RightArrowButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents KittyTypeLabel As Label
    Friend WithEvents GroupLabel As Label
    Friend WithEvents TotalInstalmentsLabel As Label
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents TotalKittysLB As Label
    Friend WithEvents DissolveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Intrestlabel As Label
    Friend WithEvents PaymentButton As FontAwesome.Sharp.IconButton
    Friend WithEvents KittyTypeCB As ComboBox
    Friend WithEvents ResetButton As FontAwesome.Sharp.IconButton
    Friend WithEvents EntryAmountLabel As Label
    Friend WithEvents GivenAmountTB As TextBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents EntryTB As TextBox
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents TotalInstalmentsTB As TextBox
    Friend WithEvents KittyNoTB As TextBox
    Friend WithEvents LeftAmountLabel As Label
    Friend WithEvents KittyIntrestCB As ComboBox
    Friend WithEvents GivenAmountLabel As Label
    Friend WithEvents DeleteButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AvailButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolTip1 As ToolTip
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionDetails
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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaymentModeCB = New System.Windows.Forms.ComboBox()
        Me.ReferenceNoTB = New System.Windows.Forms.TextBox()
        Me.TransferedToCB = New System.Windows.Forms.ComboBox()
        Me.NotesTB = New System.Windows.Forms.TextBox()
        Me.PaymentModeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReferenceNoLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.DeleteBT = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalAmtTB = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OnlineTransactionsBT = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaymentModeCB
        '
        Me.PaymentModeCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PaymentModeCB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentModeCB.FormattingEnabled = True
        Me.PaymentModeCB.Items.AddRange(New Object() {"Cash", "Bank Transfer", "Others"})
        Me.PaymentModeCB.Location = New System.Drawing.Point(618, 15)
        Me.PaymentModeCB.Name = "PaymentModeCB"
        Me.PaymentModeCB.Size = New System.Drawing.Size(199, 35)
        Me.PaymentModeCB.TabIndex = 0
        '
        'ReferenceNoTB
        '
        Me.ReferenceNoTB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenceNoTB.Location = New System.Drawing.Point(618, 67)
        Me.ReferenceNoTB.Name = "ReferenceNoTB"
        Me.ReferenceNoTB.Size = New System.Drawing.Size(199, 34)
        Me.ReferenceNoTB.TabIndex = 2
        '
        'TransferedToCB
        '
        Me.TransferedToCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TransferedToCB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferedToCB.FormattingEnabled = True
        Me.TransferedToCB.Items.AddRange(New Object() {"Cash", "Bank Transfer", "Others"})
        Me.TransferedToCB.Location = New System.Drawing.Point(218, 117)
        Me.TransferedToCB.Name = "TransferedToCB"
        Me.TransferedToCB.Size = New System.Drawing.Size(199, 35)
        Me.TransferedToCB.TabIndex = 3
        '
        'NotesTB
        '
        Me.NotesTB.Font = New System.Drawing.Font("Century Schoolbook", 10.0!)
        Me.NotesTB.Location = New System.Drawing.Point(437, 117)
        Me.NotesTB.Multiline = True
        Me.NotesTB.Name = "NotesTB"
        Me.NotesTB.Size = New System.Drawing.Size(380, 90)
        Me.NotesTB.TabIndex = 4
        '
        'PaymentModeLabel
        '
        Me.PaymentModeLabel.AutoSize = True
        Me.PaymentModeLabel.BackColor = System.Drawing.Color.Transparent
        Me.PaymentModeLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentModeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PaymentModeLabel.Location = New System.Drawing.Point(432, 18)
        Me.PaymentModeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PaymentModeLabel.Name = "PaymentModeLabel"
        Me.PaymentModeLabel.Size = New System.Drawing.Size(179, 28)
        Me.PaymentModeLabel.TabIndex = 190
        Me.PaymentModeLabel.Text = "Payment Mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(6, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 28)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Transfered To"
        '
        'ReferenceNoLabel
        '
        Me.ReferenceNoLabel.AutoSize = True
        Me.ReferenceNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReferenceNoLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenceNoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ReferenceNoLabel.Location = New System.Drawing.Point(436, 73)
        Me.ReferenceNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ReferenceNoLabel.Name = "ReferenceNoLabel"
        Me.ReferenceNoLabel.Size = New System.Drawing.Size(169, 28)
        Me.ReferenceNoLabel.TabIndex = 192
        Me.ReferenceNoLabel.Text = "Trns. Ref. No."
        '
        'SaveButton
        '
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
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SaveButton.Location = New System.Drawing.Point(9, 161)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(300, 46)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save Transaction"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'DeleteBT
        '
        Me.DeleteBT.BackColor = System.Drawing.Color.Transparent
        Me.DeleteBT.FlatAppearance.BorderSize = 0
        Me.DeleteBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.DeleteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.ForeColor = System.Drawing.Color.Linen
        Me.DeleteBT.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.DeleteBT.IconColor = System.Drawing.Color.White
        Me.DeleteBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DeleteBT.IconSize = 32
        Me.DeleteBT.Location = New System.Drawing.Point(325, 162)
        Me.DeleteBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(45, 45)
        Me.DeleteBT.TabIndex = 245
        Me.DeleteBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBT.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 28)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Transfered Amt."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 28)
        Me.Label4.TabIndex = 249
        Me.Label4.Text = "Transaction Date"
        '
        'DatePicker
        '
        Me.DatePicker.CalendarFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker.Location = New System.Drawing.Point(218, 16)
        Me.DatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(199, 34)
        Me.DatePicker.TabIndex = 252
        '
        'TotalAmtTB
        '
        Me.TotalAmtTB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmtTB.Location = New System.Drawing.Point(218, 67)
        Me.TotalAmtTB.Name = "TotalAmtTB"
        Me.TotalAmtTB.Size = New System.Drawing.Size(199, 34)
        Me.TotalAmtTB.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Mode, Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(6, 222)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle40
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(820, 50)
        Me.DataGridView1.TabIndex = 10030
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridViewTextBoxColumn2.HeaderText = "KittyID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle35.Format = "d"
        DataGridViewCellStyle35.NullValue = Nothing
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle35
        Me.DataGridViewTextBoxColumn3.HeaderText = "KittyNo"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle36.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle36
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'Mode
        '
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black
        Me.Mode.DefaultCellStyle = DataGridViewCellStyle37
        Me.Mode.HeaderText = "Amt. Used"
        Me.Mode.MinimumWidth = 8
        Me.Mode.Name = "Mode"
        Me.Mode.ReadOnly = True
        Me.Mode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mode.Width = 160
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridViewTextBoxColumn5.HeaderText = "Change"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.Width = 116
        '
        'OnlineTransactionsBT
        '
        Me.OnlineTransactionsBT.BackColor = System.Drawing.Color.Transparent
        Me.OnlineTransactionsBT.FlatAppearance.BorderSize = 0
        Me.OnlineTransactionsBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.OnlineTransactionsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OnlineTransactionsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OnlineTransactionsBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnlineTransactionsBT.ForeColor = System.Drawing.Color.Linen
        Me.OnlineTransactionsBT.IconChar = FontAwesome.Sharp.IconChar.University
        Me.OnlineTransactionsBT.IconColor = System.Drawing.Color.White
        Me.OnlineTransactionsBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.OnlineTransactionsBT.IconSize = 38
        Me.OnlineTransactionsBT.Location = New System.Drawing.Point(386, 164)
        Me.OnlineTransactionsBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OnlineTransactionsBT.Name = "OnlineTransactionsBT"
        Me.OnlineTransactionsBT.Size = New System.Drawing.Size(45, 45)
        Me.OnlineTransactionsBT.TabIndex = 10031
        Me.OnlineTransactionsBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OnlineTransactionsBT.UseVisualStyleBackColor = False
        Me.OnlineTransactionsBT.Visible = False
        '
        'TransactionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(825, 257)
        Me.Controls.Add(Me.OnlineTransactionsBT)
        Me.Controls.Add(Me.PaymentModeCB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TotalAmtTB)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ReferenceNoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PaymentModeLabel)
        Me.Controls.Add(Me.NotesTB)
        Me.Controls.Add(Me.TransferedToCB)
        Me.Controls.Add(Me.ReferenceNoTB)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(847, 1000)
        Me.MinimumSize = New System.Drawing.Size(847, 313)
        Me.Name = "TransactionDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PaymentModeCB As ComboBox
    Friend WithEvents ReferenceNoTB As TextBox
    Friend WithEvents TransferedToCB As ComboBox
    Friend WithEvents CancelBT As Button
    Friend WithEvents NotesTB As TextBox
    Friend WithEvents PaymentModeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReferenceNoLabel As Label
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents DeleteBT As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents TotalAmtTB As TextBox
    Protected WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Mode As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewButtonColumn
    Friend WithEvents OnlineTransactionsBT As FontAwesome.Sharp.IconButton
End Class

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
        Me.PaymentModeCB = New System.Windows.Forms.ComboBox()
        Me.ReferenceNoTB = New System.Windows.Forms.TextBox()
        Me.TransferedToCB = New System.Windows.Forms.ComboBox()
        Me.NotesTB = New System.Windows.Forms.TextBox()
        Me.PaymentModeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReferenceNoLabel = New System.Windows.Forms.Label()
        Me.SettledChB = New System.Windows.Forms.CheckBox()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'PaymentModeCB
        '
        Me.PaymentModeCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PaymentModeCB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentModeCB.FormattingEnabled = True
        Me.PaymentModeCB.Items.AddRange(New Object() {"Cash", "Bank Transfer", "Others"})
        Me.PaymentModeCB.Location = New System.Drawing.Point(203, 16)
        Me.PaymentModeCB.Name = "PaymentModeCB"
        Me.PaymentModeCB.Size = New System.Drawing.Size(199, 35)
        Me.PaymentModeCB.TabIndex = 0
        '
        'ReferenceNoTB
        '
        Me.ReferenceNoTB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenceNoTB.Location = New System.Drawing.Point(203, 114)
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
        Me.TransferedToCB.Location = New System.Drawing.Point(203, 65)
        Me.TransferedToCB.Name = "TransferedToCB"
        Me.TransferedToCB.Size = New System.Drawing.Size(199, 35)
        Me.TransferedToCB.TabIndex = 1
        '
        'NotesTB
        '
        Me.NotesTB.Font = New System.Drawing.Font("Century Schoolbook", 10.0!)
        Me.NotesTB.Location = New System.Drawing.Point(432, 15)
        Me.NotesTB.Multiline = True
        Me.NotesTB.Name = "NotesTB"
        Me.NotesTB.Size = New System.Drawing.Size(199, 129)
        Me.NotesTB.TabIndex = 4
        '
        'PaymentModeLabel
        '
        Me.PaymentModeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PaymentModeLabel.AutoSize = True
        Me.PaymentModeLabel.BackColor = System.Drawing.Color.Transparent
        Me.PaymentModeLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentModeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PaymentModeLabel.Location = New System.Drawing.Point(21, 16)
        Me.PaymentModeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PaymentModeLabel.Name = "PaymentModeLabel"
        Me.PaymentModeLabel.Size = New System.Drawing.Size(179, 28)
        Me.PaymentModeLabel.TabIndex = 190
        Me.PaymentModeLabel.Text = "Payment Mode"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(21, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 28)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Transfered To"
        '
        'ReferenceNoLabel
        '
        Me.ReferenceNoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ReferenceNoLabel.AutoSize = True
        Me.ReferenceNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReferenceNoLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenceNoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ReferenceNoLabel.Location = New System.Drawing.Point(21, 114)
        Me.ReferenceNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ReferenceNoLabel.Name = "ReferenceNoLabel"
        Me.ReferenceNoLabel.Size = New System.Drawing.Size(169, 28)
        Me.ReferenceNoLabel.TabIndex = 192
        Me.ReferenceNoLabel.Text = "Trns. Ref. No."
        '
        'SettledChB
        '
        Me.SettledChB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SettledChB.AutoSize = True
        Me.SettledChB.BackColor = System.Drawing.Color.Transparent
        Me.SettledChB.Checked = True
        Me.SettledChB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SettledChB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettledChB.ForeColor = System.Drawing.Color.Green
        Me.SettledChB.Location = New System.Drawing.Point(432, 161)
        Me.SettledChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SettledChB.Name = "SettledChB"
        Me.SettledChB.Size = New System.Drawing.Size(184, 32)
        Me.SettledChB.TabIndex = 5
        Me.SettledChB.TabStop = False
        Me.SettledChB.Text = "Trns. Settled"
        Me.SettledChB.UseVisualStyleBackColor = False
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
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SaveButton.Location = New System.Drawing.Point(110, 161)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(292, 46)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save Transaction"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Linen
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.Location = New System.Drawing.Point(618, 154)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(45, 45)
        Me.IconButton1.TabIndex = 245
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'TransactionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 221)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.SettledChB)
        Me.Controls.Add(Me.ReferenceNoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PaymentModeLabel)
        Me.Controls.Add(Me.NotesTB)
        Me.Controls.Add(Me.TransferedToCB)
        Me.Controls.Add(Me.ReferenceNoTB)
        Me.Controls.Add(Me.PaymentModeCB)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "TransactionDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionDetails"
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
    Friend WithEvents SettledChB As CheckBox
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class

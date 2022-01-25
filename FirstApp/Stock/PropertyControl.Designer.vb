<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PropertyLB = New System.Windows.Forms.Label()
        Me.DefaultValueTB = New System.Windows.Forms.TextBox()
        Me.TrueChB = New System.Windows.Forms.CheckBox()
        Me.FalseChB = New System.Windows.Forms.CheckBox()
        Me.ListValues = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'PropertyLB
        '
        Me.PropertyLB.AutoSize = True
        Me.PropertyLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyLB.ForeColor = System.Drawing.Color.Peru
        Me.PropertyLB.Location = New System.Drawing.Point(17, 10)
        Me.PropertyLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PropertyLB.Name = "PropertyLB"
        Me.PropertyLB.Size = New System.Drawing.Size(0, 30)
        Me.PropertyLB.TabIndex = 253
        '
        'DefaultValueTB
        '
        Me.DefaultValueTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DefaultValueTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultValueTB.Location = New System.Drawing.Point(34, 8)
        Me.DefaultValueTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DefaultValueTB.Name = "DefaultValueTB"
        Me.DefaultValueTB.Size = New System.Drawing.Size(229, 36)
        Me.DefaultValueTB.TabIndex = 291
        Me.DefaultValueTB.Visible = False
        '
        'TrueChB
        '
        Me.TrueChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrueChB.AutoSize = True
        Me.TrueChB.BackColor = System.Drawing.Color.Transparent
        Me.TrueChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrueChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TrueChB.Location = New System.Drawing.Point(57, 8)
        Me.TrueChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TrueChB.Name = "TrueChB"
        Me.TrueChB.Size = New System.Drawing.Size(88, 34)
        Me.TrueChB.TabIndex = 294
        Me.TrueChB.TabStop = False
        Me.TrueChB.Text = "True"
        Me.TrueChB.UseVisualStyleBackColor = False
        Me.TrueChB.Visible = False
        '
        'FalseChB
        '
        Me.FalseChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FalseChB.AutoSize = True
        Me.FalseChB.BackColor = System.Drawing.Color.Transparent
        Me.FalseChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FalseChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FalseChB.Location = New System.Drawing.Point(153, 8)
        Me.FalseChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FalseChB.Name = "FalseChB"
        Me.FalseChB.Size = New System.Drawing.Size(99, 34)
        Me.FalseChB.TabIndex = 293
        Me.FalseChB.TabStop = False
        Me.FalseChB.Text = "False"
        Me.FalseChB.UseVisualStyleBackColor = False
        Me.FalseChB.Visible = False
        '
        'ListValues
        '
        Me.ListValues.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListValues.DropDownHeight = 200
        Me.ListValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListValues.FormattingEnabled = True
        Me.ListValues.IntegralHeight = False
        Me.ListValues.Location = New System.Drawing.Point(34, 10)
        Me.ListValues.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListValues.MaxDropDownItems = 20
        Me.ListValues.Name = "ListValues"
        Me.ListValues.Size = New System.Drawing.Size(229, 34)
        Me.ListValues.TabIndex = 295
        Me.ListValues.Tag = ""
        Me.ListValues.Visible = False
        '
        'PropertyControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Controls.Add(Me.DefaultValueTB)
        Me.Controls.Add(Me.TrueChB)
        Me.Controls.Add(Me.ListValues)
        Me.Controls.Add(Me.PropertyLB)
        Me.Controls.Add(Me.FalseChB)
        Me.Name = "PropertyControl"
        Me.Size = New System.Drawing.Size(277, 57)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PropertyLB As Label
    Friend WithEvents DefaultValueTB As TextBox
    Friend WithEvents TrueChB As CheckBox
    Friend WithEvents FalseChB As CheckBox
    Friend WithEvents ListValues As ComboBox
End Class

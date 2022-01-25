<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsUserControl
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
        Me.ItemNameParam = New System.Windows.Forms.Label()
        Me.DetailsButton = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalPropertiesParam = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'ItemNameParam
        '
        Me.ItemNameParam.AutoSize = True
        Me.ItemNameParam.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameParam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ItemNameParam.Location = New System.Drawing.Point(224, 9)
        Me.ItemNameParam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemNameParam.Name = "ItemNameParam"
        Me.ItemNameParam.Size = New System.Drawing.Size(311, 37)
        Me.ItemNameParam.TabIndex = 152
        Me.ItemNameParam.Text = "Dhananjaysd Agg"
        Me.ItemNameParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DetailsButton
        '
        Me.DetailsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsButton.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.DetailsButton.FlatAppearance.BorderSize = 0
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailsButton.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.ForeColor = System.Drawing.Color.Black
        Me.DetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.DetailsButton.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.DetailsButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DetailsButton.IconSize = 35
        Me.DetailsButton.Location = New System.Drawing.Point(517, 130)
        Me.DetailsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(146, 46)
        Me.DetailsButton.TabIndex = 165
        Me.DetailsButton.Text = "Details"
        Me.DetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DetailsButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 37)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Item Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 37)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Total Properties:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalPropertiesParam
        '
        Me.TotalPropertiesParam.AutoSize = True
        Me.TotalPropertiesParam.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPropertiesParam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TotalPropertiesParam.Location = New System.Drawing.Point(315, 64)
        Me.TotalPropertiesParam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalPropertiesParam.Name = "TotalPropertiesParam"
        Me.TotalPropertiesParam.Size = New System.Drawing.Size(35, 37)
        Me.TotalPropertiesParam.TabIndex = 168
        Me.TotalPropertiesParam.Text = "1"
        Me.TotalPropertiesParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Black
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 35
        Me.IconButton1.Location = New System.Drawing.Point(517, 51)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(146, 69)
        Me.IconButton1.TabIndex = 169
        Me.IconButton1.Text = "Stock Entry"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ItemsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.TotalPropertiesParam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DetailsButton)
        Me.Controls.Add(Me.ItemNameParam)
        Me.Name = "ItemsUserControl"
        Me.Size = New System.Drawing.Size(667, 200)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ItemNameParam As Label
    Public WithEvents DetailsButton As FontAwesome.Sharp.IconButton
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents TotalPropertiesParam As Label
    Public WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class

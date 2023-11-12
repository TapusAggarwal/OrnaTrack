<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KeyValue_Control
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyValue_Control))
        Me.KeyLB = New System.Windows.Forms.Label()
        Me.ValueLB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'KeyLB
        '
        Me.KeyLB.AutoEllipsis = True
        Me.KeyLB.AutoSize = True
        Me.KeyLB.BackColor = System.Drawing.Color.Transparent
        Me.KeyLB.Dock = System.Windows.Forms.DockStyle.Left
        Me.KeyLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyLB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.KeyLB.Location = New System.Drawing.Point(6, 6)
        Me.KeyLB.Margin = New System.Windows.Forms.Padding(3)
        Me.KeyLB.Name = "KeyLB"
        Me.KeyLB.Size = New System.Drawing.Size(63, 32)
        Me.KeyLB.TabIndex = 6
        Me.KeyLB.Text = "Key:"
        Me.KeyLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValueLB
        '
        Me.ValueLB.AutoEllipsis = True
        Me.ValueLB.AutoSize = True
        Me.ValueLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueLB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ValueLB.Location = New System.Drawing.Point(69, 6)
        Me.ValueLB.Margin = New System.Windows.Forms.Padding(0)
        Me.ValueLB.MaximumSize = New System.Drawing.Size(375, 100000)
        Me.ValueLB.Name = "ValueLB"
        Me.ValueLB.Padding = New System.Windows.Forms.Padding(4)
        Me.ValueLB.Size = New System.Drawing.Size(375, 792)
        Me.ValueLB.TabIndex = 9998
        Me.ValueLB.Text = resources.GetString("ValueLB.Text")
        Me.ValueLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'KeyValue_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Controls.Add(Me.ValueLB)
        Me.Controls.Add(Me.KeyLB)
        Me.Name = "KeyValue_Control"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Size = New System.Drawing.Size(450, 804)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KeyLB As Label
    Friend WithEvents ValueLB As Label
End Class

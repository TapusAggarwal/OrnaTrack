<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrayControl
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
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageBox
        '
        Me.ImageBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ImageBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox.Image = Global.FirstApp.My.Resources.Resources.addSign
        Me.ImageBox.Location = New System.Drawing.Point(0, 0)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(250, 250)
        Me.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageBox.TabIndex = 293
        Me.ImageBox.TabStop = False
        '
        'TrayControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Controls.Add(Me.ImageBox)
        Me.Name = "TrayControl"
        Me.Size = New System.Drawing.Size(250, 250)
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageBox As PictureBox
End Class

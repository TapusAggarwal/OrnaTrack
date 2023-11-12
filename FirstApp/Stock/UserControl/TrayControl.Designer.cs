using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TrayControl : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            ImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ImageBox
            // 
            ImageBox.BackColor = Color.FromArgb(36, 30, 60);
            ImageBox.Dock = DockStyle.Fill;
            ImageBox.Image = My.Resources.Resources.addSign;
            ImageBox.Location = new Point(0, 0);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(250, 250);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 293;
            ImageBox.TabStop = false;
            // 
            // TrayControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(36, 30, 80);
            Controls.Add(ImageBox);
            Name = "TrayControl";
            Size = new Size(250, 250);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);

        }

        internal PictureBox ImageBox;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class QrCodeView : Form
    {

        // Form overrides dispose to clean up the component list.
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
            QrBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)QrBox).BeginInit();
            SuspendLayout();
            // 
            // QrBox
            // 
            QrBox.Dock = DockStyle.Fill;
            QrBox.Location = new Point(0, 0);
            QrBox.Name = "QrBox";
            QrBox.Size = new Size(433, 431);
            QrBox.SizeMode = PictureBoxSizeMode.Zoom;
            QrBox.TabIndex = 0;
            QrBox.TabStop = false;
            // 
            // QrCodeView
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(433, 431);
            Controls.Add(QrBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QrCodeView";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scan The QrCode";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)QrBox).EndInit();
            Load += new EventHandler(QrCodeView_Load);
            ResumeLayout(false);

        }

        internal PictureBox QrBox;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PreviewCustomers : Form
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
            FlowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Dock = DockStyle.Fill;
            FlowLayoutPanel1.Location = new Point(0, 0);
            FlowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1674, 956);
            FlowLayoutPanel1.TabIndex = 187;
            // 
            // PreviewCustomers
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 35, 80);
            ClientSize = new Size(1678, 960);
            Controls.Add(FlowLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1700, 1016);
            MinimizeBox = false;
            MinimumSize = new Size(880, 1016);
            Name = "PreviewCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer PreView";
            Load += new EventHandler(PreviewCustomers_Load);
            KeyDown += new KeyEventHandler(PreviewCustomers_KeyDown);
            ResumeLayout(false);

        }
        internal FlowLayoutPanel FlowLayoutPanel1;
    }
}
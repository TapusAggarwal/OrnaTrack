using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PaymentReport : Form
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
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1060, 641);
            FlowLayoutPanel1.TabIndex = 7;
            // 
            // rough
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 641);
            Controls.Add(FlowLayoutPanel1);
            DoubleBuffered = true;
            Name = "rough";
            Text = "rough";
            Load += new EventHandler(rough_Load);
            Closed += new EventHandler(Rough_Closed);
            KeyDown += new KeyEventHandler(PreviewCustomers_KeyDown);
            ResumeLayout(false);

        }
        internal FlowLayoutPanel FlowLayoutPanel1;
    }
}
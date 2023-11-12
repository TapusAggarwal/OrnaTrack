using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TransactionsControl : UserControl
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
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Panel1 = new Panel();
            Panel2 = new Panel();
            FlowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.Controls.Add(Panel2);
            FlowLayoutPanel1.Location = new Point(3, 50);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(544, 197);
            FlowLayoutPanel1.TabIndex = 0;
            // 
            // Panel1
            // 
            Panel1.BackColor = SystemColors.ActiveCaption;
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(544, 41);
            Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            Panel2.BackColor = SystemColors.ActiveCaption;
            Panel2.Location = new Point(3, 3);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(539, 41);
            Panel2.TabIndex = 2;
            // 
            // TransactionsControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel1);
            Controls.Add(FlowLayoutPanel1);
            Name = "TransactionsControl";
            Size = new Size(550, 247);
            FlowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Panel Panel2;
        internal Panel Panel1;
    }
}
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserControl1 : UserControl
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
            Panel1 = new Panel();
            HeaderLB = new Label();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.MediumPurple;
            Panel1.Location = new Point(1, 28);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(255, 4);
            Panel1.TabIndex = 0;
            // 
            // HeaderLB
            // 
            HeaderLB.AutoSize = true;
            HeaderLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLB.ForeColor = Color.MediumPurple;
            HeaderLB.Location = new Point(13, 2);
            HeaderLB.Name = "HeaderLB";
            HeaderLB.Size = new Size(208, 30);
            HeaderLB.TabIndex = 2;
            HeaderLB.Text = "Product Details";
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AllowDrop = true;
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(0, 33);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(258, 180);
            FlowLayoutPanel1.TabIndex = 3;
            // 
            // UserControl1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Panel1);
            Controls.Add(HeaderLB);
            Name = "UserControl1";
            Size = new Size(258, 213);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal Label HeaderLB;
        internal FlowLayoutPanel FlowLayoutPanel1;
    }
}
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class KeyValue_Control : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyValue_Control));
            KeyLB = new Label();
            ValueLB = new Label();
            SuspendLayout();
            // 
            // KeyLB
            // 
            KeyLB.AutoEllipsis = true;
            KeyLB.AutoSize = true;
            KeyLB.BackColor = Color.Transparent;
            KeyLB.Dock = DockStyle.Left;
            KeyLB.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KeyLB.ForeColor = SystemColors.ButtonFace;
            KeyLB.Location = new Point(6, 6);
            KeyLB.Margin = new Padding(3);
            KeyLB.Name = "KeyLB";
            KeyLB.Size = new Size(63, 32);
            KeyLB.TabIndex = 6;
            KeyLB.Text = "Key:";
            KeyLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ValueLB
            // 
            ValueLB.AutoEllipsis = true;
            ValueLB.AutoSize = true;
            ValueLB.Dock = DockStyle.Fill;
            ValueLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValueLB.ForeColor = SystemColors.ActiveCaption;
            ValueLB.Location = new Point(69, 6);
            ValueLB.Margin = new Padding(0);
            ValueLB.MaximumSize = new Size(375, 100000);
            ValueLB.Name = "ValueLB";
            ValueLB.Padding = new Padding(4);
            ValueLB.Size = new Size(375, 792);
            ValueLB.TabIndex = 9998;
            ValueLB.Text = resources.GetString("ValueLB.Text");
            ValueLB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // KeyValue_Control
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(36, 30, 60);
            Controls.Add(ValueLB);
            Controls.Add(KeyLB);
            Name = "KeyValue_Control";
            Padding = new Padding(6);
            Size = new Size(450, 804);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label KeyLB;
        internal Label ValueLB;
    }
}
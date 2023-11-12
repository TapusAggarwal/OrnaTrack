using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class OneDayControl : UserControl
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
            Panel1.DoubleClick += new EventHandler(Panel1_DoubleClick);
            DateLB = new Label();
            NameLB = new Label();
            AmtLB = new Label();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = SystemColors.ActiveCaption;
            Panel1.Controls.Add(DateLB);
            Panel1.Controls.Add(NameLB);
            Panel1.Controls.Add(AmtLB);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(693, 36);
            Panel1.TabIndex = 5;
            // 
            // DateLB
            // 
            DateLB.AutoSize = true;
            DateLB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLB.Location = new Point(295, 5);
            DateLB.Name = "DateLB";
            DateLB.Size = new Size(150, 26);
            DateLB.TabIndex = 2;
            DateLB.Text = "19-Jun, 2003";
            // 
            // NameLB
            // 
            NameLB.AutoSize = true;
            NameLB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLB.Location = new Point(3, 5);
            NameLB.Name = "NameLB";
            NameLB.Size = new Size(165, 26);
            NameLB.TabIndex = 1;
            NameLB.Text = "Rama Sharma";
            // 
            // AmtLB
            // 
            AmtLB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmtLB.AutoSize = true;
            AmtLB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmtLB.Location = new Point(543, 5);
            AmtLB.Name = "AmtLB";
            AmtLB.Size = new Size(147, 26);
            AmtLB.TabIndex = 0;
            AmtLB.Text = "Cash:+5,000";
            // 
            // OneDayControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel1);
            DoubleBuffered = true;
            Name = "OneDayControl";
            Size = new Size(693, 36);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal Label DateLB;
        internal Label NameLB;
        internal Label AmtLB;
    }
}
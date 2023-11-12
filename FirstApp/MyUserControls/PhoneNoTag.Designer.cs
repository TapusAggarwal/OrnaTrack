using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PhoneNoTag : UserControl
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
            InitialTB = new TextBox();
            InitialTB.KeyDown += new KeyEventHandler(TB_KeyDownEvent);
            InitialTB.Leave += new EventHandler(TB_Leave);
            InitialTB.GotFocus += new EventHandler(TB_GotFocus);
            FlowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.BackColor = Color.FromArgb(36, 35, 60);
            FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            FlowLayoutPanel1.Controls.Add(InitialTB);
            FlowLayoutPanel1.Dock = DockStyle.Fill;
            FlowLayoutPanel1.Location = new Point(0, 0);
            FlowLayoutPanel1.Margin = new Padding(2);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Padding = new Padding(2);
            FlowLayoutPanel1.Size = new Size(642, 52);
            FlowLayoutPanel1.TabIndex = 219;
            // 
            // InitialTB
            // 
            InitialTB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            InitialTB.Location = new Point(6, 7);
            InitialTB.Margin = new Padding(4, 5, 4, 5);
            InitialTB.Name = "InitialTB";
            InitialTB.Size = new Size(142, 37);
            InitialTB.TabIndex = 2;
            // 
            // PhoneNoTag
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            Controls.Add(FlowLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PhoneNoTag";
            Size = new Size(642, 52);
            FlowLayoutPanel1.ResumeLayout(false);
            FlowLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal TextBox InitialTB;
    }
}
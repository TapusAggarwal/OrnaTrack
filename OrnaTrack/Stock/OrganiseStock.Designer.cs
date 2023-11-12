using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class OrganiseStock : Form
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
            TrayWidthTB = new TextBox();
            TrayWidthTB.TextChanged += new EventHandler(TextBox1_TextChanged);
            TrayHeightTB = new TextBox();
            TrayHeightTB.TextChanged += new EventHandler(TrayHeightTB_TextChanged);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            SuspendLayout();
            // 
            // TrayWidthTB
            // 
            TrayWidthTB.Font = new Font("Nirmala UI", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrayWidthTB.Location = new Point(40, 24);
            TrayWidthTB.Name = "TrayWidthTB";
            TrayWidthTB.Size = new Size(100, 50);
            TrayWidthTB.TabIndex = 0;
            // 
            // TrayHeightTB
            // 
            TrayHeightTB.Font = new Font("Nirmala UI", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrayHeightTB.Location = new Point(196, 24);
            TrayHeightTB.Name = "TrayHeightTB";
            TrayHeightTB.Size = new Size(100, 50);
            TrayHeightTB.TabIndex = 1;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(12, 89);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1037, 571);
            FlowLayoutPanel1.TabIndex = 2;
            // 
            // Button1
            // 
            Button1.Location = new Point(360, 12);
            Button1.Name = "Button1";
            Button1.Size = new Size(119, 85);
            Button1.TabIndex = 3;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // OrganiseStock
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1061, 672);
            Controls.Add(Button1);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(TrayHeightTB);
            Controls.Add(TrayWidthTB);
            Name = "OrganiseStock";
            Text = "OrganiseStock";
            Load += new EventHandler(OrganiseStock_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TrayWidthTB;
        internal TextBox TrayHeightTB;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Button Button1;
    }
}
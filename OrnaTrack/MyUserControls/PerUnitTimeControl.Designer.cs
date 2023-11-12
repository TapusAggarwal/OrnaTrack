using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PerUnitTimeControl : UserControl
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
            Panel2 = new Panel();
            InfoLB = new Label();
            AmtLB = new Label();
            DateLB = new Label();
            IconButton1 = new FontAwesome.Sharp.IconButton();
            IconButton1.Click += new EventHandler(IconButton1_Click);
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoSize = true;
            FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowLayoutPanel1.BackColor = Color.Transparent;
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(0, 45);
            FlowLayoutPanel1.MaximumSize = new Size(826, 0);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(0, 0);
            FlowLayoutPanel1.TabIndex = 1;
            FlowLayoutPanel1.Visible = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = SystemColors.Highlight;
            Panel2.Controls.Add(InfoLB);
            Panel2.Controls.Add(AmtLB);
            Panel2.Controls.Add(DateLB);
            Panel2.Controls.Add(IconButton1);
            Panel2.Location = new Point(0, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(823, 41);
            Panel2.TabIndex = 3;
            // 
            // InfoLB
            // 
            InfoLB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InfoLB.AutoSize = true;
            InfoLB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoLB.Location = new Point(657, 8);
            InfoLB.Name = "InfoLB";
            InfoLB.Size = new Size(93, 26);
            InfoLB.TabIndex = 5;
            InfoLB.Text = "Kitty:43";
            // 
            // AmtLB
            // 
            AmtLB.AutoSize = true;
            AmtLB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmtLB.Location = new Point(248, 8);
            AmtLB.Name = "AmtLB";
            AmtLB.Size = new Size(177, 26);
            AmtLB.TabIndex = 4;
            AmtLB.Text = "Total:+3,00,000";
            // 
            // DateLB
            // 
            DateLB.AutoSize = true;
            DateLB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLB.Location = new Point(3, 8);
            DateLB.Name = "DateLB";
            DateLB.Size = new Size(116, 26);
            DateLB.TabIndex = 3;
            DateLB.Text = "Jun, 2003";
            // 
            // IconButton1
            // 
            IconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconButton1.AutoSize = true;
            IconButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IconButton1.BackColor = SystemColors.ActiveCaption;
            IconButton1.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            IconButton1.FlatAppearance.BorderSize = 0;
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            IconButton1.IconColor = Color.Black;
            IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton1.IconSize = 30;
            IconButton1.Location = new Point(784, 3);
            IconButton1.Name = "IconButton1";
            IconButton1.Size = new Size(36, 36);
            IconButton1.TabIndex = 0;
            IconButton1.UseVisualStyleBackColor = false;
            // 
            // PerUnitTimeControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(Panel2);
            Controls.Add(FlowLayoutPanel1);
            DoubleBuffered = true;
            Name = "PerUnitTimeControl";
            Size = new Size(826, 48);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Panel Panel2;
        internal FontAwesome.Sharp.IconButton IconButton1;
        internal Label DateLB;
        internal Label AmtLB;
        internal Label InfoLB;
    }
}
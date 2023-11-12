using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ServerUpdateProgressBar : UserControl
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
            StatusLB = new Label();
            StartBT = new FontAwesome.Sharp.IconButton();
            TitleLB = new FontAwesome.Sharp.IconButton();
            TitleLB.TextChanged += new EventHandler(TitleLB_TextChanged);
            SuspendLayout();
            // 
            // StatusLB
            // 
            StatusLB.AutoEllipsis = true;
            StatusLB.BackColor = Color.Transparent;
            StatusLB.Dock = DockStyle.Bottom;
            StatusLB.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLB.ForeColor = Color.IndianRed;
            StatusLB.Location = new Point(0, 60);
            StatusLB.Margin = new Padding(4, 0, 4, 0);
            StatusLB.Name = "StatusLB";
            StatusLB.Size = new Size(107, 21);
            StatusLB.TabIndex = 10007;
            StatusLB.Text = "Waiting For Previous Commands To Fininsh...";
            StatusLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StartBT
            // 
            StartBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StartBT.AutoSize = true;
            StartBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartBT.BackColor = Color.FromArgb(0, 114, 0);
            StartBT.FlatAppearance.BorderSize = 0;
            StartBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            StartBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            StartBT.FlatStyle = FlatStyle.Flat;
            StartBT.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartBT.ForeColor = Color.Linen;
            StartBT.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            StartBT.IconColor = Color.White;
            StartBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StartBT.IconSize = 36;
            StartBT.Location = new Point(66, 4);
            StartBT.Margin = new Padding(4, 5, 4, 5);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(42, 42);
            StartBT.TabIndex = 10008;
            StartBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            StartBT.UseVisualStyleBackColor = false;
            // 
            // TitleLB
            // 
            TitleLB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TitleLB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleLB.BackColor = Color.Transparent;
            TitleLB.FlatAppearance.BorderSize = 0;
            TitleLB.FlatAppearance.MouseDownBackColor = Color.Lime;
            TitleLB.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            TitleLB.FlatStyle = FlatStyle.Flat;
            TitleLB.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLB.ForeColor = Color.DarkGray;
            TitleLB.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            TitleLB.IconColor = Color.DarkGray;
            TitleLB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TitleLB.IconSize = 36;
            TitleLB.ImageAlign = ContentAlignment.MiddleLeft;
            TitleLB.Location = new Point(-1, -1);
            TitleLB.Margin = new Padding(4, 5, 4, 5);
            TitleLB.Name = "TitleLB";
            TitleLB.Size = new Size(54, 55);
            TitleLB.TabIndex = 9997;
            TitleLB.TextAlign = ContentAlignment.MiddleLeft;
            TitleLB.TextImageRelation = TextImageRelation.TextBeforeImage;
            TitleLB.UseVisualStyleBackColor = false;
            // 
            // ServerUpdateProgressBar
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(StartBT);
            Controls.Add(StatusLB);
            Controls.Add(TitleLB);
            DoubleBuffered = true;
            Name = "ServerUpdateProgressBar";
            Size = new Size(107, 81);
            ResumeLayout(false);
            PerformLayout();

        }
        internal FontAwesome.Sharp.IconButton TitleLB;
        internal FontAwesome.Sharp.IconButton StartBT;
        internal Label StatusLB;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AllStock : Form
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
            NextButton = new FontAwesome.Sharp.IconButton();
            NextButton.Click += new EventHandler(NextButton_Click);
            BackButton = new FontAwesome.Sharp.IconButton();
            BackButton.Click += new EventHandler(BackButton_Click);
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Dock = DockStyle.Bottom;
            FlowLayoutPanel1.Location = new Point(0, 58);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1332, 741);
            FlowLayoutPanel1.TabIndex = 0;
            // 
            // NextButton
            // 
            NextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NextButton.AutoSize = true;
            NextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NextButton.BackColor = Color.FromArgb(25, 25, 70);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextButton.ForeColor = Color.MediumPurple;
            NextButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            NextButton.IconColor = Color.MediumPurple;
            NextButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NextButton.IconSize = 40;
            NextButton.Location = new Point(1273, 7);
            NextButton.Margin = new Padding(4, 5, 4, 5);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(46, 46);
            NextButton.TabIndex = 10010;
            NextButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            NextButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackButton.AutoSize = true;
            BackButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackButton.BackColor = Color.FromArgb(25, 25, 70);
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.MediumPurple;
            BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            BackButton.IconColor = Color.MediumPurple;
            BackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackButton.IconSize = 40;
            BackButton.Location = new Point(1221, 7);
            BackButton.Margin = new Padding(4, 5, 4, 5);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(46, 46);
            BackButton.TabIndex = 10011;
            BackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BackButton.UseVisualStyleBackColor = false;
            // 
            // ShowItems
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1332, 799);
            Controls.Add(NextButton);
            Controls.Add(BackButton);
            Controls.Add(FlowLayoutPanel1);
            Name = "ShowItems";
            Text = "ShowItems";
            Load += new EventHandler(ShowItems_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FontAwesome.Sharp.IconButton NextButton;
        internal FontAwesome.Sharp.IconButton BackButton;
    }
}
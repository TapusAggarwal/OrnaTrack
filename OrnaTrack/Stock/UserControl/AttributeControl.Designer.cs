using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AttributeControl : UserControl
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
            AttrIconBT = new FontAwesome.Sharp.IconButton();
            Label1 = new Label();
            UsedButton = new FontAwesome.Sharp.IconButton();
            UsedButton.Click += new EventHandler(UsedButton_Click);
            DefValueLB = new Label();
            SuspendLayout();
            // 
            // AttrIconBT
            // 
            AttrIconBT.AutoSize = true;
            AttrIconBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AttrIconBT.BackColor = Color.FromArgb(25, 25, 70);
            AttrIconBT.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 70);
            AttrIconBT.FlatAppearance.BorderSize = 0;
            AttrIconBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 70);
            AttrIconBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 70);
            AttrIconBT.FlatStyle = FlatStyle.Flat;
            AttrIconBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttrIconBT.ForeColor = Color.MediumPurple;
            AttrIconBT.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            AttrIconBT.IconColor = Color.White;
            AttrIconBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AttrIconBT.IconSize = 45;
            AttrIconBT.Location = new Point(4, 5);
            AttrIconBT.Margin = new Padding(4, 5, 4, 5);
            AttrIconBT.Name = "AttrIconBT";
            AttrIconBT.Size = new Size(51, 51);
            AttrIconBT.TabIndex = 278;
            AttrIconBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AttrIconBT.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.MediumPurple;
            Label1.Location = new Point(3, 64);
            Label1.Name = "Label1";
            Label1.Size = new Size(100, 27);
            Label1.TabIndex = 279;
            Label1.Text = "Def. Val:";
            // 
            // UsedButton
            // 
            UsedButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UsedButton.AutoSize = true;
            UsedButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UsedButton.BackColor = Color.Transparent;
            UsedButton.FlatAppearance.BorderSize = 0;
            UsedButton.FlatAppearance.MouseDownBackColor = Color.Red;
            UsedButton.FlatAppearance.MouseOverBackColor = Color.Snow;
            UsedButton.FlatStyle = FlatStyle.Flat;
            UsedButton.IconChar = FontAwesome.Sharp.IconChar.HandPointer;
            UsedButton.IconColor = Color.Goldenrod;
            UsedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UsedButton.IconSize = 45;
            UsedButton.ImageAlign = ContentAlignment.TopCenter;
            UsedButton.Location = new Point(45, 6);
            UsedButton.Margin = new Padding(4, 5, 4, 5);
            UsedButton.Name = "UsedButton";
            UsedButton.Size = new Size(51, 51);
            UsedButton.TabIndex = 280;
            UsedButton.UseVisualStyleBackColor = false;
            // 
            // DefValueLB
            // 
            DefValueLB.AutoSize = true;
            DefValueLB.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DefValueLB.ForeColor = Color.AliceBlue;
            DefValueLB.Location = new Point(96, 64);
            DefValueLB.Name = "DefValueLB";
            DefValueLB.Size = new Size(0, 28);
            DefValueLB.TabIndex = 281;
            // 
            // AttributeControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 70);
            Controls.Add(DefValueLB);
            Controls.Add(UsedButton);
            Controls.Add(Label1);
            Controls.Add(AttrIconBT);
            Name = "AttributeControl";
            Size = new Size(101, 103);
            ResumeLayout(false);
            PerformLayout();

        }

        internal FontAwesome.Sharp.IconButton AttrIconBT;
        internal Label DefValueLB;
        internal Label Label1;
        internal FontAwesome.Sharp.IconButton UsedButton;
    }
}
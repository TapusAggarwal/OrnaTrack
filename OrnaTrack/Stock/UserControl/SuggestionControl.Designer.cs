using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SuggestionControl : UserControl
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
            Label1 = new Label();
            Panel1 = new Panel();
            SelectBT = new FontAwesome.Sharp.IconButton();
            DefValueLB = new Label();
            Label2 = new Label();
            AttrIconBT = new FontAwesome.Sharp.IconButton();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.Dock = DockStyle.Left;
            Label1.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.MediumPurple;
            Label1.Location = new Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(119, 93);
            Label1.TabIndex = 280;
            Label1.Text = "Column 4:";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            Panel1.AutoSize = true;
            Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel1.Controls.Add(SelectBT);
            Panel1.Controls.Add(DefValueLB);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(AttrIconBT);
            Panel1.Location = new Point(132, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(107, 90);
            Panel1.TabIndex = 9999;
            // 
            // SelectBT
            // 
            SelectBT.AutoSize = true;
            SelectBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectBT.BackColor = Color.Transparent;
            SelectBT.FlatAppearance.BorderSize = 0;
            SelectBT.FlatAppearance.MouseDownBackColor = Color.Red;
            SelectBT.FlatAppearance.MouseOverBackColor = Color.Snow;
            SelectBT.FlatStyle = FlatStyle.Flat;
            SelectBT.IconChar = FontAwesome.Sharp.IconChar.HandPointer;
            SelectBT.IconColor = Color.Goldenrod;
            SelectBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SelectBT.IconSize = 45;
            SelectBT.ImageAlign = ContentAlignment.TopCenter;
            SelectBT.Location = new Point(0, 5);
            SelectBT.Margin = new Padding(4, 5, 4, 5);
            SelectBT.Name = "SelectBT";
            SelectBT.Size = new Size(51, 51);
            SelectBT.TabIndex = 10000;
            SelectBT.UseVisualStyleBackColor = false;
            // 
            // DefValueLB
            // 
            DefValueLB.AutoSize = true;
            DefValueLB.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DefValueLB.ForeColor = Color.AliceBlue;
            DefValueLB.Location = new Point(96, 62);
            DefValueLB.Name = "DefValueLB";
            DefValueLB.Size = new Size(0, 28);
            DefValueLB.TabIndex = 285;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.MediumPurple;
            Label2.Location = new Point(3, 62);
            Label2.Name = "Label2";
            Label2.Size = new Size(100, 27);
            Label2.TabIndex = 283;
            Label2.Text = "Def. Val:";
            Label2.Visible = false;
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
            AttrIconBT.Location = new Point(52, 5);
            AttrIconBT.Margin = new Padding(4, 5, 4, 5);
            AttrIconBT.Name = "AttrIconBT";
            AttrIconBT.Size = new Size(51, 51);
            AttrIconBT.TabIndex = 282;
            AttrIconBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AttrIconBT.UseVisualStyleBackColor = false;
            AttrIconBT.Visible = false;
            // 
            // SuggestionControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(36, 30, 60);
            Controls.Add(Panel1);
            Controls.Add(Label1);
            Name = "SuggestionControl";
            Size = new Size(242, 93);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Panel Panel1;
        internal Label DefValueLB;
        internal Label Label2;
        internal FontAwesome.Sharp.IconButton AttrIconBT;
        internal FontAwesome.Sharp.IconButton SelectBT;
    }
}
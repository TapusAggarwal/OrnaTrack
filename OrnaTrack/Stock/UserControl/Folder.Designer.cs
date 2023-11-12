using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Folder : UserControl
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
            BackPanel = new Panel();
            Label5 = new Label();
            Panel4 = new Panel();
            Panel3 = new Panel();
            TopPanel = new Panel();
            Btn = new FontAwesome.Sharp.IconButton();
            BackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackPanel
            // 
            BackPanel.BackColor = SystemColors.ActiveCaptionText;
            BackPanel.Controls.Add(Label5);
            BackPanel.Controls.Add(Panel4);
            BackPanel.Controls.Add(Panel3);
            BackPanel.Controls.Add(TopPanel);
            BackPanel.Controls.Add(Btn);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Name = "BackPanel";
            BackPanel.Size = new Size(258, 208);
            BackPanel.TabIndex = 289;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.Peru;
            Label5.Location = new Point(62, 166);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(132, 25);
            Label5.TabIndex = 292;
            Label5.Text = "Item-Name:";
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.White;
            Panel4.Location = new Point(14, 42);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(92, 8);
            Panel4.TabIndex = 291;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.Black;
            Panel3.Location = new Point(91, 28);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(164, 4);
            Panel3.TabIndex = 290;
            // 
            // TopPanel
            // 
            TopPanel.Location = new Point(88, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(172, 26);
            TopPanel.TabIndex = 289;
            // 
            // Btn
            // 
            Btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn.BackColor = Color.FromArgb(25, 25, 70);
            Btn.Dock = DockStyle.Top;
            Btn.FlatAppearance.BorderSize = 0;
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn.ForeColor = Color.MediumPurple;
            Btn.IconChar = FontAwesome.Sharp.IconChar.SignLanguage;
            Btn.IconColor = Color.White;
            Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn.IconSize = 60;
            Btn.Location = new Point(0, 0);
            Btn.Margin = new Padding(4, 5, 4, 5);
            Btn.Name = "Btn";
            Btn.Size = new Size(258, 151);
            Btn.TabIndex = 278;
            Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn.UseVisualStyleBackColor = false;
            // 
            // Folder
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(BackPanel);
            Name = "Folder";
            Size = new Size(258, 208);
            BackPanel.ResumeLayout(false);
            BackPanel.PerformLayout();
            ResumeLayout(false);

        }

        internal Panel BackPanel;
        internal Label Label5;
        internal Panel Panel4;
        internal Panel Panel3;
        internal Panel TopPanel;
        internal FontAwesome.Sharp.IconButton Btn;
    }
}
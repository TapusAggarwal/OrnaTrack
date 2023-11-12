using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Main : Form
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
            KittyMode1 = new CheckBox();
            KittyMode1.CheckedChanged += new EventHandler(KittyMode1_CheckedChanged);
            KittyNoTB = new TextBox();
            KittyNoTB.TextChanged += new EventHandler(SearchTextBoxes_TextChanged);
            KittyNoTB.KeyDown += new KeyEventHandler(TextBox1_KeyDown);
            KittyNoTB.TextChanged += new EventHandler(KittyNoTB_TextChanged);
            Label4 = new Label();
            PhNoTB = new TextBox();
            PhNoTB.TextChanged += new EventHandler(SearchTextBoxes_TextChanged);
            PhNoTB.KeyDown += new KeyEventHandler(TextBox1_KeyDown);
            PhNoTB.TextChanged += new EventHandler(KittyNoTB_TextChanged);
            Label2 = new Label();
            NameTB = new TextBox();
            NameTB.TextChanged += new EventHandler(SearchTextBoxes_TextChanged);
            NameTB.KeyDown += new KeyEventHandler(TextBox1_KeyDown);
            Label9 = new Label();
            Panel2 = new Panel();
            FindCoustmerButton = new FontAwesome.Sharp.IconButton();
            FindCoustmerButton.Click += new EventHandler(FindCoustmerButton_Click);
            PanelTitleBar = new Panel();
            IconSleep = new FontAwesome.Sharp.IconPictureBox();
            Panel2.SuspendLayout();
            PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconSleep).BeginInit();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(13, 347);
            FlowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1773, 617);
            FlowLayoutPanel1.TabIndex = 187;
            // 
            // KittyMode1
            // 
            KittyMode1.AutoSize = true;
            KittyMode1.Checked = true;
            KittyMode1.CheckState = CheckState.Checked;
            KittyMode1.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            KittyMode1.ForeColor = Color.Orange;
            KittyMode1.Location = new Point(231, 21);
            KittyMode1.Margin = new Padding(4, 5, 4, 5);
            KittyMode1.Name = "KittyMode1";
            KittyMode1.Size = new Size(133, 27);
            KittyMode1.TabIndex = 9990;
            KittyMode1.Text = "KittyMode";
            KittyMode1.UseVisualStyleBackColor = true;
            // 
            // KittyNoTB
            // 
            KittyNoTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyNoTB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyNoTB.Location = new Point(120, 13);
            KittyNoTB.Margin = new Padding(4, 5, 4, 5);
            KittyNoTB.Name = "KittyNoTB";
            KittyNoTB.Size = new Size(90, 34);
            KittyNoTB.TabIndex = 9991;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.Orange;
            Label4.Location = new Point(13, 18);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(99, 27);
            Label4.TabIndex = 142;
            Label4.Text = "Kitty No";
            // 
            // PhNoTB
            // 
            PhNoTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PhNoTB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhNoTB.Location = new Point(120, 78);
            PhNoTB.Margin = new Padding(4, 5, 4, 5);
            PhNoTB.Name = "PhNoTB";
            PhNoTB.Size = new Size(211, 34);
            PhNoTB.TabIndex = 9992;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.Orange;
            Label2.Location = new Point(13, 81);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(72, 27);
            Label2.TabIndex = 132;
            Label2.Text = "PhNo";
            // 
            // NameTB
            // 
            NameTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NameTB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameTB.Location = new Point(120, 138);
            NameTB.Margin = new Padding(4, 5, 4, 5);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(210, 34);
            NameTB.TabIndex = 9993;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.Orange;
            Label9.Location = new Point(13, 143);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(82, 27);
            Label9.TabIndex = 130;
            Label9.Text = "Name";
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(32, 32, 67);
            Panel2.Controls.Add(KittyMode1);
            Panel2.Controls.Add(KittyNoTB);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(FindCoustmerButton);
            Panel2.Controls.Add(PhNoTB);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(NameTB);
            Panel2.Controls.Add(Label9);
            Panel2.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Panel2.ForeColor = Color.DarkOrange;
            Panel2.Location = new Point(1, 68);
            Panel2.Margin = new Padding(4, 5, 4, 5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(368, 269);
            Panel2.TabIndex = 185;
            // 
            // FindCoustmerButton
            // 
            FindCoustmerButton.BackColor = Color.FromArgb(25, 25, 70);
            FindCoustmerButton.Dock = DockStyle.Bottom;
            FindCoustmerButton.FlatAppearance.BorderSize = 0;
            FindCoustmerButton.FlatStyle = FlatStyle.Flat;
            FindCoustmerButton.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindCoustmerButton.ForeColor = Color.MediumPurple;
            FindCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            FindCoustmerButton.IconColor = Color.Purple;
            FindCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FindCoustmerButton.IconSize = 50;
            FindCoustmerButton.Location = new Point(0, 189);
            FindCoustmerButton.Margin = new Padding(0);
            FindCoustmerButton.Name = "FindCoustmerButton";
            FindCoustmerButton.Size = new Size(368, 80);
            FindCoustmerButton.TabIndex = 3;
            FindCoustmerButton.Text = "Find Coustmer";
            FindCoustmerButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            FindCoustmerButton.UseVisualStyleBackColor = false;
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.FromArgb(24, 24, 60);
            PanelTitleBar.Controls.Add(IconSleep);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(0, 0);
            PanelTitleBar.Margin = new Padding(4, 5, 4, 5);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(1820, 63);
            PanelTitleBar.TabIndex = 188;
            PanelTitleBar.Visible = false;
            // 
            // IconSleep
            // 
            IconSleep.BackColor = Color.FromArgb(24, 24, 60);
            IconSleep.BackgroundImageLayout = ImageLayout.Stretch;
            IconSleep.ForeColor = SystemColors.ControlText;
            IconSleep.IconChar = FontAwesome.Sharp.IconChar.Bed;
            IconSleep.IconColor = SystemColors.ControlText;
            IconSleep.IconFont = FontAwesome.Sharp.IconFont.Solid;
            IconSleep.IconSize = 60;
            IconSleep.Location = new Point(1822, 8);
            IconSleep.Margin = new Padding(4, 5, 4, 5);
            IconSleep.Name = "IconSleep";
            IconSleep.Size = new Size(78, 60);
            IconSleep.TabIndex = 0;
            IconSleep.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 35, 80);
            ClientSize = new Size(1820, 922);
            Controls.Add(PanelTitleBar);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Form15";
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            PanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconSleep).EndInit();
            Load += new EventHandler(Main_Load);
            ResumeLayout(false);

        }
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal CheckBox KittyMode1;
        internal TextBox KittyNoTB;
        internal Label Label4;
        internal FontAwesome.Sharp.IconButton FindCoustmerButton;
        internal TextBox PhNoTB;
        internal Label Label2;
        internal TextBox NameTB;
        internal Label Label9;
        internal Panel Panel2;
        internal Panel PanelTitleBar;
        internal FontAwesome.Sharp.IconPictureBox IconSleep;
    }
}
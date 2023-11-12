using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class HUID_Checker : Form
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
            SearchTB = new TextBox();
            SearchTB.TextChanged += new EventHandler(SearchTB_TextChanged);
            SearchTB.KeyDown += new KeyEventHandler(SearchTB_KeyDown);
            FindCoustmerButton = new FontAwesome.Sharp.IconButton();
            FindCoustmerButton.Click += new EventHandler(FindCoustmerButton_Click);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            SelectBT = new FontAwesome.Sharp.IconButton();
            SelectBT.Click += new EventHandler(IconButton1_Click);
            ListBox1 = new ListBox();
            ListBox1.SelectedValueChanged += new EventHandler(ListBox1_SelectedValueChanged);
            SuspendLayout();
            // 
            // SearchTB
            // 
            SearchTB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SearchTB.Font = new Font("Segoe UI", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTB.Location = new Point(138, 27);
            SearchTB.Margin = new Padding(4, 5, 4, 5);
            SearchTB.Name = "SearchTB";
            SearchTB.Size = new Size(248, 45);
            SearchTB.TabIndex = 9994;
            // 
            // FindCoustmerButton
            // 
            FindCoustmerButton.AutoSize = true;
            FindCoustmerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FindCoustmerButton.BackColor = Color.Transparent;
            FindCoustmerButton.FlatAppearance.BorderSize = 0;
            FindCoustmerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 30, 90);
            FindCoustmerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 30, 75);
            FindCoustmerButton.FlatStyle = FlatStyle.Flat;
            FindCoustmerButton.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindCoustmerButton.ForeColor = Color.MediumPurple;
            FindCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            FindCoustmerButton.IconColor = Color.DarkMagenta;
            FindCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FindCoustmerButton.IconSize = 50;
            FindCoustmerButton.Location = new Point(404, 27);
            FindCoustmerButton.Margin = new Padding(0);
            FindCoustmerButton.Name = "FindCoustmerButton";
            FindCoustmerButton.Size = new Size(56, 56);
            FindCoustmerButton.TabIndex = 9995;
            FindCoustmerButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            FindCoustmerButton.UseVisualStyleBackColor = false;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Dock = DockStyle.Bottom;
            FlowLayoutPanel1.Location = new Point(0, 102);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(610, 505);
            FlowLayoutPanel1.TabIndex = 9996;
            // 
            // SelectBT
            // 
            SelectBT.AutoSize = true;
            SelectBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectBT.BackColor = Color.Transparent;
            SelectBT.FlatAppearance.BorderSize = 0;
            SelectBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 30, 90);
            SelectBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 30, 75);
            SelectBT.FlatStyle = FlatStyle.Flat;
            SelectBT.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectBT.ForeColor = Color.MediumPurple;
            SelectBT.IconChar = FontAwesome.Sharp.IconChar.HandPointer;
            SelectBT.IconColor = Color.Goldenrod;
            SelectBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SelectBT.IconSize = 50;
            SelectBT.Location = new Point(472, 27);
            SelectBT.Margin = new Padding(0);
            SelectBT.Name = "SelectBT";
            SelectBT.Size = new Size(56, 56);
            SelectBT.TabIndex = 9997;
            SelectBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            SelectBT.UseVisualStyleBackColor = false;
            SelectBT.Visible = false;
            // 
            // ListBox1
            // 
            ListBox1.Font = new Font("Segoe UI", 14.0f);
            ListBox1.FormattingEnabled = true;
            ListBox1.IntegralHeight = false;
            ListBox1.ItemHeight = 38;
            ListBox1.Location = new Point(138, 69);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(248, 42);
            ListBox1.TabIndex = 9999;
            ListBox1.Visible = false;
            // 
            // HUID_Checker
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(610, 607);
            Controls.Add(ListBox1);
            Controls.Add(SelectBT);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(FindCoustmerButton);
            Controls.Add(SearchTB);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HUID_Checker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HUID_Checker";
            Load += new EventHandler(HUID_Checker_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox SearchTB;
        internal FontAwesome.Sharp.IconButton FindCoustmerButton;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FontAwesome.Sharp.IconButton SelectBT;
        internal ListBox ListBox1;
    }
}
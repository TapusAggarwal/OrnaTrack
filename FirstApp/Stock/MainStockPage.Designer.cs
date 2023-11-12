using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MainStockPage : Form
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
            TreeView1 = new TreeView();
            TreeView1.AfterSelect += new TreeViewEventHandler(TreeView1_AfterSelect);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            FlowLayoutPanel1.Paint += new PaintEventHandler(FlowLayoutPanel1_Paint);
            Label1 = new Label();
            EditBT = new FontAwesome.Sharp.IconButton();
            EditBT.Click += new EventHandler(EditBT_Click);
            StockEntryBT = new FontAwesome.Sharp.IconButton();
            StockEntryBT.Click += new EventHandler(StockEntryBT_Click);
            SaveBT = new FontAwesome.Sharp.IconButton();
            SaveBT.Click += new EventHandler(SaveBT_Click);
            AddBT = new FontAwesome.Sharp.IconButton();
            AddBT.Click += new EventHandler(AddBT_Click);
            IconButton1 = new FontAwesome.Sharp.IconButton();
            IconButton1.Click += new EventHandler(IconButton1_Click);
            IconButton2 = new FontAwesome.Sharp.IconButton();
            IconButton2.Click += new EventHandler(IconButton2_Click);
            IconButton3 = new FontAwesome.Sharp.IconButton();
            IconButton3.Click += new EventHandler(IconButton3_Click);
            FlowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TreeView1
            // 
            TreeView1.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TreeView1.Location = new Point(3, 3);
            TreeView1.Name = "TreeView1";
            TreeView1.Size = new Size(428, 395);
            TreeView1.TabIndex = 0;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Controls.Add(TreeView1);
            FlowLayoutPanel1.Dock = DockStyle.Right;
            FlowLayoutPanel1.Location = new Point(720, 0);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(473, 786);
            FlowLayoutPanel1.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(107, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 20);
            Label1.TabIndex = 3;
            Label1.Text = "Label1";
            // 
            // EditBT
            // 
            EditBT.IconChar = FontAwesome.Sharp.IconChar.None;
            EditBT.IconColor = Color.Black;
            EditBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditBT.Location = new Point(588, 55);
            EditBT.Name = "EditBT";
            EditBT.Size = new Size(101, 39);
            EditBT.TabIndex = 6;
            EditBT.Text = "Edit Node";
            EditBT.UseVisualStyleBackColor = true;
            // 
            // StockEntryBT
            // 
            StockEntryBT.IconChar = FontAwesome.Sharp.IconChar.None;
            StockEntryBT.IconColor = Color.Black;
            StockEntryBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StockEntryBT.Location = new Point(588, 334);
            StockEntryBT.Name = "StockEntryBT";
            StockEntryBT.Size = new Size(101, 39);
            StockEntryBT.TabIndex = 5;
            StockEntryBT.Text = "Stock Entry";
            StockEntryBT.UseVisualStyleBackColor = true;
            // 
            // SaveBT
            // 
            SaveBT.IconChar = FontAwesome.Sharp.IconChar.None;
            SaveBT.IconColor = Color.Black;
            SaveBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveBT.Location = new Point(588, 102);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(101, 39);
            SaveBT.TabIndex = 4;
            SaveBT.Text = "Save";
            SaveBT.UseVisualStyleBackColor = true;
            // 
            // AddBT
            // 
            AddBT.IconChar = FontAwesome.Sharp.IconChar.None;
            AddBT.IconColor = Color.Black;
            AddBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBT.Location = new Point(588, 10);
            AddBT.Name = "AddBT";
            AddBT.Size = new Size(101, 39);
            AddBT.TabIndex = 2;
            AddBT.Text = "Add Node";
            AddBT.UseVisualStyleBackColor = true;
            // 
            // IconButton1
            // 
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            IconButton1.IconColor = Color.Black;
            IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton1.Location = new Point(588, 391);
            IconButton1.Name = "IconButton1";
            IconButton1.Size = new Size(101, 39);
            IconButton1.TabIndex = 7;
            IconButton1.Text = "Show Entry";
            IconButton1.UseVisualStyleBackColor = true;
            // 
            // IconButton2
            // 
            IconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            IconButton2.IconColor = Color.Black;
            IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton2.Location = new Point(588, 278);
            IconButton2.Name = "IconButton2";
            IconButton2.Size = new Size(101, 39);
            IconButton2.TabIndex = 8;
            IconButton2.Text = "Bulk Entry";
            IconButton2.UseVisualStyleBackColor = true;
            // 
            // IconButton3
            // 
            IconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            IconButton3.IconColor = Color.Black;
            IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton3.Location = new Point(292, 10);
            IconButton3.Name = "IconButton3";
            IconButton3.Size = new Size(172, 39);
            IconButton3.TabIndex = 9;
            IconButton3.Text = "Add Purchase Bill";
            IconButton3.UseVisualStyleBackColor = true;
            // 
            // MainStockPage
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1193, 786);
            Controls.Add(IconButton3);
            Controls.Add(IconButton2);
            Controls.Add(IconButton1);
            Controls.Add(EditBT);
            Controls.Add(StockEntryBT);
            Controls.Add(SaveBT);
            Controls.Add(Label1);
            Controls.Add(AddBT);
            Controls.Add(FlowLayoutPanel1);
            Name = "MainStockPage";
            Text = "CategoriesPage";
            FlowLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(CategoriesPage_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TreeView TreeView1;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FontAwesome.Sharp.IconButton AddBT;
        internal Label Label1;
        internal FontAwesome.Sharp.IconButton SaveBT;
        internal FontAwesome.Sharp.IconButton StockEntryBT;
        internal FontAwesome.Sharp.IconButton EditBT;
        internal FontAwesome.Sharp.IconButton IconButton1;
        internal FontAwesome.Sharp.IconButton IconButton2;
        internal FontAwesome.Sharp.IconButton IconButton3;
    }
}
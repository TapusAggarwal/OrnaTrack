using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class StockEntry : Form
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
            components = new System.ComponentModel.Container();
            ContextMenuStrip1 = new ContextMenuStrip(components);
            ChangeListenerPhNoToolStripMenuItem = new ToolStripMenuItem();
            ListenOnceToolStripMenuItem = new ToolStripMenuItem();
            Panel1 = new Panel();
            SaleFP = new UserControl1();
            ProductFP = new UserControl1();
            PurchaseFP = new UserControl1();
            Panel2 = new Panel();
            ReloadImgBT = new FontAwesome.Sharp.IconButton();
            ReloadImgBT.Click += new EventHandler(ReloadImgBT_Click);
            NextImgButton = new FontAwesome.Sharp.IconButton();
            BackImgButton = new FontAwesome.Sharp.IconButton();
            SaveBT = new FontAwesome.Sharp.IconButton();
            SaveBT.Click += new EventHandler(SaveBT_Click_1);
            ListeningStatusPanel = new Panel();
            ImageBox = new PictureBox();
            ContextMenuStrip1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            ListeningStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { ChangeListenerPhNoToolStripMenuItem, ListenOnceToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(259, 68);
            // 
            // ChangeListenerPhNoToolStripMenuItem
            // 
            ChangeListenerPhNoToolStripMenuItem.Name = "ChangeListenerPhNoToolStripMenuItem";
            ChangeListenerPhNoToolStripMenuItem.Size = new Size(258, 32);
            ChangeListenerPhNoToolStripMenuItem.Text = "Change Listener PhNo";
            // 
            // ListenOnceToolStripMenuItem
            // 
            ListenOnceToolStripMenuItem.Name = "ListenOnceToolStripMenuItem";
            ListenOnceToolStripMenuItem.Size = new Size(258, 32);
            ListenOnceToolStripMenuItem.Text = "Listen Once";
            // 
            // Panel1
            // 
            Panel1.AutoScroll = true;
            Panel1.AutoSize = true;
            Panel1.Controls.Add(SaleFP);
            Panel1.Controls.Add(ProductFP);
            Panel1.Controls.Add(PurchaseFP);
            Panel1.Dock = DockStyle.Right;
            Panel1.Location = new Point(259, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1665, 726);
            Panel1.TabIndex = 320;
            // 
            // SaleFP
            // 
            SaleFP.AllowDrop = true;
            SaleFP.BackColor = Color.FromArgb(36, 30, 60);
            SaleFP.BorderStyle = BorderStyle.Fixed3D;
            SaleFP.Dock = DockStyle.Left;
            SaleFP.Location = new Point(1110, 0);
            SaleFP.Name = "SaleFP";
            SaleFP.Size = new Size(555, 726);
            SaleFP.TabIndex = 306;
            SaleFP.Title = "Sale Attr.";
            // 
            // ProductFP
            // 
            ProductFP.AllowDrop = true;
            ProductFP.BackColor = Color.FromArgb(36, 30, 60);
            ProductFP.BorderStyle = BorderStyle.Fixed3D;
            ProductFP.Dock = DockStyle.Left;
            ProductFP.Location = new Point(555, 0);
            ProductFP.Name = "ProductFP";
            ProductFP.Size = new Size(555, 726);
            ProductFP.TabIndex = 305;
            ProductFP.Title = "Product Attr.";
            // 
            // PurchaseFP
            // 
            PurchaseFP.AllowDrop = true;
            PurchaseFP.BackColor = Color.FromArgb(36, 30, 60);
            PurchaseFP.BorderStyle = BorderStyle.Fixed3D;
            PurchaseFP.Dock = DockStyle.Left;
            PurchaseFP.Location = new Point(0, 0);
            PurchaseFP.Name = "PurchaseFP";
            PurchaseFP.Size = new Size(555, 726);
            PurchaseFP.TabIndex = 304;
            PurchaseFP.Title = "Puchase Attr.";
            // 
            // Panel2
            // 
            Panel2.Controls.Add(ReloadImgBT);
            Panel2.Controls.Add(NextImgButton);
            Panel2.Controls.Add(BackImgButton);
            Panel2.Controls.Add(SaveBT);
            Panel2.Controls.Add(ListeningStatusPanel);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(259, 726);
            Panel2.TabIndex = 322;
            // 
            // ReloadImgBT
            // 
            ReloadImgBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ReloadImgBT.AutoSize = true;
            ReloadImgBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ReloadImgBT.BackColor = Color.FromArgb(25, 25, 70);
            ReloadImgBT.FlatAppearance.BorderSize = 0;
            ReloadImgBT.FlatStyle = FlatStyle.Flat;
            ReloadImgBT.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReloadImgBT.ForeColor = Color.MediumPurple;
            ReloadImgBT.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            ReloadImgBT.IconColor = Color.MediumPurple;
            ReloadImgBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReloadImgBT.IconSize = 40;
            ReloadImgBT.Location = new Point(176, 439);
            ReloadImgBT.Margin = new Padding(4, 5, 4, 5);
            ReloadImgBT.Name = "ReloadImgBT";
            ReloadImgBT.Size = new Size(46, 46);
            ReloadImgBT.TabIndex = 10012;
            ReloadImgBT.Tag = "-1";
            ReloadImgBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            ReloadImgBT.UseVisualStyleBackColor = false;
            // 
            // NextImgButton
            // 
            NextImgButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NextImgButton.AutoSize = true;
            NextImgButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NextImgButton.BackColor = Color.FromArgb(25, 25, 70);
            NextImgButton.FlatAppearance.BorderSize = 0;
            NextImgButton.FlatStyle = FlatStyle.Flat;
            NextImgButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextImgButton.ForeColor = Color.MediumPurple;
            NextImgButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            NextImgButton.IconColor = Color.MediumPurple;
            NextImgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NextImgButton.IconSize = 40;
            NextImgButton.Location = new Point(97, 439);
            NextImgButton.Margin = new Padding(4, 5, 4, 5);
            NextImgButton.Name = "NextImgButton";
            NextImgButton.Size = new Size(46, 46);
            NextImgButton.TabIndex = 10010;
            NextImgButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            NextImgButton.UseVisualStyleBackColor = false;
            NextImgButton.Visible = false;
            // 
            // BackImgButton
            // 
            BackImgButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackImgButton.AutoSize = true;
            BackImgButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackImgButton.BackColor = Color.FromArgb(25, 25, 70);
            BackImgButton.FlatAppearance.BorderSize = 0;
            BackImgButton.FlatStyle = FlatStyle.Flat;
            BackImgButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackImgButton.ForeColor = Color.MediumPurple;
            BackImgButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            BackImgButton.IconColor = Color.MediumPurple;
            BackImgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackImgButton.IconSize = 40;
            BackImgButton.Location = new Point(35, 439);
            BackImgButton.Margin = new Padding(4, 5, 4, 5);
            BackImgButton.Name = "BackImgButton";
            BackImgButton.Size = new Size(46, 46);
            BackImgButton.TabIndex = 10011;
            BackImgButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BackImgButton.UseVisualStyleBackColor = false;
            BackImgButton.Visible = false;
            // 
            // SaveBT
            // 
            SaveBT.AutoSize = true;
            SaveBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveBT.BackColor = Color.FromArgb(25, 25, 70);
            SaveBT.Dock = DockStyle.Bottom;
            SaveBT.FlatAppearance.BorderSize = 0;
            SaveBT.FlatStyle = FlatStyle.Flat;
            SaveBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBT.ForeColor = Color.MediumPurple;
            SaveBT.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            SaveBT.IconColor = Color.White;
            SaveBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveBT.IconSize = 45;
            SaveBT.Location = new Point(0, 675);
            SaveBT.Margin = new Padding(4, 5, 4, 5);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(259, 51);
            SaveBT.TabIndex = 322;
            SaveBT.Text = "Save";
            SaveBT.TextAlign = ContentAlignment.MiddleRight;
            SaveBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveBT.UseVisualStyleBackColor = false;
            // 
            // ListeningStatusPanel
            // 
            ListeningStatusPanel.BackColor = Color.Red;
            ListeningStatusPanel.Controls.Add(ImageBox);
            ListeningStatusPanel.Location = new Point(3, 3);
            ListeningStatusPanel.Name = "ListeningStatusPanel";
            ListeningStatusPanel.Size = new Size(256, 426);
            ListeningStatusPanel.TabIndex = 323;
            // 
            // ImageBox
            // 
            ImageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ImageBox.BackColor = Color.FromArgb(36, 30, 60);
            ImageBox.Image = My.Resources.Resources.addSign;
            ImageBox.Location = new Point(3, 3);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(250, 420);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 290;
            ImageBox.TabStop = false;
            // 
            // StockEntry
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1924, 726);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Name = "StockEntry";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StockEntry";
            ContextMenuStrip1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ListeningStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            Load += new EventHandler(StockEntry_Load);
            Closed += new EventHandler(StockEntry_Closed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem ChangeListenerPhNoToolStripMenuItem;
        internal ToolStripMenuItem ListenOnceToolStripMenuItem;
        internal UserControl1 ProductFP;
        internal UserControl1 SaleFP;
        internal Panel Panel1;
        internal Panel Panel2;
        internal FontAwesome.Sharp.IconButton SaveBT;
        internal Panel ListeningStatusPanel;
        internal PictureBox ImageBox;
        internal UserControl1 PurchaseFP;
        internal FontAwesome.Sharp.IconButton NextImgButton;
        internal FontAwesome.Sharp.IconButton BackImgButton;
        internal FontAwesome.Sharp.IconButton ReloadImgBT;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ImageDownloader : Form
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
            PhNoTB = new TextBox();
            NameLabel = new Label();
            SaveFileDialog1 = new SaveFileDialog();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            CancelEditBT = new FontAwesome.Sharp.IconButton();
            CancelEditBT.Click += new EventHandler(CancelBT_Click);
            SelectBT = new FontAwesome.Sharp.IconButton();
            SelectBT.Click += new EventHandler(Select_Click);
            DeleteBT = new FontAwesome.Sharp.IconButton();
            DeleteBT.Click += new EventHandler(DeleteBT_Click);
            SaveButton = new FontAwesome.Sharp.IconButton();
            SaveButton.Click += new EventHandler(SaveButton_Click);
            AddNewListenerBT = new FontAwesome.Sharp.IconButton();
            AddNewListenerBT.Click += new EventHandler(AddNewListenerBT_Click);
            ListenPhNoBT = new FontAwesome.Sharp.IconButton();
            ListenPhNoBT.Click += new EventHandler(ListenPhNoBT_Click);
            ImageBox = new PictureBox();
            ReloadImgBT = new FontAwesome.Sharp.IconButton();
            ReloadImgBT.Click += new EventHandler(ReloadImgBT_Click);
            ContextMenuStrip1.SuspendLayout();
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
            // PhNoTB
            // 
            PhNoTB.Anchor = AnchorStyles.Left;
            PhNoTB.BackColor = Color.White;
            PhNoTB.Enabled = false;
            PhNoTB.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhNoTB.Location = new Point(581, 157);
            PhNoTB.Margin = new Padding(4, 5, 4, 5);
            PhNoTB.Name = "PhNoTB";
            PhNoTB.Size = new Size(229, 35);
            PhNoTB.TabIndex = 322;
            PhNoTB.Tag = "";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Left;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = SystemColors.ActiveCaption;
            NameLabel.Location = new Point(576, 9);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(335, 143);
            NameLabel.TabIndex = 323;
            NameLabel.Text = "Enter New PhNo With Country Code Which Will Be Used As A Listener." + '\r' + '\n' + "(Eg: 91988296" + "0863)";
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Location = new Point(576, 300);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(341, 318);
            FlowLayoutPanel1.TabIndex = 326;
            // 
            // CancelEditBT
            // 
            CancelEditBT.BackColor = Color.Maroon;
            CancelEditBT.FlatAppearance.BorderSize = 0;
            CancelEditBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            CancelEditBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            CancelEditBT.FlatStyle = FlatStyle.Flat;
            CancelEditBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelEditBT.ForeColor = Color.Linen;
            CancelEditBT.IconChar = FontAwesome.Sharp.IconChar.Times;
            CancelEditBT.IconColor = Color.White;
            CancelEditBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelEditBT.IconSize = 36;
            CancelEditBT.Location = new Point(924, 418);
            CancelEditBT.Margin = new Padding(4, 5, 4, 5);
            CancelEditBT.Name = "CancelEditBT";
            CancelEditBT.Size = new Size(45, 44);
            CancelEditBT.TabIndex = 10040;
            CancelEditBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelEditBT.UseVisualStyleBackColor = false;
            CancelEditBT.Visible = false;
            // 
            // SelectBT
            // 
            SelectBT.BackColor = Color.FromArgb(0, 64, 0);
            SelectBT.FlatAppearance.BorderSize = 0;
            SelectBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            SelectBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SelectBT.FlatStyle = FlatStyle.Flat;
            SelectBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectBT.ForeColor = Color.Linen;
            SelectBT.IconChar = FontAwesome.Sharp.IconChar.Check;
            SelectBT.IconColor = Color.White;
            SelectBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SelectBT.IconSize = 36;
            SelectBT.Location = new Point(924, 310);
            SelectBT.Margin = new Padding(4, 5, 4, 5);
            SelectBT.Name = "SelectBT";
            SelectBT.Size = new Size(45, 44);
            SelectBT.TabIndex = 10039;
            SelectBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SelectBT.UseVisualStyleBackColor = false;
            SelectBT.Visible = false;
            // 
            // DeleteBT
            // 
            DeleteBT.BackColor = Color.Maroon;
            DeleteBT.FlatAppearance.BorderSize = 0;
            DeleteBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            DeleteBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            DeleteBT.FlatStyle = FlatStyle.Flat;
            DeleteBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBT.ForeColor = Color.Linen;
            DeleteBT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            DeleteBT.IconColor = Color.White;
            DeleteBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBT.IconSize = 36;
            DeleteBT.Location = new Point(924, 364);
            DeleteBT.Margin = new Padding(4, 5, 4, 5);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(45, 44);
            DeleteBT.TabIndex = 10041;
            DeleteBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteBT.UseVisualStyleBackColor = false;
            DeleteBT.Visible = false;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(0, 64, 0);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatAppearance.MouseDownBackColor = Color.Lime;
            SaveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.Linen;
            SaveButton.IconChar = FontAwesome.Sharp.IconChar.Download;
            SaveButton.IconColor = Color.White;
            SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveButton.IconSize = 32;
            SaveButton.Location = new Point(581, 226);
            SaveButton.Margin = new Padding(4, 5, 4, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(282, 56);
            SaveButton.TabIndex = 325;
            SaveButton.Text = "Download To PC";
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // AddNewListenerBT
            // 
            AddNewListenerBT.BackColor = Color.Transparent;
            AddNewListenerBT.FlatAppearance.BorderSize = 0;
            AddNewListenerBT.FlatAppearance.MouseDownBackColor = Color.Transparent;
            AddNewListenerBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            AddNewListenerBT.FlatStyle = FlatStyle.Popup;
            AddNewListenerBT.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewListenerBT.ForeColor = Color.Transparent;
            AddNewListenerBT.IconChar = FontAwesome.Sharp.IconChar.Edit;
            AddNewListenerBT.IconColor = Color.Goldenrod;
            AddNewListenerBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddNewListenerBT.IconSize = 40;
            AddNewListenerBT.Location = new Point(941, 156);
            AddNewListenerBT.Margin = new Padding(4, 5, 4, 5);
            AddNewListenerBT.Name = "AddNewListenerBT";
            AddNewListenerBT.Size = new Size(34, 38);
            AddNewListenerBT.TabIndex = 324;
            AddNewListenerBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddNewListenerBT.UseVisualStyleBackColor = false;
            // 
            // ListenPhNoBT
            // 
            ListenPhNoBT.AutoSize = true;
            ListenPhNoBT.BackColor = Color.FromArgb(0, 64, 0);
            ListenPhNoBT.FlatAppearance.BorderSize = 0;
            ListenPhNoBT.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ListenPhNoBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ListenPhNoBT.FlatStyle = FlatStyle.Popup;
            ListenPhNoBT.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListenPhNoBT.ForeColor = Color.White;
            ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ListenPhNoBT.IconColor = Color.White;
            ListenPhNoBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ListenPhNoBT.IconSize = 40;
            ListenPhNoBT.Location = new Point(818, 152);
            ListenPhNoBT.Margin = new Padding(4, 5, 4, 5);
            ListenPhNoBT.Name = "ListenPhNoBT";
            ListenPhNoBT.Size = new Size(115, 46);
            ListenPhNoBT.TabIndex = 321;
            ListenPhNoBT.Text = "Start";
            ListenPhNoBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            ListenPhNoBT.UseVisualStyleBackColor = false;
            // 
            // ImageBox
            // 
            ImageBox.Dock = DockStyle.Left;
            ImageBox.Image = My.Resources.Resources.addSign;
            ImageBox.Location = new Point(0, 0);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(564, 636);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 320;
            ImageBox.TabStop = false;
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
            ReloadImgBT.Location = new Point(871, 231);
            ReloadImgBT.Margin = new Padding(4, 5, 4, 5);
            ReloadImgBT.Name = "ReloadImgBT";
            ReloadImgBT.Size = new Size(46, 46);
            ReloadImgBT.TabIndex = 10042;
            ReloadImgBT.Tag = "-1";
            ReloadImgBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            ReloadImgBT.UseVisualStyleBackColor = false;
            // 
            // ImageDownloader
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(992, 636);
            Controls.Add(ReloadImgBT);
            Controls.Add(CancelEditBT);
            Controls.Add(SelectBT);
            Controls.Add(DeleteBT);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(SaveButton);
            Controls.Add(AddNewListenerBT);
            Controls.Add(NameLabel);
            Controls.Add(PhNoTB);
            Controls.Add(ListenPhNoBT);
            Controls.Add(ImageBox);
            Name = "ImageDownloader";
            Text = "ImageDownloader";
            ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            Load += new EventHandler(ImageDownloader_Load);
            Closed += new EventHandler(ImageDownloader_Closed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal PictureBox ImageBox;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem ChangeListenerPhNoToolStripMenuItem;
        internal ToolStripMenuItem ListenOnceToolStripMenuItem;
        internal TextBox PhNoTB;
        internal Label NameLabel;
        internal FontAwesome.Sharp.IconButton AddNewListenerBT;
        internal FontAwesome.Sharp.IconButton SaveButton;
        internal SaveFileDialog SaveFileDialog1;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FontAwesome.Sharp.IconButton CancelEditBT;
        internal FontAwesome.Sharp.IconButton SelectBT;
        internal FontAwesome.Sharp.IconButton DeleteBT;
        internal FontAwesome.Sharp.IconButton ListenPhNoBT;
        internal FontAwesome.Sharp.IconButton ReloadImgBT;
    }
}
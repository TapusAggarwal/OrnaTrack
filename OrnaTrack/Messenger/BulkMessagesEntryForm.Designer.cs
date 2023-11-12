using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BulkMessagesEntryForm : Form
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
            MaturedToolStripMenuItem = new ToolStripMenuItem();
            PendingToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            UpToDateToolStripMenuItem = new ToolStripMenuItem();
            AvailedToolStripMenuItem = new ToolStripMenuItem();
            WarningLabel = new Label();
            CustomerSelectionChB = new CheckBox();
            CustomerSelectionChB.CheckedChanged += new EventHandler(CustomerSelectionChB_CheckedChanged);
            KittySelectionChB = new CheckBox();
            KittySelectionChB.CheckedChanged += new EventHandler(KittySelectionChB_CheckedChanged);
            SendButton = new FontAwesome.Sharp.IconButton();
            SendButton.Click += new EventHandler(SendButton_Click);
            PreviewBT = new FontAwesome.Sharp.IconButton();
            PreviewBT.Click += new EventHandler(PreviewBT_Click);
            KittyTypeCList = new CheckedListBox();
            KittyTypeCList.ItemCheck += new ItemCheckEventHandler(KittyTypeCList_ItemCheck);
            InstalmentsPendingCList = new CheckedListBox();
            InstalmentsPendingCList.ItemCheck += new ItemCheckEventHandler(InstalmentsPendingCList_ItemCheck);
            MaturedChB = new CheckBox();
            MaturedChB.CheckedChanged += new EventHandler(MaturedChB_CheckedChanged);
            AvailedChB = new CheckBox();
            AvailedChB.CheckedChanged += new EventHandler(MaturedChB_CheckedChanged);
            InstalmentsLeftCList = new CheckedListBox();
            InstalmentsLeftCList.ItemCheck += new ItemCheckEventHandler(InstalmentsLeftCList_ItemCheck);
            Label1 = new Label();
            SelectedCustomersLB = new Label();
            IconButton1 = new FontAwesome.Sharp.IconButton();
            IconButton1.Click += new EventHandler(IconButton1_Click);
            InActiveCB = new CheckBox();
            InActiveCB.CheckedChanged += new EventHandler(MaturedChB_CheckedChanged);
            ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.AllowDrop = true;
            ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { MaturedToolStripMenuItem, PendingToolStripMenuItem, NewToolStripMenuItem, UpToDateToolStripMenuItem, AvailedToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(163, 164);
            // 
            // MaturedToolStripMenuItem
            // 
            MaturedToolStripMenuItem.Name = "MaturedToolStripMenuItem";
            MaturedToolStripMenuItem.Size = new Size(162, 32);
            MaturedToolStripMenuItem.Text = "Matured";
            // 
            // PendingToolStripMenuItem
            // 
            PendingToolStripMenuItem.Name = "PendingToolStripMenuItem";
            PendingToolStripMenuItem.Size = new Size(162, 32);
            PendingToolStripMenuItem.Text = "Pending";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(162, 32);
            NewToolStripMenuItem.Text = "New";
            // 
            // UpToDateToolStripMenuItem
            // 
            UpToDateToolStripMenuItem.Name = "UpToDateToolStripMenuItem";
            UpToDateToolStripMenuItem.Size = new Size(162, 32);
            UpToDateToolStripMenuItem.Text = "UpToDate";
            // 
            // AvailedToolStripMenuItem
            // 
            AvailedToolStripMenuItem.Name = "AvailedToolStripMenuItem";
            AvailedToolStripMenuItem.Size = new Size(162, 32);
            AvailedToolStripMenuItem.Text = "Availed";
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.BackColor = Color.Transparent;
            WarningLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            WarningLabel.ForeColor = Color.Goldenrod;
            WarningLabel.Location = new Point(164, 9);
            WarningLabel.Margin = new Padding(4, 0, 4, 0);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(413, 30);
            WarningLabel.TabIndex = 253;
            WarningLabel.Text = "Sort Customers To Send Messages";
            // 
            // CustomerSelectionChB
            // 
            CustomerSelectionChB.AutoSize = true;
            CustomerSelectionChB.Location = new Point(16, 79);
            CustomerSelectionChB.Name = "CustomerSelectionChB";
            CustomerSelectionChB.Size = new Size(133, 24);
            CustomerSelectionChB.TabIndex = 255;
            CustomerSelectionChB.Text = "All Customers";
            CustomerSelectionChB.UseVisualStyleBackColor = true;
            // 
            // KittySelectionChB
            // 
            KittySelectionChB.AutoSize = true;
            KittySelectionChB.Location = new Point(169, 79);
            KittySelectionChB.Name = "KittySelectionChB";
            KittySelectionChB.Size = new Size(145, 24);
            KittySelectionChB.TabIndex = 257;
            KittySelectionChB.Text = "Selected Kitties";
            KittySelectionChB.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.FromArgb(0, 64, 0);
            SendButton.Enabled = false;
            SendButton.FlatAppearance.BorderSize = 0;
            SendButton.FlatAppearance.MouseDownBackColor = Color.Lime;
            SendButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SendButton.FlatStyle = FlatStyle.Flat;
            SendButton.Font = new Font("Century Gothic", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendButton.ForeColor = Color.Linen;
            SendButton.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            SendButton.IconColor = Color.White;
            SendButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SendButton.IconSize = 25;
            SendButton.Location = new Point(366, 114);
            SendButton.Margin = new Padding(4, 5, 4, 5);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(191, 45);
            SendButton.TabIndex = 258;
            SendButton.Text = "Send Message";
            SendButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SendButton.UseVisualStyleBackColor = false;
            // 
            // PreviewBT
            // 
            PreviewBT.BackColor = Color.FromArgb(0, 64, 0);
            PreviewBT.Enabled = false;
            PreviewBT.FlatAppearance.BorderSize = 0;
            PreviewBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            PreviewBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            PreviewBT.FlatStyle = FlatStyle.Flat;
            PreviewBT.Font = new Font("Century Gothic", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviewBT.ForeColor = Color.Linen;
            PreviewBT.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            PreviewBT.IconColor = Color.White;
            PreviewBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PreviewBT.IconSize = 25;
            PreviewBT.Location = new Point(565, 114);
            PreviewBT.Margin = new Padding(4, 5, 4, 5);
            PreviewBT.Name = "PreviewBT";
            PreviewBT.Size = new Size(127, 45);
            PreviewBT.TabIndex = 259;
            PreviewBT.Text = "Preview";
            PreviewBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            PreviewBT.UseVisualStyleBackColor = false;
            // 
            // KittyTypeCList
            // 
            KittyTypeCList.FormattingEnabled = true;
            KittyTypeCList.Items.AddRange(new object[] { "All", "500", "1000", "2000", "3000", "5000" });
            KittyTypeCList.Location = new Point(22, 186);
            KittyTypeCList.Name = "KittyTypeCList";
            KittyTypeCList.Size = new Size(145, 211);
            KittyTypeCList.TabIndex = 264;
            KittyTypeCList.Visible = false;
            // 
            // InstalmentsPendingCList
            // 
            InstalmentsPendingCList.FormattingEnabled = true;
            InstalmentsPendingCList.Items.AddRange(new object[] { "1 Instalment Pending", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            InstalmentsPendingCList.Location = new Point(458, 186);
            InstalmentsPendingCList.Name = "InstalmentsPendingCList";
            InstalmentsPendingCList.Size = new Size(270, 349);
            InstalmentsPendingCList.TabIndex = 263;
            InstalmentsPendingCList.Visible = false;
            // 
            // MaturedChB
            // 
            MaturedChB.AutoSize = true;
            MaturedChB.Location = new Point(22, 415);
            MaturedChB.Name = "MaturedChB";
            MaturedChB.Size = new Size(94, 24);
            MaturedChB.TabIndex = 262;
            MaturedChB.Text = "Matured";
            MaturedChB.UseVisualStyleBackColor = true;
            MaturedChB.Visible = false;
            // 
            // AvailedChB
            // 
            AvailedChB.AutoSize = true;
            AvailedChB.Location = new Point(22, 446);
            AvailedChB.Name = "AvailedChB";
            AvailedChB.Size = new Size(86, 24);
            AvailedChB.TabIndex = 261;
            AvailedChB.Text = "Availed";
            AvailedChB.UseVisualStyleBackColor = true;
            AvailedChB.Visible = false;
            // 
            // InstalmentsLeftCList
            // 
            InstalmentsLeftCList.FormattingEnabled = true;
            InstalmentsLeftCList.Items.AddRange(new object[] { "1 Instalment Left", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" });
            InstalmentsLeftCList.Location = new Point(193, 186);
            InstalmentsLeftCList.Name = "InstalmentsLeftCList";
            InstalmentsLeftCList.Size = new Size(243, 349);
            InstalmentsLeftCList.TabIndex = 260;
            InstalmentsLeftCList.Visible = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Goldenrod;
            Label1.Location = new Point(392, 71);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(126, 30);
            Label1.TabIndex = 265;
            Label1.Text = "Selected:";
            // 
            // SelectedCustomersLB
            // 
            SelectedCustomersLB.AutoSize = true;
            SelectedCustomersLB.BackColor = Color.Transparent;
            SelectedCustomersLB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedCustomersLB.ForeColor = Color.Goldenrod;
            SelectedCustomersLB.Location = new Point(522, 71);
            SelectedCustomersLB.Margin = new Padding(4, 0, 4, 0);
            SelectedCustomersLB.Name = "SelectedCustomersLB";
            SelectedCustomersLB.Size = new Size(26, 30);
            SelectedCustomersLB.TabIndex = 266;
            SelectedCustomersLB.Text = "0";
            // 
            // IconButton1
            // 
            IconButton1.BackColor = Color.FromArgb(0, 64, 0);
            IconButton1.FlatAppearance.BorderSize = 0;
            IconButton1.FlatAppearance.MouseDownBackColor = Color.Lime;
            IconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            IconButton1.FlatStyle = FlatStyle.Flat;
            IconButton1.Font = new Font("Century Gothic", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            IconButton1.ForeColor = Color.Linen;
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            IconButton1.IconColor = Color.White;
            IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton1.IconSize = 25;
            IconButton1.Location = new Point(231, 114);
            IconButton1.Margin = new Padding(4, 5, 4, 5);
            IconButton1.Name = "IconButton1";
            IconButton1.Size = new Size(127, 45);
            IconButton1.TabIndex = 267;
            IconButton1.Text = "Previous";
            IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButton1.UseVisualStyleBackColor = false;
            // 
            // InActiveCB
            // 
            InActiveCB.AutoSize = true;
            InActiveCB.Location = new Point(22, 477);
            InActiveCB.Name = "InActiveCB";
            InActiveCB.Size = new Size(86, 24);
            InActiveCB.TabIndex = 268;
            InActiveCB.Text = "Availed";
            InActiveCB.UseVisualStyleBackColor = true;
            InActiveCB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(740, 569);
            Controls.Add(InActiveCB);
            Controls.Add(IconButton1);
            Controls.Add(SelectedCustomersLB);
            Controls.Add(Label1);
            Controls.Add(KittyTypeCList);
            Controls.Add(InstalmentsPendingCList);
            Controls.Add(MaturedChB);
            Controls.Add(AvailedChB);
            Controls.Add(InstalmentsLeftCList);
            Controls.Add(PreviewBT);
            Controls.Add(SendButton);
            Controls.Add(KittySelectionChB);
            Controls.Add(CustomerSelectionChB);
            Controls.Add(WarningLabel);
            ForeColor = SystemColors.ActiveCaption;
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem MaturedToolStripMenuItem;
        internal ToolStripMenuItem PendingToolStripMenuItem;
        internal ToolStripMenuItem NewToolStripMenuItem;
        internal ToolStripMenuItem UpToDateToolStripMenuItem;
        internal ToolStripMenuItem AvailedToolStripMenuItem;
        internal Label WarningLabel;
        internal CheckBox CustomerSelectionChB;
        internal CheckBox KittySelectionChB;
        internal FontAwesome.Sharp.IconButton SendButton;
        internal FontAwesome.Sharp.IconButton PreviewBT;
        internal CheckedListBox KittyTypeCList;
        internal CheckedListBox InstalmentsPendingCList;
        internal CheckBox MaturedChB;
        internal CheckBox AvailedChB;
        internal CheckedListBox InstalmentsLeftCList;
        internal Label Label1;
        internal Label SelectedCustomersLB;
        internal FontAwesome.Sharp.IconButton IconButton1;
        internal CheckBox InActiveCB;
    }
}
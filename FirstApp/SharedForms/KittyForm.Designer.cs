using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class KittyForm : Form
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
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle17 = new DataGridViewCellStyle();
            var DataGridViewCellStyle18 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            MainPanel = new Panel();
            NotesTB = new RichTextBox();
            NotesTB.TextChanged += new EventHandler(NotesTB_TextChanged);
            DotsButton = new FontAwesome.Sharp.IconPictureBox();
            DotsButton.Click += new EventHandler(IconPictureBox1_Click);
            ContextMenuStrip1 = new ContextMenuStrip(components);
            CrackThisKittyToolStripMenuItem = new ToolStripMenuItem();
            CrackThisKittyToolStripMenuItem.Click += new EventHandler(CrackThisKittyToolStripMenuItem_Click);
            MarkAsInactiveToolStripMenuItem = new ToolStripMenuItem();
            MarkAsInactiveToolStripMenuItem.Click += new EventHandler(MarkAsInactiveToolStripMenuItem_Click);
            TransferKittyToolStripMenuItem = new ToolStripMenuItem();
            TransferKittyToolStripMenuItem.Click += new EventHandler(TransferKittyToolStripMenuItem_Click);
            CloseButton = new FontAwesome.Sharp.IconButton();
            CloseButton.Click += new EventHandler(CloseButton_Click);
            NotificationButton = new FontAwesome.Sharp.IconPictureBox();
            NotificationButton.Click += new EventHandler(NotificationButton_Click);
            _Dgv = new DataGridView();
            _Dgv.CellClick += new DataGridViewCellEventHandler(Dgv_CellClick);
            Column3 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Mode = new DataGridViewTextBoxColumn();
            RightArrowButton = new FontAwesome.Sharp.IconPictureBox();
            RightArrowButton.Click += new EventHandler(RightArrowButton_Click);
            KittyTypeLabel = new Label();
            StatusLabel = new Label();
            BalanceTB = new TextBox();
            BalanceTB.TextChanged += new EventHandler(BalanceTB_TextChanged);
            KittyNoLabel = new Label();
            LeftAmountTB = new TextBox();
            LeftAmountTB.TextChanged += new EventHandler(BalanceTB_TextChanged);
            BalanceLabel = new Label();
            TotalInstalmentsLabel = new Label();
            SaveButton = new FontAwesome.Sharp.IconButton();
            SaveButton.Click += new EventHandler(SaveButton_Click);
            TotalKittysLB = new Label();
            DissolveButton = new FontAwesome.Sharp.IconButton();
            DissolveButton.Click += new EventHandler(DissolveButton_Click);
            Intrestlabel = new Label();
            PaymentButton = new FontAwesome.Sharp.IconButton();
            PaymentButton.Click += new EventHandler(PaymentButton_Click);
            KittyTypeCB = new ComboBox();
            KittyTypeCB.SelectionChangeCommitted += new EventHandler(KittyTypeCB_SelectionChangeCommitted);
            KittyTypeCB.KeyDown += new KeyEventHandler(KittyTypeCB_KeyDown);
            ResetButton = new FontAwesome.Sharp.IconButton();
            ResetButton.Click += new EventHandler(ResetButton_Click);
            EntryAmountLabel = new Label();
            GivenAmountTB = new TextBox();
            GivenAmountTB.TextChanged += new EventHandler(BalanceTB_TextChanged);
            DateLabel = new Label();
            EntryTB = new TextBox();
            EntryTB.KeyDown += new KeyEventHandler(KeyDown_TextBoxControls);
            EntryTB.GotFocus += new EventHandler(Controls_GotFocus);
            EntryTB.Leave += new EventHandler(Controls_Leave);
            DatePicker = new DateTimePicker();
            DatePicker.KeyDown += new KeyEventHandler(KeyDown_TextBoxControls);
            TotalInstalmentsTB = new TextBox();
            TotalInstalmentsTB.TextChanged += new EventHandler(Controls_TextChanged);
            TotalInstalmentsTB.KeyDown += new KeyEventHandler(KeyDown_TextBoxControls);
            TotalInstalmentsTB.GotFocus += new EventHandler(Controls_GotFocus);
            TotalInstalmentsTB.Leave += new EventHandler(Controls_Leave);
            KittyNoTB = new TextBox();
            KittyNoTB.TextChanged += new EventHandler(Controls_TextChanged);
            KittyNoTB.KeyDown += new KeyEventHandler(KeyDown_TextBoxControls);
            KittyNoTB.GotFocus += new EventHandler(Controls_GotFocus);
            KittyNoTB.Leave += new EventHandler(Controls_Leave);
            LeftAmountLabel = new Label();
            KittyIntrestCB = new ComboBox();
            KittyIntrestCB.SelectedIndexChanged += new EventHandler(KittyIntrestCB_SelectedIndexChanged);
            KittyIntrestCB.KeyDown += new KeyEventHandler(KittyIntrestCB_KeyDown);
            GivenAmountLabel = new Label();
            DeleteButton = new FontAwesome.Sharp.IconButton();
            DeleteButton.Click += new EventHandler(DeleteButton_Click);
            AvailButton = new FontAwesome.Sharp.IconButton();
            AvailButton.Click += new EventHandler(AvailButton_Click);
            ToolTip1 = new ToolTip(components);
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DotsButton).BeginInit();
            ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightArrowButton).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(NotesTB);
            MainPanel.Controls.Add(DotsButton);
            MainPanel.Controls.Add(CloseButton);
            MainPanel.Controls.Add(NotificationButton);
            MainPanel.Controls.Add(_Dgv);
            MainPanel.Controls.Add(RightArrowButton);
            MainPanel.Controls.Add(KittyTypeLabel);
            MainPanel.Controls.Add(StatusLabel);
            MainPanel.Controls.Add(BalanceTB);
            MainPanel.Controls.Add(KittyNoLabel);
            MainPanel.Controls.Add(LeftAmountTB);
            MainPanel.Controls.Add(BalanceLabel);
            MainPanel.Controls.Add(TotalInstalmentsLabel);
            MainPanel.Controls.Add(SaveButton);
            MainPanel.Controls.Add(TotalKittysLB);
            MainPanel.Controls.Add(DissolveButton);
            MainPanel.Controls.Add(Intrestlabel);
            MainPanel.Controls.Add(PaymentButton);
            MainPanel.Controls.Add(KittyTypeCB);
            MainPanel.Controls.Add(ResetButton);
            MainPanel.Controls.Add(EntryAmountLabel);
            MainPanel.Controls.Add(GivenAmountTB);
            MainPanel.Controls.Add(DateLabel);
            MainPanel.Controls.Add(EntryTB);
            MainPanel.Controls.Add(DatePicker);
            MainPanel.Controls.Add(TotalInstalmentsTB);
            MainPanel.Controls.Add(KittyNoTB);
            MainPanel.Controls.Add(LeftAmountLabel);
            MainPanel.Controls.Add(KittyIntrestCB);
            MainPanel.Controls.Add(GivenAmountLabel);
            MainPanel.Controls.Add(DeleteButton);
            MainPanel.Controls.Add(AvailButton);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1405, 523);
            MainPanel.TabIndex = 235;
            // 
            // NotesTB
            // 
            NotesTB.Location = new Point(1040, 355);
            NotesTB.Name = "NotesTB";
            NotesTB.Size = new Size(349, 77);
            NotesTB.TabIndex = 267;
            NotesTB.Text = "";
            ToolTip1.SetToolTip(NotesTB, "Enter Notes That You Want To Keep On This Kitty.");
            NotesTB.ZoomFactor = 1.2f;
            // 
            // DotsButton
            // 
            DotsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DotsButton.BackColor = Color.Transparent;
            DotsButton.BackgroundImageLayout = ImageLayout.Stretch;
            DotsButton.ContextMenuStrip = ContextMenuStrip1;
            DotsButton.ForeColor = Color.Silver;
            DotsButton.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            DotsButton.IconColor = Color.Silver;
            DotsButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            DotsButton.IconSize = 47;
            DotsButton.Location = new Point(1338, 140);
            DotsButton.Margin = new Padding(4, 5, 4, 5);
            DotsButton.Name = "DotsButton";
            DotsButton.Size = new Size(47, 47);
            DotsButton.TabIndex = 266;
            DotsButton.TabStop = false;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { CrackThisKittyToolStripMenuItem, MarkAsInactiveToolStripMenuItem, TransferKittyToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(215, 100);
            // 
            // CrackThisKittyToolStripMenuItem
            // 
            CrackThisKittyToolStripMenuItem.Name = "CrackThisKittyToolStripMenuItem";
            CrackThisKittyToolStripMenuItem.ShowShortcutKeys = false;
            CrackThisKittyToolStripMenuItem.Size = new Size(214, 32);
            CrackThisKittyToolStripMenuItem.Text = "Crack This Kitty";
            // 
            // MarkAsInactiveToolStripMenuItem
            // 
            MarkAsInactiveToolStripMenuItem.Name = "MarkAsInactiveToolStripMenuItem";
            MarkAsInactiveToolStripMenuItem.Size = new Size(214, 32);
            MarkAsInactiveToolStripMenuItem.Text = "Mark As Inactive";
            // 
            // TransferKittyToolStripMenuItem
            // 
            TransferKittyToolStripMenuItem.Name = "TransferKittyToolStripMenuItem";
            TransferKittyToolStripMenuItem.Size = new Size(214, 32);
            TransferKittyToolStripMenuItem.Text = "Transfer Kitty";
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Snow;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            CloseButton.IconColor = Color.DarkRed;
            CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CloseButton.IconSize = 45;
            CloseButton.ImageAlign = ContentAlignment.TopCenter;
            CloseButton.Location = new Point(1357, 2);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(43, 42);
            CloseButton.TabIndex = 265;
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // NotificationButton
            // 
            NotificationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NotificationButton.BackColor = Color.Transparent;
            NotificationButton.BackgroundImageLayout = ImageLayout.Stretch;
            NotificationButton.ForeColor = Color.ForestGreen;
            NotificationButton.IconChar = FontAwesome.Sharp.IconChar.Bell;
            NotificationButton.IconColor = Color.ForestGreen;
            NotificationButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            NotificationButton.IconSize = 47;
            NotificationButton.Location = new Point(1283, 143);
            NotificationButton.Margin = new Padding(4, 5, 4, 5);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Size = new Size(47, 47);
            NotificationButton.TabIndex = 264;
            NotificationButton.TabStop = false;
            // 
            // Dgv
            // 
            _Dgv.AllowUserToAddRows = false;
            _Dgv.AllowUserToDeleteRows = false;
            _Dgv.AllowUserToResizeColumns = false;
            _Dgv.AllowUserToResizeRows = false;
            DataGridViewCellStyle10.BackColor = Color.FromArgb(224, 224, 224);
            _Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10;
            _Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _Dgv.BackgroundColor = Color.FromArgb(0, 0, 50);
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = SystemColors.Control;
            DataGridViewCellStyle11.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            _Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11;
            _Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _Dgv.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column6, Column2, Column4, Column5, Mode });
            DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle17.BackColor = SystemColors.Window;
            DataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            _Dgv.DefaultCellStyle = DataGridViewCellStyle17;
            _Dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            _Dgv.Location = new Point(0, 0);
            _Dgv.Margin = new Padding(4, 5, 4, 5);
            _Dgv.MultiSelect = false;
            _Dgv.Name = "_Dgv";
            _Dgv.ReadOnly = true;
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle18.BackColor = SystemColors.Control;
            DataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            _Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle18;
            _Dgv.RowHeadersVisible = false;
            _Dgv.RowHeadersWidth = 62;
            _Dgv.Size = new Size(663, 523);
            _Dgv.TabIndex = 244;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 35;
            // 
            // Column1
            // 
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle12.NullValue = null;
            Column1.DefaultCellStyle = DataGridViewCellStyle12;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 40;
            // 
            // Column6
            // 
            Column6.HeaderText = "Month";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column2
            // 
            DataGridViewCellStyle13.Font = new Font("Arial Rounded MT Bold", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle13.Format = "d";
            DataGridViewCellStyle13.NullValue = null;
            DataGridViewCellStyle13.SelectionBackColor = Color.White;
            DataGridViewCellStyle13.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = DataGridViewCellStyle13;
            Column2.HeaderText = "Date";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 140;
            // 
            // Column4
            // 
            DataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle14.NullValue = null;
            Column4.DefaultCellStyle = DataGridViewCellStyle14;
            Column4.HeaderText = "Paid";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 125;
            // 
            // Column5
            // 
            DataGridViewCellStyle15.BackColor = Color.White;
            Column5.DefaultCellStyle = DataGridViewCellStyle15;
            Column5.HeaderText = "Type";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.Width = 116;
            // 
            // Mode
            // 
            DataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mode.DefaultCellStyle = DataGridViewCellStyle16;
            Mode.HeaderText = "Trns.";
            Mode.MinimumWidth = 8;
            Mode.Name = "Mode";
            Mode.ReadOnly = true;
            Mode.Resizable = DataGridViewTriState.False;
            Mode.Width = 70;
            // 
            // RightArrowButton
            // 
            RightArrowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RightArrowButton.BackColor = Color.Transparent;
            RightArrowButton.BackgroundImageLayout = ImageLayout.Stretch;
            RightArrowButton.ForeColor = Color.ForestGreen;
            RightArrowButton.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            RightArrowButton.IconColor = Color.ForestGreen;
            RightArrowButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            RightArrowButton.IconSize = 44;
            RightArrowButton.Location = new Point(1222, 143);
            RightArrowButton.Margin = new Padding(4, 5, 4, 5);
            RightArrowButton.Name = "RightArrowButton";
            RightArrowButton.Size = new Size(46, 44);
            RightArrowButton.TabIndex = 248;
            RightArrowButton.TabStop = false;
            ToolTip1.SetToolTip(RightArrowButton, "Send Kitty Reciept");
            // 
            // KittyTypeLabel
            // 
            KittyTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyTypeLabel.AutoSize = true;
            KittyTypeLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyTypeLabel.ForeColor = Color.Peru;
            KittyTypeLabel.Location = new Point(729, 27);
            KittyTypeLabel.Margin = new Padding(4, 0, 4, 0);
            KittyTypeLabel.Name = "KittyTypeLabel";
            KittyTypeLabel.Size = new Size(146, 30);
            KittyTypeLabel.TabIndex = 246;
            KittyTypeLabel.Text = "Kitty Type";
            // 
            // StatusLabel
            // 
            StatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.Peru;
            StatusLabel.Location = new Point(698, 388);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(99, 30);
            StatusLabel.TabIndex = 263;
            StatusLabel.Text = "Status:";
            StatusLabel.Visible = false;
            // 
            // BalanceTB
            // 
            BalanceTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BalanceTB.BackColor = SystemColors.ControlDark;
            BalanceTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BalanceTB.ForeColor = SystemColors.Menu;
            BalanceTB.Location = new Point(1241, 297);
            BalanceTB.Margin = new Padding(4, 5, 4, 5);
            BalanceTB.Name = "BalanceTB";
            BalanceTB.ReadOnly = true;
            BalanceTB.Size = new Size(148, 36);
            BalanceTB.TabIndex = 261;
            BalanceTB.Text = "0";
            // 
            // KittyNoLabel
            // 
            KittyNoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyNoLabel.AutoSize = true;
            KittyNoLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyNoLabel.ForeColor = Color.Peru;
            KittyNoLabel.Location = new Point(1045, 93);
            KittyNoLabel.Margin = new Padding(4, 0, 4, 0);
            KittyNoLabel.Name = "KittyNoLabel";
            KittyNoLabel.Size = new Size(131, 30);
            KittyNoLabel.TabIndex = 245;
            KittyNoLabel.Text = "Kitty No*";
            // 
            // LeftAmountTB
            // 
            LeftAmountTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LeftAmountTB.BackColor = SystemColors.ControlDark;
            LeftAmountTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeftAmountTB.ForeColor = SystemColors.Menu;
            LeftAmountTB.Location = new Point(1241, 197);
            LeftAmountTB.Margin = new Padding(4, 5, 4, 5);
            LeftAmountTB.Name = "LeftAmountTB";
            LeftAmountTB.ReadOnly = true;
            LeftAmountTB.Size = new Size(148, 36);
            LeftAmountTB.TabIndex = 259;
            LeftAmountTB.Text = "0";
            // 
            // BalanceLabel
            // 
            BalanceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BalanceLabel.ForeColor = Color.Peru;
            BalanceLabel.Location = new Point(1081, 299);
            BalanceLabel.Margin = new Padding(4, 0, 4, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(113, 30);
            BalanceLabel.TabIndex = 260;
            BalanceLabel.Text = "Balance";
            // 
            // TotalInstalmentsLabel
            // 
            TotalInstalmentsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalInstalmentsLabel.AutoSize = true;
            TotalInstalmentsLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalInstalmentsLabel.ForeColor = Color.Peru;
            TotalInstalmentsLabel.Location = new Point(681, 93);
            TotalInstalmentsLabel.Margin = new Padding(4, 0, 4, 0);
            TotalInstalmentsLabel.Name = "TotalInstalmentsLabel";
            TotalInstalmentsLabel.Size = new Size(232, 30);
            TotalInstalmentsLabel.TabIndex = 247;
            TotalInstalmentsLabel.Text = "Total Instalments";
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
            SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            SaveButton.IconColor = Color.White;
            SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveButton.IconSize = 32;
            SaveButton.Location = new Point(1055, 453);
            SaveButton.Margin = new Padding(4, 5, 4, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(282, 56);
            SaveButton.TabIndex = 242;
            SaveButton.Text = "Save Kitty Data";
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // TotalKittysLB
            // 
            TotalKittysLB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalKittysLB.BackColor = Color.DarkGoldenrod;
            TotalKittysLB.Font = new Font("Consolas", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalKittysLB.ForeColor = SystemColors.ActiveCaptionText;
            TotalKittysLB.Location = new Point(1310, 62);
            TotalKittysLB.Margin = new Padding(4, 0, 4, 0);
            TotalKittysLB.Name = "TotalKittysLB";
            TotalKittysLB.Size = new Size(93, 48);
            TotalKittysLB.TabIndex = 249;
            TotalKittysLB.Text = "#1";
            // 
            // DissolveButton
            // 
            DissolveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DissolveButton.BackColor = Color.FromArgb(65, 0, 0);
            DissolveButton.FlatAppearance.BorderSize = 0;
            DissolveButton.FlatAppearance.MouseDownBackColor = Color.Red;
            DissolveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            DissolveButton.FlatStyle = FlatStyle.Flat;
            DissolveButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DissolveButton.ForeColor = Color.Linen;
            DissolveButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DissolveButton.IconColor = Color.White;
            DissolveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DissolveButton.IconSize = 32;
            DissolveButton.Location = new Point(731, 453);
            DissolveButton.Margin = new Padding(4, 5, 4, 5);
            DissolveButton.Name = "DissolveButton";
            DissolveButton.Size = new Size(266, 56);
            DissolveButton.TabIndex = 243;
            DissolveButton.Text = "Dissolve Kitty";
            DissolveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DissolveButton.UseVisualStyleBackColor = false;
            DissolveButton.Visible = false;
            // 
            // Intrestlabel
            // 
            Intrestlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Intrestlabel.AutoSize = true;
            Intrestlabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Intrestlabel.ForeColor = Color.Peru;
            Intrestlabel.Location = new Point(1045, 30);
            Intrestlabel.Margin = new Padding(4, 0, 4, 0);
            Intrestlabel.Name = "Intrestlabel";
            Intrestlabel.Size = new Size(98, 30);
            Intrestlabel.TabIndex = 250;
            Intrestlabel.Text = "Intrest";
            // 
            // PaymentButton
            // 
            PaymentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PaymentButton.BackColor = Color.FromArgb(25, 25, 70);
            PaymentButton.FlatAppearance.BorderSize = 0;
            PaymentButton.FlatStyle = FlatStyle.Flat;
            PaymentButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentButton.ForeColor = Color.MediumPurple;
            PaymentButton.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            PaymentButton.IconColor = Color.White;
            PaymentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PaymentButton.IconSize = 32;
            PaymentButton.Location = new Point(801, 373);
            PaymentButton.Margin = new Padding(4, 5, 4, 5);
            PaymentButton.Name = "PaymentButton";
            PaymentButton.Size = new Size(232, 58);
            PaymentButton.TabIndex = 241;
            PaymentButton.Text = "Add Payment";
            PaymentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PaymentButton.UseVisualStyleBackColor = false;
            // 
            // KittyTypeCB
            // 
            KittyTypeCB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyTypeCB.FlatStyle = FlatStyle.Flat;
            KittyTypeCB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyTypeCB.FormattingEnabled = true;
            KittyTypeCB.ImeMode = ImeMode.Off;
            KittyTypeCB.Location = new Point(882, 25);
            KittyTypeCB.Margin = new Padding(4, 5, 4, 5);
            KittyTypeCB.Name = "KittyTypeCB";
            KittyTypeCB.Size = new Size(117, 36);
            KittyTypeCB.TabIndex = 235;
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResetButton.BackColor = Color.FromArgb(25, 25, 70);
            ResetButton.Cursor = Cursors.Default;
            ResetButton.FlatAppearance.BorderSize = 0;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetButton.ForeColor = Color.MediumPurple;
            ResetButton.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            ResetButton.IconColor = Color.White;
            ResetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ResetButton.IconSize = 25;
            ResetButton.Location = new Point(686, 178);
            ResetButton.Margin = new Padding(4, 5, 4, 5);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(138, 52);
            ResetButton.TabIndex = 257;
            ResetButton.Text = "Reset";
            ResetButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ResetButton.UseVisualStyleBackColor = false;
            // 
            // EntryAmountLabel
            // 
            EntryAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EntryAmountLabel.AutoSize = true;
            EntryAmountLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            EntryAmountLabel.ForeColor = Color.Peru;
            EntryAmountLabel.Location = new Point(681, 249);
            EntryAmountLabel.Margin = new Padding(4, 0, 4, 0);
            EntryAmountLabel.Name = "EntryAmountLabel";
            EntryAmountLabel.Size = new Size(149, 30);
            EntryAmountLabel.TabIndex = 251;
            EntryAmountLabel.Text = "Entry Amt.";
            // 
            // GivenAmountTB
            // 
            GivenAmountTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GivenAmountTB.BackColor = SystemColors.ControlDark;
            GivenAmountTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GivenAmountTB.ForeColor = SystemColors.Menu;
            GivenAmountTB.Location = new Point(1241, 247);
            GivenAmountTB.Margin = new Padding(4, 5, 4, 5);
            GivenAmountTB.Name = "GivenAmountTB";
            GivenAmountTB.ReadOnly = true;
            GivenAmountTB.Size = new Size(148, 36);
            GivenAmountTB.TabIndex = 256;
            GivenAmountTB.Text = "0";
            // 
            // DateLabel
            // 
            DateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = Color.Peru;
            DateLabel.Location = new Point(752, 321);
            DateLabel.Margin = new Padding(4, 0, 4, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(72, 30);
            DateLabel.TabIndex = 252;
            DateLabel.Text = "Date";
            // 
            // EntryTB
            // 
            EntryTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EntryTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            EntryTB.Location = new Point(848, 249);
            EntryTB.Margin = new Padding(4, 5, 4, 5);
            EntryTB.Name = "EntryTB";
            EntryTB.Size = new Size(151, 36);
            EntryTB.TabIndex = 239;
            // 
            // DatePicker
            // 
            DatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DatePicker.CalendarFont = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePicker.Font = new Font("Century", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.Location = new Point(848, 317);
            DatePicker.Margin = new Padding(4, 5, 4, 5);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(151, 34);
            DatePicker.TabIndex = 240;
            // 
            // TotalInstalmentsTB
            // 
            TotalInstalmentsTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalInstalmentsTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalInstalmentsTB.Location = new Point(937, 87);
            TotalInstalmentsTB.Margin = new Padding(4, 5, 4, 5);
            TotalInstalmentsTB.Name = "TotalInstalmentsTB";
            TotalInstalmentsTB.Size = new Size(61, 36);
            TotalInstalmentsTB.TabIndex = 237;
            // 
            // KittyNoTB
            // 
            KittyNoTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyNoTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyNoTB.Location = new Point(1182, 87);
            KittyNoTB.Margin = new Padding(4, 5, 4, 5);
            KittyNoTB.Name = "KittyNoTB";
            KittyNoTB.Size = new Size(100, 36);
            KittyNoTB.TabIndex = 238;
            // 
            // LeftAmountLabel
            // 
            LeftAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LeftAmountLabel.AutoSize = true;
            LeftAmountLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeftAmountLabel.ForeColor = Color.Peru;
            LeftAmountLabel.Location = new Point(1050, 199);
            LeftAmountLabel.Margin = new Padding(4, 0, 4, 0);
            LeftAmountLabel.Name = "LeftAmountLabel";
            LeftAmountLabel.Size = new Size(168, 30);
            LeftAmountLabel.TabIndex = 255;
            LeftAmountLabel.Text = "Left Amount";
            // 
            // KittyIntrestCB
            // 
            KittyIntrestCB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyIntrestCB.FlatStyle = FlatStyle.Flat;
            KittyIntrestCB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyIntrestCB.FormattingEnabled = true;
            KittyIntrestCB.Location = new Point(1165, 25);
            KittyIntrestCB.Margin = new Padding(4, 5, 4, 5);
            KittyIntrestCB.Name = "KittyIntrestCB";
            KittyIntrestCB.Size = new Size(117, 36);
            KittyIntrestCB.TabIndex = 236;
            // 
            // GivenAmountLabel
            // 
            GivenAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GivenAmountLabel.AutoSize = true;
            GivenAmountLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GivenAmountLabel.ForeColor = Color.Peru;
            GivenAmountLabel.Location = new Point(1041, 249);
            GivenAmountLabel.Margin = new Padding(4, 0, 4, 0);
            GivenAmountLabel.Name = "GivenAmountLabel";
            GivenAmountLabel.Size = new Size(192, 30);
            GivenAmountLabel.TabIndex = 254;
            GivenAmountLabel.Text = "Given Amount";
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.BackColor = Color.FromArgb(25, 25, 70);
            DeleteButton.Cursor = Cursors.Default;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.MediumPurple;
            DeleteButton.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            DeleteButton.IconColor = Color.White;
            DeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteButton.IconSize = 25;
            DeleteButton.Location = new Point(866, 178);
            DeleteButton.Margin = new Padding(4, 5, 4, 5);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(138, 52);
            DeleteButton.TabIndex = 253;
            DeleteButton.Text = "Delete";
            DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AvailButton
            // 
            AvailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AvailButton.BackColor = Color.FromArgb(25, 25, 70);
            AvailButton.FlatAppearance.BorderSize = 0;
            AvailButton.FlatStyle = FlatStyle.Flat;
            AvailButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailButton.ForeColor = Color.MediumPurple;
            AvailButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            AvailButton.IconColor = Color.White;
            AvailButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AvailButton.IconSize = 35;
            AvailButton.Location = new Point(801, 373);
            AvailButton.Margin = new Padding(4, 5, 4, 5);
            AvailButton.Name = "AvailButton";
            AvailButton.Size = new Size(198, 58);
            AvailButton.TabIndex = 262;
            AvailButton.Text = "UnAvailed";
            AvailButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AvailButton.UseVisualStyleBackColor = false;
            AvailButton.Visible = false;
            // 
            // KittyForm
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1405, 523);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "KittyForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DotsButton).EndInit();
            ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NotificationButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightArrowButton).EndInit();
            Load += new EventHandler(Kitty_Load);
            KeyDown += new KeyEventHandler(Kitty_KeyDown);
            ResumeLayout(false);

        }
        internal CheckBox IntrestCheckBox;
        internal Panel MainPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        internal FontAwesome.Sharp.IconPictureBox NotificationButton;
        private DataGridView _Dgv;

        protected virtual DataGridView Dgv
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Dgv;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Dgv != null)
                {
                    _Dgv.CellClick -= Dgv_CellClick;
                }

                _Dgv = value;
                if (_Dgv != null)
                {
                    _Dgv.CellClick += Dgv_CellClick;
                }
            }
        }
        internal FontAwesome.Sharp.IconPictureBox RightArrowButton;
        internal ToolTip ToolTip1;
        internal Label KittyTypeLabel;
        internal Label StatusLabel;
        internal TextBox BalanceTB;
        internal Label KittyNoLabel;
        internal TextBox LeftAmountTB;
        internal Label BalanceLabel;
        internal Label TotalInstalmentsLabel;
        internal FontAwesome.Sharp.IconButton SaveButton;
        internal Label TotalKittysLB;
        internal FontAwesome.Sharp.IconButton DissolveButton;
        internal Label Intrestlabel;
        internal FontAwesome.Sharp.IconButton PaymentButton;
        internal ComboBox KittyTypeCB;
        internal FontAwesome.Sharp.IconButton ResetButton;
        internal Label EntryAmountLabel;
        internal TextBox GivenAmountTB;
        internal Label DateLabel;
        internal TextBox EntryTB;
        internal DateTimePicker DatePicker;
        internal TextBox TotalInstalmentsTB;
        internal TextBox KittyNoTB;
        internal Label LeftAmountLabel;
        internal ComboBox KittyIntrestCB;
        internal Label GivenAmountLabel;
        internal FontAwesome.Sharp.IconButton DeleteButton;
        internal FontAwesome.Sharp.IconButton AvailButton;
        internal FontAwesome.Sharp.IconPictureBox DotsButton;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem CrackThisKittyToolStripMenuItem;
        internal ToolStripMenuItem TransferKittyToolStripMenuItem;
        internal RichTextBox NotesTB;
        internal DataGridViewCheckBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Mode;
        internal ToolStripMenuItem MarkAsInactiveToolStripMenuItem;
    }
}
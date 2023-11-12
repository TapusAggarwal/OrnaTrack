using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MessageAndImageSender : Form
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
            var DataGridViewCellStyle17 = new DataGridViewCellStyle();
            var DataGridViewCellStyle18 = new DataGridViewCellStyle();
            var DataGridViewCellStyle19 = new DataGridViewCellStyle();
            var DataGridViewCellStyle20 = new DataGridViewCellStyle();
            var DataGridViewCellStyle21 = new DataGridViewCellStyle();
            var DataGridViewCellStyle22 = new DataGridViewCellStyle();
            var DataGridViewCellStyle23 = new DataGridViewCellStyle();
            var DataGridViewCellStyle24 = new DataGridViewCellStyle();
            var DataGridViewCellStyle25 = new DataGridViewCellStyle();
            var DataGridViewCellStyle26 = new DataGridViewCellStyle();
            var DataGridViewCellStyle27 = new DataGridViewCellStyle();
            var DataGridViewCellStyle28 = new DataGridViewCellStyle();
            var DataGridViewCellStyle29 = new DataGridViewCellStyle();
            var DataGridViewCellStyle30 = new DataGridViewCellStyle();
            var DataGridViewCellStyle31 = new DataGridViewCellStyle();
            var DataGridViewCellStyle32 = new DataGridViewCellStyle();
            Column10 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewButtonColumn1 = new DataGridViewCheckBoxColumn();
            MessageTB = new ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl();
            MessageTB.TextChanged += new EventHandler(MessageTB_TextChanged);
            Panel2 = new Panel();
            StrikeoutButton = new FontAwesome.Sharp.IconButton();
            UnderlinedButton = new FontAwesome.Sharp.IconButton();
            ItalicButton = new FontAwesome.Sharp.IconButton();
            BoldButton = new FontAwesome.Sharp.IconButton();
            ProfileLabel = new Label();
            Panel3 = new Panel();
            ToolTip1 = new ToolTip(components);
            ToolTipChB = new CheckBox();
            ToolTipChB.CheckedChanged += new EventHandler(ToolTipChB_CheckedChanged);
            MessagePanel = new Panel();
            CancelEditBT = new FontAwesome.Sharp.IconButton();
            EditBT = new FontAwesome.Sharp.IconButton();
            DeleteBT = new FontAwesome.Sharp.IconButton();
            SavedTemplatesBT = new FontAwesome.Sharp.IconButton();
            SavedTemplatesBT.Click += new EventHandler(SavedTemplatesBT_Click);
            ImageRemoveLB = new Label();
            AddImageBT = new FontAwesome.Sharp.IconButton();
            AddImageBT.Click += new EventHandler(AddImageBT_Click);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            AddMsgBT = new FontAwesome.Sharp.IconButton();
            AddMsgBT.Click += new EventHandler(AddMsgBT_Click);
            PreviewBT = new FontAwesome.Sharp.IconButton();
            PreviewBT.Click += new EventHandler(PreviewBT_Click);
            HandsCheckBox = new CheckBox();
            HandsCheckBox.CheckedChanged += new EventHandler(HandsCheckBox_CheckedChanged);
            GreetButton = new FontAwesome.Sharp.IconButton();
            GreetButton.Click += new EventHandler(GreetButton_Click);
            GreetButton.MouseHover += new EventHandler(GreetButton_MouseHover);
            InstCompletedButton = new FontAwesome.Sharp.IconButton();
            InstCompletedButton.Click += new EventHandler(InstCompletedButton_Click);
            InstCompletedButton.MouseHover += new EventHandler(InstCompletedButton_MouseHover);
            GivenAmountButton = new FontAwesome.Sharp.IconButton();
            GivenAmountButton.Click += new EventHandler(GivenAmountButton_Click);
            GivenAmountButton.MouseHover += new EventHandler(GivenAmountButton_MouseHover);
            PendingAmountButton = new FontAwesome.Sharp.IconButton();
            PendingAmountButton.Click += new EventHandler(PendingAmountButton_Click);
            PendingAmountButton.MouseHover += new EventHandler(PendingAmountButton_MouseHover);
            PendingMonthButton = new FontAwesome.Sharp.IconButton();
            PendingMonthButton.Click += new EventHandler(PendingMonthButton_Click);
            PendingMonthButton.MouseHover += new EventHandler(PendingMonthButton_MouseHover);
            KittyNoButton = new FontAwesome.Sharp.IconButton();
            KittyNoButton.Click += new EventHandler(KittyNoButton_Click);
            KittyNoButton.MouseHover += new EventHandler(KittyNoButton_MouseHover);
            CompMonthButton = new FontAwesome.Sharp.IconButton();
            CompMonthButton.Click += new EventHandler(CompMonthButton_Click);
            CompMonthButton.MouseHover += new EventHandler(CompMonthButton_MouseHover);
            KittyTypeButton = new FontAwesome.Sharp.IconButton();
            KittyTypeButton.Click += new EventHandler(KittyTypeButton_Click);
            KittyTypeButton.MouseHover += new EventHandler(KittyTypeButton_MouseHover);
            PendingInstButton = new FontAwesome.Sharp.IconButton();
            PendingInstButton.Click += new EventHandler(PendingInstButton_Click);
            PendingInstButton.MouseHover += new EventHandler(PendingInstButton_MouseHover);
            PhNoButton = new FontAwesome.Sharp.IconButton();
            PhNoButton.Click += new EventHandler(PhNo_Click);
            PhNoButton.MouseHover += new EventHandler(PhNoButton_MouseHover);
            CoustNameButton = new FontAwesome.Sharp.IconButton();
            CoustNameButton.Click += new EventHandler(CoustNameButton_Click);
            CoustNameButton.MouseHover += new EventHandler(CoustNameButton_MouseHover);
            SendBT = new FontAwesome.Sharp.IconButton();
            SendBT.Click += new EventHandler(SendBT_Click);
            ImagePanel = new FlowLayoutPanel();
            ImageFirstChB = new CheckBox();
            ImageFirstChB.CheckedChanged += new EventHandler(ImageFirstChB_CheckedChanged);
            Panel2.SuspendLayout();
            MessagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // Column10
            // 
            Column10.Frozen = true;
            Column10.HeaderText = "";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Resizable = DataGridViewTriState.False;
            Column10.Width = 27;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle17.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle17.NullValue = null;
            DataGridViewCellStyle17.SelectionBackColor = Color.White;
            DataGridViewCellStyle17.SelectionForeColor = Color.Black;
            Column1.DefaultCellStyle = DataGridViewCellStyle17;
            Column1.Frozen = true;
            Column1.HeaderText = "SrNo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 63;
            // 
            // Column9
            // 
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle18.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Column9.DefaultCellStyle = DataGridViewCellStyle18;
            Column9.Frozen = true;
            Column9.HeaderText = "KittyNo";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column9.Width = 91;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle19.BackColor = Color.White;
            DataGridViewCellStyle19.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Column5.DefaultCellStyle = DataGridViewCellStyle19;
            Column5.Frozen = true;
            Column5.HeaderText = "KittyType";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 113;
            // 
            // Column2
            // 
            DataGridViewCellStyle20.Font = new Font("Century Schoolbook", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle20.Format = "d";
            DataGridViewCellStyle20.NullValue = null;
            DataGridViewCellStyle20.SelectionBackColor = Color.White;
            DataGridViewCellStyle20.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = DataGridViewCellStyle20;
            Column2.Frozen = true;
            Column2.HeaderText = "Last Installment";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 204;
            // 
            // Column6
            // 
            DataGridViewCellStyle21.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle21.ForeColor = Color.Red;
            Column6.DefaultCellStyle = DataGridViewCellStyle21;
            Column6.Frozen = true;
            Column6.HeaderText = "Given Amt.";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 161;
            // 
            // Column4
            // 
            DataGridViewCellStyle22.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle22.NullValue = null;
            Column4.DefaultCellStyle = DataGridViewCellStyle22;
            Column4.Frozen = true;
            Column4.HeaderText = "Total Amt+Intrst";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 206;
            // 
            // Status
            // 
            DataGridViewCellStyle23.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.DefaultCellStyle = DataGridViewCellStyle23;
            Status.Frozen = true;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 140;
            // 
            // Column7
            // 
            DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle24.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle24.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle24.ForeColor = Color.White;
            DataGridViewCellStyle24.SelectionBackColor = Color.ForestGreen;
            Column7.DefaultCellStyle = DataGridViewCellStyle24;
            Column7.Frozen = true;
            Column7.HeaderText = "Show Details";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Text = "Show Details";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 145;
            // 
            // Column8
            // 
            Column8.Frozen = true;
            Column8.HeaderText = "KittyID";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            Column8.Width = 119;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.HeaderText = "KittyID";
            DataGridViewTextBoxColumn8.MinimumWidth = 8;
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.ReadOnly = true;
            DataGridViewTextBoxColumn8.Visible = false;
            DataGridViewTextBoxColumn8.Width = 119;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            DataGridViewCheckBoxColumn1.Frozen = true;
            DataGridViewCheckBoxColumn1.HeaderText = "";
            DataGridViewCheckBoxColumn1.MinimumWidth = 8;
            DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            DataGridViewCheckBoxColumn1.ReadOnly = true;
            DataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.False;
            DataGridViewCheckBoxColumn1.Width = 27;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle25.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle25.NullValue = null;
            DataGridViewCellStyle25.SelectionBackColor = Color.White;
            DataGridViewCellStyle25.SelectionForeColor = Color.Black;
            DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle25;
            DataGridViewTextBoxColumn1.HeaderText = "SrNo";
            DataGridViewTextBoxColumn1.MinimumWidth = 8;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            DataGridViewTextBoxColumn1.Width = 63;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle26.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle26;
            DataGridViewTextBoxColumn2.HeaderText = "KittyNo";
            DataGridViewTextBoxColumn2.MinimumWidth = 8;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewTextBoxColumn2.Width = 91;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle27.BackColor = Color.White;
            DataGridViewCellStyle27.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle27;
            DataGridViewTextBoxColumn3.HeaderText = "KittyType";
            DataGridViewTextBoxColumn3.MinimumWidth = 8;
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Width = 113;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewCellStyle28.Font = new Font("Century Schoolbook", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle28.Format = "d";
            DataGridViewCellStyle28.NullValue = null;
            DataGridViewCellStyle28.SelectionBackColor = Color.White;
            DataGridViewCellStyle28.SelectionForeColor = Color.Black;
            DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle28;
            DataGridViewTextBoxColumn4.HeaderText = "Last Installment";
            DataGridViewTextBoxColumn4.MinimumWidth = 8;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Width = 204;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewCellStyle29.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle29.ForeColor = Color.Red;
            DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle29;
            DataGridViewTextBoxColumn5.HeaderText = "Given Amt.";
            DataGridViewTextBoxColumn5.MinimumWidth = 8;
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            DataGridViewTextBoxColumn5.Width = 161;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewCellStyle30.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle30.NullValue = null;
            DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle30;
            DataGridViewTextBoxColumn6.HeaderText = "Total Amt+Intrst";
            DataGridViewTextBoxColumn6.MinimumWidth = 8;
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            DataGridViewTextBoxColumn6.Width = 206;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewCellStyle31.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle31;
            DataGridViewTextBoxColumn7.HeaderText = "Status";
            DataGridViewTextBoxColumn7.MinimumWidth = 8;
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            DataGridViewTextBoxColumn7.Width = 140;
            // 
            // DataGridViewButtonColumn1
            // 
            DataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle32.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle32.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle32.ForeColor = Color.White;
            DataGridViewCellStyle32.NullValue = false;
            DataGridViewCellStyle32.SelectionBackColor = Color.ForestGreen;
            DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle32;
            DataGridViewButtonColumn1.HeaderText = "";
            DataGridViewButtonColumn1.MinimumWidth = 8;
            DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1";
            DataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            DataGridViewButtonColumn1.Width = 27;
            // 
            // MessageTB
            // 
            MessageTB.AutoWordSelection = true;
            MessageTB.BackColor = Color.Lavender;
            MessageTB.Font = new Font("Century Schoolbook", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageTB.Location = new Point(10, 190);
            MessageTB.Name = "MessageTB";
            MessageTB.Size = new Size(554, 324);
            MessageTB.TabIndex = 260;
            MessageTB.Text = "";
            MessageTB.ZoomFactor = 0.6f;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(36, 20, 55);
            Panel2.Controls.Add(StrikeoutButton);
            Panel2.Controls.Add(UnderlinedButton);
            Panel2.Controls.Add(ItalicButton);
            Panel2.Controls.Add(BoldButton);
            Panel2.Location = new Point(632, 221);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(54, 217);
            Panel2.TabIndex = 267;
            Panel2.Visible = false;
            // 
            // StrikeoutButton
            // 
            StrikeoutButton.BackColor = Color.Transparent;
            StrikeoutButton.FlatAppearance.BorderSize = 0;
            StrikeoutButton.FlatAppearance.MouseDownBackColor = Color.Wheat;
            StrikeoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 30, 70);
            StrikeoutButton.FlatStyle = FlatStyle.Flat;
            StrikeoutButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            StrikeoutButton.ForeColor = Color.MediumPurple;
            StrikeoutButton.IconChar = FontAwesome.Sharp.IconChar.Strikethrough;
            StrikeoutButton.IconColor = Color.MediumSlateBlue;
            StrikeoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StrikeoutButton.IconSize = 35;
            StrikeoutButton.Location = new Point(7, 170);
            StrikeoutButton.Margin = new Padding(4, 5, 4, 5);
            StrikeoutButton.Name = "StrikeoutButton";
            StrikeoutButton.Size = new Size(37, 44);
            StrikeoutButton.TabIndex = 270;
            StrikeoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            StrikeoutButton.UseVisualStyleBackColor = false;
            // 
            // UnderlinedButton
            // 
            UnderlinedButton.BackColor = Color.Transparent;
            UnderlinedButton.FlatAppearance.BorderSize = 0;
            UnderlinedButton.FlatAppearance.MouseDownBackColor = Color.Wheat;
            UnderlinedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 30, 70);
            UnderlinedButton.FlatStyle = FlatStyle.Flat;
            UnderlinedButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnderlinedButton.ForeColor = Color.MediumPurple;
            UnderlinedButton.IconChar = FontAwesome.Sharp.IconChar.MediumM;
            UnderlinedButton.IconColor = Color.MediumSlateBlue;
            UnderlinedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UnderlinedButton.IconSize = 35;
            UnderlinedButton.Location = new Point(7, 119);
            UnderlinedButton.Margin = new Padding(4, 5, 4, 5);
            UnderlinedButton.Name = "UnderlinedButton";
            UnderlinedButton.Size = new Size(37, 44);
            UnderlinedButton.TabIndex = 269;
            UnderlinedButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            UnderlinedButton.UseVisualStyleBackColor = false;
            // 
            // ItalicButton
            // 
            ItalicButton.BackColor = Color.Transparent;
            ItalicButton.FlatAppearance.BorderSize = 0;
            ItalicButton.FlatAppearance.MouseDownBackColor = Color.Wheat;
            ItalicButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 30, 70);
            ItalicButton.FlatStyle = FlatStyle.Flat;
            ItalicButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItalicButton.ForeColor = Color.MediumPurple;
            ItalicButton.IconChar = FontAwesome.Sharp.IconChar.Italic;
            ItalicButton.IconColor = Color.MediumSlateBlue;
            ItalicButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItalicButton.IconSize = 35;
            ItalicButton.Location = new Point(7, 65);
            ItalicButton.Margin = new Padding(4, 5, 4, 5);
            ItalicButton.Name = "ItalicButton";
            ItalicButton.Size = new Size(37, 44);
            ItalicButton.TabIndex = 268;
            ItalicButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ItalicButton.UseVisualStyleBackColor = false;
            // 
            // BoldButton
            // 
            BoldButton.BackColor = Color.Transparent;
            BoldButton.FlatAppearance.BorderSize = 0;
            BoldButton.FlatAppearance.MouseDownBackColor = Color.Wheat;
            BoldButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 30, 70);
            BoldButton.FlatStyle = FlatStyle.Flat;
            BoldButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoldButton.ForeColor = Color.MediumPurple;
            BoldButton.IconChar = FontAwesome.Sharp.IconChar.Bold;
            BoldButton.IconColor = Color.MediumSlateBlue;
            BoldButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BoldButton.IconSize = 35;
            BoldButton.Location = new Point(7, 11);
            BoldButton.Margin = new Padding(4, 5, 4, 5);
            BoldButton.Name = "BoldButton";
            BoldButton.Size = new Size(37, 44);
            BoldButton.TabIndex = 267;
            BoldButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BoldButton.UseVisualStyleBackColor = false;
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.BackColor = Color.FromArgb(36, 30, 60);
            ProfileLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileLabel.ForeColor = SystemColors.ActiveCaption;
            ProfileLabel.Location = new Point(33, 524);
            ProfileLabel.Margin = new Padding(4, 0, 4, 0);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(130, 30);
            ProfileLabel.TabIndex = 273;
            ProfileLabel.Text = "Messages";
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Location = new Point(10, 543);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(554, 3);
            Panel3.TabIndex = 274;
            // 
            // ToolTip1
            // 
            ToolTip1.AutoPopDelay = 3000;
            ToolTip1.InitialDelay = 500;
            ToolTip1.ReshowDelay = 100;
            // 
            // ToolTipChB
            // 
            ToolTipChB.AutoSize = true;
            ToolTipChB.Location = new Point(717, 190);
            ToolTipChB.Name = "ToolTipChB";
            ToolTipChB.Size = new Size(22, 21);
            ToolTipChB.TabIndex = 290;
            ToolTipChB.UseVisualStyleBackColor = true;
            // 
            // MessagePanel
            // 
            MessagePanel.Controls.Add(ImageFirstChB);
            MessagePanel.Controls.Add(CancelEditBT);
            MessagePanel.Controls.Add(EditBT);
            MessagePanel.Controls.Add(DeleteBT);
            MessagePanel.Controls.Add(SavedTemplatesBT);
            MessagePanel.Controls.Add(ImageRemoveLB);
            MessagePanel.Controls.Add(AddImageBT);
            MessagePanel.Controls.Add(FlowLayoutPanel1);
            MessagePanel.Controls.Add(AddMsgBT);
            MessagePanel.Controls.Add(PreviewBT);
            MessagePanel.Controls.Add(HandsCheckBox);
            MessagePanel.Controls.Add(GreetButton);
            MessagePanel.Controls.Add(ProfileLabel);
            MessagePanel.Controls.Add(ToolTipChB);
            MessagePanel.Controls.Add(MessageTB);
            MessagePanel.Controls.Add(InstCompletedButton);
            MessagePanel.Controls.Add(GivenAmountButton);
            MessagePanel.Controls.Add(PendingAmountButton);
            MessagePanel.Controls.Add(PendingMonthButton);
            MessagePanel.Controls.Add(Panel2);
            MessagePanel.Controls.Add(KittyNoButton);
            MessagePanel.Controls.Add(CompMonthButton);
            MessagePanel.Controls.Add(Panel3);
            MessagePanel.Controls.Add(KittyTypeButton);
            MessagePanel.Controls.Add(PendingInstButton);
            MessagePanel.Controls.Add(PhNoButton);
            MessagePanel.Controls.Add(CoustNameButton);
            MessagePanel.Controls.Add(SendBT);
            MessagePanel.Dock = DockStyle.Right;
            MessagePanel.Location = new Point(319, 0);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(760, 933);
            MessagePanel.TabIndex = 291;
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
            CancelEditBT.Location = new Point(563, 702);
            CancelEditBT.Margin = new Padding(4, 5, 4, 5);
            CancelEditBT.Name = "CancelEditBT";
            CancelEditBT.Size = new Size(45, 44);
            CancelEditBT.TabIndex = 10037;
            CancelEditBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelEditBT.UseVisualStyleBackColor = false;
            CancelEditBT.Visible = false;
            // 
            // EditBT
            // 
            EditBT.BackColor = Color.Maroon;
            EditBT.FlatAppearance.BorderSize = 0;
            EditBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            EditBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            EditBT.FlatStyle = FlatStyle.Flat;
            EditBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBT.ForeColor = Color.Linen;
            EditBT.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            EditBT.IconColor = Color.White;
            EditBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditBT.IconSize = 36;
            EditBT.Location = new Point(563, 594);
            EditBT.Margin = new Padding(4, 5, 4, 5);
            EditBT.Name = "EditBT";
            EditBT.Size = new Size(45, 44);
            EditBT.TabIndex = 10036;
            EditBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditBT.UseVisualStyleBackColor = false;
            EditBT.Visible = false;
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
            DeleteBT.Location = new Point(563, 648);
            DeleteBT.Margin = new Padding(4, 5, 4, 5);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(45, 44);
            DeleteBT.TabIndex = 10038;
            DeleteBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteBT.UseVisualStyleBackColor = false;
            DeleteBT.Visible = false;
            // 
            // SavedTemplatesBT
            // 
            SavedTemplatesBT.BackColor = Color.FromArgb(0, 64, 0);
            SavedTemplatesBT.FlatAppearance.BorderSize = 0;
            SavedTemplatesBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            SavedTemplatesBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SavedTemplatesBT.FlatStyle = FlatStyle.Flat;
            SavedTemplatesBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SavedTemplatesBT.ForeColor = Color.Linen;
            SavedTemplatesBT.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            SavedTemplatesBT.IconColor = Color.White;
            SavedTemplatesBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SavedTemplatesBT.IconSize = 36;
            SavedTemplatesBT.Location = new Point(666, 445);
            SavedTemplatesBT.Margin = new Padding(4, 5, 4, 5);
            SavedTemplatesBT.Name = "SavedTemplatesBT";
            SavedTemplatesBT.Size = new Size(72, 44);
            SavedTemplatesBT.TabIndex = 10007;
            SavedTemplatesBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SavedTemplatesBT.UseVisualStyleBackColor = false;
            // 
            // ImageRemoveLB
            // 
            ImageRemoveLB.BackColor = Color.Transparent;
            ImageRemoveLB.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ImageRemoveLB.ForeColor = Color.IndianRed;
            ImageRemoveLB.Location = new Point(571, 763);
            ImageRemoveLB.Margin = new Padding(4, 0, 4, 0);
            ImageRemoveLB.Name = "ImageRemoveLB";
            ImageRemoveLB.Size = new Size(175, 57);
            ImageRemoveLB.TabIndex = 10006;
            ImageRemoveLB.Text = "Double Tap To Remove 'Image'";
            ImageRemoveLB.TextAlign = ContentAlignment.MiddleCenter;
            ImageRemoveLB.Visible = false;
            // 
            // AddImageBT
            // 
            AddImageBT.BackColor = Color.FromArgb(0, 64, 0);
            AddImageBT.FlatAppearance.BorderSize = 0;
            AddImageBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            AddImageBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            AddImageBT.FlatStyle = FlatStyle.Flat;
            AddImageBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddImageBT.ForeColor = Color.Linen;
            AddImageBT.IconChar = FontAwesome.Sharp.IconChar.Images;
            AddImageBT.IconColor = Color.White;
            AddImageBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddImageBT.IconSize = 36;
            AddImageBT.Location = new Point(579, 873);
            AddImageBT.Margin = new Padding(4, 5, 4, 5);
            AddImageBT.Name = "AddImageBT";
            AddImageBT.Size = new Size(167, 44);
            AddImageBT.TabIndex = 9998;
            AddImageBT.Text = "Image";
            AddImageBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddImageBT.UseVisualStyleBackColor = false;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(8, 561);
            FlowLayoutPanel1.Margin = new Padding(1000);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(554, 356);
            FlowLayoutPanel1.TabIndex = 9996;
            // 
            // AddMsgBT
            // 
            AddMsgBT.BackColor = Color.FromArgb(0, 64, 0);
            AddMsgBT.FlatAppearance.BorderSize = 0;
            AddMsgBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            AddMsgBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            AddMsgBT.FlatStyle = FlatStyle.Flat;
            AddMsgBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMsgBT.ForeColor = Color.Linen;
            AddMsgBT.IconChar = FontAwesome.Sharp.IconChar.Plus;
            AddMsgBT.IconColor = Color.White;
            AddMsgBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddMsgBT.IconSize = 36;
            AddMsgBT.Location = new Point(586, 445);
            AddMsgBT.Margin = new Padding(4, 5, 4, 5);
            AddMsgBT.Name = "AddMsgBT";
            AddMsgBT.Size = new Size(72, 44);
            AddMsgBT.TabIndex = 9995;
            AddMsgBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddMsgBT.UseVisualStyleBackColor = false;
            // 
            // PreviewBT
            // 
            PreviewBT.AutoSize = true;
            PreviewBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PreviewBT.BackColor = Color.FromArgb(0, 64, 0);
            PreviewBT.FlatAppearance.BorderSize = 0;
            PreviewBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            PreviewBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            PreviewBT.FlatStyle = FlatStyle.Flat;
            PreviewBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviewBT.ForeColor = Color.Linen;
            PreviewBT.IconChar = FontAwesome.Sharp.IconChar.Paragraph;
            PreviewBT.IconColor = Color.White;
            PreviewBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PreviewBT.IconSize = 36;
            PreviewBT.Location = new Point(579, 499);
            PreviewBT.Margin = new Padding(4, 5, 4, 5);
            PreviewBT.Name = "PreviewBT";
            PreviewBT.Size = new Size(167, 44);
            PreviewBT.TabIndex = 9993;
            PreviewBT.Text = "Preview";
            PreviewBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            PreviewBT.UseVisualStyleBackColor = false;
            // 
            // HandsCheckBox
            // 
            HandsCheckBox.AutoSize = true;
            HandsCheckBox.Checked = true;
            HandsCheckBox.CheckState = CheckState.Checked;
            HandsCheckBox.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            HandsCheckBox.ForeColor = Color.Orange;
            HandsCheckBox.Location = new Point(586, 555);
            HandsCheckBox.Margin = new Padding(4, 5, 4, 5);
            HandsCheckBox.Name = "HandsCheckBox";
            HandsCheckBox.Size = new Size(153, 27);
            HandsCheckBox.TabIndex = 9992;
            HandsCheckBox.Text = "Hands Emoji";
            HandsCheckBox.UseVisualStyleBackColor = true;
            // 
            // GreetButton
            // 
            GreetButton.AutoSize = true;
            GreetButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GreetButton.BackColor = Color.FromArgb(25, 25, 70);
            GreetButton.FlatAppearance.BorderSize = 0;
            GreetButton.FlatStyle = FlatStyle.Flat;
            GreetButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GreetButton.ForeColor = Color.MediumPurple;
            GreetButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            GreetButton.IconColor = Color.White;
            GreetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            GreetButton.IconSize = 30;
            GreetButton.Location = new Point(11, 18);
            GreetButton.Margin = new Padding(4, 5, 4, 5);
            GreetButton.Name = "GreetButton";
            GreetButton.Size = new Size(117, 37);
            GreetButton.TabIndex = 291;
            GreetButton.Text = "Greet";
            GreetButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            GreetButton.UseVisualStyleBackColor = false;
            // 
            // InstCompletedButton
            // 
            InstCompletedButton.AutoSize = true;
            InstCompletedButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InstCompletedButton.BackColor = Color.FromArgb(25, 25, 70);
            InstCompletedButton.FlatAppearance.BorderSize = 0;
            InstCompletedButton.FlatStyle = FlatStyle.Flat;
            InstCompletedButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            InstCompletedButton.ForeColor = Color.MediumPurple;
            InstCompletedButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            InstCompletedButton.IconColor = Color.White;
            InstCompletedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            InstCompletedButton.IconSize = 40;
            InstCompletedButton.Location = new Point(6, 70);
            InstCompletedButton.Margin = new Padding(4, 5, 4, 5);
            InstCompletedButton.Name = "InstCompletedButton";
            InstCompletedButton.Size = new Size(237, 46);
            InstCompletedButton.TabIndex = 288;
            InstCompletedButton.Text = "Inst Completed";
            InstCompletedButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            InstCompletedButton.UseVisualStyleBackColor = false;
            // 
            // GivenAmountButton
            // 
            GivenAmountButton.AutoSize = true;
            GivenAmountButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GivenAmountButton.BackColor = Color.FromArgb(25, 25, 70);
            GivenAmountButton.FlatAppearance.BorderSize = 0;
            GivenAmountButton.FlatStyle = FlatStyle.Flat;
            GivenAmountButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GivenAmountButton.ForeColor = Color.MediumPurple;
            GivenAmountButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            GivenAmountButton.IconColor = Color.White;
            GivenAmountButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            GivenAmountButton.IconSize = 40;
            GivenAmountButton.Location = new Point(526, 70);
            GivenAmountButton.Margin = new Padding(4, 5, 4, 5);
            GivenAmountButton.Name = "GivenAmountButton";
            GivenAmountButton.Size = new Size(228, 46);
            GivenAmountButton.TabIndex = 287;
            GivenAmountButton.Text = "Given Amount";
            GivenAmountButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            GivenAmountButton.UseVisualStyleBackColor = false;
            // 
            // PendingAmountButton
            // 
            PendingAmountButton.AutoSize = true;
            PendingAmountButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PendingAmountButton.BackColor = Color.FromArgb(25, 25, 70);
            PendingAmountButton.FlatAppearance.BorderSize = 0;
            PendingAmountButton.FlatStyle = FlatStyle.Flat;
            PendingAmountButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PendingAmountButton.ForeColor = Color.MediumPurple;
            PendingAmountButton.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            PendingAmountButton.IconColor = Color.White;
            PendingAmountButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PendingAmountButton.IconSize = 40;
            PendingAmountButton.Location = new Point(497, 132);
            PendingAmountButton.Margin = new Padding(4, 5, 4, 5);
            PendingAmountButton.Name = "PendingAmountButton";
            PendingAmountButton.Size = new Size(252, 46);
            PendingAmountButton.TabIndex = 286;
            PendingAmountButton.Text = "Pending Amount";
            PendingAmountButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PendingAmountButton.UseVisualStyleBackColor = false;
            // 
            // PendingMonthButton
            // 
            PendingMonthButton.AutoSize = true;
            PendingMonthButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PendingMonthButton.BackColor = Color.FromArgb(25, 25, 70);
            PendingMonthButton.FlatAppearance.BorderSize = 0;
            PendingMonthButton.FlatStyle = FlatStyle.Flat;
            PendingMonthButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PendingMonthButton.ForeColor = Color.MediumPurple;
            PendingMonthButton.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            PendingMonthButton.IconColor = Color.White;
            PendingMonthButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PendingMonthButton.IconSize = 40;
            PendingMonthButton.Location = new Point(226, 132);
            PendingMonthButton.Margin = new Padding(4, 5, 4, 5);
            PendingMonthButton.Name = "PendingMonthButton";
            PendingMonthButton.Size = new Size(254, 46);
            PendingMonthButton.TabIndex = 285;
            PendingMonthButton.Text = "Inst-Pend.-Month";
            PendingMonthButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PendingMonthButton.UseVisualStyleBackColor = false;
            // 
            // KittyNoButton
            // 
            KittyNoButton.AutoSize = true;
            KittyNoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            KittyNoButton.BackColor = Color.FromArgb(25, 25, 70);
            KittyNoButton.FlatAppearance.BorderSize = 0;
            KittyNoButton.FlatStyle = FlatStyle.Flat;
            KittyNoButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            KittyNoButton.ForeColor = Color.MediumPurple;
            KittyNoButton.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            KittyNoButton.IconColor = Color.White;
            KittyNoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            KittyNoButton.IconSize = 30;
            KittyNoButton.Location = new Point(615, 18);
            KittyNoButton.Margin = new Padding(4, 5, 4, 5);
            KittyNoButton.Name = "KittyNoButton";
            KittyNoButton.Size = new Size(133, 37);
            KittyNoButton.TabIndex = 283;
            KittyNoButton.Text = "KittyNo";
            KittyNoButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            KittyNoButton.UseVisualStyleBackColor = false;
            // 
            // CompMonthButton
            // 
            CompMonthButton.AutoSize = true;
            CompMonthButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CompMonthButton.BackColor = Color.FromArgb(25, 25, 70);
            CompMonthButton.FlatAppearance.BorderSize = 0;
            CompMonthButton.FlatStyle = FlatStyle.Flat;
            CompMonthButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompMonthButton.ForeColor = Color.MediumPurple;
            CompMonthButton.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            CompMonthButton.IconColor = Color.White;
            CompMonthButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CompMonthButton.IconSize = 40;
            CompMonthButton.Location = new Point(251, 70);
            CompMonthButton.Margin = new Padding(4, 5, 4, 5);
            CompMonthButton.Name = "CompMonthButton";
            CompMonthButton.Size = new Size(267, 46);
            CompMonthButton.TabIndex = 282;
            CompMonthButton.Text = "Inst-Comp.-Month";
            CompMonthButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CompMonthButton.UseVisualStyleBackColor = false;
            // 
            // KittyTypeButton
            // 
            KittyTypeButton.AutoSize = true;
            KittyTypeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            KittyTypeButton.BackColor = Color.FromArgb(25, 25, 70);
            KittyTypeButton.FlatAppearance.BorderSize = 0;
            KittyTypeButton.FlatStyle = FlatStyle.Flat;
            KittyTypeButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            KittyTypeButton.ForeColor = Color.MediumPurple;
            KittyTypeButton.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            KittyTypeButton.IconColor = Color.White;
            KittyTypeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            KittyTypeButton.IconSize = 30;
            KittyTypeButton.Location = new Point(448, 18);
            KittyTypeButton.Margin = new Padding(4, 5, 4, 5);
            KittyTypeButton.Name = "KittyTypeButton";
            KittyTypeButton.Size = new Size(162, 37);
            KittyTypeButton.TabIndex = 280;
            KittyTypeButton.Text = "Kitty Type";
            KittyTypeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            KittyTypeButton.UseVisualStyleBackColor = false;
            // 
            // PendingInstButton
            // 
            PendingInstButton.AutoSize = true;
            PendingInstButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PendingInstButton.BackColor = Color.FromArgb(25, 25, 70);
            PendingInstButton.FlatAppearance.BorderSize = 0;
            PendingInstButton.FlatStyle = FlatStyle.Flat;
            PendingInstButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PendingInstButton.ForeColor = Color.MediumPurple;
            PendingInstButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            PendingInstButton.IconColor = Color.White;
            PendingInstButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PendingInstButton.IconSize = 40;
            PendingInstButton.Location = new Point(10, 132);
            PendingInstButton.Margin = new Padding(4, 5, 4, 5);
            PendingInstButton.Name = "PendingInstButton";
            PendingInstButton.Size = new Size(199, 46);
            PendingInstButton.TabIndex = 278;
            PendingInstButton.Text = "Inst Pending";
            PendingInstButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PendingInstButton.UseVisualStyleBackColor = false;
            // 
            // PhNoButton
            // 
            PhNoButton.AutoSize = true;
            PhNoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PhNoButton.BackColor = Color.FromArgb(25, 25, 70);
            PhNoButton.FlatAppearance.BorderSize = 0;
            PhNoButton.FlatStyle = FlatStyle.Flat;
            PhNoButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhNoButton.ForeColor = Color.MediumPurple;
            PhNoButton.IconChar = FontAwesome.Sharp.IconChar.PhoneSquareAlt;
            PhNoButton.IconColor = Color.White;
            PhNoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PhNoButton.IconSize = 30;
            PhNoButton.Location = new Point(331, 18);
            PhNoButton.Margin = new Padding(4, 5, 4, 5);
            PhNoButton.Name = "PhNoButton";
            PhNoButton.Size = new Size(112, 37);
            PhNoButton.TabIndex = 277;
            PhNoButton.Text = "PhNo" + '\r' + '\n';
            PhNoButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PhNoButton.UseVisualStyleBackColor = false;
            // 
            // CoustNameButton
            // 
            CoustNameButton.AutoSize = true;
            CoustNameButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CoustNameButton.BackColor = Color.FromArgb(25, 25, 70);
            CoustNameButton.FlatAppearance.BorderSize = 0;
            CoustNameButton.FlatStyle = FlatStyle.Flat;
            CoustNameButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoustNameButton.ForeColor = Color.MediumPurple;
            CoustNameButton.IconChar = FontAwesome.Sharp.IconChar.Signature;
            CoustNameButton.IconColor = Color.White;
            CoustNameButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CoustNameButton.IconSize = 30;
            CoustNameButton.Location = new Point(133, 18);
            CoustNameButton.Margin = new Padding(4, 5, 4, 5);
            CoustNameButton.Name = "CoustNameButton";
            CoustNameButton.Size = new Size(193, 37);
            CoustNameButton.TabIndex = 276;
            CoustNameButton.Text = "Coust Name";
            CoustNameButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CoustNameButton.UseVisualStyleBackColor = false;
            // 
            // SendBT
            // 
            SendBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendBT.BackColor = Color.FromArgb(0, 64, 0);
            SendBT.FlatAppearance.BorderSize = 0;
            SendBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            SendBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SendBT.FlatStyle = FlatStyle.Flat;
            SendBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBT.ForeColor = Color.Linen;
            SendBT.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            SendBT.IconColor = Color.White;
            SendBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SendBT.IconSize = 36;
            SendBT.Location = new Point(579, 499);
            SendBT.Margin = new Padding(4, 5, 4, 5);
            SendBT.Name = "SendBT";
            SendBT.Size = new Size(167, 44);
            SendBT.TabIndex = 10039;
            SendBT.Text = "Send";
            SendBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SendBT.UseVisualStyleBackColor = false;
            SendBT.Visible = false;
            // 
            // ImagePanel
            // 
            ImagePanel.AutoScroll = true;
            ImagePanel.Dock = DockStyle.Left;
            ImagePanel.Location = new Point(0, 0);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(320, 933);
            ImagePanel.TabIndex = 292;
            // 
            // ImageFirstChB
            // 
            ImageFirstChB.AutoSize = true;
            ImageFirstChB.Checked = true;
            ImageFirstChB.CheckState = CheckState.Checked;
            ImageFirstChB.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImageFirstChB.ForeColor = Color.Orange;
            ImageFirstChB.Location = new Point(585, 836);
            ImageFirstChB.Margin = new Padding(4, 5, 4, 5);
            ImageFirstChB.Name = "ImageFirstChB";
            ImageFirstChB.Size = new Size(140, 27);
            ImageFirstChB.TabIndex = 10040;
            ImageFirstChB.Text = "Image First";
            ImageFirstChB.UseVisualStyleBackColor = true;
            // 
            // MessageSender
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1079, 933);
            Controls.Add(ImagePanel);
            Controls.Add(MessagePanel);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(593, 933);
            Name = "MessageSender";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            Panel2.ResumeLayout(false);
            MessagePanel.ResumeLayout(false);
            MessagePanel.PerformLayout();
            Load += new EventHandler(MessageSender_Load);
            ResumeLayout(false);

        }
        internal DataGridViewCheckBoxColumn Column10;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Status;
        internal DataGridViewButtonColumn Column7;
        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewCheckBoxColumn DataGridViewButtonColumn1;
        internal ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl MessageTB;
        internal Panel Panel2;
        internal FontAwesome.Sharp.IconButton StrikeoutButton;
        internal FontAwesome.Sharp.IconButton UnderlinedButton;
        internal FontAwesome.Sharp.IconButton ItalicButton;
        internal FontAwesome.Sharp.IconButton BoldButton;
        internal Label ProfileLabel;
        internal Panel Panel3;
        internal FontAwesome.Sharp.IconButton PendingInstButton;
        internal FontAwesome.Sharp.IconButton PhNoButton;
        internal FontAwesome.Sharp.IconButton CoustNameButton;
        internal FontAwesome.Sharp.IconButton KittyNoButton;
        internal FontAwesome.Sharp.IconButton KittyTypeButton;
        internal ToolTip ToolTip1;
        internal FontAwesome.Sharp.IconButton PendingMonthButton;
        internal FontAwesome.Sharp.IconButton PendingAmountButton;
        internal FontAwesome.Sharp.IconButton GivenAmountButton;
        internal FontAwesome.Sharp.IconButton CompMonthButton;
        internal FontAwesome.Sharp.IconButton InstCompletedButton;
        internal CheckBox ToolTipChB;
        internal Panel MessagePanel;
        internal FontAwesome.Sharp.IconButton GreetButton;
        internal CheckBox HandsCheckBox;
        internal FontAwesome.Sharp.IconButton PreviewBT;
        internal FontAwesome.Sharp.IconButton AddMsgBT;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FlowLayoutPanel ImagePanel;
        internal FontAwesome.Sharp.IconButton AddImageBT;
        private Label ImageRemoveLB;
        internal FontAwesome.Sharp.IconButton SavedTemplatesBT;
        internal FontAwesome.Sharp.IconButton CancelEditBT;
        internal FontAwesome.Sharp.IconButton EditBT;
        internal FontAwesome.Sharp.IconButton DeleteBT;
        internal FontAwesome.Sharp.IconButton SendBT;
        internal CheckBox ImageFirstChB;
    }
}
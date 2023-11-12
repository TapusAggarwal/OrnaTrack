using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MessageTemplates : Form
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
            Panel3 = new Panel();
            ProfileLabel = new Label();
            HandsCheckBox = new CheckBox();
            HandsCheckBox.CheckedChanged += new EventHandler(HandsCheckBox_CheckedChanged);
            ToolTipChB = new CheckBox();
            MessageTB = new ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl();
            MessageTB.TextChanged += new EventHandler(MessageTB_TextChanged);
            Panel2 = new Panel();
            StrikeoutButton = new FontAwesome.Sharp.IconButton();
            UnderlinedButton = new FontAwesome.Sharp.IconButton();
            ItalicButton = new FontAwesome.Sharp.IconButton();
            BoldButton = new FontAwesome.Sharp.IconButton();
            AddMsgBT = new FontAwesome.Sharp.IconButton();
            AddMsgBT.Click += new EventHandler(AddMsgBT_Click);
            CancelEditBT = new FontAwesome.Sharp.IconButton();
            EditBT = new FontAwesome.Sharp.IconButton();
            SelectMsgBT = new FontAwesome.Sharp.IconButton();
            SelectMsgBT.Click += new EventHandler(SelectMsgBT_Click);
            GreetButton = new FontAwesome.Sharp.IconButton();
            InstCompletedButton = new FontAwesome.Sharp.IconButton();
            GivenAmountButton = new FontAwesome.Sharp.IconButton();
            PendingAmountButton = new FontAwesome.Sharp.IconButton();
            PendingMonthButton = new FontAwesome.Sharp.IconButton();
            KittyNoButton = new FontAwesome.Sharp.IconButton();
            CompMonthButton = new FontAwesome.Sharp.IconButton();
            KittyTypeButton = new FontAwesome.Sharp.IconButton();
            PendingInstButton = new FontAwesome.Sharp.IconButton();
            PhNoButton = new FontAwesome.Sharp.IconButton();
            CoustNameButton = new FontAwesome.Sharp.IconButton();
            DeleteBT = new FontAwesome.Sharp.IconButton();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(767, 157);
            FlowLayoutPanel1.Margin = new Padding(1000);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(556, 630);
            FlowLayoutPanel1.TabIndex = 10031;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Location = new Point(769, 139);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(554, 3);
            Panel3.TabIndex = 10030;
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.BackColor = Color.FromArgb(36, 30, 60);
            ProfileLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileLabel.ForeColor = SystemColors.ActiveCaption;
            ProfileLabel.Location = new Point(792, 120);
            ProfileLabel.Margin = new Padding(4, 0, 4, 0);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(218, 30);
            ProfileLabel.TabIndex = 10029;
            ProfileLabel.Text = "Saved Templates";
            // 
            // HandsCheckBox
            // 
            HandsCheckBox.AutoSize = true;
            HandsCheckBox.Checked = true;
            HandsCheckBox.CheckState = CheckState.Checked;
            HandsCheckBox.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            HandsCheckBox.ForeColor = Color.Orange;
            HandsCheckBox.Location = new Point(595, 510);
            HandsCheckBox.Margin = new Padding(4, 5, 4, 5);
            HandsCheckBox.Name = "HandsCheckBox";
            HandsCheckBox.Size = new Size(153, 27);
            HandsCheckBox.TabIndex = 10024;
            HandsCheckBox.Text = "Hands Emoji";
            HandsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToolTipChB
            // 
            ToolTipChB.AutoSize = true;
            ToolTipChB.Location = new Point(1290, 83);
            ToolTipChB.Name = "ToolTipChB";
            ToolTipChB.Size = new Size(22, 21);
            ToolTipChB.TabIndex = 10022;
            ToolTipChB.UseVisualStyleBackColor = true;
            // 
            // MessageTB
            // 
            MessageTB.AutoWordSelection = true;
            MessageTB.BackColor = Color.Lavender;
            MessageTB.Font = new Font("Century Schoolbook", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageTB.Location = new Point(16, 137);
            MessageTB.Name = "MessageTB";
            MessageTB.Size = new Size(554, 650);
            MessageTB.TabIndex = 10010;
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
            Panel2.Location = new Point(642, 168);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(54, 217);
            Panel2.TabIndex = 10011;
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
            AddMsgBT.Location = new Point(595, 401);
            AddMsgBT.Margin = new Padding(4, 5, 4, 5);
            AddMsgBT.Name = "AddMsgBT";
            AddMsgBT.Size = new Size(152, 44);
            AddMsgBT.TabIndex = 10026;
            AddMsgBT.Text = "Add";
            AddMsgBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddMsgBT.UseVisualStyleBackColor = false;
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
            CancelEditBT.Location = new Point(698, 401);
            CancelEditBT.Margin = new Padding(4, 5, 4, 5);
            CancelEditBT.Name = "CancelEditBT";
            CancelEditBT.Size = new Size(45, 44);
            CancelEditBT.TabIndex = 10034;
            CancelEditBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelEditBT.UseVisualStyleBackColor = false;
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
            EditBT.IconChar = FontAwesome.Sharp.IconChar.Pen;
            EditBT.IconColor = Color.White;
            EditBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditBT.IconSize = 36;
            EditBT.Location = new Point(596, 401);
            EditBT.Margin = new Padding(4, 5, 4, 5);
            EditBT.Name = "EditBT";
            EditBT.Size = new Size(45, 44);
            EditBT.TabIndex = 10033;
            EditBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditBT.UseVisualStyleBackColor = false;
            // 
            // SelectMsgBT
            // 
            SelectMsgBT.BackColor = Color.FromArgb(0, 64, 0);
            SelectMsgBT.Enabled = false;
            SelectMsgBT.FlatAppearance.BorderSize = 0;
            SelectMsgBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            SelectMsgBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SelectMsgBT.FlatStyle = FlatStyle.Flat;
            SelectMsgBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectMsgBT.ForeColor = Color.Linen;
            SelectMsgBT.IconChar = FontAwesome.Sharp.IconChar.HandPointer;
            SelectMsgBT.IconColor = Color.White;
            SelectMsgBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SelectMsgBT.IconSize = 36;
            SelectMsgBT.Location = new Point(593, 455);
            SelectMsgBT.Margin = new Padding(4, 5, 4, 5);
            SelectMsgBT.Name = "SelectMsgBT";
            SelectMsgBT.Size = new Size(152, 44);
            SelectMsgBT.TabIndex = 10032;
            SelectMsgBT.Text = "Select";
            SelectMsgBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SelectMsgBT.UseVisualStyleBackColor = false;
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
            GreetButton.Location = new Point(39, 18);
            GreetButton.Margin = new Padding(4, 5, 4, 5);
            GreetButton.Name = "GreetButton";
            GreetButton.Size = new Size(117, 37);
            GreetButton.TabIndex = 10023;
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
            InstCompletedButton.Location = new Point(787, 13);
            InstCompletedButton.Margin = new Padding(4, 5, 4, 5);
            InstCompletedButton.Name = "InstCompletedButton";
            InstCompletedButton.Size = new Size(237, 46);
            InstCompletedButton.TabIndex = 10021;
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
            GivenAmountButton.Location = new Point(205, 65);
            GivenAmountButton.Margin = new Padding(4, 5, 4, 5);
            GivenAmountButton.Name = "GivenAmountButton";
            GivenAmountButton.Size = new Size(228, 46);
            GivenAmountButton.TabIndex = 10020;
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
            PendingAmountButton.Location = new Point(904, 65);
            PendingAmountButton.Margin = new Padding(4, 5, 4, 5);
            PendingAmountButton.Name = "PendingAmountButton";
            PendingAmountButton.Size = new Size(252, 46);
            PendingAmountButton.TabIndex = 10019;
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
            PendingMonthButton.Location = new Point(644, 65);
            PendingMonthButton.Margin = new Padding(4, 5, 4, 5);
            PendingMonthButton.Name = "PendingMonthButton";
            PendingMonthButton.Size = new Size(254, 46);
            PendingMonthButton.TabIndex = 10018;
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
            KittyNoButton.Location = new Point(646, 18);
            KittyNoButton.Margin = new Padding(4, 5, 4, 5);
            KittyNoButton.Name = "KittyNoButton";
            KittyNoButton.Size = new Size(133, 37);
            KittyNoButton.TabIndex = 10017;
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
            CompMonthButton.Location = new Point(1032, 14);
            CompMonthButton.Margin = new Padding(4, 5, 4, 5);
            CompMonthButton.Name = "CompMonthButton";
            CompMonthButton.Size = new Size(267, 46);
            CompMonthButton.TabIndex = 10016;
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
            KittyTypeButton.Location = new Point(476, 18);
            KittyTypeButton.Margin = new Padding(4, 5, 4, 5);
            KittyTypeButton.Name = "KittyTypeButton";
            KittyTypeButton.Size = new Size(162, 37);
            KittyTypeButton.TabIndex = 10015;
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
            PendingInstButton.Location = new Point(439, 65);
            PendingInstButton.Margin = new Padding(4, 5, 4, 5);
            PendingInstButton.Name = "PendingInstButton";
            PendingInstButton.Size = new Size(199, 46);
            PendingInstButton.TabIndex = 10014;
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
            PhNoButton.Location = new Point(359, 18);
            PhNoButton.Margin = new Padding(4, 5, 4, 5);
            PhNoButton.Name = "PhNoButton";
            PhNoButton.Size = new Size(112, 37);
            PhNoButton.TabIndex = 10013;
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
            CoustNameButton.Location = new Point(161, 18);
            CoustNameButton.Margin = new Padding(4, 5, 4, 5);
            CoustNameButton.Name = "CoustNameButton";
            CoustNameButton.Size = new Size(193, 37);
            CoustNameButton.TabIndex = 10012;
            CoustNameButton.Text = "Coust Name";
            CoustNameButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CoustNameButton.UseVisualStyleBackColor = false;
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
            DeleteBT.Location = new Point(647, 401);
            DeleteBT.Margin = new Padding(4, 5, 4, 5);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(45, 44);
            DeleteBT.TabIndex = 10035;
            DeleteBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteBT.UseVisualStyleBackColor = false;
            // 
            // MessageTemplates
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1339, 803);
            Controls.Add(AddMsgBT);
            Controls.Add(CancelEditBT);
            Controls.Add(EditBT);
            Controls.Add(SelectMsgBT);
            Controls.Add(ProfileLabel);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Panel3);
            Controls.Add(HandsCheckBox);
            Controls.Add(GreetButton);
            Controls.Add(ToolTipChB);
            Controls.Add(MessageTB);
            Controls.Add(InstCompletedButton);
            Controls.Add(GivenAmountButton);
            Controls.Add(PendingAmountButton);
            Controls.Add(PendingMonthButton);
            Controls.Add(Panel2);
            Controls.Add(KittyNoButton);
            Controls.Add(CompMonthButton);
            Controls.Add(KittyTypeButton);
            Controls.Add(PendingInstButton);
            Controls.Add(PhNoButton);
            Controls.Add(CoustNameButton);
            Controls.Add(DeleteBT);
            Name = "MessageTemplates";
            Text = "MessageTemplates";
            Panel2.ResumeLayout(false);
            Load += new EventHandler(MessageTemplates_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Panel Panel3;
        internal FontAwesome.Sharp.IconButton StrikeoutButton;
        internal FontAwesome.Sharp.IconButton UnderlinedButton;
        internal FontAwesome.Sharp.IconButton ItalicButton;
        internal FontAwesome.Sharp.IconButton BoldButton;
        internal Label ProfileLabel;
        internal FontAwesome.Sharp.IconButton AddMsgBT;
        internal FontAwesome.Sharp.IconButton PreviewBT;
        internal CheckBox HandsCheckBox;
        internal FontAwesome.Sharp.IconButton GreetButton;
        internal CheckBox ToolTipChB;
        internal ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl MessageTB;
        internal FontAwesome.Sharp.IconButton InstCompletedButton;
        internal FontAwesome.Sharp.IconButton GivenAmountButton;
        internal FontAwesome.Sharp.IconButton PendingAmountButton;
        internal FontAwesome.Sharp.IconButton PendingMonthButton;
        internal Panel Panel2;
        internal FontAwesome.Sharp.IconButton KittyNoButton;
        internal FontAwesome.Sharp.IconButton CompMonthButton;
        internal FontAwesome.Sharp.IconButton KittyTypeButton;
        internal FontAwesome.Sharp.IconButton PendingInstButton;
        internal FontAwesome.Sharp.IconButton PhNoButton;
        internal FontAwesome.Sharp.IconButton CoustNameButton;
        internal FontAwesome.Sharp.IconButton SelectMsgBT;
        internal FontAwesome.Sharp.IconButton EditBT;
        internal FontAwesome.Sharp.IconButton CancelEditBT;
        internal FontAwesome.Sharp.IconButton DeleteBT;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CoustProfileUpdated : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CoustProfileUpdated));
            IconButton2 = new FontAwesome.Sharp.IconButton();
            IconButton2.Click += new EventHandler(IconButton2_Click);
            ToolTip1 = new ToolTip(components);
            ExistingPhNosButton = new FontAwesome.Sharp.IconButton();
            ExistingPhNosButton.Click += new EventHandler(ExistingPhNosButton_Click);
            CheckRegistrationButton = new FontAwesome.Sharp.IconButton();
            CheckRegistrationButton.Click += new EventHandler(CheckRegistrationButton_Click);
            ConnectKittys = new FontAwesome.Sharp.IconButton();
            PanelTitleBar = new Panel();
            KittyNoLabel = new Label();
            NotesLabel = new Label();
            CustomerIdTB = new TextBox();
            CustomerIdTB.TextChanged += new EventHandler(CustomerIdTB_TextChanged);
            NotesTB = new TextBox();
            SaveCoustmerButton = new FontAwesome.Sharp.IconButton();
            SaveCoustmerButton.Click += new EventHandler(SaveCoustmerButton_Click);
            DeleteCoustmerButton = new FontAwesome.Sharp.IconButton();
            DeleteCoustmerButton.Click += new EventHandler(DeleteCoustmerButton_Click);
            ButtonPanel = new Panel();
            GetImageFromWatsappToolStripMenuItem = new ToolStripMenuItem();
            GetImageFromDeviceToolStripMenuItem = new ToolStripMenuItem();
            RemoveImageToolStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip1 = new ContextMenuStrip(components);
            ProfileLabel = new Label();
            ImageBoxPanel = new Panel();
            ImageBox = new PictureBox();
            ProfilePanel = new Panel();
            FemaleRB = new RadioButton();
            ProfessionCB = new ComboBox();
            ProfessionCB.KeyDown += new KeyEventHandler(ProfessionCB_KeyDown);
            MaleRB = new RadioButton();
            IconButton1 = new FontAwesome.Sharp.IconButton();
            NameLabel = new Label();
            AddressTB = new TextBox();
            AddressTB.GotFocus += new EventHandler(TB_GotFocus);
            AddressTB.LostFocus += new EventHandler(TB_LostFocus);
            AddressTB.KeyDown += new KeyEventHandler(TB_KeyDown);
            AddressTB.GotFocus += new EventHandler(TB_GotFocus);
            AddressTB.LostFocus += new EventHandler(TB_LostFocus);
            RegionCB = new ComboBox();
            RegionCB.KeyDown += new KeyEventHandler(RegionCB_KeyDown);
            SirNameLabel = new Label();
            PhoneNoLabel = new Label();
            NameTB = new TextBox();
            NameTB.GotFocus += new EventHandler(TB_GotFocus);
            NameTB.LostFocus += new EventHandler(TB_LostFocus);
            NameTB.KeyDown += new KeyEventHandler(TB_KeyDown);
            NameTB.GotFocus += new EventHandler(TB_GotFocus);
            NameTB.LostFocus += new EventHandler(TB_LostFocus);
            SirNameTB = new TextBox();
            SirNameTB.GotFocus += new EventHandler(TB_GotFocus);
            SirNameTB.LostFocus += new EventHandler(TB_LostFocus);
            SirNameTB.KeyDown += new KeyEventHandler(TB_KeyDown);
            SirNameTB.GotFocus += new EventHandler(TB_GotFocus);
            SirNameTB.LostFocus += new EventHandler(TB_LostFocus);
            ProfessionLabel = new Label();
            RegionLabel = new Label();
            MarriedCheckBox = new CheckBox();
            AddressLabel = new Label();
            LedgerLabel = new Label();
            LedgerPanel = new Panel();
            Label2 = new Label();
            TextBox1 = new TextBox();
            Label1 = new Label();
            UdhariDetailsButton = new FontAwesome.Sharp.IconButton();
            AddUdhariButton = new FontAwesome.Sharp.IconButton();
            ProductDetailsButton = new FontAwesome.Sharp.IconButton();
            AccountBalanceLabel = new Label();
            AddBalanceButton = new FontAwesome.Sharp.IconButton();
            AccountBalanceTB = new TextBox();
            HistoryButton = new FontAwesome.Sharp.IconButton();
            UdhariAmountLabel = new Label();
            UdhariAmountTB = new TextBox();
            UdhariCompleted = new Label();
            KittyCompletedLabel = new Label();
            UdhariCompletedLabel = new Label();
            KittysCompleted = new Label();
            AddPurchaseButton = new FontAwesome.Sharp.IconButton();
            KittyAvailedLabel = new Label();
            AddKittyButton = new FontAwesome.Sharp.IconButton();
            AddKittyButton.Click += new EventHandler(AddKittyButton_Click);
            KittysAvailed = new Label();
            TillDateAmountTB = new TextBox();
            ProductCompletedLabel = new Label();
            TillDateAmountLabel = new Label();
            ProductsCompleted = new Label();
            KittyDetailsButton = new FontAwesome.Sharp.IconButton();
            KittyDetailsButton.Click += new EventHandler(KittyDetailsButton_Click);
            Label3 = new Label();
            Adhaar = new TextBox();
            PhoneNoTag1 = new PhoneNoTag();
            PhoneNoTag1.LeftTextBox += new PhoneNoTag.LeftTextBoxEventHandler(CheckForSimilarPhNo);
            PhoneNoTag1.UP_keyPressed += new PhoneNoTag.UP_keyPressedEventHandler(PhoneNoTag1_UP_keyPressed);
            PhoneNoTag1.DOWN_keyPressed += new PhoneNoTag.DOWN_keyPressedEventHandler(PhoneNoTag1_DOWN_keyPressed);
            ButtonPanel.SuspendLayout();
            ContextMenuStrip1.SuspendLayout();
            ImageBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            ProfilePanel.SuspendLayout();
            LedgerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IconButton2
            // 
            IconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconButton2.BackColor = Color.FromArgb(25, 25, 70);
            IconButton2.FlatAppearance.BorderSize = 0;
            IconButton2.FlatStyle = FlatStyle.Flat;
            IconButton2.Font = new Font("Cambria", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            IconButton2.ForeColor = Color.MediumPurple;
            IconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            IconButton2.IconColor = Color.MediumOrchid;
            IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton2.IconSize = 38;
            IconButton2.Location = new Point(30, 231);
            IconButton2.Margin = new Padding(4, 5, 4, 5);
            IconButton2.Name = "IconButton2";
            IconButton2.Size = new Size(206, 79);
            IconButton2.TabIndex = 259;
            IconButton2.Text = "KittyMode";
            IconButton2.TextImageRelation = TextImageRelation.TextBeforeImage;
            IconButton2.UseVisualStyleBackColor = false;
            // 
            // ExistingPhNosButton
            // 
            ExistingPhNosButton.BackColor = Color.Transparent;
            ExistingPhNosButton.FlatAppearance.BorderSize = 0;
            ExistingPhNosButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ExistingPhNosButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ExistingPhNosButton.FlatStyle = FlatStyle.Flat;
            ExistingPhNosButton.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExistingPhNosButton.ForeColor = Color.Transparent;
            ExistingPhNosButton.IconChar = FontAwesome.Sharp.IconChar.PersonBooth;
            ExistingPhNosButton.IconColor = Color.Goldenrod;
            ExistingPhNosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExistingPhNosButton.IconSize = 40;
            ExistingPhNosButton.Location = new Point(1451, 218);
            ExistingPhNosButton.Margin = new Padding(4, 5, 4, 5);
            ExistingPhNosButton.Name = "ExistingPhNosButton";
            ExistingPhNosButton.Size = new Size(34, 38);
            ExistingPhNosButton.TabIndex = 267;
            ExistingPhNosButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(ExistingPhNosButton, "All The Customers Connected With Same PhNos As This One.");
            ExistingPhNosButton.UseVisualStyleBackColor = false;
            ExistingPhNosButton.Visible = false;
            // 
            // CheckRegistrationButton
            // 
            CheckRegistrationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CheckRegistrationButton.BackColor = Color.Transparent;
            CheckRegistrationButton.FlatAppearance.BorderSize = 0;
            CheckRegistrationButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 35, 60);
            CheckRegistrationButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            CheckRegistrationButton.FlatStyle = FlatStyle.Flat;
            CheckRegistrationButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckRegistrationButton.ForeColor = Color.MediumPurple;
            CheckRegistrationButton.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            CheckRegistrationButton.IconColor = Color.MediumPurple;
            CheckRegistrationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CheckRegistrationButton.IconSize = 25;
            CheckRegistrationButton.ImageAlign = ContentAlignment.TopCenter;
            CheckRegistrationButton.Location = new Point(807, 95);
            CheckRegistrationButton.Margin = new Padding(4, 5, 4, 5);
            CheckRegistrationButton.Name = "CheckRegistrationButton";
            CheckRegistrationButton.Size = new Size(28, 35);
            CheckRegistrationButton.TabIndex = 248;
            CheckRegistrationButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            ToolTip1.SetToolTip(CheckRegistrationButton, "Checks If A Number Is Registered With Whatsapp");
            CheckRegistrationButton.UseVisualStyleBackColor = false;
            // 
            // ConnectKittys
            // 
            ConnectKittys.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ConnectKittys.BackColor = Color.Transparent;
            ConnectKittys.FlatAppearance.BorderSize = 0;
            ConnectKittys.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 55, 90);
            ConnectKittys.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            ConnectKittys.FlatStyle = FlatStyle.Flat;
            ConnectKittys.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConnectKittys.ForeColor = Color.MediumPurple;
            ConnectKittys.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            ConnectKittys.IconColor = Color.MediumPurple;
            ConnectKittys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ConnectKittys.IconSize = 45;
            ConnectKittys.ImageAlign = ContentAlignment.TopCenter;
            ConnectKittys.Location = new Point(721, 19);
            ConnectKittys.Margin = new Padding(4, 5, 4, 5);
            ConnectKittys.Name = "ConnectKittys";
            ConnectKittys.Size = new Size(43, 46);
            ConnectKittys.TabIndex = 247;
            ConnectKittys.TextImageRelation = TextImageRelation.TextBeforeImage;
            ToolTip1.SetToolTip(ConnectKittys, "Here You Can Connect Kitties With This Customer");
            ConnectKittys.UseVisualStyleBackColor = false;
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.FromArgb(24, 24, 60);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(0, 0);
            PanelTitleBar.Margin = new Padding(4, 5, 4, 5);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(1924, 63);
            PanelTitleBar.TabIndex = 262;
            PanelTitleBar.Visible = false;
            // 
            // KittyNoLabel
            // 
            KittyNoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyNoLabel.AutoSize = true;
            KittyNoLabel.BackColor = Color.DarkGoldenrod;
            KittyNoLabel.Font = new Font("Consolas", 18.0f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            KittyNoLabel.ForeColor = SystemColors.ActiveCaptionText;
            KittyNoLabel.Location = new Point(780, 70);
            KittyNoLabel.Margin = new Padding(4, 0, 4, 0);
            KittyNoLabel.Name = "KittyNoLabel";
            KittyNoLabel.Size = new Size(0, 42);
            KittyNoLabel.TabIndex = 261;
            KittyNoLabel.TextAlign = ContentAlignment.MiddleCenter;
            KittyNoLabel.Visible = false;
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotesLabel.ForeColor = SystemColors.ActiveCaption;
            NotesLabel.Location = new Point(1567, 337);
            NotesLabel.Margin = new Padding(4, 0, 4, 0);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(247, 30);
            NotesLabel.TabIndex = 254;
            NotesLabel.Text = "Notes On Coustmer";
            // 
            // CustomerIdTB
            // 
            CustomerIdTB.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerIdTB.Location = new Point(13, 87);
            CustomerIdTB.Margin = new Padding(4, 5, 4, 5);
            CustomerIdTB.Name = "CustomerIdTB";
            CustomerIdTB.ReadOnly = true;
            CustomerIdTB.Size = new Size(105, 35);
            CustomerIdTB.TabIndex = 256;
            CustomerIdTB.Tag = "";
            CustomerIdTB.Visible = false;
            // 
            // NotesTB
            // 
            NotesTB.BackColor = Color.Lavender;
            NotesTB.BorderStyle = BorderStyle.None;
            NotesTB.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotesTB.Location = new Point(1509, 372);
            NotesTB.Margin = new Padding(4, 5, 4, 5);
            NotesTB.Multiline = true;
            NotesTB.Name = "NotesTB";
            NotesTB.Size = new Size(356, 582);
            NotesTB.TabIndex = 253;
            // 
            // SaveCoustmerButton
            // 
            SaveCoustmerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveCoustmerButton.BackColor = Color.FromArgb(25, 25, 70);
            SaveCoustmerButton.FlatAppearance.BorderSize = 0;
            SaveCoustmerButton.FlatStyle = FlatStyle.Flat;
            SaveCoustmerButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveCoustmerButton.ForeColor = Color.MediumPurple;
            SaveCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            SaveCoustmerButton.IconColor = Color.Black;
            SaveCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveCoustmerButton.Location = new Point(0, 7);
            SaveCoustmerButton.Margin = new Padding(4, 5, 4, 5);
            SaveCoustmerButton.Name = "SaveCoustmerButton";
            SaveCoustmerButton.Padding = new Padding(15, 0, 30, 0);
            SaveCoustmerButton.Size = new Size(394, 76);
            SaveCoustmerButton.TabIndex = 10;
            SaveCoustmerButton.Text = "Save Record";
            SaveCoustmerButton.TextAlign = ContentAlignment.MiddleLeft;
            SaveCoustmerButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveCoustmerButton.UseVisualStyleBackColor = false;
            // 
            // DeleteCoustmerButton
            // 
            DeleteCoustmerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteCoustmerButton.BackColor = Color.FromArgb(25, 25, 70);
            DeleteCoustmerButton.FlatAppearance.BorderSize = 0;
            DeleteCoustmerButton.FlatStyle = FlatStyle.Flat;
            DeleteCoustmerButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteCoustmerButton.ForeColor = Color.MediumPurple;
            DeleteCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            DeleteCoustmerButton.IconColor = Color.Black;
            DeleteCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteCoustmerButton.Location = new Point(0, 93);
            DeleteCoustmerButton.Margin = new Padding(4, 5, 4, 5);
            DeleteCoustmerButton.Name = "DeleteCoustmerButton";
            DeleteCoustmerButton.Padding = new Padding(15, 0, 30, 0);
            DeleteCoustmerButton.Size = new Size(394, 76);
            DeleteCoustmerButton.TabIndex = 206;
            DeleteCoustmerButton.Text = "Remove Coustmer";
            DeleteCoustmerButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteCoustmerButton.UseVisualStyleBackColor = false;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonPanel.Controls.Add(DeleteCoustmerButton);
            ButtonPanel.Controls.Add(SaveCoustmerButton);
            ButtonPanel.Location = new Point(1534, 116);
            ButtonPanel.Margin = new Padding(4, 5, 4, 5);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(392, 182);
            ButtonPanel.TabIndex = 252;
            // 
            // GetImageFromWatsappToolStripMenuItem
            // 
            GetImageFromWatsappToolStripMenuItem.Name = "GetImageFromWatsappToolStripMenuItem";
            GetImageFromWatsappToolStripMenuItem.Size = new Size(288, 32);
            GetImageFromWatsappToolStripMenuItem.Text = "Get Image From Watsapp";
            // 
            // GetImageFromDeviceToolStripMenuItem
            // 
            GetImageFromDeviceToolStripMenuItem.Name = "GetImageFromDeviceToolStripMenuItem";
            GetImageFromDeviceToolStripMenuItem.Size = new Size(288, 32);
            GetImageFromDeviceToolStripMenuItem.Text = "Get Image From Device";
            // 
            // RemoveImageToolStripMenuItem
            // 
            RemoveImageToolStripMenuItem.Name = "RemoveImageToolStripMenuItem";
            RemoveImageToolStripMenuItem.Size = new Size(288, 32);
            RemoveImageToolStripMenuItem.Text = "Remove Image";
            RemoveImageToolStripMenuItem.Visible = false;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { GetImageFromWatsappToolStripMenuItem, GetImageFromDeviceToolStripMenuItem, RemoveImageToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(289, 100);
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.BackColor = Color.Transparent;
            ProfileLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileLabel.ForeColor = SystemColors.ActiveCaption;
            ProfileLabel.Location = new Point(616, 108);
            ProfileLabel.Margin = new Padding(4, 0, 4, 0);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(86, 30);
            ProfileLabel.TabIndex = 265;
            ProfileLabel.Text = "Profile";
            // 
            // ImageBoxPanel
            // 
            ImageBoxPanel.BackColor = Color.FromArgb(36, 35, 70);
            ImageBoxPanel.Controls.Add(ImageBox);
            ImageBoxPanel.Location = new Point(275, 127);
            ImageBoxPanel.Name = "ImageBoxPanel";
            ImageBoxPanel.Size = new Size(314, 359);
            ImageBoxPanel.TabIndex = 266;
            // 
            // ImageBox
            // 
            ImageBox.BackgroundImageLayout = ImageLayout.Zoom;
            ImageBox.ContextMenuStrip = ContextMenuStrip1;
            ImageBox.ErrorImage = null;
            ImageBox.Image = (Image)resources.GetObject("ImageBox.Image");
            ImageBox.InitialImage = null;
            ImageBox.Location = new Point(31, 43);
            ImageBox.Margin = new Padding(4, 5, 4, 5);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(253, 273);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 4;
            ImageBox.TabStop = false;
            // 
            // ProfilePanel
            // 
            ProfilePanel.BackColor = Color.FromArgb(36, 35, 70);
            ProfilePanel.Controls.Add(Label3);
            ProfilePanel.Controls.Add(Adhaar);
            ProfilePanel.Controls.Add(PhoneNoTag1);
            ProfilePanel.Controls.Add(FemaleRB);
            ProfilePanel.Controls.Add(ProfessionCB);
            ProfilePanel.Controls.Add(MaleRB);
            ProfilePanel.Controls.Add(CheckRegistrationButton);
            ProfilePanel.Controls.Add(IconButton1);
            ProfilePanel.Controls.Add(NameLabel);
            ProfilePanel.Controls.Add(AddressTB);
            ProfilePanel.Controls.Add(RegionCB);
            ProfilePanel.Controls.Add(SirNameLabel);
            ProfilePanel.Controls.Add(PhoneNoLabel);
            ProfilePanel.Controls.Add(NameTB);
            ProfilePanel.Controls.Add(SirNameTB);
            ProfilePanel.Controls.Add(ProfessionLabel);
            ProfilePanel.Controls.Add(RegionLabel);
            ProfilePanel.Controls.Add(MarriedCheckBox);
            ProfilePanel.Controls.Add(AddressLabel);
            ProfilePanel.Location = new Point(605, 127);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(839, 359);
            ProfilePanel.TabIndex = 5;
            // 
            // FemaleRB
            // 
            FemaleRB.AutoSize = true;
            FemaleRB.Checked = true;
            FemaleRB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FemaleRB.ForeColor = SystemColors.ActiveCaption;
            FemaleRB.Location = new Point(531, 300);
            FemaleRB.Margin = new Padding(4, 5, 4, 5);
            FemaleRB.Name = "FemaleRB";
            FemaleRB.Size = new Size(128, 34);
            FemaleRB.TabIndex = 201;
            FemaleRB.TabStop = true;
            FemaleRB.Text = "Female";
            FemaleRB.UseVisualStyleBackColor = true;
            // 
            // ProfessionCB
            // 
            ProfessionCB.Anchor = AnchorStyles.Left;
            ProfessionCB.DropDownHeight = 200;
            ProfessionCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ProfessionCB.FlatStyle = FlatStyle.Flat;
            ProfessionCB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfessionCB.FormattingEnabled = true;
            ProfessionCB.IntegralHeight = false;
            ProfessionCB.Location = new Point(165, 166);
            ProfessionCB.Margin = new Padding(4, 5, 4, 5);
            ProfessionCB.MaxDropDownItems = 20;
            ProfessionCB.Name = "ProfessionCB";
            ProfessionCB.Size = new Size(229, 34);
            ProfessionCB.TabIndex = 3;
            ProfessionCB.Tag = "";
            // 
            // MaleRB
            // 
            MaleRB.AutoSize = true;
            MaleRB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaleRB.ForeColor = SystemColors.ActiveCaption;
            MaleRB.Location = new Point(433, 300);
            MaleRB.Margin = new Padding(4, 5, 4, 5);
            MaleRB.Name = "MaleRB";
            MaleRB.Size = new Size(99, 34);
            MaleRB.TabIndex = 200;
            MaleRB.Text = "Male";
            MaleRB.UseVisualStyleBackColor = true;
            // 
            // IconButton1
            // 
            IconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconButton1.BackColor = Color.Transparent;
            IconButton1.FlatAppearance.BorderSize = 0;
            IconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 55, 90);
            IconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            IconButton1.FlatStyle = FlatStyle.Flat;
            IconButton1.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            IconButton1.ForeColor = Color.MediumPurple;
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            IconButton1.IconColor = Color.MediumPurple;
            IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton1.IconSize = 30;
            IconButton1.ImageAlign = ContentAlignment.TopCenter;
            IconButton1.Location = new Point(126, 238);
            IconButton1.Margin = new Padding(4, 5, 4, 5);
            IconButton1.Name = "IconButton1";
            IconButton1.Size = new Size(30, 32);
            IconButton1.TabIndex = 13;
            IconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            IconButton1.UseVisualStyleBackColor = false;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Left;
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = SystemColors.ActiveCaption;
            NameLabel.Location = new Point(13, 23);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(87, 30);
            NameLabel.TabIndex = 189;
            NameLabel.Text = "Name";
            // 
            // AddressTB
            // 
            AddressTB.Anchor = AnchorStyles.Left;
            AddressTB.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTB.Location = new Point(164, 237);
            AddressTB.Margin = new Padding(4, 5, 4, 5);
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(642, 35);
            AddressTB.TabIndex = 5;
            AddressTB.Tag = "";
            // 
            // RegionCB
            // 
            RegionCB.Anchor = AnchorStyles.Left;
            RegionCB.DropDownStyle = ComboBoxStyle.DropDownList;
            RegionCB.FlatStyle = FlatStyle.Flat;
            RegionCB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegionCB.FormattingEnabled = true;
            RegionCB.Location = new Point(574, 166);
            RegionCB.Margin = new Padding(4, 5, 4, 5);
            RegionCB.Name = "RegionCB";
            RegionCB.Size = new Size(229, 34);
            RegionCB.TabIndex = 4;
            RegionCB.Tag = "";
            // 
            // SirNameLabel
            // 
            SirNameLabel.Anchor = AnchorStyles.Left;
            SirNameLabel.AutoSize = true;
            SirNameLabel.BackColor = Color.Transparent;
            SirNameLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SirNameLabel.ForeColor = SystemColors.ActiveCaption;
            SirNameLabel.Location = new Point(450, 23);
            SirNameLabel.Margin = new Padding(4, 0, 4, 0);
            SirNameLabel.Name = "SirNameLabel";
            SirNameLabel.Size = new Size(119, 30);
            SirNameLabel.TabIndex = 204;
            SirNameLabel.Text = "Sir Name";
            // 
            // PhoneNoLabel
            // 
            PhoneNoLabel.Anchor = AnchorStyles.Left;
            PhoneNoLabel.AutoSize = true;
            PhoneNoLabel.BackColor = Color.Transparent;
            PhoneNoLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNoLabel.ForeColor = SystemColors.ActiveCaption;
            PhoneNoLabel.Location = new Point(13, 91);
            PhoneNoLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneNoLabel.Name = "PhoneNoLabel";
            PhoneNoLabel.Size = new Size(130, 30);
            PhoneNoLabel.TabIndex = 190;
            PhoneNoLabel.Text = "Phone No";
            // 
            // NameTB
            // 
            NameTB.Anchor = AnchorStyles.Left;
            NameTB.BackColor = Color.White;
            NameTB.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTB.Location = new Point(165, 23);
            NameTB.Margin = new Padding(4, 5, 4, 5);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(229, 35);
            NameTB.TabIndex = 0;
            NameTB.Tag = "";
            // 
            // SirNameTB
            // 
            SirNameTB.Anchor = AnchorStyles.Left;
            SirNameTB.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SirNameTB.Location = new Point(574, 23);
            SirNameTB.Margin = new Padding(4, 5, 4, 5);
            SirNameTB.Name = "SirNameTB";
            SirNameTB.Size = new Size(229, 35);
            SirNameTB.TabIndex = 1;
            SirNameTB.Tag = "";
            // 
            // ProfessionLabel
            // 
            ProfessionLabel.Anchor = AnchorStyles.Left;
            ProfessionLabel.AutoSize = true;
            ProfessionLabel.BackColor = Color.Transparent;
            ProfessionLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfessionLabel.ForeColor = SystemColors.ActiveCaption;
            ProfessionLabel.Location = new Point(13, 165);
            ProfessionLabel.Margin = new Padding(4, 0, 4, 0);
            ProfessionLabel.Name = "ProfessionLabel";
            ProfessionLabel.Size = new Size(131, 30);
            ProfessionLabel.TabIndex = 195;
            ProfessionLabel.Text = "Profession";
            // 
            // RegionLabel
            // 
            RegionLabel.Anchor = AnchorStyles.Left;
            RegionLabel.AutoSize = true;
            RegionLabel.BackColor = Color.Transparent;
            RegionLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegionLabel.ForeColor = SystemColors.ActiveCaption;
            RegionLabel.Location = new Point(450, 168);
            RegionLabel.Margin = new Padding(4, 0, 4, 0);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(97, 30);
            RegionLabel.TabIndex = 198;
            RegionLabel.Text = "Region";
            // 
            // MarriedCheckBox
            // 
            MarriedCheckBox.Anchor = AnchorStyles.Left;
            MarriedCheckBox.BackColor = Color.Transparent;
            MarriedCheckBox.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarriedCheckBox.ForeColor = SystemColors.ActiveCaption;
            MarriedCheckBox.Location = new Point(688, 297);
            MarriedCheckBox.Margin = new Padding(4, 5, 4, 5);
            MarriedCheckBox.Name = "MarriedCheckBox";
            MarriedCheckBox.Size = new Size(141, 43);
            MarriedCheckBox.TabIndex = 6;
            MarriedCheckBox.TabStop = false;
            MarriedCheckBox.Text = "Married";
            MarriedCheckBox.UseVisualStyleBackColor = false;
            // 
            // AddressLabel
            // 
            AddressLabel.Anchor = AnchorStyles.Left;
            AddressLabel.AutoSize = true;
            AddressLabel.BackColor = Color.Transparent;
            AddressLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressLabel.ForeColor = SystemColors.ActiveCaption;
            AddressLabel.Location = new Point(13, 238);
            AddressLabel.Margin = new Padding(4, 0, 4, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(105, 30);
            AddressLabel.TabIndex = 220;
            AddressLabel.Text = "Address";
            // 
            // LedgerLabel
            // 
            LedgerLabel.AutoSize = true;
            LedgerLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LedgerLabel.ForeColor = SystemColors.ActiveCaption;
            LedgerLabel.Location = new Point(287, 496);
            LedgerLabel.Margin = new Padding(4, 0, 4, 0);
            LedgerLabel.Name = "LedgerLabel";
            LedgerLabel.Size = new Size(95, 30);
            LedgerLabel.TabIndex = 269;
            LedgerLabel.Text = "Ledger";
            // 
            // LedgerPanel
            // 
            LedgerPanel.BackColor = Color.FromArgb(36, 35, 70);
            LedgerPanel.Controls.Add(Label2);
            LedgerPanel.Controls.Add(ConnectKittys);
            LedgerPanel.Controls.Add(TextBox1);
            LedgerPanel.Controls.Add(Label1);
            LedgerPanel.Controls.Add(UdhariDetailsButton);
            LedgerPanel.Controls.Add(AddUdhariButton);
            LedgerPanel.Controls.Add(ProductDetailsButton);
            LedgerPanel.Controls.Add(AccountBalanceLabel);
            LedgerPanel.Controls.Add(AddBalanceButton);
            LedgerPanel.Controls.Add(AccountBalanceTB);
            LedgerPanel.Controls.Add(HistoryButton);
            LedgerPanel.Controls.Add(UdhariAmountLabel);
            LedgerPanel.Controls.Add(UdhariAmountTB);
            LedgerPanel.Controls.Add(UdhariCompleted);
            LedgerPanel.Controls.Add(KittyCompletedLabel);
            LedgerPanel.Controls.Add(UdhariCompletedLabel);
            LedgerPanel.Controls.Add(KittysCompleted);
            LedgerPanel.Controls.Add(AddPurchaseButton);
            LedgerPanel.Controls.Add(KittyAvailedLabel);
            LedgerPanel.Controls.Add(AddKittyButton);
            LedgerPanel.Controls.Add(KittysAvailed);
            LedgerPanel.Controls.Add(TillDateAmountTB);
            LedgerPanel.Controls.Add(ProductCompletedLabel);
            LedgerPanel.Controls.Add(TillDateAmountLabel);
            LedgerPanel.Controls.Add(ProductsCompleted);
            LedgerPanel.Controls.Add(KittyDetailsButton);
            LedgerPanel.Location = new Point(275, 514);
            LedgerPanel.Name = "LedgerPanel";
            LedgerPanel.Size = new Size(1173, 452);
            LedgerPanel.TabIndex = 268;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = SystemColors.ActiveCaption;
            Label2.Location = new Point(66, 262);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(604, 28);
            Label2.TabIndex = 248;
            Label2.Text = "2: Active    1: UnAvailed      1: Availed     1:Cracked";
            Label2.Visible = false;
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox1.Location = new Point(408, 380);
            TextBox1.Margin = new Padding(4, 5, 4, 5);
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.Size = new Size(229, 36);
            TextBox1.TabIndex = 245;
            TextBox1.Tag = "";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ActiveCaption;
            Label1.Location = new Point(81, 381);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(233, 30);
            Label1.TabIndex = 246;
            Label1.Text = "TILL-Date Net Profit";
            // 
            // UdhariDetailsButton
            // 
            UdhariDetailsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UdhariDetailsButton.BackColor = Color.Transparent;
            UdhariDetailsButton.FlatAppearance.BorderSize = 0;
            UdhariDetailsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 55, 90);
            UdhariDetailsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            UdhariDetailsButton.FlatStyle = FlatStyle.Flat;
            UdhariDetailsButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            UdhariDetailsButton.ForeColor = Color.MediumPurple;
            UdhariDetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            UdhariDetailsButton.IconColor = Color.MediumPurple;
            UdhariDetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UdhariDetailsButton.IconSize = 45;
            UdhariDetailsButton.ImageAlign = ContentAlignment.TopCenter;
            UdhariDetailsButton.Location = new Point(649, 78);
            UdhariDetailsButton.Margin = new Padding(4, 5, 4, 5);
            UdhariDetailsButton.Name = "UdhariDetailsButton";
            UdhariDetailsButton.Size = new Size(43, 46);
            UdhariDetailsButton.TabIndex = 244;
            UdhariDetailsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            UdhariDetailsButton.UseVisualStyleBackColor = false;
            // 
            // AddUdhariButton
            // 
            AddUdhariButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddUdhariButton.BackColor = Color.FromArgb(25, 25, 70);
            AddUdhariButton.FlatAppearance.BorderSize = 0;
            AddUdhariButton.FlatStyle = FlatStyle.Flat;
            AddUdhariButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUdhariButton.ForeColor = Color.MediumPurple;
            AddUdhariButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            AddUdhariButton.IconColor = Color.Black;
            AddUdhariButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddUdhariButton.Location = new Point(847, 93);
            AddUdhariButton.Margin = new Padding(4, 5, 4, 5);
            AddUdhariButton.Name = "AddUdhariButton";
            AddUdhariButton.Size = new Size(326, 79);
            AddUdhariButton.TabIndex = 240;
            AddUdhariButton.Text = "Add New Udhari";
            AddUdhariButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddUdhariButton.UseVisualStyleBackColor = false;
            // 
            // ProductDetailsButton
            // 
            ProductDetailsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProductDetailsButton.BackColor = Color.Transparent;
            ProductDetailsButton.FlatAppearance.BorderSize = 0;
            ProductDetailsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 55, 90);
            ProductDetailsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            ProductDetailsButton.FlatStyle = FlatStyle.Flat;
            ProductDetailsButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDetailsButton.ForeColor = Color.MediumPurple;
            ProductDetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            ProductDetailsButton.IconColor = Color.MediumPurple;
            ProductDetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ProductDetailsButton.IconSize = 45;
            ProductDetailsButton.ImageAlign = ContentAlignment.TopCenter;
            ProductDetailsButton.Location = new Point(649, 136);
            ProductDetailsButton.Margin = new Padding(4, 5, 4, 5);
            ProductDetailsButton.Name = "ProductDetailsButton";
            ProductDetailsButton.Size = new Size(43, 46);
            ProductDetailsButton.TabIndex = 243;
            ProductDetailsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            ProductDetailsButton.UseVisualStyleBackColor = false;
            // 
            // AccountBalanceLabel
            // 
            AccountBalanceLabel.AutoSize = true;
            AccountBalanceLabel.BackColor = Color.Transparent;
            AccountBalanceLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountBalanceLabel.ForeColor = SystemColors.ActiveCaption;
            AccountBalanceLabel.Location = new Point(681, 309);
            AccountBalanceLabel.Margin = new Padding(4, 0, 4, 0);
            AccountBalanceLabel.Name = "AccountBalanceLabel";
            AccountBalanceLabel.Size = new Size(222, 30);
            AccountBalanceLabel.TabIndex = 222;
            AccountBalanceLabel.Text = "Account Balance";
            // 
            // AddBalanceButton
            // 
            AddBalanceButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBalanceButton.BackColor = Color.DarkGoldenrod;
            AddBalanceButton.FlatAppearance.BorderSize = 0;
            AddBalanceButton.FlatStyle = FlatStyle.Flat;
            AddBalanceButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBalanceButton.ForeColor = Color.Black;
            AddBalanceButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            AddBalanceButton.IconColor = Color.FromArgb(0, 20, 20);
            AddBalanceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBalanceButton.IconSize = 25;
            AddBalanceButton.ImageAlign = ContentAlignment.TopCenter;
            AddBalanceButton.Location = new Point(492, 211);
            AddBalanceButton.Margin = new Padding(4, 5, 4, 5);
            AddBalanceButton.Name = "AddBalanceButton";
            AddBalanceButton.Size = new Size(200, 46);
            AddBalanceButton.TabIndex = 242;
            AddBalanceButton.Text = "Add Balance";
            AddBalanceButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            AddBalanceButton.UseVisualStyleBackColor = false;
            // 
            // AccountBalanceTB
            // 
            AccountBalanceTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountBalanceTB.Location = new Point(906, 308);
            AccountBalanceTB.Margin = new Padding(4, 5, 4, 5);
            AccountBalanceTB.Name = "AccountBalanceTB";
            AccountBalanceTB.ReadOnly = true;
            AccountBalanceTB.Size = new Size(229, 36);
            AccountBalanceTB.TabIndex = 221;
            AccountBalanceTB.Tag = "";
            // 
            // HistoryButton
            // 
            HistoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HistoryButton.BackColor = Color.DarkGoldenrod;
            HistoryButton.FlatAppearance.BorderSize = 0;
            HistoryButton.FlatStyle = FlatStyle.Flat;
            HistoryButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            HistoryButton.ForeColor = Color.Black;
            HistoryButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            HistoryButton.IconColor = Color.FromArgb(0, 20, 20);
            HistoryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HistoryButton.IconSize = 25;
            HistoryButton.ImageAlign = ContentAlignment.TopCenter;
            HistoryButton.Location = new Point(59, 211);
            HistoryButton.Margin = new Padding(4, 5, 4, 5);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(286, 46);
            HistoryButton.TabIndex = 241;
            HistoryButton.Text = "Balance History";
            HistoryButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            HistoryButton.UseVisualStyleBackColor = false;
            // 
            // UdhariAmountLabel
            // 
            UdhariAmountLabel.AutoSize = true;
            UdhariAmountLabel.BackColor = Color.Transparent;
            UdhariAmountLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UdhariAmountLabel.ForeColor = SystemColors.ActiveCaption;
            UdhariAmountLabel.Location = new Point(681, 380);
            UdhariAmountLabel.Margin = new Padding(4, 0, 4, 0);
            UdhariAmountLabel.Name = "UdhariAmountLabel";
            UdhariAmountLabel.Size = new Size(175, 30);
            UdhariAmountLabel.TabIndex = 224;
            UdhariAmountLabel.Text = "Uhari Amount";
            // 
            // UdhariAmountTB
            // 
            UdhariAmountTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UdhariAmountTB.Location = new Point(906, 379);
            UdhariAmountTB.Margin = new Padding(4, 5, 4, 5);
            UdhariAmountTB.Name = "UdhariAmountTB";
            UdhariAmountTB.ReadOnly = true;
            UdhariAmountTB.Size = new Size(229, 36);
            UdhariAmountTB.TabIndex = 223;
            UdhariAmountTB.Tag = "";
            // 
            // UdhariCompleted
            // 
            UdhariCompleted.AutoSize = true;
            UdhariCompleted.BackColor = Color.Transparent;
            UdhariCompleted.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UdhariCompleted.ForeColor = SystemColors.ActiveCaption;
            UdhariCompleted.Location = new Point(285, 85);
            UdhariCompleted.Margin = new Padding(4, 0, 4, 0);
            UdhariCompleted.Name = "UdhariCompleted";
            UdhariCompleted.Size = new Size(49, 30);
            UdhariCompleted.TabIndex = 238;
            UdhariCompleted.Text = "1/3";
            // 
            // KittyCompletedLabel
            // 
            KittyCompletedLabel.AutoSize = true;
            KittyCompletedLabel.BackColor = Color.Transparent;
            KittyCompletedLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyCompletedLabel.ForeColor = SystemColors.ActiveCaption;
            KittyCompletedLabel.Location = new Point(54, 28);
            KittyCompletedLabel.Margin = new Padding(4, 0, 4, 0);
            KittyCompletedLabel.Name = "KittyCompletedLabel";
            KittyCompletedLabel.Size = new Size(207, 28);
            KittyCompletedLabel.TabIndex = 225;
            KittyCompletedLabel.Text = "Kitty Completed:";
            // 
            // UdhariCompletedLabel
            // 
            UdhariCompletedLabel.AutoSize = true;
            UdhariCompletedLabel.BackColor = Color.Transparent;
            UdhariCompletedLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            UdhariCompletedLabel.ForeColor = SystemColors.ActiveCaption;
            UdhariCompletedLabel.Location = new Point(56, 87);
            UdhariCompletedLabel.Margin = new Padding(4, 0, 4, 0);
            UdhariCompletedLabel.Name = "UdhariCompletedLabel";
            UdhariCompletedLabel.Size = new Size(233, 28);
            UdhariCompletedLabel.TabIndex = 237;
            UdhariCompletedLabel.Text = "Udhari Completed:";
            // 
            // KittysCompleted
            // 
            KittysCompleted.AutoSize = true;
            KittysCompleted.BackColor = Color.Transparent;
            KittysCompleted.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            KittysCompleted.ForeColor = SystemColors.ActiveCaption;
            KittysCompleted.Location = new Point(257, 26);
            KittysCompleted.Margin = new Padding(4, 0, 4, 0);
            KittysCompleted.Name = "KittysCompleted";
            KittysCompleted.Size = new Size(49, 30);
            KittysCompleted.TabIndex = 226;
            KittysCompleted.Text = "2/4";
            // 
            // AddPurchaseButton
            // 
            AddPurchaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddPurchaseButton.BackColor = Color.FromArgb(25, 25, 70);
            AddPurchaseButton.FlatAppearance.BorderSize = 0;
            AddPurchaseButton.FlatStyle = FlatStyle.Flat;
            AddPurchaseButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddPurchaseButton.ForeColor = Color.MediumPurple;
            AddPurchaseButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            AddPurchaseButton.IconColor = Color.Black;
            AddPurchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddPurchaseButton.Location = new Point(847, 182);
            AddPurchaseButton.Margin = new Padding(4, 5, 4, 5);
            AddPurchaseButton.Name = "AddPurchaseButton";
            AddPurchaseButton.Size = new Size(326, 79);
            AddPurchaseButton.TabIndex = 235;
            AddPurchaseButton.Text = "Add New Purchase";
            AddPurchaseButton.TextAlign = ContentAlignment.MiddleLeft;
            AddPurchaseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddPurchaseButton.UseVisualStyleBackColor = false;
            // 
            // KittyAvailedLabel
            // 
            KittyAvailedLabel.AutoSize = true;
            KittyAvailedLabel.BackColor = Color.Transparent;
            KittyAvailedLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyAvailedLabel.ForeColor = SystemColors.ActiveCaption;
            KittyAvailedLabel.Location = new Point(403, 30);
            KittyAvailedLabel.Margin = new Padding(4, 0, 4, 0);
            KittyAvailedLabel.Name = "KittyAvailedLabel";
            KittyAvailedLabel.Size = new Size(165, 28);
            KittyAvailedLabel.TabIndex = 227;
            KittyAvailedLabel.Text = "Kitty Availed:";
            // 
            // AddKittyButton
            // 
            AddKittyButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddKittyButton.BackColor = Color.FromArgb(25, 25, 70);
            AddKittyButton.FlatAppearance.BorderSize = 0;
            AddKittyButton.FlatStyle = FlatStyle.Flat;
            AddKittyButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddKittyButton.ForeColor = Color.MediumPurple;
            AddKittyButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            AddKittyButton.IconColor = Color.Black;
            AddKittyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddKittyButton.Location = new Point(847, 5);
            AddKittyButton.Margin = new Padding(4, 5, 4, 5);
            AddKittyButton.Name = "AddKittyButton";
            AddKittyButton.Size = new Size(326, 79);
            AddKittyButton.TabIndex = 236;
            AddKittyButton.Text = "Add New Kitty     ";
            AddKittyButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddKittyButton.UseVisualStyleBackColor = false;
            // 
            // KittysAvailed
            // 
            KittysAvailed.AutoSize = true;
            KittysAvailed.BackColor = Color.Transparent;
            KittysAvailed.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            KittysAvailed.ForeColor = SystemColors.ActiveCaption;
            KittysAvailed.Location = new Point(566, 30);
            KittysAvailed.Margin = new Padding(4, 0, 4, 0);
            KittysAvailed.Name = "KittysAvailed";
            KittysAvailed.Size = new Size(49, 30);
            KittysAvailed.TabIndex = 228;
            KittysAvailed.Text = "1/2";
            // 
            // TillDateAmountTB
            // 
            TillDateAmountTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TillDateAmountTB.Location = new Point(408, 309);
            TillDateAmountTB.Margin = new Padding(4, 5, 4, 5);
            TillDateAmountTB.Name = "TillDateAmountTB";
            TillDateAmountTB.ReadOnly = true;
            TillDateAmountTB.Size = new Size(229, 36);
            TillDateAmountTB.TabIndex = 233;
            TillDateAmountTB.Tag = "";
            // 
            // ProductCompletedLabel
            // 
            ProductCompletedLabel.AutoSize = true;
            ProductCompletedLabel.BackColor = Color.Transparent;
            ProductCompletedLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductCompletedLabel.ForeColor = SystemColors.ActiveCaption;
            ProductCompletedLabel.Location = new Point(56, 146);
            ProductCompletedLabel.Margin = new Padding(4, 0, 4, 0);
            ProductCompletedLabel.Name = "ProductCompletedLabel";
            ProductCompletedLabel.Size = new Size(355, 28);
            ProductCompletedLabel.TabIndex = 229;
            ProductCompletedLabel.Text = "Product Payment Completed:";
            // 
            // TillDateAmountLabel
            // 
            TillDateAmountLabel.AutoSize = true;
            TillDateAmountLabel.BackColor = Color.Transparent;
            TillDateAmountLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TillDateAmountLabel.ForeColor = SystemColors.ActiveCaption;
            TillDateAmountLabel.Location = new Point(37, 310);
            TillDateAmountLabel.Margin = new Padding(4, 0, 4, 0);
            TillDateAmountLabel.Name = "TillDateAmountLabel";
            TillDateAmountLabel.Size = new Size(363, 30);
            TillDateAmountLabel.TabIndex = 234;
            TillDateAmountLabel.Text = "TILL-Date Transactoin Amount";
            // 
            // ProductsCompleted
            // 
            ProductsCompleted.AutoSize = true;
            ProductsCompleted.BackColor = Color.Transparent;
            ProductsCompleted.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductsCompleted.ForeColor = SystemColors.ActiveCaption;
            ProductsCompleted.Location = new Point(409, 145);
            ProductsCompleted.Margin = new Padding(4, 0, 4, 0);
            ProductsCompleted.Name = "ProductsCompleted";
            ProductsCompleted.Size = new Size(49, 30);
            ProductsCompleted.TabIndex = 230;
            ProductsCompleted.Text = "0/0";
            // 
            // KittyDetailsButton
            // 
            KittyDetailsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KittyDetailsButton.BackColor = Color.Transparent;
            KittyDetailsButton.FlatAppearance.BorderSize = 0;
            KittyDetailsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 55, 90);
            KittyDetailsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            KittyDetailsButton.FlatStyle = FlatStyle.Flat;
            KittyDetailsButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyDetailsButton.ForeColor = Color.MediumPurple;
            KittyDetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            KittyDetailsButton.IconColor = Color.MediumPurple;
            KittyDetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            KittyDetailsButton.IconSize = 45;
            KittyDetailsButton.ImageAlign = ContentAlignment.TopCenter;
            KittyDetailsButton.Location = new Point(649, 20);
            KittyDetailsButton.Margin = new Padding(4, 5, 4, 5);
            KittyDetailsButton.Name = "KittyDetailsButton";
            KittyDetailsButton.Size = new Size(43, 46);
            KittyDetailsButton.TabIndex = 231;
            KittyDetailsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            KittyDetailsButton.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Left;
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = SystemColors.ActiveCaption;
            Label3.Location = new Point(13, 298);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(148, 30);
            Label3.TabIndex = 250;
            Label3.Text = "Adhaar No.";
            // 
            // Adhaar
            // 
            Adhaar.Anchor = AnchorStyles.Left;
            Adhaar.BackColor = Color.White;
            Adhaar.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Adhaar.Location = new Point(165, 297);
            Adhaar.Margin = new Padding(4, 5, 4, 5);
            Adhaar.Name = "Adhaar";
            Adhaar.Size = new Size(229, 35);
            Adhaar.TabIndex = 249;
            Adhaar.Tag = "";
            Adhaar.TextAlign = HorizontalAlignment.Center;
            // 
            // PhoneNoTag1
            // 
            PhoneNoTag1.BackColor = Color.MediumSlateBlue;
            PhoneNoTag1.Location = new Point(164, 82);
            PhoneNoTag1.Margin = new Padding(4, 5, 4, 5);
            PhoneNoTag1.Name = "PhoneNoTag1";
            PhoneNoTag1.Size = new Size(642, 52);
            PhoneNoTag1.TabIndex = 2;
            PhoneNoTag1.TagData = "";
            // 
            // CoustProfileUpdated
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(36, 35, 80);
            ClientSize = new Size(1924, 987);
            Controls.Add(LedgerLabel);
            Controls.Add(LedgerPanel);
            Controls.Add(ExistingPhNosButton);
            Controls.Add(ProfileLabel);
            Controls.Add(ImageBoxPanel);
            Controls.Add(ProfilePanel);
            Controls.Add(PanelTitleBar);
            Controls.Add(ButtonPanel);
            Controls.Add(IconButton2);
            Controls.Add(NotesTB);
            Controls.Add(CustomerIdTB);
            Controls.Add(NotesLabel);
            Controls.Add(KittyNoLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "CoustProfileUpdated";
            Text = "Kitty Records";
            ButtonPanel.ResumeLayout(false);
            ContextMenuStrip1.ResumeLayout(false);
            ImageBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ProfilePanel.ResumeLayout(false);
            ProfilePanel.PerformLayout();
            LedgerPanel.ResumeLayout(false);
            LedgerPanel.PerformLayout();
            Load += new EventHandler(CustomerProfile_Load);
            KeyDown += new KeyEventHandler(CustomerProfile_KeyDown);
            ResumeLayout(false);
            PerformLayout();

        }

        internal FontAwesome.Sharp.IconButton IconButton2;
        internal ToolTip ToolTip1;
        internal Panel PanelTitleBar;
        internal Label KittyNoLabel;
        internal Label NotesLabel;
        internal TextBox CustomerIdTB;
        internal TextBox NotesTB;
        internal FontAwesome.Sharp.IconButton SaveCoustmerButton;
        internal FontAwesome.Sharp.IconButton DeleteCoustmerButton;
        internal Panel ButtonPanel;
        internal ToolStripMenuItem GetImageFromWatsappToolStripMenuItem;
        internal ToolStripMenuItem GetImageFromDeviceToolStripMenuItem;
        internal ToolStripMenuItem RemoveImageToolStripMenuItem;
        internal ContextMenuStrip ContextMenuStrip1;
        internal FontAwesome.Sharp.IconButton ExistingPhNosButton;
        internal Label ProfileLabel;
        internal Panel ImageBoxPanel;
        internal PictureBox ImageBox;
        internal Panel ProfilePanel;
        internal RadioButton FemaleRB;
        internal ComboBox ProfessionCB;
        internal RadioButton MaleRB;
        internal FontAwesome.Sharp.IconButton CheckRegistrationButton;
        internal FontAwesome.Sharp.IconButton IconButton1;
        internal Label NameLabel;
        internal TextBox AddressTB;
        internal ComboBox RegionCB;
        internal Label SirNameLabel;
        internal Label PhoneNoLabel;
        internal TextBox NameTB;
        internal TextBox SirNameTB;
        internal Label ProfessionLabel;
        internal Label RegionLabel;
        internal CheckBox MarriedCheckBox;
        internal Label AddressLabel;
        internal Label LedgerLabel;
        internal Panel LedgerPanel;
        internal Label Label2;
        internal FontAwesome.Sharp.IconButton ConnectKittys;
        internal TextBox TextBox1;
        internal Label Label1;
        internal FontAwesome.Sharp.IconButton UdhariDetailsButton;
        internal FontAwesome.Sharp.IconButton AddUdhariButton;
        internal FontAwesome.Sharp.IconButton ProductDetailsButton;
        internal Label AccountBalanceLabel;
        internal FontAwesome.Sharp.IconButton AddBalanceButton;
        internal TextBox AccountBalanceTB;
        internal FontAwesome.Sharp.IconButton HistoryButton;
        internal Label UdhariAmountLabel;
        internal TextBox UdhariAmountTB;
        internal Label UdhariCompleted;
        internal Label KittyCompletedLabel;
        internal Label UdhariCompletedLabel;
        internal Label KittysCompleted;
        internal FontAwesome.Sharp.IconButton AddPurchaseButton;
        internal Label KittyAvailedLabel;
        internal FontAwesome.Sharp.IconButton AddKittyButton;
        internal Label KittysAvailed;
        internal TextBox TillDateAmountTB;
        internal Label ProductCompletedLabel;
        internal Label TillDateAmountLabel;
        internal Label ProductsCompleted;
        internal FontAwesome.Sharp.IconButton KittyDetailsButton;
        internal PhoneNoTag PhoneNoTag1;
        internal Label Label3;
        internal TextBox Adhaar;
    }
}
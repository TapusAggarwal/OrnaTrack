using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class KittyModeCoustView : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(KittyModeCoustView));
            ProfileLabel = new Label();
            NameLabel = new Label();
            CustomerIdTB = new TextBox();
            CustomerIdTB.TextChanged += new EventHandler(CoustmerIdTB_TextChanged);
            CustomerIdTB.KeyDown += new KeyEventHandler(CoustmerIdTB_KeyDown);
            ProfessionLabel = new Label();
            PanelTitleBar = new Panel();
            KittyPanel = new Panel();
            KittyPanel.ControlAdded += new ControlEventHandler(KittyPanel_ControlAdded);
            KittyPanel.ControlRemoved += new ControlEventHandler(KittyPanel_ControlAdded);
            ShowLabel = new Label();
            ToolTip1 = new ToolTip(components);
            ExistingPhNosButton = new FontAwesome.Sharp.IconButton();
            ExistingPhNosButton.Click += new EventHandler(ExistingPhNosButton_Click);
            ConnectKittys = new FontAwesome.Sharp.IconButton();
            ContextMenuStrip1 = new ContextMenuStrip(components);
            ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(ContextMenuStrip1_Opening);
            Prev_SessionToolStripMenuItem = new ToolStripMenuItem();
            Prev_SessionToolStripMenuItem.Click += new EventHandler(Prev_SessionToolStripMenuItem_Click);
            StartNewReviewSessionToolStripMenuItem = new ToolStripMenuItem();
            StartNewReviewSessionToolStripMenuItem.Click += new EventHandler(StartNewReviewSessionToolStripMenuItem_Click);
            ReviewButton = new FontAwesome.Sharp.IconButton();
            ReviewButton.Click += new EventHandler(IconButton1_Click);
            FullName = new Label();
            PhNoLabel = new Label();
            Profession = new Label();
            RegionData = new Label();
            RegionLabel = new Label();
            Address = new Label();
            AddressLabel = new Label();
            Gender = new Label();
            Label9 = new Label();
            Married = new Label();
            MarriedLabel = new Label();
            ProfilePanel = new Panel();
            ImageBox = new PictureBox();
            CustomerDetailsButton = new FontAwesome.Sharp.IconButton();
            CustomerDetailsButton.Click += new EventHandler(CustomerDetailsButton_Click);
            PhNo = new Label();
            PanelView = new Panel();
            KittyIdTB = new TextBox();
            KittyIdTB.TextChanged += new EventHandler(KittyIdTB_TextChanged);
            KittyIdTB.KeyDown += new KeyEventHandler(CoustmerIdTB_KeyDown);
            Panel1 = new Panel();
            KittyInfoLabel = new Label();
            NextKittyButton = new FontAwesome.Sharp.IconButton();
            NextKittyButton.Click += new EventHandler(NextKittyButton_Click);
            PrevKittyButton = new FontAwesome.Sharp.IconButton();
            PrevKittyButton.Click += new EventHandler(PrevKittyButton_Click);
            BookModeButton = new FontAwesome.Sharp.IconButton();
            BookModeButton.Click += new EventHandler(BookModeButton_Click);
            AddKittyButton = new FontAwesome.Sharp.IconButton();
            AddKittyButton.Click += new EventHandler(AddKittyButton_Click);
            JumpToKittyNoButton = new FontAwesome.Sharp.IconButton();
            JumpToKittyNoButton.Click += new EventHandler(JumpToKittyNoButton_Click);
            DotsButton = new FontAwesome.Sharp.IconPictureBox();
            DotsButton.Click += new EventHandler(DotsButton_Click);
            BookModeSelectedTypes = new ContextMenuStrip(components);
            ContextMenuStrip2 = new ContextMenuStrip(components);
            ContextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(ContextMenuStrip2_Opening);
            IconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            IconPictureBox1.Click += new EventHandler(IconPictureBox1_Click);
            KittyPanel.SuspendLayout();
            ContextMenuStrip1.SuspendLayout();
            ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DotsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.BackColor = Color.Transparent;
            ProfileLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileLabel.ForeColor = Color.CornflowerBlue;
            ProfileLabel.Location = new Point(4, 2);
            ProfileLabel.Margin = new Padding(4, 0, 4, 0);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(86, 30);
            ProfileLabel.TabIndex = 255;
            ProfileLabel.Text = "Profile";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = SystemColors.ActiveCaption;
            NameLabel.Location = new Point(11, 286);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(157, 34);
            NameLabel.TabIndex = 189;
            NameLabel.Text = "Full Name:";
            // 
            // CustomerIdTB
            // 
            CustomerIdTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerIdTB.Location = new Point(16, 1019);
            CustomerIdTB.Margin = new Padding(4, 5, 4, 5);
            CustomerIdTB.Name = "CustomerIdTB";
            CustomerIdTB.ReadOnly = true;
            CustomerIdTB.Size = new Size(105, 36);
            CustomerIdTB.TabIndex = 256;
            CustomerIdTB.Tag = "";
            // 
            // ProfessionLabel
            // 
            ProfessionLabel.AutoSize = true;
            ProfessionLabel.BackColor = Color.Transparent;
            ProfessionLabel.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfessionLabel.ForeColor = SystemColors.ActiveCaption;
            ProfessionLabel.Location = new Point(11, 545);
            ProfessionLabel.Margin = new Padding(4, 0, 4, 0);
            ProfessionLabel.Name = "ProfessionLabel";
            ProfessionLabel.Size = new Size(156, 34);
            ProfessionLabel.TabIndex = 195;
            ProfessionLabel.Text = "Profession:";
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.FromArgb(24, 24, 60);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(0, 0);
            PanelTitleBar.Margin = new Padding(4, 5, 4, 5);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(1920, 63);
            PanelTitleBar.TabIndex = 262;
            PanelTitleBar.Visible = false;
            // 
            // KittyPanel
            // 
            KittyPanel.BackColor = Color.FromArgb(36, 30, 60);
            KittyPanel.Controls.Add(ShowLabel);
            KittyPanel.Location = new Point(497, 84);
            KittyPanel.Name = "KittyPanel";
            KittyPanel.Size = new Size(1404, 523);
            KittyPanel.TabIndex = 264;
            // 
            // ShowLabel
            // 
            ShowLabel.AutoSize = true;
            ShowLabel.BackColor = Color.Transparent;
            ShowLabel.Font = new Font("Century Gothic", 20.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowLabel.ForeColor = SystemColors.ControlDarkDark;
            ShowLabel.Location = new Point(335, 238);
            ShowLabel.Margin = new Padding(4, 0, 4, 0);
            ShowLabel.Name = "ShowLabel";
            ShowLabel.Size = new Size(732, 47);
            ShowLabel.TabIndex = 266;
            ShowLabel.Text = "Click On \"Show Details\" Button Below";
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
            ExistingPhNosButton.Location = new Point(413, 344);
            ExistingPhNosButton.Margin = new Padding(4, 5, 4, 5);
            ExistingPhNosButton.Name = "ExistingPhNosButton";
            ExistingPhNosButton.Size = new Size(33, 35);
            ExistingPhNosButton.TabIndex = 263;
            ExistingPhNosButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(ExistingPhNosButton, "All Customers Having Same PhNo As This Customer.");
            ExistingPhNosButton.UseVisualStyleBackColor = false;
            ExistingPhNosButton.Visible = false;
            // 
            // ConnectKittys
            // 
            ConnectKittys.BackColor = Color.Transparent;
            ConnectKittys.ContextMenuStrip = ContextMenuStrip1;
            ConnectKittys.FlatAppearance.BorderSize = 0;
            ConnectKittys.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 55, 90);
            ConnectKittys.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            ConnectKittys.FlatStyle = FlatStyle.Flat;
            ConnectKittys.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConnectKittys.ForeColor = Color.MediumPurple;
            ConnectKittys.IconChar = FontAwesome.Sharp.IconChar.History;
            ConnectKittys.IconColor = Color.MediumPurple;
            ConnectKittys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ConnectKittys.IconSize = 45;
            ConnectKittys.ImageAlign = ContentAlignment.TopCenter;
            ConnectKittys.Location = new Point(1506, 1013);
            ConnectKittys.Margin = new Padding(4, 5, 4, 5);
            ConnectKittys.Name = "ConnectKittys";
            ConnectKittys.Size = new Size(43, 46);
            ConnectKittys.TabIndex = 247;
            ConnectKittys.TextImageRelation = TextImageRelation.TextBeforeImage;
            ToolTip1.SetToolTip(ConnectKittys, "Here You Can Connect Kitties With This Customer");
            ConnectKittys.UseVisualStyleBackColor = false;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { Prev_SessionToolStripMenuItem, StartNewReviewSessionToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(285, 68);
            // 
            // Prev_SessionToolStripMenuItem
            // 
            Prev_SessionToolStripMenuItem.Checked = true;
            Prev_SessionToolStripMenuItem.CheckOnClick = true;
            Prev_SessionToolStripMenuItem.CheckState = CheckState.Checked;
            Prev_SessionToolStripMenuItem.Name = "Prev_SessionToolStripMenuItem";
            Prev_SessionToolStripMenuItem.Size = new Size(284, 32);
            Prev_SessionToolStripMenuItem.Text = "Prev_Session";
            // 
            // StartNewReviewSessionToolStripMenuItem
            // 
            StartNewReviewSessionToolStripMenuItem.Name = "StartNewReviewSessionToolStripMenuItem";
            StartNewReviewSessionToolStripMenuItem.Size = new Size(284, 32);
            StartNewReviewSessionToolStripMenuItem.Text = "Start New Review Session";
            // 
            // ReviewButton
            // 
            ReviewButton.BackColor = Color.Transparent;
            ReviewButton.ContextMenuStrip = ContextMenuStrip1;
            ReviewButton.FlatAppearance.BorderSize = 0;
            ReviewButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 55, 90);
            ReviewButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 90);
            ReviewButton.FlatStyle = FlatStyle.Flat;
            ReviewButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReviewButton.ForeColor = Color.MediumPurple;
            ReviewButton.IconChar = FontAwesome.Sharp.IconChar.Star;
            ReviewButton.IconColor = Color.MediumPurple;
            ReviewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReviewButton.IconSize = 45;
            ReviewButton.ImageAlign = ContentAlignment.TopCenter;
            ReviewButton.Location = new Point(413, 14);
            ReviewButton.Margin = new Padding(4, 5, 4, 5);
            ReviewButton.Name = "ReviewButton";
            ReviewButton.Size = new Size(43, 46);
            ReviewButton.TabIndex = 2988;
            ReviewButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            ToolTip1.SetToolTip(ReviewButton, "Here You Can Connect Kitties With This Customer");
            ReviewButton.UseVisualStyleBackColor = false;
            ReviewButton.Visible = false;
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.BackColor = Color.Transparent;
            FullName.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullName.ForeColor = SystemColors.ControlLightLight;
            FullName.Location = new Point(160, 290);
            FullName.Margin = new Padding(4, 0, 4, 0);
            FullName.Name = "FullName";
            FullName.Size = new Size(170, 30);
            FullName.TabIndex = 265;
            FullName.Text = "Tapus Ranjan";
            // 
            // PhNoLabel
            // 
            PhNoLabel.AutoSize = true;
            PhNoLabel.BackColor = Color.Transparent;
            PhNoLabel.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhNoLabel.ForeColor = SystemColors.ActiveCaption;
            PhNoLabel.Location = new Point(11, 342);
            PhNoLabel.Margin = new Padding(4, 0, 4, 0);
            PhNoLabel.Name = "PhNoLabel";
            PhNoLabel.Size = new Size(95, 34);
            PhNoLabel.TabIndex = 266;
            PhNoLabel.Text = "PhNo:";
            // 
            // Profession
            // 
            Profession.AutoSize = true;
            Profession.BackColor = Color.Transparent;
            Profession.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Profession.ForeColor = SystemColors.ControlLightLight;
            Profession.Location = new Point(160, 549);
            Profession.Margin = new Padding(4, 0, 4, 0);
            Profession.Name = "Profession";
            Profession.Size = new Size(96, 30);
            Profession.TabIndex = 267;
            Profession.Text = "Lawyer";
            // 
            // RegionData
            // 
            RegionData.AutoSize = true;
            RegionData.BackColor = Color.Transparent;
            RegionData.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegionData.ForeColor = SystemColors.ControlLightLight;
            RegionData.Location = new Point(117, 610);
            RegionData.Margin = new Padding(4, 0, 4, 0);
            RegionData.Name = "RegionData";
            RegionData.Size = new Size(171, 30);
            RegionData.TabIndex = 269;
            RegionData.Text = "Bhojpur Bazar";
            // 
            // RegionLabel
            // 
            RegionLabel.AutoSize = true;
            RegionLabel.BackColor = Color.Transparent;
            RegionLabel.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegionLabel.ForeColor = SystemColors.ActiveCaption;
            RegionLabel.Location = new Point(11, 606);
            RegionLabel.Margin = new Padding(4, 0, 4, 0);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(118, 34);
            RegionLabel.TabIndex = 268;
            RegionLabel.Text = "Region:";
            // 
            // Address
            // 
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address.ForeColor = SystemColors.ControlLightLight;
            Address.Location = new Point(15, 706);
            Address.Margin = new Padding(4, 0, 4, 0);
            Address.Name = "Address";
            Address.Size = new Size(444, 118);
            Address.TabIndex = 271;
            Address.Text = "Introduced By kamla Kambosh";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.BackColor = Color.Transparent;
            AddressLabel.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressLabel.ForeColor = SystemColors.ActiveCaption;
            AddressLabel.Location = new Point(11, 667);
            AddressLabel.Margin = new Padding(4, 0, 4, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(129, 34);
            AddressLabel.TabIndex = 270;
            AddressLabel.Text = "Address:";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.BackColor = Color.Transparent;
            Gender.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gender.ForeColor = SystemColors.ControlLightLight;
            Gender.Location = new Point(129, 428);
            Gender.Margin = new Padding(4, 0, 4, 0);
            Gender.Name = "Gender";
            Gender.Size = new Size(103, 30);
            Gender.TabIndex = 2987;
            Gender.Text = "Female";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = SystemColors.ActiveCaption;
            Label9.Location = new Point(11, 423);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(126, 34);
            Label9.TabIndex = 272;
            Label9.Text = "Gender:";
            // 
            // Married
            // 
            Married.AutoSize = true;
            Married.BackColor = Color.Transparent;
            Married.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Married.ForeColor = SystemColors.ControlLightLight;
            Married.Location = new Point(129, 488);
            Married.Margin = new Padding(4, 0, 4, 0);
            Married.Name = "Married";
            Married.Size = new Size(73, 30);
            Married.TabIndex = 275;
            Married.Text = "False";
            // 
            // MarriedLabel
            // 
            MarriedLabel.AutoSize = true;
            MarriedLabel.BackColor = Color.Transparent;
            MarriedLabel.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarriedLabel.ForeColor = SystemColors.ActiveCaption;
            MarriedLabel.Location = new Point(10, 484);
            MarriedLabel.Margin = new Padding(4, 0, 4, 0);
            MarriedLabel.Name = "MarriedLabel";
            MarriedLabel.Size = new Size(126, 34);
            MarriedLabel.TabIndex = 274;
            MarriedLabel.Text = "Married:";
            // 
            // ProfilePanel
            // 
            ProfilePanel.BackColor = Color.FromArgb(36, 30, 60);
            ProfilePanel.Controls.Add(ReviewButton);
            ProfilePanel.Controls.Add(ProfileLabel);
            ProfilePanel.Controls.Add(ImageBox);
            ProfilePanel.Controls.Add(Address);
            ProfilePanel.Controls.Add(RegionData);
            ProfilePanel.Controls.Add(Married);
            ProfilePanel.Controls.Add(Gender);
            ProfilePanel.Controls.Add(Profession);
            ProfilePanel.Controls.Add(CustomerDetailsButton);
            ProfilePanel.Controls.Add(ExistingPhNosButton);
            ProfilePanel.Controls.Add(FullName);
            ProfilePanel.Controls.Add(ProfessionLabel);
            ProfilePanel.Controls.Add(MarriedLabel);
            ProfilePanel.Controls.Add(PhNo);
            ProfilePanel.Controls.Add(NameLabel);
            ProfilePanel.Controls.Add(Label9);
            ProfilePanel.Controls.Add(PhNoLabel);
            ProfilePanel.Controls.Add(AddressLabel);
            ProfilePanel.Controls.Add(RegionLabel);
            ProfilePanel.Location = new Point(17, 82);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(470, 907);
            ProfilePanel.TabIndex = 251;
            // 
            // ImageBox
            // 
            ImageBox.BackgroundImage = (Image)resources.GetObject("ImageBox.BackgroundImage");
            ImageBox.BackgroundImageLayout = ImageLayout.Zoom;
            ImageBox.ErrorImage = (Image)resources.GetObject("ImageBox.ErrorImage");
            ImageBox.InitialImage = (Image)resources.GetObject("ImageBox.InitialImage");
            ImageBox.Location = new Point(122, 31);
            ImageBox.Margin = new Padding(4, 5, 4, 5);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(226, 233);
            ImageBox.TabIndex = 4;
            ImageBox.TabStop = false;
            // 
            // CustomerDetailsButton
            // 
            CustomerDetailsButton.BackColor = Color.FromArgb(25, 25, 70);
            CustomerDetailsButton.FlatAppearance.BorderSize = 0;
            CustomerDetailsButton.FlatStyle = FlatStyle.Flat;
            CustomerDetailsButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerDetailsButton.ForeColor = Color.MediumPurple;
            CustomerDetailsButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            CustomerDetailsButton.IconColor = Color.Black;
            CustomerDetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CustomerDetailsButton.Location = new Point(69, 833);
            CustomerDetailsButton.Margin = new Padding(4, 5, 4, 5);
            CustomerDetailsButton.Name = "CustomerDetailsButton";
            CustomerDetailsButton.Size = new Size(333, 60);
            CustomerDetailsButton.TabIndex = 266;
            CustomerDetailsButton.Text = "Coustmer Details";
            CustomerDetailsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CustomerDetailsButton.UseVisualStyleBackColor = false;
            // 
            // PhNo
            // 
            PhNo.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhNo.ForeColor = SystemColors.ControlLightLight;
            PhNo.Location = new Point(101, 344);
            PhNo.Margin = new Padding(4, 0, 4, 0);
            PhNo.Name = "PhNo";
            PhNo.Size = new Size(294, 67);
            PhNo.TabIndex = 260;
            PhNo.Text = "9816057863, 9882960863, 6239631173, 7018362951";
            // 
            // PanelView
            // 
            PanelView.BackColor = Color.FromArgb(36, 30, 60);
            PanelView.Location = new Point(33, 3);
            PanelView.Name = "PanelView";
            PanelView.Size = new Size(1338, 367);
            PanelView.TabIndex = 264;
            // 
            // KittyIdTB
            // 
            KittyIdTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            KittyIdTB.Location = new Point(129, 1019);
            KittyIdTB.Margin = new Padding(4, 5, 4, 5);
            KittyIdTB.Name = "KittyIdTB";
            KittyIdTB.ReadOnly = true;
            KittyIdTB.Size = new Size(56, 36);
            KittyIdTB.TabIndex = 268;
            KittyIdTB.Tag = "";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(36, 30, 60);
            Panel1.Controls.Add(PanelView);
            Panel1.Location = new Point(496, 615);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1405, 374);
            Panel1.TabIndex = 265;
            // 
            // KittyInfoLabel
            // 
            KittyInfoLabel.AutoSize = true;
            KittyInfoLabel.BackColor = Color.DarkGoldenrod;
            KittyInfoLabel.Font = new Font("Consolas", 22.0f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            KittyInfoLabel.ForeColor = SystemColors.ActiveCaptionText;
            KittyInfoLabel.Location = new Point(863, 1009);
            KittyInfoLabel.Margin = new Padding(4, 0, 4, 0);
            KittyInfoLabel.Name = "KittyInfoLabel";
            KittyInfoLabel.Size = new Size(622, 51);
            KittyInfoLabel.TabIndex = 2989;
            KittyInfoLabel.Text = "₹10,000: #1097: 1011-1300";
            KittyInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            KittyInfoLabel.Visible = false;
            // 
            // NextKittyButton
            // 
            NextKittyButton.AutoSize = true;
            NextKittyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NextKittyButton.BackColor = Color.FromArgb(25, 25, 70);
            NextKittyButton.FlatAppearance.BorderSize = 0;
            NextKittyButton.FlatStyle = FlatStyle.Flat;
            NextKittyButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextKittyButton.ForeColor = Color.MediumPurple;
            NextKittyButton.IconChar = FontAwesome.Sharp.IconChar.Forward;
            NextKittyButton.IconColor = Color.PaleGreen;
            NextKittyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NextKittyButton.IconSize = 40;
            NextKittyButton.Location = new Point(668, 1013);
            NextKittyButton.Margin = new Padding(4, 5, 4, 5);
            NextKittyButton.Name = "NextKittyButton";
            NextKittyButton.Size = new Size(125, 46);
            NextKittyButton.TabIndex = 2991;
            NextKittyButton.Text = "Next";
            NextKittyButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            NextKittyButton.UseVisualStyleBackColor = false;
            NextKittyButton.Visible = false;
            // 
            // PrevKittyButton
            // 
            PrevKittyButton.AutoSize = true;
            PrevKittyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PrevKittyButton.BackColor = Color.FromArgb(25, 25, 70);
            PrevKittyButton.FlatAppearance.BorderSize = 0;
            PrevKittyButton.FlatStyle = FlatStyle.Flat;
            PrevKittyButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrevKittyButton.ForeColor = Color.MediumPurple;
            PrevKittyButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            PrevKittyButton.IconColor = Color.PaleGreen;
            PrevKittyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PrevKittyButton.IconSize = 40;
            PrevKittyButton.Location = new Point(530, 1013);
            PrevKittyButton.Margin = new Padding(4, 5, 4, 5);
            PrevKittyButton.Name = "PrevKittyButton";
            PrevKittyButton.Size = new Size(131, 46);
            PrevKittyButton.TabIndex = 2990;
            PrevKittyButton.Text = "Back";
            PrevKittyButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PrevKittyButton.UseVisualStyleBackColor = false;
            PrevKittyButton.Visible = false;
            // 
            // BookModeButton
            // 
            BookModeButton.AutoSize = true;
            BookModeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BookModeButton.BackColor = Color.FromArgb(25, 25, 70);
            BookModeButton.FlatAppearance.BorderSize = 0;
            BookModeButton.FlatStyle = FlatStyle.Flat;
            BookModeButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookModeButton.ForeColor = Color.MediumPurple;
            BookModeButton.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            BookModeButton.IconColor = Color.Silver;
            BookModeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BookModeButton.Location = new Point(397, 1012);
            BookModeButton.Margin = new Padding(4, 5, 4, 5);
            BookModeButton.Name = "BookModeButton";
            BookModeButton.Size = new Size(54, 54);
            BookModeButton.TabIndex = 2988;
            BookModeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BookModeButton.UseVisualStyleBackColor = false;
            // 
            // AddKittyButton
            // 
            AddKittyButton.BackColor = Color.FromArgb(25, 25, 70);
            AddKittyButton.FlatAppearance.BorderSize = 0;
            AddKittyButton.FlatStyle = FlatStyle.Flat;
            AddKittyButton.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddKittyButton.ForeColor = Color.MediumPurple;
            AddKittyButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            AddKittyButton.IconColor = Color.Black;
            AddKittyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddKittyButton.Location = new Point(1557, 1004);
            AddKittyButton.Margin = new Padding(4, 5, 4, 5);
            AddKittyButton.Name = "AddKittyButton";
            AddKittyButton.Size = new Size(318, 61);
            AddKittyButton.TabIndex = 267;
            AddKittyButton.Text = "Add New Kitty     ";
            AddKittyButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddKittyButton.UseVisualStyleBackColor = false;
            // 
            // JumpToKittyNoButton
            // 
            JumpToKittyNoButton.BackColor = Color.Transparent;
            JumpToKittyNoButton.FlatAppearance.BorderColor = Color.FromArgb(36, 35, 80);
            JumpToKittyNoButton.FlatAppearance.BorderSize = 0;
            JumpToKittyNoButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 35, 80);
            JumpToKittyNoButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 35, 80);
            JumpToKittyNoButton.FlatStyle = FlatStyle.Flat;
            JumpToKittyNoButton.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            JumpToKittyNoButton.ForeColor = Color.MediumPurple;
            JumpToKittyNoButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            JumpToKittyNoButton.IconColor = Color.PaleGreen;
            JumpToKittyNoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            JumpToKittyNoButton.IconSize = 50;
            JumpToKittyNoButton.Location = new Point(797, 1013);
            JumpToKittyNoButton.Margin = new Padding(0);
            JumpToKittyNoButton.Name = "JumpToKittyNoButton";
            JumpToKittyNoButton.Size = new Size(50, 47);
            JumpToKittyNoButton.TabIndex = 2992;
            JumpToKittyNoButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            JumpToKittyNoButton.UseVisualStyleBackColor = false;
            JumpToKittyNoButton.Visible = false;
            // 
            // DotsButton
            // 
            DotsButton.BackColor = Color.Transparent;
            DotsButton.BackgroundImageLayout = ImageLayout.Stretch;
            DotsButton.ForeColor = Color.Silver;
            DotsButton.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            DotsButton.IconColor = Color.Silver;
            DotsButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            DotsButton.IconSize = 47;
            DotsButton.Location = new Point(459, 1019);
            DotsButton.Margin = new Padding(4, 5, 4, 5);
            DotsButton.Name = "DotsButton";
            DotsButton.Size = new Size(47, 47);
            DotsButton.TabIndex = 2993;
            DotsButton.TabStop = false;
            // 
            // BookModeSelectedTypes
            // 
            BookModeSelectedTypes.ImageScalingSize = new Size(24, 24);
            BookModeSelectedTypes.Name = "ContextMenuStrip1";
            BookModeSelectedTypes.Size = new Size(61, 4);
            // 
            // ContextMenuStrip2
            // 
            ContextMenuStrip2.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip2.Name = "ContextMenuStrip2";
            ContextMenuStrip2.Size = new Size(61, 4);
            // 
            // IconPictureBox1
            // 
            IconPictureBox1.BackColor = Color.Transparent;
            IconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            IconPictureBox1.ForeColor = Color.Silver;
            IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            IconPictureBox1.IconColor = Color.Silver;
            IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            IconPictureBox1.IconSize = 47;
            IconPictureBox1.Location = new Point(342, 1018);
            IconPictureBox1.Margin = new Padding(4, 5, 4, 5);
            IconPictureBox1.Name = "IconPictureBox1";
            IconPictureBox1.Size = new Size(47, 47);
            IconPictureBox1.TabIndex = 2995;
            IconPictureBox1.TabStop = false;
            // 
            // KittyModeCoustView
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(36, 35, 80);
            ClientSize = new Size(1920, 1080);
            Controls.Add(IconPictureBox1);
            Controls.Add(JumpToKittyNoButton);
            Controls.Add(NextKittyButton);
            Controls.Add(PrevKittyButton);
            Controls.Add(KittyInfoLabel);
            Controls.Add(BookModeButton);
            Controls.Add(Panel1);
            Controls.Add(KittyIdTB);
            Controls.Add(AddKittyButton);
            Controls.Add(ProfilePanel);
            Controls.Add(KittyPanel);
            Controls.Add(PanelTitleBar);
            Controls.Add(ConnectKittys);
            Controls.Add(CustomerIdTB);
            Controls.Add(DotsButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "KittyModeCoustView";
            Text = "Kitty Records";
            KittyPanel.ResumeLayout(false);
            KittyPanel.PerformLayout();
            ContextMenuStrip1.ResumeLayout(false);
            ProfilePanel.ResumeLayout(false);
            ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DotsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconPictureBox1).EndInit();
            Load += new EventHandler(CoustProfileUpdated_Load);
            Shown += new EventHandler(KittyModeCoustView_Shown);
            KeyDown += new KeyEventHandler(Me_KeyDown);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label ProfileLabel;
        internal FontAwesome.Sharp.IconButton ConnectKittys;
        internal Label KittysCompleted;
        internal PictureBox ImageBox;
        internal Label NameLabel;
        internal TextBox CustomerIdTB;
        internal Label ProfessionLabel;
        internal Panel PanelTitleBar;
        internal FontAwesome.Sharp.IconButton ExistingPhNosButton;
        internal Panel KittyPanel;
        internal ToolTip ToolTip1;
        internal Label FullName;
        internal Label PhNoLabel;
        internal Label Profession;
        internal Label RegionData;
        internal Label RegionLabel;
        internal Label Address;
        internal Label AddressLabel;
        internal Label Gender;
        internal Label Label9;
        internal Label Married;
        internal Label MarriedLabel;
        internal Panel ProfilePanel;
        internal Panel PanelView;
        internal Label ShowLabel;
        internal Label PhNo;
        internal FontAwesome.Sharp.IconButton CustomerDetailsButton;
        internal FontAwesome.Sharp.IconButton AddKittyButton;
        internal TextBox KittyIdTB;
        internal Panel Panel1;
        internal FontAwesome.Sharp.IconButton BookModeButton;
        internal Label KittyInfoLabel;
        internal FontAwesome.Sharp.IconButton PrevKittyButton;
        internal FontAwesome.Sharp.IconButton NextKittyButton;
        internal FontAwesome.Sharp.IconButton JumpToKittyNoButton;
        internal ToolStripMenuItem Prev_SessionToolStripMenuItem;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem StartNewReviewSessionToolStripMenuItem;
        internal FontAwesome.Sharp.IconButton ReviewButton;
        internal FontAwesome.Sharp.IconPictureBox DotsButton;
        internal ContextMenuStrip BookModeSelectedTypes;
        internal ContextMenuStrip ContextMenuStrip2;
        internal FontAwesome.Sharp.IconPictureBox IconPictureBox1;
    }
}
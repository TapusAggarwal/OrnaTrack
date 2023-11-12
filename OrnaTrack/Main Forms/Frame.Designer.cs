using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Frame : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            PanelTitleBar = new Panel();
            IconButton2 = new FontAwesome.Sharp.IconButton();
            IconButton2.Click += new EventHandler(IconButton2_Click_1);
            RoughButton = new FontAwesome.Sharp.IconButton();
            RoughButton.Click += new EventHandler(RoughButton_Click);
            VersionLB = new FontAwesome.Sharp.IconButton();
            VersionLB.Click += new EventHandler(IconButton2_Click);
            ServerContextMenuStrip = new ContextMenuStrip(components);
            ServerContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(ServerContextMenuStrip_Opening);
            WhatsappWebVisibilityToolStripMenuItem = new ToolStripMenuItem();
            WhatsappWebVisibilityToolStripMenuItem.Click += new EventHandler(WhatsappWebVisibilityToolStripMenuItem_Click);
            NotificationToolStripMenuItem = new ToolStripMenuItem();
            NotificationToolStripMenuItem.Click += new EventHandler(NotificationToolStripMenuItem_Click);
            RestartToolStripMenuItem = new ToolStripMenuItem();
            RestartServerToolStripMenuItem = new ToolStripMenuItem();
            RestartServerToolStripMenuItem.Click += new EventHandler(RestartServerToolStripMenuItem_Click);
            CloseServerToolStripMenuItem = new ToolStripMenuItem();
            CloseServerToolStripMenuItem.Click += new EventHandler(CloseServerToolStripMenuItem_Click);
            CleanAllSessionsToolStripMenuItem = new ToolStripMenuItem();
            CleanAllSessionsToolStripMenuItem.Click += new EventHandler(CleanAllSessionsToolStripMenuItem_Click);
            ChangeServerAddressToolStripMenuItem = new ToolStripMenuItem();
            ChangeServerAddressToolStripMenuItem.Click += new EventHandler(ChangeServerAddressToolStripMenuItem_Click);
            TestConnectionToolStripMenuItem = new ToolStripMenuItem();
            TestConnectionToolStripMenuItem.Click += new EventHandler(TestConnectionToolStripMenuItem_Click);
            UpdateServerToolStripMenuItem = new ToolStripMenuItem();
            UpdateServerToolStripMenuItem.Click += new EventHandler(UpdateServerToolStripMenuItem_Click);
            ImageDownloadToolStripMenuItem = new ToolStripMenuItem();
            ImageDownloadToolStripMenuItem.Click += new EventHandler(ImageDownloadToolStripMenuItem_Click);
            IconButton1 = new FontAwesome.Sharp.IconButton();
            IconButton1.Click += new EventHandler(IconButton1_Click);
            WindowsRestoreButton = new FontAwesome.Sharp.IconButton();
            WindowsRestoreButton.Click += new EventHandler(WindowsRestoreButton_Click);
            WindowsMinimizeButton = new FontAwesome.Sharp.IconButton();
            WindowsMinimizeButton.Click += new EventHandler(WindowsMinimizeButton_Click);
            CloseButton = new FontAwesome.Sharp.IconButton();
            CloseButton.Click += new EventHandler(CloseButton_Click);
            SilverRateLabel = new Label();
            GoldRateLabel = new Label();
            SilverButton = new FontAwesome.Sharp.IconButton();
            SilverButton.Click += new EventHandler(SilverButton_Click);
            UserPhNo = new FontAwesome.Sharp.IconButton();
            ConnectionLabel = new FontAwesome.Sharp.IconButton();
            ConnectionLabel.Click += new EventHandler(ConnectionLabel_Click);
            SidePanelButton = new FontAwesome.Sharp.IconPictureBox();
            SidePanelButton.Click += new EventHandler(SidePanelButton_Click);
            LeftArrowButton = new FontAwesome.Sharp.IconPictureBox();
            LeftArrowButton.Click += new EventHandler(LeftArrowButton_Click);
            RightArrowButton = new FontAwesome.Sharp.IconPictureBox();
            RightArrowButton.Click += new EventHandler(LeftArrowButton_Click);
            ProgressBar1 = new ProgressBar();
            PanelMenu = new Panel();
            PictureBox1 = new PictureBox();
            NewCoustmerButton = new FontAwesome.Sharp.IconButton();
            NewCoustmerButton.Click += new EventHandler(NewCoustmerButton_Click);
            SendMessageButton = new FontAwesome.Sharp.IconButton();
            SendMessageButton.Click += new EventHandler(SendMessageButton_Click);
            QuickSearchButton = new FontAwesome.Sharp.IconButton();
            QuickSearchButton.Click += new EventHandler(QuickSearchButton_Click);
            DBSourceToolStripMenuItem = new ToolStripMenuItem();
            DBSourceToolStripMenuItem.Click += new EventHandler(DBSourceToolStripMenuItem_Click);
            PanelTitleBar.SuspendLayout();
            ServerContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SidePanelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftArrowButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightArrowButton).BeginInit();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.FromArgb(24, 24, 60);
            PanelTitleBar.Controls.Add(IconButton2);
            PanelTitleBar.Controls.Add(RoughButton);
            PanelTitleBar.Controls.Add(VersionLB);
            PanelTitleBar.Controls.Add(IconButton1);
            PanelTitleBar.Controls.Add(WindowsRestoreButton);
            PanelTitleBar.Controls.Add(WindowsMinimizeButton);
            PanelTitleBar.Controls.Add(CloseButton);
            PanelTitleBar.Controls.Add(SilverRateLabel);
            PanelTitleBar.Controls.Add(GoldRateLabel);
            PanelTitleBar.Controls.Add(SilverButton);
            PanelTitleBar.Controls.Add(UserPhNo);
            PanelTitleBar.Controls.Add(ConnectionLabel);
            PanelTitleBar.Controls.Add(SidePanelButton);
            PanelTitleBar.Controls.Add(LeftArrowButton);
            PanelTitleBar.Controls.Add(RightArrowButton);
            PanelTitleBar.Controls.Add(ProgressBar1);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(0, 0);
            PanelTitleBar.Margin = new Padding(4, 5, 4, 5);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(1924, 63);
            PanelTitleBar.TabIndex = 138;
            // 
            // IconButton2
            // 
            IconButton2.BackColor = Color.Transparent;
            IconButton2.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 60);
            IconButton2.FlatAppearance.BorderSize = 0;
            IconButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            IconButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            IconButton2.FlatStyle = FlatStyle.Flat;
            IconButton2.Font = new Font("Comic Sans MS", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconButton2.ForeColor = Color.WhiteSmoke;
            IconButton2.IconChar = FontAwesome.Sharp.IconChar.Globe;
            IconButton2.IconColor = Color.WhiteSmoke;
            IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton2.IconSize = 60;
            IconButton2.Location = new Point(316, 3);
            IconButton2.Margin = new Padding(4, 5, 4, 5);
            IconButton2.Name = "IconButton2";
            IconButton2.Size = new Size(96, 58);
            IconButton2.TabIndex = 270;
            IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButton2.UseVisualStyleBackColor = false;
            IconButton2.Visible = false;
            // 
            // RoughButton
            // 
            RoughButton.BackColor = Color.Transparent;
            RoughButton.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 60);
            RoughButton.FlatAppearance.BorderSize = 0;
            RoughButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            RoughButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            RoughButton.FlatStyle = FlatStyle.Flat;
            RoughButton.Font = new Font("Comic Sans MS", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoughButton.ForeColor = Color.WhiteSmoke;
            RoughButton.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            RoughButton.IconColor = Color.WhiteSmoke;
            RoughButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RoughButton.IconSize = 60;
            RoughButton.Location = new Point(231, 3);
            RoughButton.Margin = new Padding(4, 5, 4, 5);
            RoughButton.Name = "RoughButton";
            RoughButton.Size = new Size(100, 58);
            RoughButton.TabIndex = 269;
            RoughButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RoughButton.UseVisualStyleBackColor = false;
            // 
            // VersionLB
            // 
            VersionLB.BackColor = Color.Transparent;
            VersionLB.ContextMenuStrip = ServerContextMenuStrip;
            VersionLB.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 60);
            VersionLB.FlatAppearance.BorderSize = 0;
            VersionLB.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 24, 60);
            VersionLB.FlatAppearance.MouseOverBackColor = Color.Transparent;
            VersionLB.FlatStyle = FlatStyle.Flat;
            VersionLB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            VersionLB.ForeColor = Color.White;
            VersionLB.IconChar = FontAwesome.Sharp.IconChar.CodeBranch;
            VersionLB.IconColor = Color.White;
            VersionLB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            VersionLB.IconSize = 60;
            VersionLB.Location = new Point(723, 3);
            VersionLB.Margin = new Padding(4, 5, 4, 5);
            VersionLB.Name = "VersionLB";
            VersionLB.Size = new Size(325, 58);
            VersionLB.TabIndex = 268;
            VersionLB.Text = "V-1.0.1";
            VersionLB.TextImageRelation = TextImageRelation.ImageBeforeText;
            VersionLB.UseVisualStyleBackColor = false;
            VersionLB.Visible = false;
            // 
            // ServerContextMenuStrip
            // 
            ServerContextMenuStrip.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServerContextMenuStrip.ImageScalingSize = new Size(24, 24);
            ServerContextMenuStrip.Items.AddRange(new ToolStripItem[] { WhatsappWebVisibilityToolStripMenuItem, NotificationToolStripMenuItem, RestartToolStripMenuItem, ChangeServerAddressToolStripMenuItem, TestConnectionToolStripMenuItem, UpdateServerToolStripMenuItem, ImageDownloadToolStripMenuItem, DBSourceToolStripMenuItem });
            ServerContextMenuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            ServerContextMenuStrip.Name = "ServerContextMenuStrip";
            ServerContextMenuStrip.RenderMode = ToolStripRenderMode.Professional;
            ServerContextMenuStrip.Size = new Size(296, 260);
            // 
            // WhatsappWebVisibilityToolStripMenuItem
            // 
            WhatsappWebVisibilityToolStripMenuItem.Name = "WhatsappWebVisibilityToolStripMenuItem";
            WhatsappWebVisibilityToolStripMenuItem.Size = new Size(295, 32);
            WhatsappWebVisibilityToolStripMenuItem.Text = "Change Visibilty";
            // 
            // NotificationToolStripMenuItem
            // 
            NotificationToolStripMenuItem.Name = "NotificationToolStripMenuItem";
            NotificationToolStripMenuItem.Size = new Size(295, 32);
            NotificationToolStripMenuItem.Text = "Notifications: Turned On";
            // 
            // RestartToolStripMenuItem
            // 
            RestartToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RestartServerToolStripMenuItem, CloseServerToolStripMenuItem, CleanAllSessionsToolStripMenuItem });
            RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
            RestartToolStripMenuItem.Size = new Size(295, 32);
            RestartToolStripMenuItem.Text = "Server Options";
            // 
            // RestartServerToolStripMenuItem
            // 
            RestartServerToolStripMenuItem.Name = "RestartServerToolStripMenuItem";
            RestartServerToolStripMenuItem.Size = new Size(279, 34);
            RestartServerToolStripMenuItem.Text = "Restart Server";
            // 
            // CloseServerToolStripMenuItem
            // 
            CloseServerToolStripMenuItem.Name = "CloseServerToolStripMenuItem";
            CloseServerToolStripMenuItem.Size = new Size(279, 34);
            CloseServerToolStripMenuItem.Text = "Close Server";
            // 
            // CleanAllSessionsToolStripMenuItem
            // 
            CleanAllSessionsToolStripMenuItem.Name = "CleanAllSessionsToolStripMenuItem";
            CleanAllSessionsToolStripMenuItem.Size = new Size(279, 34);
            CleanAllSessionsToolStripMenuItem.Text = "Clean All Sessions";
            // 
            // ChangeServerAddressToolStripMenuItem
            // 
            ChangeServerAddressToolStripMenuItem.Name = "ChangeServerAddressToolStripMenuItem";
            ChangeServerAddressToolStripMenuItem.Size = new Size(295, 32);
            ChangeServerAddressToolStripMenuItem.Text = "Change Server Address";
            // 
            // TestConnectionToolStripMenuItem
            // 
            TestConnectionToolStripMenuItem.Name = "TestConnectionToolStripMenuItem";
            TestConnectionToolStripMenuItem.Size = new Size(295, 32);
            TestConnectionToolStripMenuItem.Text = "Test Connection";
            // 
            // UpdateServerToolStripMenuItem
            // 
            UpdateServerToolStripMenuItem.Name = "UpdateServerToolStripMenuItem";
            UpdateServerToolStripMenuItem.Size = new Size(295, 32);
            UpdateServerToolStripMenuItem.Text = "Update Server";
            // 
            // ImageDownloadToolStripMenuItem
            // 
            ImageDownloadToolStripMenuItem.Name = "ImageDownloadToolStripMenuItem";
            ImageDownloadToolStripMenuItem.Size = new Size(295, 32);
            ImageDownloadToolStripMenuItem.Text = "Download Image";
            // 
            // IconButton1
            // 
            IconButton1.BackColor = Color.Transparent;
            IconButton1.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 60);
            IconButton1.FlatAppearance.BorderSize = 0;
            IconButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            IconButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            IconButton1.FlatStyle = FlatStyle.Flat;
            IconButton1.Font = new Font("Comic Sans MS", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconButton1.ForeColor = Color.WhiteSmoke;
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            IconButton1.IconColor = Color.WhiteSmoke;
            IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton1.IconSize = 60;
            IconButton1.Location = new Point(392, 3);
            IconButton1.Margin = new Padding(4, 5, 4, 5);
            IconButton1.Name = "IconButton1";
            IconButton1.Size = new Size(100, 58);
            IconButton1.TabIndex = 267;
            IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButton1.UseVisualStyleBackColor = false;
            // 
            // WindowsRestoreButton
            // 
            WindowsRestoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WindowsRestoreButton.BackColor = Color.Transparent;
            WindowsRestoreButton.FlatAppearance.BorderSize = 0;
            WindowsRestoreButton.FlatAppearance.MouseDownBackColor = Color.Maroon;
            WindowsRestoreButton.FlatAppearance.MouseOverBackColor = Color.Red;
            WindowsRestoreButton.FlatStyle = FlatStyle.Flat;
            WindowsRestoreButton.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            WindowsRestoreButton.ForeColor = Color.Linen;
            WindowsRestoreButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            WindowsRestoreButton.IconColor = Color.White;
            WindowsRestoreButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            WindowsRestoreButton.IconSize = 32;
            WindowsRestoreButton.ImageAlign = ContentAlignment.BottomCenter;
            WindowsRestoreButton.Location = new Point(1833, -2);
            WindowsRestoreButton.Margin = new Padding(4, 5, 4, 5);
            WindowsRestoreButton.Name = "WindowsRestoreButton";
            WindowsRestoreButton.Size = new Size(47, 42);
            WindowsRestoreButton.TabIndex = 266;
            WindowsRestoreButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            WindowsRestoreButton.UseVisualStyleBackColor = false;
            // 
            // WindowsMinimizeButton
            // 
            WindowsMinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WindowsMinimizeButton.BackColor = Color.Transparent;
            WindowsMinimizeButton.FlatAppearance.BorderSize = 0;
            WindowsMinimizeButton.FlatAppearance.MouseDownBackColor = Color.Maroon;
            WindowsMinimizeButton.FlatAppearance.MouseOverBackColor = Color.Red;
            WindowsMinimizeButton.FlatStyle = FlatStyle.Flat;
            WindowsMinimizeButton.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            WindowsMinimizeButton.ForeColor = Color.Linen;
            WindowsMinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            WindowsMinimizeButton.IconColor = Color.White;
            WindowsMinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            WindowsMinimizeButton.IconSize = 32;
            WindowsMinimizeButton.ImageAlign = ContentAlignment.BottomCenter;
            WindowsMinimizeButton.Location = new Point(1787, -2);
            WindowsMinimizeButton.Margin = new Padding(4, 5, 4, 5);
            WindowsMinimizeButton.Name = "WindowsMinimizeButton";
            WindowsMinimizeButton.Size = new Size(47, 42);
            WindowsMinimizeButton.TabIndex = 265;
            WindowsMinimizeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            WindowsMinimizeButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Maroon;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = Color.Linen;
            CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            CloseButton.IconColor = Color.White;
            CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CloseButton.IconSize = 32;
            CloseButton.ImageAlign = ContentAlignment.BottomCenter;
            CloseButton.Location = new Point(1879, -2);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(47, 42);
            CloseButton.TabIndex = 263;
            CloseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // SilverRateLabel
            // 
            SilverRateLabel.AutoSize = true;
            SilverRateLabel.BackColor = Color.Transparent;
            SilverRateLabel.Font = new Font("Comic Sans MS", 15.0f);
            SilverRateLabel.ForeColor = Color.LimeGreen;
            SilverRateLabel.Location = new Point(448, 11);
            SilverRateLabel.Name = "SilverRateLabel";
            SilverRateLabel.Size = new Size(0, 42);
            SilverRateLabel.TabIndex = 173;
            SilverRateLabel.Visible = false;
            // 
            // GoldRateLabel
            // 
            GoldRateLabel.AutoSize = true;
            GoldRateLabel.BackColor = Color.Transparent;
            GoldRateLabel.Font = new Font("Comic Sans MS", 15.0f);
            GoldRateLabel.ForeColor = Color.LimeGreen;
            GoldRateLabel.Location = new Point(992, 11);
            GoldRateLabel.Name = "GoldRateLabel";
            GoldRateLabel.Size = new Size(0, 42);
            GoldRateLabel.TabIndex = 172;
            GoldRateLabel.Visible = false;
            // 
            // SilverButton
            // 
            SilverButton.BackColor = Color.Transparent;
            SilverButton.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 60);
            SilverButton.FlatAppearance.BorderSize = 0;
            SilverButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SilverButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SilverButton.FlatStyle = FlatStyle.Flat;
            SilverButton.Font = new Font("Comic Sans MS", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SilverButton.ForeColor = Color.WhiteSmoke;
            SilverButton.IconChar = FontAwesome.Sharp.IconChar.Globe;
            SilverButton.IconColor = Color.WhiteSmoke;
            SilverButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SilverButton.IconSize = 60;
            SilverButton.Location = new Point(500, 3);
            SilverButton.Margin = new Padding(4, 5, 4, 5);
            SilverButton.Name = "SilverButton";
            SilverButton.Size = new Size(96, 58);
            SilverButton.TabIndex = 172;
            SilverButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SilverButton.UseVisualStyleBackColor = false;
            // 
            // UserPhNo
            // 
            UserPhNo.AutoSize = true;
            UserPhNo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UserPhNo.BackColor = Color.Transparent;
            UserPhNo.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 60);
            UserPhNo.FlatAppearance.BorderSize = 0;
            UserPhNo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            UserPhNo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            UserPhNo.FlatStyle = FlatStyle.Flat;
            UserPhNo.Font = new Font("Comic Sans MS", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserPhNo.ForeColor = Color.Green;
            UserPhNo.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            UserPhNo.IconColor = Color.Green;
            UserPhNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UserPhNo.IconSize = 60;
            UserPhNo.Location = new Point(1171, 3);
            UserPhNo.Margin = new Padding(4, 5, 4, 5);
            UserPhNo.Name = "UserPhNo";
            UserPhNo.Size = new Size(268, 66);
            UserPhNo.TabIndex = 167;
            UserPhNo.Text = "9882960863";
            UserPhNo.TextImageRelation = TextImageRelation.TextBeforeImage;
            UserPhNo.UseVisualStyleBackColor = false;
            UserPhNo.Visible = false;
            // 
            // ConnectionLabel
            // 
            ConnectionLabel.BackColor = Color.Transparent;
            ConnectionLabel.ContextMenuStrip = ServerContextMenuStrip;
            ConnectionLabel.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 60);
            ConnectionLabel.FlatAppearance.BorderSize = 0;
            ConnectionLabel.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 24, 60);
            ConnectionLabel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ConnectionLabel.FlatStyle = FlatStyle.Flat;
            ConnectionLabel.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConnectionLabel.ForeColor = Color.Red;
            ConnectionLabel.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            ConnectionLabel.IconColor = Color.Goldenrod;
            ConnectionLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ConnectionLabel.IconSize = 60;
            ConnectionLabel.Location = new Point(1449, 3);
            ConnectionLabel.Margin = new Padding(4, 5, 4, 5);
            ConnectionLabel.Name = "ConnectionLabel";
            ConnectionLabel.Size = new Size(325, 58);
            ConnectionLabel.TabIndex = 165;
            ConnectionLabel.Text = "Not Connected";
            ConnectionLabel.TextImageRelation = TextImageRelation.ImageBeforeText;
            ConnectionLabel.UseVisualStyleBackColor = false;
            // 
            // SidePanelButton
            // 
            SidePanelButton.BackColor = Color.FromArgb(24, 24, 60);
            SidePanelButton.BackgroundImageLayout = ImageLayout.Stretch;
            SidePanelButton.ForeColor = SystemColors.ControlText;
            SidePanelButton.IconChar = FontAwesome.Sharp.IconChar.Database;
            SidePanelButton.IconColor = SystemColors.ControlText;
            SidePanelButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            SidePanelButton.IconSize = 46;
            SidePanelButton.Location = new Point(13, 5);
            SidePanelButton.Margin = new Padding(4, 5, 4, 5);
            SidePanelButton.Name = "SidePanelButton";
            SidePanelButton.Size = new Size(48, 46);
            SidePanelButton.TabIndex = 141;
            SidePanelButton.TabStop = false;
            // 
            // LeftArrowButton
            // 
            LeftArrowButton.BackColor = Color.FromArgb(24, 24, 60);
            LeftArrowButton.BackgroundImageLayout = ImageLayout.Stretch;
            LeftArrowButton.ForeColor = SystemColors.ControlText;
            LeftArrowButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            LeftArrowButton.IconColor = SystemColors.ControlText;
            LeftArrowButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            LeftArrowButton.IconSize = 46;
            LeftArrowButton.Location = new Point(118, 8);
            LeftArrowButton.Margin = new Padding(4, 5, 4, 5);
            LeftArrowButton.Name = "LeftArrowButton";
            LeftArrowButton.Size = new Size(48, 46);
            LeftArrowButton.TabIndex = 140;
            LeftArrowButton.TabStop = false;
            // 
            // RightArrowButton
            // 
            RightArrowButton.BackColor = Color.FromArgb(24, 24, 60);
            RightArrowButton.BackgroundImageLayout = ImageLayout.Stretch;
            RightArrowButton.ForeColor = SystemColors.ControlText;
            RightArrowButton.IconChar = FontAwesome.Sharp.IconChar.Forward;
            RightArrowButton.IconColor = SystemColors.ControlText;
            RightArrowButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            RightArrowButton.IconSize = 46;
            RightArrowButton.Location = new Point(175, 8);
            RightArrowButton.Margin = new Padding(4, 5, 4, 5);
            RightArrowButton.Name = "RightArrowButton";
            RightArrowButton.Size = new Size(48, 46);
            RightArrowButton.TabIndex = 139;
            RightArrowButton.TabStop = false;
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(628, 22);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(482, 24);
            ProgressBar1.Step = 1;
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            ProgressBar1.TabIndex = 172;
            ProgressBar1.Visible = false;
            // 
            // PanelMenu
            // 
            PanelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelMenu.BackColor = Color.FromArgb(32, 32, 65);
            PanelMenu.Controls.Add(PictureBox1);
            PanelMenu.Controls.Add(NewCoustmerButton);
            PanelMenu.Controls.Add(SendMessageButton);
            PanelMenu.Controls.Add(QuickSearchButton);
            PanelMenu.Location = new Point(0, 63);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(340, 987);
            PanelMenu.TabIndex = 170;
            PanelMenu.Visible = false;
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(-1, 18);
            PictureBox1.Margin = new Padding(4, 5, 4, 5);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(336, 177);
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // NewCoustmerButton
            // 
            NewCoustmerButton.BackColor = Color.FromArgb(25, 25, 70);
            NewCoustmerButton.FlatAppearance.BorderSize = 0;
            NewCoustmerButton.FlatStyle = FlatStyle.Flat;
            NewCoustmerButton.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewCoustmerButton.ForeColor = Color.MediumPurple;
            NewCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            NewCoustmerButton.IconColor = Color.Black;
            NewCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NewCoustmerButton.IconSize = 40;
            NewCoustmerButton.Location = new Point(0, 333);
            NewCoustmerButton.Margin = new Padding(4, 5, 4, 5);
            NewCoustmerButton.Name = "NewCoustmerButton";
            NewCoustmerButton.Size = new Size(340, 91);
            NewCoustmerButton.TabIndex = 163;
            NewCoustmerButton.Text = "Add habitué";
            NewCoustmerButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            NewCoustmerButton.UseVisualStyleBackColor = false;
            // 
            // SendMessageButton
            // 
            SendMessageButton.BackColor = Color.FromArgb(25, 25, 70);
            SendMessageButton.FlatAppearance.BorderSize = 0;
            SendMessageButton.FlatStyle = FlatStyle.Flat;
            SendMessageButton.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendMessageButton.ForeColor = Color.MediumPurple;
            SendMessageButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            SendMessageButton.IconColor = Color.Black;
            SendMessageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SendMessageButton.IconSize = 40;
            SendMessageButton.Location = new Point(0, 436);
            SendMessageButton.Margin = new Padding(4, 5, 4, 5);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Size = new Size(340, 91);
            SendMessageButton.TabIndex = 164;
            SendMessageButton.Text = "Send Message";
            SendMessageButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            SendMessageButton.UseVisualStyleBackColor = false;
            // 
            // QuickSearchButton
            // 
            QuickSearchButton.BackColor = Color.FromArgb(25, 25, 70);
            QuickSearchButton.FlatAppearance.BorderSize = 0;
            QuickSearchButton.FlatStyle = FlatStyle.Flat;
            QuickSearchButton.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuickSearchButton.ForeColor = Color.MediumPurple;
            QuickSearchButton.IconChar = FontAwesome.Sharp.IconChar.Server;
            QuickSearchButton.IconColor = Color.Black;
            QuickSearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            QuickSearchButton.IconSize = 40;
            QuickSearchButton.Location = new Point(0, 229);
            QuickSearchButton.Margin = new Padding(4, 5, 4, 5);
            QuickSearchButton.Name = "QuickSearchButton";
            QuickSearchButton.Size = new Size(340, 91);
            QuickSearchButton.TabIndex = 142;
            QuickSearchButton.Text = "Insta  Search";
            QuickSearchButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            QuickSearchButton.UseVisualStyleBackColor = false;
            // 
            // DBSourceToolStripMenuItem
            // 
            DBSourceToolStripMenuItem.Name = "DBSourceToolStripMenuItem";
            DBSourceToolStripMenuItem.Size = new Size(295, 32);
            DBSourceToolStripMenuItem.Text = "DB Source";
            // 
            // Frame
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(36, 35, 80);
            ClientSize = new Size(1924, 1050);
            Controls.Add(PanelTitleBar);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frame";
            Text = "Frame";
            WindowState = FormWindowState.Maximized;
            PanelTitleBar.ResumeLayout(false);
            PanelTitleBar.PerformLayout();
            ServerContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SidePanelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftArrowButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightArrowButton).EndInit();
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Frame_Load);
            KeyDown += new KeyEventHandler(Frame_KeyDown);
            MdiChildActivate += new EventHandler(Frame_MdiChildActivate);
            Resize += new EventHandler(Frame_Resize);
            ResumeLayout(false);

        }
        internal Panel PanelTitleBar;
        internal FontAwesome.Sharp.IconPictureBox LeftArrowButton;
        internal FontAwesome.Sharp.IconPictureBox RightArrowButton;
        internal FontAwesome.Sharp.IconPictureBox SidePanelButton;
        internal FontAwesome.Sharp.IconButton ConnectionLabel;
        internal FontAwesome.Sharp.IconButton UserPhNo;
        internal FontAwesome.Sharp.IconButton SendMessageButton;
        internal PictureBox PictureBox1;
        internal FontAwesome.Sharp.IconButton NewCoustmerButton;
        internal FontAwesome.Sharp.IconButton QuickSearchButton;
        internal Panel PanelMenu;
        internal Label GoldRateLabel;
        internal FontAwesome.Sharp.IconButton SilverButton;
        internal Label SilverRateLabel;
        internal FontAwesome.Sharp.IconButton CloseButton;
        internal ContextMenuStrip ServerContextMenuStrip;
        internal ToolStripMenuItem WhatsappWebVisibilityToolStripMenuItem;
        internal ToolStripMenuItem NotificationToolStripMenuItem;
        internal ToolStripMenuItem RestartToolStripMenuItem;
        internal FontAwesome.Sharp.IconButton WindowsRestoreButton;
        internal FontAwesome.Sharp.IconButton WindowsMinimizeButton;
        internal ToolStripMenuItem ChangeServerAddressToolStripMenuItem;
        internal ToolStripMenuItem RestartServerToolStripMenuItem;
        internal ToolStripMenuItem CloseServerToolStripMenuItem;
        internal ToolStripMenuItem TestConnectionToolStripMenuItem;
        internal ToolStripMenuItem CleanAllSessionsToolStripMenuItem;
        internal ToolStripMenuItem UpdateServerToolStripMenuItem;
        internal FontAwesome.Sharp.IconButton IconButton1;
        internal FontAwesome.Sharp.IconButton VersionLB;
        internal ProgressBar ProgressBar1;
        internal FontAwesome.Sharp.IconButton RoughButton;
        internal ToolStripMenuItem ImageDownloadToolStripMenuItem;
        internal FontAwesome.Sharp.IconButton IconButton2;
        internal ToolStripMenuItem DBSourceToolStripMenuItem;
    }
}
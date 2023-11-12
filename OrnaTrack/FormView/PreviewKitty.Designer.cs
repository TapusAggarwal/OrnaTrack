using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PreviewKitty : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewKitty));
            ProfilePanel = new Panel();
            Panel1 = new Panel();
            AllKittiesBT = new FontAwesome.Sharp.IconButton();
            AllKittiesBT.Click += new EventHandler(AllKittiesBT_Click);
            SaveCoustmerButton = new FontAwesome.Sharp.IconButton();
            SaveCoustmerButton.Click += new EventHandler(SaveCoustmerButton_Click);
            ProfileLabel = new Label();
            ImageBox = new PictureBox();
            KittyPanel = new Panel();
            KittyIdTB = new TextBox();
            ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ProfilePanel
            // 
            ProfilePanel.BackColor = Color.FromArgb(36, 30, 60);
            ProfilePanel.Controls.Add(KittyIdTB);
            ProfilePanel.Controls.Add(Panel1);
            ProfilePanel.Controls.Add(AllKittiesBT);
            ProfilePanel.Controls.Add(SaveCoustmerButton);
            ProfilePanel.Controls.Add(ProfileLabel);
            ProfilePanel.Controls.Add(ImageBox);
            ProfilePanel.Dock = DockStyle.Bottom;
            ProfilePanel.Location = new Point(0, 529);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(1405, 368);
            ProfilePanel.TabIndex = 252;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(36, 35, 70);
            Panel1.Location = new Point(244, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(839, 359);
            Panel1.TabIndex = 6;
            // 
            // AllKittiesBT
            // 
            AllKittiesBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AllKittiesBT.BackColor = Color.FromArgb(25, 25, 70);
            AllKittiesBT.FlatAppearance.BorderSize = 0;
            AllKittiesBT.FlatStyle = FlatStyle.Flat;
            AllKittiesBT.Font = new Font("Cambria", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllKittiesBT.ForeColor = Color.MediumPurple;
            AllKittiesBT.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            AllKittiesBT.IconColor = Color.Black;
            AllKittiesBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AllKittiesBT.Location = new Point(1092, 159);
            AllKittiesBT.Margin = new Padding(4, 5, 4, 5);
            AllKittiesBT.Name = "AllKittiesBT";
            AllKittiesBT.Padding = new Padding(15, 0, 30, 0);
            AllKittiesBT.Size = new Size(313, 76);
            AllKittiesBT.TabIndex = 2989;
            AllKittiesBT.Text = "All Kitties";
            AllKittiesBT.TextAlign = ContentAlignment.MiddleLeft;
            AllKittiesBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AllKittiesBT.UseVisualStyleBackColor = false;
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
            SaveCoustmerButton.Location = new Point(1092, 74);
            SaveCoustmerButton.Margin = new Padding(4, 5, 4, 5);
            SaveCoustmerButton.Name = "SaveCoustmerButton";
            SaveCoustmerButton.Padding = new Padding(15, 0, 30, 0);
            SaveCoustmerButton.Size = new Size(313, 76);
            SaveCoustmerButton.TabIndex = 2988;
            SaveCoustmerButton.Text = "Save Record";
            SaveCoustmerButton.TextAlign = ContentAlignment.MiddleLeft;
            SaveCoustmerButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveCoustmerButton.UseVisualStyleBackColor = false;
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
            // ImageBox
            // 
            ImageBox.BackgroundImage = (Image)resources.GetObject("ImageBox.BackgroundImage");
            ImageBox.BackgroundImageLayout = ImageLayout.Zoom;
            ImageBox.ErrorImage = (Image)resources.GetObject("ImageBox.ErrorImage");
            ImageBox.InitialImage = (Image)resources.GetObject("ImageBox.InitialImage");
            ImageBox.Location = new Point(13, 68);
            ImageBox.Margin = new Padding(4, 5, 4, 5);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(226, 233);
            ImageBox.TabIndex = 4;
            ImageBox.TabStop = false;
            // 
            // KittyPanel
            // 
            KittyPanel.BackColor = Color.FromArgb(36, 30, 60);
            KittyPanel.Dock = DockStyle.Fill;
            KittyPanel.Location = new Point(0, 0);
            KittyPanel.MaximumSize = new Size(1404, 523);
            KittyPanel.MinimumSize = new Size(1404, 523);
            KittyPanel.Name = "KittyPanel";
            KittyPanel.Size = new Size(1404, 523);
            KittyPanel.TabIndex = 265;
            // 
            // KittyIdTB
            // 
            KittyIdTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            KittyIdTB.Location = new Point(9, 318);
            KittyIdTB.Margin = new Padding(4, 5, 4, 5);
            KittyIdTB.Name = "KittyIdTB";
            KittyIdTB.ReadOnly = true;
            KittyIdTB.Size = new Size(56, 36);
            KittyIdTB.TabIndex = 2990;
            KittyIdTB.Tag = "";
            // 
            // PreviewKitty
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 35, 80);
            ClientSize = new Size(1405, 897);
            Controls.Add(KittyPanel);
            Controls.Add(ProfilePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PreviewKitty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreviewKitty";
            ProfilePanel.ResumeLayout(false);
            ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            KeyDown += new KeyEventHandler(Me_KeyDown);
            Load += new EventHandler(PreviewKitty_Load);
            ResumeLayout(false);

        }

        internal Panel ProfilePanel;
        internal Label ProfileLabel;
        internal PictureBox ImageBox;
        internal Panel KittyPanel;
        internal Panel Panel1;
        internal FontAwesome.Sharp.IconButton AllKittiesBT;
        internal FontAwesome.Sharp.IconButton SaveCoustmerButton;
        internal TextBox KittyIdTB;
    }
}
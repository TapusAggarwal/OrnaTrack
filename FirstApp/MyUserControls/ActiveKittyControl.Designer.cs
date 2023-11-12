using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ActiveKittyControl : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
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
            ImagePanel2 = new Panel();
            ImageParam = new PictureBox();
            Panel2 = new Panel();
            ActiveKittyParam = new Label();
            ActiveKittyLabel = new Label();
            NeverLabel = new Label();
            CoustmerIdParam = new Label();
            _DetailsButton = new FontAwesome.Sharp.IconButton();
            _DetailsButton.Click += new EventHandler(DetailsButton_Click);
            SrNoParam = new Label();
            CloseButton = new FontAwesome.Sharp.IconButton();
            CloseButton.Click += new EventHandler(CloseButton_Click);
            PhNoParam = new Label();
            NameParam = new Label();
            ImagePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageParam).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ImagePanel2
            // 
            ImagePanel2.BackColor = Color.FromArgb(32, 32, 67);
            ImagePanel2.Controls.Add(ImageParam);
            ImagePanel2.Location = new Point(56, 3);
            ImagePanel2.Margin = new Padding(4, 5, 4, 5);
            ImagePanel2.Name = "ImagePanel2";
            ImagePanel2.Size = new Size(180, 228);
            ImagePanel2.TabIndex = 177;
            // 
            // ImageParam
            // 
            ImageParam.BackgroundImageLayout = ImageLayout.Zoom;
            ImageParam.Image = My.Resources.Resources.addSign;
            ImageParam.Location = new Point(3, 26);
            ImageParam.Margin = new Padding(4, 5, 4, 5);
            ImageParam.Name = "ImageParam";
            ImageParam.Size = new Size(174, 177);
            ImageParam.SizeMode = PictureBoxSizeMode.Zoom;
            ImageParam.TabIndex = 7;
            ImageParam.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(32, 32, 32);
            Panel2.Controls.Add(ActiveKittyParam);
            Panel2.Controls.Add(ActiveKittyLabel);
            Panel2.Controls.Add(NeverLabel);
            Panel2.Controls.Add(CoustmerIdParam);
            Panel2.Controls.Add(_DetailsButton);
            Panel2.Controls.Add(SrNoParam);
            Panel2.Controls.Add(CloseButton);
            Panel2.Controls.Add(PhNoParam);
            Panel2.Controls.Add(NameParam);
            Panel2.Location = new Point(6, 24);
            Panel2.Margin = new Padding(4, 5, 4, 5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(787, 186);
            Panel2.TabIndex = 176;
            // 
            // ActiveKittyParam
            // 
            ActiveKittyParam.BackColor = Color.Transparent;
            ActiveKittyParam.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActiveKittyParam.ForeColor = Color.LimeGreen;
            ActiveKittyParam.Location = new Point(444, 88);
            ActiveKittyParam.Margin = new Padding(4, 0, 4, 0);
            ActiveKittyParam.Name = "ActiveKittyParam";
            ActiveKittyParam.Size = new Size(87, 26);
            ActiveKittyParam.TabIndex = 170;
            ActiveKittyParam.Text = "2";
            ActiveKittyParam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ActiveKittyLabel
            // 
            ActiveKittyLabel.BackColor = Color.Transparent;
            ActiveKittyLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActiveKittyLabel.ForeColor = Color.FromArgb(0, 150, 150);
            ActiveKittyLabel.Location = new Point(256, 83);
            ActiveKittyLabel.Margin = new Padding(4, 0, 4, 0);
            ActiveKittyLabel.Name = "ActiveKittyLabel";
            ActiveKittyLabel.Size = new Size(190, 37);
            ActiveKittyLabel.TabIndex = 169;
            ActiveKittyLabel.Text = "Active Kitty:";
            ActiveKittyLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NeverLabel
            // 
            NeverLabel.AutoSize = true;
            NeverLabel.Font = new Font("Comic Sans MS", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NeverLabel.ForeColor = Color.Red;
            NeverLabel.Location = new Point(282, 85);
            NeverLabel.Margin = new Padding(4, 0, 4, 0);
            NeverLabel.Name = "NeverLabel";
            NeverLabel.Size = new Size(215, 35);
            NeverLabel.TabIndex = 171;
            NeverLabel.Text = "Never A Member";
            NeverLabel.Visible = false;
            // 
            // CoustmerIdParam
            // 
            CoustmerIdParam.AutoSize = true;
            CoustmerIdParam.Location = new Point(20, 45);
            CoustmerIdParam.Name = "CoustmerIdParam";
            CoustmerIdParam.Size = new Size(0, 20);
            CoustmerIdParam.TabIndex = 168;
            CoustmerIdParam.Visible = false;
            // 
            // DetailsButton
            // 
            _DetailsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _DetailsButton.BackColor = Color.DarkGoldenrod;
            _DetailsButton.FlatAppearance.BorderSize = 0;
            _DetailsButton.FlatStyle = FlatStyle.Flat;
            _DetailsButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            _DetailsButton.ForeColor = Color.Black;
            _DetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            _DetailsButton.IconColor = Color.FromArgb(0, 20, 20);
            _DetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            _DetailsButton.IconSize = 35;
            _DetailsButton.Location = new Point(641, 100);
            _DetailsButton.Margin = new Padding(4, 5, 4, 5);
            _DetailsButton.Name = "_DetailsButton";
            _DetailsButton.Size = new Size(146, 46);
            _DetailsButton.TabIndex = 164;
            _DetailsButton.Text = "Details";
            _DetailsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            _DetailsButton.UseVisualStyleBackColor = false;
            // 
            // SrNoParam
            // 
            SrNoParam.AutoSize = true;
            SrNoParam.BackColor = Color.Transparent;
            SrNoParam.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SrNoParam.ForeColor = Color.FromArgb(0, 150, 150);
            SrNoParam.Location = new Point(0, 5);
            SrNoParam.Margin = new Padding(4, 0, 4, 0);
            SrNoParam.Name = "SrNoParam";
            SrNoParam.Size = new Size(30, 21);
            SrNoParam.TabIndex = 161;
            SrNoParam.Text = "#1";
            SrNoParam.TextAlign = ContentAlignment.MiddleLeft;
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
            CloseButton.Location = new Point(730, 2);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(51, 46);
            CloseButton.TabIndex = 160;
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // PhNoParam
            // 
            PhNoParam.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhNoParam.ForeColor = Color.FromArgb(0, 150, 150);
            PhNoParam.Location = new Point(234, 157);
            PhNoParam.Margin = new Padding(4, 0, 4, 0);
            PhNoParam.Name = "PhNoParam";
            PhNoParam.Size = new Size(560, 25);
            PhNoParam.TabIndex = 152;
            PhNoParam.Text = "7018362951, 9816057863, 9882960863, 6239631173";
            PhNoParam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameParam
            // 
            NameParam.Font = new Font("Century Schoolbook", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameParam.ForeColor = Color.FromArgb(0, 150, 150);
            NameParam.Location = new Point(236, 5);
            NameParam.Margin = new Padding(4, 0, 4, 0);
            NameParam.Name = "NameParam";
            NameParam.Size = new Size(485, 55);
            NameParam.TabIndex = 151;
            NameParam.Text = "Dhananjaysd Aggarwalxsa";
            NameParam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ActiveKittyControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ImagePanel2);
            Controls.Add(Panel2);
            Name = "ActiveKittyControl";
            Size = new Size(799, 234);
            ImagePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageParam).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ResumeLayout(false);

        }

        private Panel ImagePanel2;
        private PictureBox ImageParam;
        private Panel Panel2;
        private Label CoustmerIdParam;
        private Label SrNoParam;
        private FontAwesome.Sharp.IconButton CloseButton;
        private Label PhNoParam;
        private Label NameParam;
        private Label ActiveKittyParam;
        private Label ActiveKittyLabel;
        private Label NeverLabel;
        private FontAwesome.Sharp.IconButton _DetailsButton;

        public virtual FontAwesome.Sharp.IconButton DetailsButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DetailsButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DetailsButton != null)
                {
                    _DetailsButton.Click -= (_, __) => DetailsButton_Click();
                }

                _DetailsButton = value;
                if (_DetailsButton != null)
                {
                    _DetailsButton.Click += (_, __) => DetailsButton_Click();
                }
            }
        }
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class KittyModeControl : UserControl
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
            InstLeftParam = new Label();
            KittyIDParam = new Label();
            KittyNoParam = new Label();
            Label3 = new Label();
            KittyTypeParam = new Label();
            Label7 = new Label();
            CoustmerIdParam = new Label();
            _DetailsButton = new FontAwesome.Sharp.IconButton();
            _DetailsButton.Click += new EventHandler(DetailsButton_Click);
            SrNoParam = new Label();
            CloseButton = new FontAwesome.Sharp.IconButton();
            CloseButton.Click += new EventHandler(CloseButton_Click);
            InstPendingParam = new Label();
            InstallmentsLabel = new Label();
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
            ImagePanel2.Location = new Point(58, 3);
            ImagePanel2.Margin = new Padding(4, 5, 4, 5);
            ImagePanel2.Name = "ImagePanel2";
            ImagePanel2.Size = new Size(180, 228);
            ImagePanel2.TabIndex = 175;
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
            Panel2.Controls.Add(InstLeftParam);
            Panel2.Controls.Add(KittyIDParam);
            Panel2.Controls.Add(KittyNoParam);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(KittyTypeParam);
            Panel2.Controls.Add(Label7);
            Panel2.Controls.Add(CoustmerIdParam);
            Panel2.Controls.Add(_DetailsButton);
            Panel2.Controls.Add(SrNoParam);
            Panel2.Controls.Add(CloseButton);
            Panel2.Controls.Add(InstPendingParam);
            Panel2.Controls.Add(InstallmentsLabel);
            Panel2.Controls.Add(PhNoParam);
            Panel2.Controls.Add(NameParam);
            Panel2.Location = new Point(8, 24);
            Panel2.Margin = new Padding(4, 5, 4, 5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(787, 186);
            Panel2.TabIndex = 174;
            // 
            // InstLeftParam
            // 
            InstLeftParam.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstLeftParam.ForeColor = Color.FromArgb(200, 0, 0);
            InstLeftParam.Location = new Point(554, 60);
            InstLeftParam.Margin = new Padding(4, 0, 4, 0);
            InstLeftParam.Name = "InstLeftParam";
            InstLeftParam.Size = new Size(142, 35);
            InstLeftParam.TabIndex = 181;
            InstLeftParam.Text = "Left: 4";
            InstLeftParam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // KittyIDParam
            // 
            KittyIDParam.AutoSize = true;
            KittyIDParam.Location = new Point(20, 104);
            KittyIDParam.Name = "KittyIDParam";
            KittyIDParam.Size = new Size(0, 20);
            KittyIDParam.TabIndex = 178;
            KittyIDParam.Visible = false;
            // 
            // KittyNoParam
            // 
            KittyNoParam.BackColor = Color.Transparent;
            KittyNoParam.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyNoParam.ForeColor = Color.FromArgb(200, 0, 0);
            KittyNoParam.Location = new Point(547, 112);
            KittyNoParam.Margin = new Padding(4, 0, 4, 0);
            KittyNoParam.Name = "KittyNoParam";
            KittyNoParam.Size = new Size(87, 26);
            KittyNoParam.TabIndex = 180;
            KittyNoParam.Text = "832";
            KittyNoParam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(0, 150, 150);
            Label3.Location = new Point(426, 105);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(122, 37);
            Label3.TabIndex = 179;
            Label3.Text = "KittyNo:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // KittyTypeParam
            // 
            KittyTypeParam.BackColor = Color.Transparent;
            KittyTypeParam.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            KittyTypeParam.ForeColor = Color.FromArgb(200, 0, 0);
            KittyTypeParam.Location = new Point(321, 109);
            KittyTypeParam.Margin = new Padding(4, 0, 4, 0);
            KittyTypeParam.Name = "KittyTypeParam";
            KittyTypeParam.Size = new Size(87, 26);
            KittyTypeParam.TabIndex = 178;
            KittyTypeParam.Text = "2000";
            KittyTypeParam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.FromArgb(0, 150, 150);
            Label7.Location = new Point(240, 102);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(85, 37);
            Label7.TabIndex = 177;
            Label7.Text = "Kitty:";
            Label7.TextAlign = ContentAlignment.MiddleRight;
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
            // InstPendingParam
            // 
            InstPendingParam.AutoSize = true;
            InstPendingParam.BackColor = Color.Transparent;
            InstPendingParam.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstPendingParam.ForeColor = Color.FromArgb(200, 0, 0);
            InstPendingParam.Location = new Point(381, 64);
            InstPendingParam.Margin = new Padding(4, 0, 4, 0);
            InstPendingParam.Name = "InstPendingParam";
            InstPendingParam.Size = new Size(138, 27);
            InstPendingParam.TabIndex = 156;
            InstPendingParam.Text = "Pending: 0";
            InstPendingParam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InstallmentsLabel
            // 
            InstallmentsLabel.AutoSize = true;
            InstallmentsLabel.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstallmentsLabel.ForeColor = Color.FromArgb(0, 150, 150);
            InstallmentsLabel.Location = new Point(233, 64);
            InstallmentsLabel.Margin = new Padding(4, 0, 4, 0);
            InstallmentsLabel.Name = "InstallmentsLabel";
            InstallmentsLabel.Size = new Size(149, 27);
            InstallmentsLabel.TabIndex = 153;
            InstallmentsLabel.Text = "Instalment:";
            InstallmentsLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            // KittyModeControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ImagePanel2);
            Controls.Add(Panel2);
            DoubleBuffered = true;
            Name = "KittyModeControl";
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
        private Label KittyIDParam;
        private Label KittyNoParam;
        private Label Label3;
        private Label KittyTypeParam;
        private Label Label7;
        private Label CoustmerIdParam;
        private Label SrNoParam;
        private FontAwesome.Sharp.IconButton CloseButton;
        private Label InstPendingParam;
        private Label InstallmentsLabel;
        private Label PhNoParam;
        private Label NameParam;
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
        private Label InstLeftParam;
    }
}
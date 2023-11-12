using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ItemsUserControl : UserControl
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
            _DetailsButton = new FontAwesome.Sharp.IconButton();
            _DetailsButton.Click += new EventHandler(DetailsButton_Click);
            ImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // DetailsButton
            // 
            _DetailsButton.BackColor = Color.DarkGoldenrod;
            _DetailsButton.FlatAppearance.BorderSize = 0;
            _DetailsButton.FlatStyle = FlatStyle.Flat;
            _DetailsButton.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            _DetailsButton.ForeColor = Color.Black;
            _DetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            _DetailsButton.IconColor = Color.FromArgb(0, 20, 20);
            _DetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            _DetailsButton.IconSize = 35;
            _DetailsButton.Location = new Point(65, 443);
            _DetailsButton.Margin = new Padding(4, 5, 4, 5);
            _DetailsButton.Name = "_DetailsButton";
            _DetailsButton.Size = new Size(146, 46);
            _DetailsButton.TabIndex = 165;
            _DetailsButton.Text = "Details";
            _DetailsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            _DetailsButton.UseVisualStyleBackColor = false;
            // 
            // ImageBox
            // 
            ImageBox.BackColor = Color.FromArgb(36, 30, 60);
            ImageBox.Image = My.Resources.Resources.addSign;
            ImageBox.Location = new Point(13, 15);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(250, 420);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 291;
            ImageBox.TabStop = false;
            // 
            // ItemsUserControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 80);
            Controls.Add(ImageBox);
            Controls.Add(_DetailsButton);
            Name = "ItemsUserControl";
            Size = new Size(277, 503);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);

        }
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
                    _DetailsButton.Click -= DetailsButton_Click;
                }

                _DetailsButton = value;
                if (_DetailsButton != null)
                {
                    _DetailsButton.Click += DetailsButton_Click;
                }
            }
        }
        internal PictureBox ImageBox;
    }
}
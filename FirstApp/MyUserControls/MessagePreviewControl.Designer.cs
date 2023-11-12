using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MessagePreviewControl : UserControl
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
            Label1 = new Label();
            DetailsButton = new FontAwesome.Sharp.IconButton();
            DetailsButton.Click += new EventHandler(DetailsButton_Click);
            CloseButton = new FontAwesome.Sharp.IconButton();
            CloseButton.Click += new EventHandler(CloseButton_Click);
            SendBT = new FontAwesome.Sharp.IconButton();
            SendBT.Click += new EventHandler(SendBT_Click);
            SrNoLB = new Label();
            Panel1 = new Panel();
            IconButton1 = new FontAwesome.Sharp.IconButton();
            IconButton1.Click += new EventHandler(IconButton1_Click);
            StatusLB = new Label();
            Panel2 = new Panel();
            Panel3 = new Panel();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoEllipsis = true;
            Label1.AutoSize = true;
            Label1.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Green;
            Label1.Location = new Point(3, 55);
            Label1.Name = "Label1";
            Label1.Size = new Size(89, 28);
            Label1.TabIndex = 9998;
            Label1.Text = "Label1";
            // 
            // DetailsButton
            // 
            DetailsButton.AutoSize = true;
            DetailsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DetailsButton.BackColor = Color.Transparent;
            DetailsButton.FlatAppearance.BorderSize = 0;
            DetailsButton.FlatAppearance.MouseDownBackColor = Color.Lime;
            DetailsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            DetailsButton.FlatStyle = FlatStyle.Flat;
            DetailsButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetailsButton.ForeColor = Color.Linen;
            DetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            DetailsButton.IconColor = Color.White;
            DetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DetailsButton.IconSize = 36;
            DetailsButton.ImageAlign = ContentAlignment.TopCenter;
            DetailsButton.Location = new Point(182, 4);
            DetailsButton.Margin = new Padding(4, 5, 4, 5);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(42, 42);
            DetailsButton.TabIndex = 9997;
            DetailsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DetailsButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.AutoSize = true;
            CloseButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseButton.BackColor = Color.FromArgb(65, 0, 0);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 0, 0);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = Color.Linen;
            CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            CloseButton.IconColor = Color.White;
            CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CloseButton.IconSize = 32;
            CloseButton.ImageAlign = ContentAlignment.TopCenter;
            CloseButton.Location = new Point(588, 5);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(38, 38);
            CloseButton.TabIndex = 9996;
            CloseButton.TextAlign = ContentAlignment.MiddleLeft;
            CloseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // SendBT
            // 
            SendBT.AutoSize = true;
            SendBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendBT.BackColor = Color.FromArgb(0, 64, 0);
            SendBT.FlatAppearance.BorderSize = 0;
            SendBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            SendBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SendBT.FlatStyle = FlatStyle.Flat;
            SendBT.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBT.ForeColor = Color.Linen;
            SendBT.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            SendBT.IconColor = Color.White;
            SendBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SendBT.IconSize = 36;
            SendBT.Location = new Point(60, 4);
            SendBT.Margin = new Padding(4, 5, 4, 5);
            SendBT.Name = "SendBT";
            SendBT.Size = new Size(115, 42);
            SendBT.TabIndex = 9995;
            SendBT.Text = "Send";
            SendBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SendBT.UseVisualStyleBackColor = false;
            // 
            // SrNoLB
            // 
            SrNoLB.AutoSize = true;
            SrNoLB.BackColor = Color.Transparent;
            SrNoLB.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SrNoLB.ForeColor = Color.Goldenrod;
            SrNoLB.Location = new Point(1, 13);
            SrNoLB.Margin = new Padding(4, 0, 4, 0);
            SrNoLB.Name = "SrNoLB";
            SrNoLB.Size = new Size(56, 25);
            SrNoLB.TabIndex = 10000;
            SrNoLB.Text = "#999";
            SrNoLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(30, 30, 60);
            Panel1.Controls.Add(IconButton1);
            Panel1.Controls.Add(StatusLB);
            Panel1.Controls.Add(SrNoLB);
            Panel1.Controls.Add(SendBT);
            Panel1.Controls.Add(DetailsButton);
            Panel1.Location = new Point(0, 0);
            Panel1.MaximumSize = new Size(615, 52);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(583, 52);
            Panel1.TabIndex = 10001;
            // 
            // IconButton1
            // 
            IconButton1.AutoSize = true;
            IconButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IconButton1.BackColor = Color.Transparent;
            IconButton1.FlatAppearance.BorderSize = 0;
            IconButton1.FlatAppearance.MouseDownBackColor = Color.Lime;
            IconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            IconButton1.FlatStyle = FlatStyle.Flat;
            IconButton1.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            IconButton1.ForeColor = Color.Linen;
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            IconButton1.IconColor = Color.White;
            IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton1.IconSize = 36;
            IconButton1.ImageAlign = ContentAlignment.TopCenter;
            IconButton1.Location = new Point(232, 4);
            IconButton1.Margin = new Padding(4, 5, 4, 5);
            IconButton1.Name = "IconButton1";
            IconButton1.Size = new Size(42, 42);
            IconButton1.TabIndex = 10007;
            IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButton1.UseVisualStyleBackColor = false;
            // 
            // StatusLB
            // 
            StatusLB.AutoSize = true;
            StatusLB.BackColor = Color.Transparent;
            StatusLB.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLB.ForeColor = Color.Red;
            StatusLB.Location = new Point(281, 13);
            StatusLB.Margin = new Padding(4, 0, 4, 0);
            StatusLB.Name = "StatusLB";
            StatusLB.Size = new Size(286, 21);
            StatusLB.TabIndex = 10006;
            StatusLB.Text = "+916239631173: NotRegistered";
            StatusLB.TextAlign = ContentAlignment.MiddleLeft;
            StatusLB.Visible = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(224, 224, 224);
            Panel2.Location = new Point(565, 39);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(5, 21);
            Panel2.TabIndex = 10002;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(224, 224, 224);
            Panel3.Location = new Point(556, 39);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(5, 21);
            Panel3.TabIndex = 10003;
            // 
            // MessagePreviewControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 70);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(Label1);
            Controls.Add(CloseButton);
            Name = "MessagePreviewControl";
            Size = new Size(630, 63);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal FontAwesome.Sharp.IconButton SendBT;
        internal FontAwesome.Sharp.IconButton CloseButton;
        internal FontAwesome.Sharp.IconButton DetailsButton;
        internal Label Label1;
        private Label SrNoLB;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Panel Panel3;
        private Label StatusLB;
        internal FontAwesome.Sharp.IconButton IconButton1;
    }
}
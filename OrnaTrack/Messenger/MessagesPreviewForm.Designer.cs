using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MessagesPreviewForm : Form
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
            SendButton = new FontAwesome.Sharp.IconButton();
            SendButton.Click += new EventHandler(SendButton_Click);
            RetryButton = new FontAwesome.Sharp.IconButton();
            RetryButton.Click += new EventHandler(RetryButton_Click);
            SentLB = new Label();
            SentText = new Label();
            UnRegisteredText = new Label();
            UnRegisteredLB = new Label();
            BackButton = new FontAwesome.Sharp.IconButton();
            BackButton.Click += new EventHandler(BackButton_Click);
            NextButton = new FontAwesome.Sharp.IconButton();
            NextButton.Click += new EventHandler(NextButton_Click);
            PreviewCountLB = new Label();
            FailedLB = new Label();
            FailedText = new Label();
            Panel1 = new Panel();
            ImagesPreview = new FontAwesome.Sharp.IconButton();
            ImagesPreview.Click += new EventHandler(ImagesPreview_Click);
            CurrentCB = new CheckBox();
            CurrentCB.CheckedChanged += new EventHandler(CurrentCB_CheckedChanged);
            AllCB = new CheckBox();
            AllCB.CheckedChanged += new EventHandler(AllCB_CheckedChanged);
            MessagesPerPageTB = new TextBox();
            MessagesPerPageTB.TextChanged += new EventHandler(OneTimeControlTB_TextChanged);
            MessagesPerPageTB.KeyDown += new KeyEventHandler(OneTimeControlTB_KeyDown);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(0, 61);
            FlowLayoutPanel1.Margin = new Padding(1000);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1595, 569);
            FlowLayoutPanel1.TabIndex = 9997;
            // 
            // SendButton
            // 
            SendButton.AutoSize = true;
            SendButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendButton.BackColor = Color.FromArgb(0, 64, 0);
            SendButton.FlatAppearance.BorderSize = 0;
            SendButton.FlatAppearance.MouseDownBackColor = Color.Lime;
            SendButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SendButton.FlatStyle = FlatStyle.Flat;
            SendButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendButton.ForeColor = Color.Linen;
            SendButton.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            SendButton.IconColor = Color.White;
            SendButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SendButton.IconSize = 36;
            SendButton.Location = new Point(279, 6);
            SendButton.Margin = new Padding(4, 5, 4, 5);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(129, 44);
            SendButton.TabIndex = 9998;
            SendButton.Text = "Send";
            SendButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SendButton.UseVisualStyleBackColor = false;
            // 
            // RetryButton
            // 
            RetryButton.AutoSize = true;
            RetryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RetryButton.BackColor = Color.FromArgb(0, 64, 0);
            RetryButton.FlatAppearance.BorderSize = 0;
            RetryButton.FlatAppearance.MouseDownBackColor = Color.Lime;
            RetryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            RetryButton.FlatStyle = FlatStyle.Flat;
            RetryButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            RetryButton.ForeColor = Color.Linen;
            RetryButton.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            RetryButton.IconColor = Color.White;
            RetryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RetryButton.IconSize = 36;
            RetryButton.Location = new Point(422, 6);
            RetryButton.Margin = new Padding(4, 5, 4, 5);
            RetryButton.Name = "RetryButton";
            RetryButton.Size = new Size(128, 44);
            RetryButton.TabIndex = 9999;
            RetryButton.Text = "Retry";
            RetryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RetryButton.UseVisualStyleBackColor = false;
            // 
            // SentLB
            // 
            SentLB.AutoSize = true;
            SentLB.BackColor = Color.Transparent;
            SentLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SentLB.ForeColor = Color.Goldenrod;
            SentLB.Location = new Point(573, 15);
            SentLB.Margin = new Padding(4, 0, 4, 0);
            SentLB.Name = "SentLB";
            SentLB.Size = new Size(76, 30);
            SentLB.TabIndex = 10001;
            SentLB.Text = "Sent:";
            SentLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SentText
            // 
            SentText.AutoSize = true;
            SentText.BackColor = Color.Transparent;
            SentText.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SentText.ForeColor = Color.Goldenrod;
            SentText.Location = new Point(646, 15);
            SentText.Margin = new Padding(4, 0, 4, 0);
            SentText.Name = "SentText";
            SentText.Size = new Size(104, 30);
            SentText.TabIndex = 10002;
            SentText.Text = "500/710";
            SentText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UnRegisteredText
            // 
            UnRegisteredText.AutoSize = true;
            UnRegisteredText.BackColor = Color.Transparent;
            UnRegisteredText.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnRegisteredText.ForeColor = Color.Goldenrod;
            UnRegisteredText.Location = new Point(951, 15);
            UnRegisteredText.Margin = new Padding(4, 0, 4, 0);
            UnRegisteredText.Name = "UnRegisteredText";
            UnRegisteredText.Size = new Size(55, 30);
            UnRegisteredText.TabIndex = 10004;
            UnRegisteredText.Text = "180";
            UnRegisteredText.TextAlign = ContentAlignment.MiddleLeft;
            UnRegisteredText.Visible = false;
            // 
            // UnRegisteredLB
            // 
            UnRegisteredLB.AutoSize = true;
            UnRegisteredLB.BackColor = Color.Transparent;
            UnRegisteredLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnRegisteredLB.ForeColor = Color.Goldenrod;
            UnRegisteredLB.Location = new Point(779, 15);
            UnRegisteredLB.Margin = new Padding(4, 0, 4, 0);
            UnRegisteredLB.Name = "UnRegisteredLB";
            UnRegisteredLB.Size = new Size(176, 30);
            UnRegisteredLB.TabIndex = 10003;
            UnRegisteredLB.Text = "UnRegiseter:";
            UnRegisteredLB.TextAlign = ContentAlignment.MiddleLeft;
            UnRegisteredLB.Visible = false;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackButton.AutoSize = true;
            BackButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackButton.BackColor = Color.FromArgb(25, 25, 70);
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.MediumPurple;
            BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            BackButton.IconColor = Color.MediumPurple;
            BackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackButton.IconSize = 40;
            BackButton.Location = new Point(1475, 6);
            BackButton.Margin = new Padding(4, 5, 4, 5);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(46, 46);
            BackButton.TabIndex = 10009;
            BackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BackButton.UseVisualStyleBackColor = false;
            // 
            // NextButton
            // 
            NextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NextButton.AutoSize = true;
            NextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NextButton.BackColor = Color.FromArgb(25, 25, 70);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextButton.ForeColor = Color.MediumPurple;
            NextButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            NextButton.IconColor = Color.MediumPurple;
            NextButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NextButton.IconSize = 40;
            NextButton.Location = new Point(1527, 6);
            NextButton.Margin = new Padding(4, 5, 4, 5);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(46, 46);
            NextButton.TabIndex = 10008;
            NextButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            NextButton.UseVisualStyleBackColor = false;
            // 
            // PreviewCountLB
            // 
            PreviewCountLB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PreviewCountLB.BackColor = Color.Transparent;
            PreviewCountLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviewCountLB.ForeColor = Color.MediumPurple;
            PreviewCountLB.Location = new Point(1226, 13);
            PreviewCountLB.Margin = new Padding(4, 0, 4, 0);
            PreviewCountLB.Name = "PreviewCountLB";
            PreviewCountLB.Size = new Size(202, 30);
            PreviewCountLB.TabIndex = 10010;
            PreviewCountLB.Text = "0-20/127";
            PreviewCountLB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FailedLB
            // 
            FailedLB.AutoSize = true;
            FailedLB.BackColor = Color.Transparent;
            FailedLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            FailedLB.ForeColor = Color.Goldenrod;
            FailedLB.Location = new Point(1040, 15);
            FailedLB.Margin = new Padding(4, 0, 4, 0);
            FailedLB.Name = "FailedLB";
            FailedLB.Size = new Size(99, 30);
            FailedLB.TabIndex = 10005;
            FailedLB.Text = "Failed:";
            FailedLB.TextAlign = ContentAlignment.MiddleLeft;
            FailedLB.Visible = false;
            // 
            // FailedText
            // 
            FailedText.AutoSize = true;
            FailedText.BackColor = Color.Transparent;
            FailedText.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            FailedText.ForeColor = Color.Goldenrod;
            FailedText.Location = new Point(1135, 15);
            FailedText.Margin = new Padding(4, 0, 4, 0);
            FailedText.Name = "FailedText";
            FailedText.Size = new Size(55, 30);
            FailedText.TabIndex = 10006;
            FailedText.Text = "300";
            FailedText.TextAlign = ContentAlignment.MiddleLeft;
            FailedText.Visible = false;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.Controls.Add(ImagesPreview);
            Panel1.Controls.Add(CurrentCB);
            Panel1.Controls.Add(AllCB);
            Panel1.Controls.Add(MessagesPerPageTB);
            Panel1.Controls.Add(PreviewCountLB);
            Panel1.Controls.Add(SendButton);
            Panel1.Controls.Add(NextButton);
            Panel1.Controls.Add(RetryButton);
            Panel1.Controls.Add(BackButton);
            Panel1.Controls.Add(SentLB);
            Panel1.Controls.Add(FailedText);
            Panel1.Controls.Add(SentText);
            Panel1.Controls.Add(FailedLB);
            Panel1.Controls.Add(UnRegisteredLB);
            Panel1.Controls.Add(UnRegisteredText);
            Panel1.Location = new Point(0, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1595, 58);
            Panel1.TabIndex = 0;
            // 
            // ImagesPreview
            // 
            ImagesPreview.AutoSize = true;
            ImagesPreview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ImagesPreview.BackColor = Color.FromArgb(25, 25, 70);
            ImagesPreview.FlatAppearance.BorderSize = 0;
            ImagesPreview.FlatStyle = FlatStyle.Flat;
            ImagesPreview.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ImagesPreview.ForeColor = Color.MediumPurple;
            ImagesPreview.IconChar = FontAwesome.Sharp.IconChar.Images;
            ImagesPreview.IconColor = Color.MediumPurple;
            ImagesPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ImagesPreview.IconSize = 40;
            ImagesPreview.Location = new Point(222, 7);
            ImagesPreview.Margin = new Padding(4, 5, 4, 5);
            ImagesPreview.Name = "ImagesPreview";
            ImagesPreview.Size = new Size(46, 46);
            ImagesPreview.TabIndex = 10015;
            ImagesPreview.TextImageRelation = TextImageRelation.ImageBeforeText;
            ImagesPreview.UseVisualStyleBackColor = false;
            ImagesPreview.Visible = false;
            // 
            // CurrentCB
            // 
            CurrentCB.AutoSize = true;
            CurrentCB.Checked = true;
            CurrentCB.CheckState = CheckState.Checked;
            CurrentCB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentCB.ForeColor = Color.MediumPurple;
            CurrentCB.Location = new Point(94, 15);
            CurrentCB.Name = "CurrentCB";
            CurrentCB.Size = new Size(129, 30);
            CurrentCB.TabIndex = 10014;
            CurrentCB.Text = "Current";
            CurrentCB.UseVisualStyleBackColor = true;
            // 
            // AllCB
            // 
            AllCB.AutoSize = true;
            AllCB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllCB.ForeColor = Color.MediumPurple;
            AllCB.Location = new Point(17, 15);
            AllCB.Name = "AllCB";
            AllCB.Size = new Size(71, 30);
            AllCB.TabIndex = 10013;
            AllCB.Text = "All";
            AllCB.UseVisualStyleBackColor = true;
            // 
            // MessagesPerPageTB
            // 
            MessagesPerPageTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MessagesPerPageTB.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessagesPerPageTB.Location = new Point(1435, 13);
            MessagesPerPageTB.Name = "MessagesPerPageTB";
            MessagesPerPageTB.Size = new Size(33, 30);
            MessagesPerPageTB.TabIndex = 10012;
            // 
            // MessagesPreviewForm
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1595, 698);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MessagesPreviewForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(PreviewForm_Load);
            KeyDown += new KeyEventHandler(PreviewForm_KeyDown);
            ResumeLayout(false);

        }

        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FontAwesome.Sharp.IconButton SendButton;
        internal FontAwesome.Sharp.IconButton RetryButton;
        private Label SentLB;
        private Label SentText;
        private Label UnRegisteredText;
        private Label UnRegisteredLB;
        internal FontAwesome.Sharp.IconButton BackButton;
        internal FontAwesome.Sharp.IconButton NextButton;
        private Label PreviewCountLB;
        private Label FailedLB;
        private Label FailedText;
        internal Panel Panel1;
        internal TextBox MessagesPerPageTB;
        internal CheckBox CurrentCB;
        internal CheckBox AllCB;
        internal FontAwesome.Sharp.IconButton ImagesPreview;
    }
}
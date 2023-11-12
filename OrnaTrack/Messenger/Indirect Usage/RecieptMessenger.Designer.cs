using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class RecieptMessenger : Form
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
            var DataGridViewCellStyle17 = new DataGridViewCellStyle();
            var DataGridViewCellStyle18 = new DataGridViewCellStyle();
            var DataGridViewCellStyle19 = new DataGridViewCellStyle();
            var DataGridViewCellStyle20 = new DataGridViewCellStyle();
            var DataGridViewCellStyle21 = new DataGridViewCellStyle();
            var DataGridViewCellStyle22 = new DataGridViewCellStyle();
            var DataGridViewCellStyle23 = new DataGridViewCellStyle();
            var DataGridViewCellStyle24 = new DataGridViewCellStyle();
            var DataGridViewCellStyle25 = new DataGridViewCellStyle();
            var DataGridViewCellStyle26 = new DataGridViewCellStyle();
            var DataGridViewCellStyle27 = new DataGridViewCellStyle();
            var DataGridViewCellStyle28 = new DataGridViewCellStyle();
            var DataGridViewCellStyle29 = new DataGridViewCellStyle();
            var DataGridViewCellStyle30 = new DataGridViewCellStyle();
            var DataGridViewCellStyle31 = new DataGridViewCellStyle();
            var DataGridViewCellStyle32 = new DataGridViewCellStyle();
            Column10 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewButtonColumn1 = new DataGridViewCheckBoxColumn();
            Panel1 = new Panel();
            ImgBox = new PictureBox();
            WarningLabel = new Label();
            MessageTB = new ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl();
            HandsCheckBox = new CheckBox();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            MessageResultLB = new Label();
            SendRecieptCB = new CheckBox();
            SendRecieptCB.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            NextButton = new FontAwesome.Sharp.IconButton();
            NextButton.Click += new EventHandler(NextButton_Click);
            BackButton = new FontAwesome.Sharp.IconButton();
            BackButton.Click += new EventHandler(BackButton_Click);
            SendButton = new FontAwesome.Sharp.IconButton();
            SendButton.Click += new EventHandler(SendButton_Click);
            MainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)ImgBox).BeginInit();
            FlowLayoutPanel1.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Column10
            // 
            Column10.Frozen = true;
            Column10.HeaderText = "";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Resizable = DataGridViewTriState.False;
            Column10.Width = 27;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle17.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle17.NullValue = null;
            DataGridViewCellStyle17.SelectionBackColor = Color.White;
            DataGridViewCellStyle17.SelectionForeColor = Color.Black;
            Column1.DefaultCellStyle = DataGridViewCellStyle17;
            Column1.Frozen = true;
            Column1.HeaderText = "SrNo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 63;
            // 
            // Column9
            // 
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle18.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Column9.DefaultCellStyle = DataGridViewCellStyle18;
            Column9.Frozen = true;
            Column9.HeaderText = "KittyNo";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column9.Width = 91;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle19.BackColor = Color.White;
            DataGridViewCellStyle19.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Column5.DefaultCellStyle = DataGridViewCellStyle19;
            Column5.Frozen = true;
            Column5.HeaderText = "KittyType";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 113;
            // 
            // Column2
            // 
            DataGridViewCellStyle20.Font = new Font("Century Schoolbook", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle20.Format = "d";
            DataGridViewCellStyle20.NullValue = null;
            DataGridViewCellStyle20.SelectionBackColor = Color.White;
            DataGridViewCellStyle20.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = DataGridViewCellStyle20;
            Column2.Frozen = true;
            Column2.HeaderText = "Last Installment";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 204;
            // 
            // Column6
            // 
            DataGridViewCellStyle21.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle21.ForeColor = Color.Red;
            Column6.DefaultCellStyle = DataGridViewCellStyle21;
            Column6.Frozen = true;
            Column6.HeaderText = "Given Amt.";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 161;
            // 
            // Column4
            // 
            DataGridViewCellStyle22.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle22.NullValue = null;
            Column4.DefaultCellStyle = DataGridViewCellStyle22;
            Column4.Frozen = true;
            Column4.HeaderText = "Total Amt+Intrst";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 206;
            // 
            // Status
            // 
            DataGridViewCellStyle23.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.DefaultCellStyle = DataGridViewCellStyle23;
            Status.Frozen = true;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 140;
            // 
            // Column7
            // 
            DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle24.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle24.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle24.ForeColor = Color.White;
            DataGridViewCellStyle24.SelectionBackColor = Color.ForestGreen;
            Column7.DefaultCellStyle = DataGridViewCellStyle24;
            Column7.Frozen = true;
            Column7.HeaderText = "Show Details";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Text = "Show Details";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 145;
            // 
            // Column8
            // 
            Column8.Frozen = true;
            Column8.HeaderText = "KittyID";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            Column8.Width = 119;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.HeaderText = "KittyID";
            DataGridViewTextBoxColumn8.MinimumWidth = 8;
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.ReadOnly = true;
            DataGridViewTextBoxColumn8.Visible = false;
            DataGridViewTextBoxColumn8.Width = 119;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            DataGridViewCheckBoxColumn1.Frozen = true;
            DataGridViewCheckBoxColumn1.HeaderText = "";
            DataGridViewCheckBoxColumn1.MinimumWidth = 8;
            DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            DataGridViewCheckBoxColumn1.ReadOnly = true;
            DataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.False;
            DataGridViewCheckBoxColumn1.Width = 27;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle25.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle25.NullValue = null;
            DataGridViewCellStyle25.SelectionBackColor = Color.White;
            DataGridViewCellStyle25.SelectionForeColor = Color.Black;
            DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle25;
            DataGridViewTextBoxColumn1.HeaderText = "SrNo";
            DataGridViewTextBoxColumn1.MinimumWidth = 8;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            DataGridViewTextBoxColumn1.Width = 63;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle26.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle26;
            DataGridViewTextBoxColumn2.HeaderText = "KittyNo";
            DataGridViewTextBoxColumn2.MinimumWidth = 8;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewTextBoxColumn2.Width = 91;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle27.BackColor = Color.White;
            DataGridViewCellStyle27.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle27;
            DataGridViewTextBoxColumn3.HeaderText = "KittyType";
            DataGridViewTextBoxColumn3.MinimumWidth = 8;
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Width = 113;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewCellStyle28.Font = new Font("Century Schoolbook", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle28.Format = "d";
            DataGridViewCellStyle28.NullValue = null;
            DataGridViewCellStyle28.SelectionBackColor = Color.White;
            DataGridViewCellStyle28.SelectionForeColor = Color.Black;
            DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle28;
            DataGridViewTextBoxColumn4.HeaderText = "Last Installment";
            DataGridViewTextBoxColumn4.MinimumWidth = 8;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Width = 204;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewCellStyle29.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle29.ForeColor = Color.Red;
            DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle29;
            DataGridViewTextBoxColumn5.HeaderText = "Given Amt.";
            DataGridViewTextBoxColumn5.MinimumWidth = 8;
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            DataGridViewTextBoxColumn5.Width = 161;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewCellStyle30.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle30.NullValue = null;
            DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle30;
            DataGridViewTextBoxColumn6.HeaderText = "Total Amt+Intrst";
            DataGridViewTextBoxColumn6.MinimumWidth = 8;
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            DataGridViewTextBoxColumn6.Width = 206;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewCellStyle31.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle31;
            DataGridViewTextBoxColumn7.HeaderText = "Status";
            DataGridViewTextBoxColumn7.MinimumWidth = 8;
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            DataGridViewTextBoxColumn7.Width = 140;
            // 
            // DataGridViewButtonColumn1
            // 
            DataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle32.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle32.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle32.ForeColor = Color.White;
            DataGridViewCellStyle32.NullValue = false;
            DataGridViewCellStyle32.SelectionBackColor = Color.ForestGreen;
            DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle32;
            DataGridViewButtonColumn1.HeaderText = "";
            DataGridViewButtonColumn1.MinimumWidth = 8;
            DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1";
            DataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            DataGridViewButtonColumn1.Width = 27;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Location = new Point(13, 15);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(534, 902);
            Panel1.TabIndex = 236;
            // 
            // ImgBox
            // 
            ImgBox.BackgroundImageLayout = ImageLayout.Zoom;
            ImgBox.Location = new Point(13, 15);
            ImgBox.Name = "ImgBox";
            ImgBox.Size = new Size(534, 902);
            ImgBox.TabIndex = 0;
            ImgBox.TabStop = false;
            ImgBox.Visible = false;
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.BackColor = Color.Transparent;
            WarningLabel.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            WarningLabel.ForeColor = Color.Goldenrod;
            WarningLabel.Location = new Point(577, 78);
            WarningLabel.Margin = new Padding(4, 0, 4, 0);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(511, 30);
            WarningLabel.TabIndex = 252;
            WarningLabel.Text = "Please Scan QrCode From Whatsapp First!";
            WarningLabel.Visible = false;
            // 
            // MessageTB
            // 
            MessageTB.AutoWordSelection = true;
            MessageTB.BackColor = Color.Lavender;
            MessageTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageTB.Location = new Point(563, 111);
            MessageTB.Name = "MessageTB";
            MessageTB.Size = new Size(535, 433);
            MessageTB.TabIndex = 261;
            MessageTB.Text = "";
            // 
            // HandsCheckBox
            // 
            HandsCheckBox.AutoSize = true;
            HandsCheckBox.Checked = true;
            HandsCheckBox.CheckState = CheckState.Checked;
            HandsCheckBox.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            HandsCheckBox.ForeColor = Color.Orange;
            HandsCheckBox.Location = new Point(955, 628);
            HandsCheckBox.Margin = new Padding(4, 5, 4, 5);
            HandsCheckBox.Name = "HandsCheckBox";
            HandsCheckBox.Size = new Size(153, 27);
            HandsCheckBox.TabIndex = 9991;
            HandsCheckBox.Text = "Hands Emoji";
            HandsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FlowLayoutPanel1.BackColor = Color.FromArgb(36, 30, 60);
            FlowLayoutPanel1.Controls.Add(MessageResultLB);
            FlowLayoutPanel1.Location = new Point(570, 678);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(447, 235);
            FlowLayoutPanel1.TabIndex = 9992;
            // 
            // MessageResultLB
            // 
            MessageResultLB.AutoSize = true;
            MessageResultLB.BackColor = Color.Transparent;
            MessageResultLB.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MessageResultLB.ForeColor = Color.ForestGreen;
            MessageResultLB.Location = new Point(4, 0);
            MessageResultLB.Margin = new Padding(4, 0, 4, 0);
            MessageResultLB.Name = "MessageResultLB";
            MessageResultLB.Size = new Size(244, 28);
            MessageResultLB.TabIndex = 226;
            MessageResultLB.Text = "+919816057863: Sent";
            MessageResultLB.Visible = false;
            // 
            // SendRecieptCB
            // 
            SendRecieptCB.AutoSize = true;
            SendRecieptCB.Checked = true;
            SendRecieptCB.CheckState = CheckState.Checked;
            SendRecieptCB.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendRecieptCB.ForeColor = Color.Orange;
            SendRecieptCB.Location = new Point(781, 628);
            SendRecieptCB.Margin = new Padding(4, 5, 4, 5);
            SendRecieptCB.Name = "SendRecieptCB";
            SendRecieptCB.Size = new Size(166, 27);
            SendRecieptCB.TabIndex = 9993;
            SendRecieptCB.Text = "Send Reciept";
            SendRecieptCB.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.FromArgb(25, 25, 70);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextButton.ForeColor = Color.MediumPurple;
            NextButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            NextButton.IconColor = Color.MediumPurple;
            NextButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NextButton.ImageAlign = ContentAlignment.BottomCenter;
            NextButton.Location = new Point(646, 554);
            NextButton.Margin = new Padding(4, 5, 4, 5);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(54, 62);
            NextButton.TabIndex = 249;
            NextButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Visible = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(25, 25, 70);
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Cambria", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.MediumPurple;
            BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            BackButton.IconColor = Color.MediumPurple;
            BackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackButton.ImageAlign = ContentAlignment.BottomCenter;
            BackButton.Location = new Point(584, 552);
            BackButton.Margin = new Padding(4, 5, 4, 5);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(54, 62);
            BackButton.TabIndex = 250;
            BackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Visible = false;
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.FromArgb(0, 64, 0);
            SendButton.Enabled = false;
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
            SendButton.Location = new Point(827, 556);
            SendButton.Margin = new Padding(4, 5, 4, 5);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(277, 62);
            SendButton.TabIndex = 243;
            SendButton.Text = "Send Receipt";
            SendButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SendButton.UseVisualStyleBackColor = false;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(Panel1);
            MainPanel.Controls.Add(ImgBox);
            MainPanel.Controls.Add(SendButton);
            MainPanel.Controls.Add(WarningLabel);
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(NextButton);
            MainPanel.Controls.Add(MessageTB);
            MainPanel.Controls.Add(HandsCheckBox);
            MainPanel.Controls.Add(FlowLayoutPanel1);
            MainPanel.Controls.Add(SendRecieptCB);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1117, 932);
            MainPanel.TabIndex = 9994;
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1117, 932);
            Controls.Add(MainPanel);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Messenger";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ImgBox).EndInit();
            FlowLayoutPanel1.ResumeLayout(false);
            FlowLayoutPanel1.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            Load += new EventHandler(GlobalKittyBillView_Load);
            ResumeLayout(false);

        }
        internal DataGridViewCheckBoxColumn Column10;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Status;
        internal DataGridViewButtonColumn Column7;
        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewCheckBoxColumn DataGridViewButtonColumn1;
        internal Panel Panel1;
        internal FontAwesome.Sharp.IconButton SendButton;
        internal FontAwesome.Sharp.IconButton NextButton;
        internal FontAwesome.Sharp.IconButton BackButton;
        internal PictureBox ImgBox;
        internal Label WarningLabel;
        internal ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl MessageTB;
        internal CheckBox HandsCheckBox;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Label MessageResultLB;
        internal CheckBox SendRecieptCB;
        internal Panel MainPanel;
    }
}
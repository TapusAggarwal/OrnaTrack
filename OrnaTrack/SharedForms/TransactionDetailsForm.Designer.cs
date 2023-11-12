using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TransactionDetailsForm : Form
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
            var DataGridViewCellStyle31 = new DataGridViewCellStyle();
            var DataGridViewCellStyle32 = new DataGridViewCellStyle();
            var DataGridViewCellStyle39 = new DataGridViewCellStyle();
            var DataGridViewCellStyle40 = new DataGridViewCellStyle();
            var DataGridViewCellStyle33 = new DataGridViewCellStyle();
            var DataGridViewCellStyle34 = new DataGridViewCellStyle();
            var DataGridViewCellStyle35 = new DataGridViewCellStyle();
            var DataGridViewCellStyle36 = new DataGridViewCellStyle();
            var DataGridViewCellStyle37 = new DataGridViewCellStyle();
            var DataGridViewCellStyle38 = new DataGridViewCellStyle();
            PaymentModeCB = new ComboBox();
            PaymentModeCB.SelectedIndexChanged += new EventHandler(PaymentModeCB_SelectedIndexChanged);
            PaymentModeCB.KeyDown += new KeyEventHandler(PaymentModeCB_KeyDown);
            PaymentModeCB.GotFocus += new EventHandler(Control_GotFocus);
            PaymentModeCB.LostFocus += new EventHandler(Control_LostFocus);
            ReferenceNoTB = new TextBox();
            ReferenceNoTB.KeyDown += new KeyEventHandler(ReferenceNoTB_KeyDown);
            ReferenceNoTB.GotFocus += new EventHandler(Control_GotFocus);
            ReferenceNoTB.LostFocus += new EventHandler(Control_LostFocus);
            TransferedToCB = new ComboBox();
            TransferedToCB.KeyDown += new KeyEventHandler(TransferedToCB_KeyDown);
            TransferedToCB.GotFocus += new EventHandler(Control_GotFocus);
            TransferedToCB.LostFocus += new EventHandler(Control_LostFocus);
            NotesTB = new TextBox();
            PaymentModeLabel = new Label();
            Label1 = new Label();
            ReferenceNoLabel = new Label();
            SaveButton = new FontAwesome.Sharp.IconButton();
            SaveButton.Click += new EventHandler(SaveButton_Click);
            DeleteBT = new FontAwesome.Sharp.IconButton();
            DeleteBT.Click += new EventHandler(IconButton1_Click);
            Label3 = new Label();
            Label4 = new Label();
            DatePicker = new DateTimePicker();
            TotalAmtTB = new TextBox();
            TotalAmtTB.KeyDown += new KeyEventHandler(ReferenceNoTB_KeyDown);
            TotalAmtTB.GotFocus += new EventHandler(TotalAmtTB_GotFocus);
            TotalAmtTB.Leave += new EventHandler(TotalAmtTB_Leave);
            _DataGridView1 = new DataGridView();
            _DataGridView1.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellClick);
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Mode = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewButtonColumn();
            OnlineTransactionsBT = new FontAwesome.Sharp.IconButton();
            OnlineTransactionsBT.Click += new EventHandler(OnlineTransactionsBT_Click);
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PaymentModeCB
            // 
            PaymentModeCB.FlatStyle = FlatStyle.Popup;
            PaymentModeCB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentModeCB.FormattingEnabled = true;
            PaymentModeCB.Items.AddRange(new object[] { "Cash", "Bank Transfer", "Others" });
            PaymentModeCB.Location = new Point(618, 15);
            PaymentModeCB.Name = "PaymentModeCB";
            PaymentModeCB.Size = new Size(199, 35);
            PaymentModeCB.TabIndex = 0;
            // 
            // ReferenceNoTB
            // 
            ReferenceNoTB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReferenceNoTB.Location = new Point(618, 67);
            ReferenceNoTB.Name = "ReferenceNoTB";
            ReferenceNoTB.Size = new Size(199, 34);
            ReferenceNoTB.TabIndex = 2;
            // 
            // TransferedToCB
            // 
            TransferedToCB.FlatStyle = FlatStyle.Popup;
            TransferedToCB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransferedToCB.FormattingEnabled = true;
            TransferedToCB.Items.AddRange(new object[] { "Cash", "Bank Transfer", "Others" });
            TransferedToCB.Location = new Point(218, 117);
            TransferedToCB.Name = "TransferedToCB";
            TransferedToCB.Size = new Size(199, 35);
            TransferedToCB.TabIndex = 3;
            // 
            // NotesTB
            // 
            NotesTB.Font = new Font("Century Schoolbook", 10.0f);
            NotesTB.Location = new Point(437, 117);
            NotesTB.Multiline = true;
            NotesTB.Name = "NotesTB";
            NotesTB.Size = new Size(380, 90);
            NotesTB.TabIndex = 4;
            // 
            // PaymentModeLabel
            // 
            PaymentModeLabel.AutoSize = true;
            PaymentModeLabel.BackColor = Color.Transparent;
            PaymentModeLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentModeLabel.ForeColor = SystemColors.ActiveCaption;
            PaymentModeLabel.Location = new Point(432, 18);
            PaymentModeLabel.Margin = new Padding(4, 0, 4, 0);
            PaymentModeLabel.Name = "PaymentModeLabel";
            PaymentModeLabel.Size = new Size(179, 28);
            PaymentModeLabel.TabIndex = 190;
            PaymentModeLabel.Text = "Payment Mode";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ActiveCaption;
            Label1.Location = new Point(6, 121);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(170, 28);
            Label1.TabIndex = 191;
            Label1.Text = "Transfered To";
            // 
            // ReferenceNoLabel
            // 
            ReferenceNoLabel.AutoSize = true;
            ReferenceNoLabel.BackColor = Color.Transparent;
            ReferenceNoLabel.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReferenceNoLabel.ForeColor = SystemColors.ActiveCaption;
            ReferenceNoLabel.Location = new Point(436, 73);
            ReferenceNoLabel.Margin = new Padding(4, 0, 4, 0);
            ReferenceNoLabel.Name = "ReferenceNoLabel";
            ReferenceNoLabel.Size = new Size(169, 28);
            ReferenceNoLabel.TabIndex = 192;
            ReferenceNoLabel.Text = "Trns. Ref. No.";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(0, 64, 0);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatAppearance.MouseDownBackColor = Color.Lime;
            SaveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.Linen;
            SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            SaveButton.IconColor = Color.White;
            SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveButton.IconSize = 32;
            SaveButton.ImageAlign = ContentAlignment.BottomCenter;
            SaveButton.Location = new Point(9, 161);
            SaveButton.Margin = new Padding(4, 5, 4, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(300, 46);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save Transaction";
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // DeleteBT
            // 
            DeleteBT.BackColor = Color.Transparent;
            DeleteBT.FlatAppearance.BorderSize = 0;
            DeleteBT.FlatAppearance.MouseDownBackColor = Color.Red;
            DeleteBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            DeleteBT.FlatStyle = FlatStyle.Flat;
            DeleteBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBT.ForeColor = Color.Linen;
            DeleteBT.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DeleteBT.IconColor = Color.White;
            DeleteBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBT.IconSize = 32;
            DeleteBT.Location = new Point(325, 162);
            DeleteBT.Margin = new Padding(4, 5, 4, 5);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(45, 45);
            DeleteBT.TabIndex = 245;
            DeleteBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteBT.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = SystemColors.ActiveCaption;
            Label3.Location = new Point(6, 69);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(196, 28);
            Label3.TabIndex = 250;
            Label3.Text = "Transfered Amt.";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = SystemColors.ActiveCaption;
            Label4.Location = new Point(6, 17);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(206, 28);
            Label4.TabIndex = 249;
            Label4.Text = "Transaction Date";
            // 
            // DatePicker
            // 
            DatePicker.CalendarFont = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePicker.Font = new Font("Century", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.Location = new Point(218, 16);
            DatePicker.Margin = new Padding(4, 5, 4, 5);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(199, 34);
            DatePicker.TabIndex = 252;
            // 
            // TotalAmtTB
            // 
            TotalAmtTB.Font = new Font("Century Schoolbook", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalAmtTB.Location = new Point(218, 67);
            TotalAmtTB.Name = "TotalAmtTB";
            TotalAmtTB.Size = new Size(199, 34);
            TotalAmtTB.TabIndex = 1;
            // 
            // DataGridView1
            // 
            _DataGridView1.AllowUserToAddRows = false;
            _DataGridView1.AllowUserToDeleteRows = false;
            _DataGridView1.AllowUserToResizeColumns = false;
            _DataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle31.BackColor = Color.FromArgb(224, 224, 224);
            _DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31;
            _DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _DataGridView1.BackgroundColor = Color.FromArgb(0, 0, 50);
            DataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle32.BackColor = SystemColors.Control;
            DataGridViewCellStyle32.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle32.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle32.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle32.WrapMode = DataGridViewTriState.True;
            _DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32;
            _DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, Mode, DataGridViewTextBoxColumn5 });
            DataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle39.BackColor = SystemColors.Window;
            DataGridViewCellStyle39.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle39.ForeColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle39.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle39.SelectionForeColor = SystemColors.ControlText;
            DataGridViewCellStyle39.WrapMode = DataGridViewTriState.False;
            _DataGridView1.DefaultCellStyle = DataGridViewCellStyle39;
            _DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DataGridView1.Location = new Point(6, 222);
            _DataGridView1.Margin = new Padding(4, 5, 4, 5);
            _DataGridView1.MultiSelect = false;
            _DataGridView1.Name = "_DataGridView1";
            _DataGridView1.ReadOnly = true;
            DataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle40.BackColor = SystemColors.Control;
            DataGridViewCellStyle40.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle40.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle40.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle40.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle40.WrapMode = DataGridViewTriState.True;
            _DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle40;
            _DataGridView1.RowHeadersVisible = false;
            _DataGridView1.RowHeadersWidth = 62;
            _DataGridView1.Size = new Size(820, 50);
            _DataGridView1.TabIndex = 10030;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle33.ForeColor = Color.Black;
            DataGridViewCellStyle33.NullValue = null;
            DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle33;
            DataGridViewTextBoxColumn1.HeaderText = "";
            DataGridViewTextBoxColumn1.MinimumWidth = 8;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            DataGridViewTextBoxColumn1.Width = 40;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewCellStyle34.ForeColor = Color.Black;
            DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle34;
            DataGridViewTextBoxColumn2.HeaderText = "KittyID";
            DataGridViewTextBoxColumn2.MinimumWidth = 8;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            DataGridViewTextBoxColumn2.Width = 125;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewCellStyle35.Font = new Font("Arial Rounded MT Bold", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle35.ForeColor = Color.Black;
            DataGridViewCellStyle35.Format = "d";
            DataGridViewCellStyle35.NullValue = null;
            DataGridViewCellStyle35.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle35.SelectionForeColor = Color.White;
            DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle35;
            DataGridViewTextBoxColumn3.HeaderText = "KittyNo";
            DataGridViewTextBoxColumn3.MinimumWidth = 8;
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            DataGridViewTextBoxColumn3.Width = 140;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewCellStyle36.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle36.ForeColor = Color.Black;
            DataGridViewCellStyle36.NullValue = null;
            DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle36;
            DataGridViewTextBoxColumn4.HeaderText = "Name";
            DataGridViewTextBoxColumn4.MinimumWidth = 8;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            DataGridViewTextBoxColumn4.Width = 200;
            // 
            // Mode
            // 
            DataGridViewCellStyle37.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle37.ForeColor = Color.Black;
            Mode.DefaultCellStyle = DataGridViewCellStyle37;
            Mode.HeaderText = "Amt. Used";
            Mode.MinimumWidth = 8;
            Mode.Name = "Mode";
            Mode.ReadOnly = true;
            Mode.Resizable = DataGridViewTriState.False;
            Mode.Width = 160;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle38.BackColor = Color.White;
            DataGridViewCellStyle38.ForeColor = Color.Black;
            DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle38;
            DataGridViewTextBoxColumn5.HeaderText = "Change";
            DataGridViewTextBoxColumn5.MinimumWidth = 8;
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            DataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
            DataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Automatic;
            DataGridViewTextBoxColumn5.Width = 116;
            // 
            // OnlineTransactionsBT
            // 
            OnlineTransactionsBT.BackColor = Color.Transparent;
            OnlineTransactionsBT.FlatAppearance.BorderSize = 0;
            OnlineTransactionsBT.FlatAppearance.MouseDownBackColor = Color.Red;
            OnlineTransactionsBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            OnlineTransactionsBT.FlatStyle = FlatStyle.Flat;
            OnlineTransactionsBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            OnlineTransactionsBT.ForeColor = Color.Linen;
            OnlineTransactionsBT.IconChar = FontAwesome.Sharp.IconChar.University;
            OnlineTransactionsBT.IconColor = Color.White;
            OnlineTransactionsBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OnlineTransactionsBT.IconSize = 38;
            OnlineTransactionsBT.Location = new Point(386, 164);
            OnlineTransactionsBT.Margin = new Padding(4, 5, 4, 5);
            OnlineTransactionsBT.Name = "OnlineTransactionsBT";
            OnlineTransactionsBT.Size = new Size(45, 45);
            OnlineTransactionsBT.TabIndex = 10031;
            OnlineTransactionsBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            OnlineTransactionsBT.UseVisualStyleBackColor = false;
            OnlineTransactionsBT.Visible = false;
            // 
            // TransactionDetails
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(825, 257);
            Controls.Add(OnlineTransactionsBT);
            Controls.Add(PaymentModeCB);
            Controls.Add(_DataGridView1);
            Controls.Add(TotalAmtTB);
            Controls.Add(DatePicker);
            Controls.Add(Label3);
            Controls.Add(Label4);
            Controls.Add(DeleteBT);
            Controls.Add(SaveButton);
            Controls.Add(ReferenceNoLabel);
            Controls.Add(Label1);
            Controls.Add(PaymentModeLabel);
            Controls.Add(NotesTB);
            Controls.Add(TransferedToCB);
            Controls.Add(ReferenceNoTB);
            ForeColor = SystemColors.ActiveCaption;
            MaximizeBox = false;
            MaximumSize = new Size(847, 1000);
            MinimumSize = new Size(847, 313);
            Name = "TransactionDetails";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionDetails";
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).EndInit();
            Load += new EventHandler(TransactionDetails_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ComboBox PaymentModeCB;
        internal TextBox ReferenceNoTB;
        internal ComboBox TransferedToCB;
        internal Button CancelBT;
        internal TextBox NotesTB;
        internal Label PaymentModeLabel;
        internal Label Label1;
        internal Label ReferenceNoLabel;
        internal FontAwesome.Sharp.IconButton SaveButton;
        internal FontAwesome.Sharp.IconButton DeleteBT;
        internal Label Label3;
        internal Label Label4;
        internal DateTimePicker DatePicker;
        internal TextBox TotalAmtTB;
        private DataGridView _DataGridView1;

        protected virtual DataGridView DataGridView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DataGridView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellClick -= DataGridView1_CellClick;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellClick += DataGridView1_CellClick;
                }
            }
        }
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn Mode;
        internal DataGridViewButtonColumn DataGridViewTextBoxColumn5;
        internal FontAwesome.Sharp.IconButton OnlineTransactionsBT;
    }
}
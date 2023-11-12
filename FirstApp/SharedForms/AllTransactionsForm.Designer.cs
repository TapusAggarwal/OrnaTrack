using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AllTransactionsForm : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            _Dgv = new DataGridView();
            _Dgv.CellClick += new DataGridViewCellEventHandler(Dgv_CellClick);
            FromDatePicker = new DateTimePicker();
            Label4 = new Label();
            TillDatePicker = new DateTimePicker();
            Label1 = new Label();
            AddMsgBT = new FontAwesome.Sharp.IconButton();
            AddMsgBT.Click += new EventHandler(AddMsgBT_Click);
            FindCoustmerButton = new FontAwesome.Sharp.IconButton();
            FindCoustmerButton.Click += new EventHandler(FindCoustmerButton_Click);
            Column3 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)_Dgv).BeginInit();
            SuspendLayout();
            // 
            // Dgv
            // 
            _Dgv.AllowUserToAddRows = false;
            _Dgv.AllowUserToDeleteRows = false;
            _Dgv.AllowUserToResizeColumns = false;
            _Dgv.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            _Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _Dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _Dgv.BackgroundColor = Color.FromArgb(0, 0, 50);
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _Dgv.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2, Column7, Column4, Column9, Column5, Column8, Column6 });
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = SystemColors.Window;
            DataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            _Dgv.DefaultCellStyle = DataGridViewCellStyle7;
            _Dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            _Dgv.Location = new Point(13, 64);
            _Dgv.Margin = new Padding(4, 5, 4, 5);
            _Dgv.MultiSelect = false;
            _Dgv.Name = "_Dgv";
            _Dgv.ReadOnly = true;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = SystemColors.Control;
            DataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _Dgv.RowHeadersVisible = false;
            _Dgv.RowHeadersWidth = 62;
            _Dgv.Size = new Size(1302, 966);
            _Dgv.TabIndex = 245;
            // 
            // FromDatePicker
            // 
            FromDatePicker.CalendarFont = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            FromDatePicker.Font = new Font("Century", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            FromDatePicker.Format = DateTimePickerFormat.Short;
            FromDatePicker.Location = new Point(96, 15);
            FromDatePicker.Margin = new Padding(4, 5, 4, 5);
            FromDatePicker.Name = "FromDatePicker";
            FromDatePicker.Size = new Size(199, 34);
            FromDatePicker.TabIndex = 254;
            FromDatePicker.Value = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = SystemColors.ActiveCaption;
            Label4.Location = new Point(16, 15);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(72, 28);
            Label4.TabIndex = 253;
            Label4.Text = "From";
            // 
            // TillDatePicker
            // 
            TillDatePicker.CalendarFont = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TillDatePicker.Font = new Font("Century", 11.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TillDatePicker.Format = DateTimePickerFormat.Short;
            TillDatePicker.Location = new Point(384, 15);
            TillDatePicker.Margin = new Padding(4, 5, 4, 5);
            TillDatePicker.Name = "TillDatePicker";
            TillDatePicker.Size = new Size(199, 34);
            TillDatePicker.TabIndex = 256;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ActiveCaption;
            Label1.Location = new Point(324, 15);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(52, 28);
            Label1.TabIndex = 255;
            Label1.Text = "Till";
            // 
            // AddMsgBT
            // 
            AddMsgBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddMsgBT.BackColor = Color.FromArgb(0, 64, 0);
            AddMsgBT.FlatAppearance.BorderSize = 0;
            AddMsgBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            AddMsgBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            AddMsgBT.FlatStyle = FlatStyle.Flat;
            AddMsgBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMsgBT.ForeColor = Color.Linen;
            AddMsgBT.IconChar = FontAwesome.Sharp.IconChar.Plus;
            AddMsgBT.IconColor = Color.White;
            AddMsgBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddMsgBT.IconSize = 36;
            AddMsgBT.Location = new Point(996, 10);
            AddMsgBT.Margin = new Padding(4, 5, 4, 5);
            AddMsgBT.Name = "AddMsgBT";
            AddMsgBT.Size = new Size(319, 44);
            AddMsgBT.TabIndex = 10027;
            AddMsgBT.Text = "Add Transaction";
            AddMsgBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddMsgBT.UseVisualStyleBackColor = false;
            // 
            // FindCoustmerButton
            // 
            FindCoustmerButton.BackColor = Color.FromArgb(25, 25, 70);
            FindCoustmerButton.FlatAppearance.BorderSize = 0;
            FindCoustmerButton.FlatStyle = FlatStyle.Flat;
            FindCoustmerButton.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindCoustmerButton.ForeColor = Color.MediumPurple;
            FindCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            FindCoustmerButton.IconColor = Color.Purple;
            FindCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FindCoustmerButton.IconSize = 50;
            FindCoustmerButton.Location = new Point(589, 11);
            FindCoustmerButton.Margin = new Padding(0);
            FindCoustmerButton.Name = "FindCoustmerButton";
            FindCoustmerButton.Size = new Size(63, 46);
            FindCoustmerButton.TabIndex = 10028;
            FindCoustmerButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            FindCoustmerButton.UseVisualStyleBackColor = false;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 35;
            // 
            // Column1
            // 
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle3.NullValue = null;
            Column1.DefaultCellStyle = DataGridViewCellStyle3;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 40;
            // 
            // Column2
            // 
            DataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.Format = "d";
            DataGridViewCellStyle4.NullValue = null;
            DataGridViewCellStyle4.SelectionBackColor = Color.White;
            DataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = DataGridViewCellStyle4;
            Column2.HeaderText = "Date";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Transfer Mode";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 180;
            // 
            // Column4
            // 
            DataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.NullValue = null;
            Column4.DefaultCellStyle = DataGridViewCellStyle5;
            Column4.HeaderText = "Amt.";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 110;
            // 
            // Column9
            // 
            Column9.HeaderText = "Account Number";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 200;
            // 
            // Column5
            // 
            DataGridViewCellStyle6.BackColor = Color.White;
            Column5.DefaultCellStyle = DataGridViewCellStyle6;
            Column5.HeaderText = "Reference No.";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "Linked KittNo";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Details";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1328, 418);
            Controls.Add(FindCoustmerButton);
            Controls.Add(AddMsgBT);
            Controls.Add(TillDatePicker);
            Controls.Add(Label1);
            Controls.Add(FromDatePicker);
            Controls.Add(Label4);
            Controls.Add(_Dgv);
            MaximumSize = new Size(1350, 1000000);
            MinimumSize = new Size(1350, 200);
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionsForm";
            ((System.ComponentModel.ISupportInitialize)_Dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private DataGridView _Dgv;

        protected virtual DataGridView Dgv
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Dgv;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Dgv != null)
                {
                    _Dgv.CellClick -= Dgv_CellClick;
                }

                _Dgv = value;
                if (_Dgv != null)
                {
                    _Dgv.CellClick += Dgv_CellClick;
                }
            }
        }
        internal DateTimePicker FromDatePicker;
        internal Label Label4;
        internal DateTimePicker TillDatePicker;
        internal Label Label1;
        internal FontAwesome.Sharp.IconButton AddMsgBT;
        internal FontAwesome.Sharp.IconButton FindCoustmerButton;
        internal DataGridViewCheckBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column7;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewButtonColumn Column6;
    }
}
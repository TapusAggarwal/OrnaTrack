using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ListTypeDgv : Form
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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            _Dgv = new DataGridView();
            _Dgv.SelectionChanged += new EventHandler(Dgv_SelectionChanged);
            SrNo = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            DeleteBT = new Button();
            DeleteBT.Click += new EventHandler(DeleteBT_Click);
            CancelBT = new Button();
            CancelBT.Click += new EventHandler(CancelBT_Click);
            SubmitBT = new Button();
            SubmitBT.Click += new EventHandler(SubmitBT_Click);
            EditBT = new Button();
            EditBT.Click += new EventHandler(EditBT_Click);
            AddBT = new Button();
            AddBT.Click += new EventHandler(AddBT_Click);
            Label4 = new Label();
            ItemTB = new TextBox();
            DownBT = new Button();
            DownBT.Click += new EventHandler(DownBT_Click);
            UpBT = new Button();
            UpBT.Click += new EventHandler(UpBT_Click);
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)_Dgv).BeginInit();
            SuspendLayout();
            // 
            // Dgv
            // 
            _Dgv.AllowUserToAddRows = false;
            _Dgv.AllowUserToDeleteRows = false;
            _Dgv.AllowUserToResizeColumns = false;
            _Dgv.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            _Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
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
            _Dgv.Columns.AddRange(new DataGridViewColumn[] { SrNo, Column2 });
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = SystemColors.Window;
            DataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _Dgv.DefaultCellStyle = DataGridViewCellStyle3;
            _Dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            _Dgv.Location = new Point(0, 0);
            _Dgv.Margin = new Padding(4, 5, 4, 5);
            _Dgv.MultiSelect = false;
            _Dgv.Name = "_Dgv";
            _Dgv.ReadOnly = true;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = SystemColors.Control;
            DataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _Dgv.RowHeadersVisible = false;
            _Dgv.RowHeadersWidth = 62;
            _Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _Dgv.Size = new Size(362, 474);
            _Dgv.TabIndex = 245;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "SrNo";
            SrNo.MinimumWidth = 8;
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            SrNo.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "ListItem";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // DeleteBT
            // 
            DeleteBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteBT.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBT.Location = new Point(416, 230);
            DeleteBT.Margin = new Padding(4, 5, 4, 5);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(82, 35);
            DeleteBT.TabIndex = 254;
            DeleteBT.Text = "Delete";
            DeleteBT.UseVisualStyleBackColor = true;
            // 
            // CancelBT
            // 
            CancelBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBT.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBT.Location = new Point(556, 362);
            CancelBT.Margin = new Padding(4, 5, 4, 5);
            CancelBT.Name = "CancelBT";
            CancelBT.Size = new Size(114, 48);
            CancelBT.TabIndex = 253;
            CancelBT.Text = "Cancel";
            CancelBT.UseVisualStyleBackColor = true;
            // 
            // SubmitBT
            // 
            SubmitBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SubmitBT.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBT.Location = new Point(416, 362);
            SubmitBT.Margin = new Padding(4, 5, 4, 5);
            SubmitBT.Name = "SubmitBT";
            SubmitBT.Size = new Size(114, 48);
            SubmitBT.TabIndex = 252;
            SubmitBT.Text = "Submit";
            SubmitBT.UseVisualStyleBackColor = true;
            // 
            // EditBT
            // 
            EditBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditBT.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBT.Location = new Point(502, 230);
            EditBT.Margin = new Padding(4, 5, 4, 5);
            EditBT.Name = "EditBT";
            EditBT.Size = new Size(82, 35);
            EditBT.TabIndex = 250;
            EditBT.Text = "Edit";
            EditBT.UseVisualStyleBackColor = true;
            // 
            // AddBT
            // 
            AddBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBT.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBT.Location = new Point(587, 230);
            AddBT.Margin = new Padding(4, 5, 4, 5);
            AddBT.Name = "AddBT";
            AddBT.Size = new Size(82, 35);
            AddBT.TabIndex = 249;
            AddBT.Text = "Add";
            AddBT.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.Goldenrod;
            Label4.Location = new Point(413, 171);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(107, 25);
            Label4.TabIndex = 251;
            Label4.Text = "Add Item";
            // 
            // ItemTB
            // 
            ItemTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ItemTB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemTB.Location = new Point(528, 165);
            ItemTB.Margin = new Padding(4, 5, 4, 5);
            ItemTB.Name = "ItemTB";
            ItemTB.Size = new Size(142, 36);
            ItemTB.TabIndex = 248;
            // 
            // DownBT
            // 
            DownBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DownBT.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DownBT.Location = new Point(365, 98);
            DownBT.Margin = new Padding(4, 5, 4, 5);
            DownBT.Name = "DownBT";
            DownBT.Size = new Size(39, 49);
            DownBT.TabIndex = 247;
            DownBT.Text = "↓";
            DownBT.TextAlign = ContentAlignment.BottomCenter;
            DownBT.UseVisualStyleBackColor = true;
            // 
            // UpBT
            // 
            UpBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpBT.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpBT.Location = new Point(365, 48);
            UpBT.Margin = new Padding(4, 5, 4, 5);
            UpBT.Name = "UpBT";
            UpBT.Size = new Size(39, 51);
            UpBT.TabIndex = 246;
            UpBT.Text = "↑";
            UpBT.TextAlign = ContentAlignment.BottomCenter;
            UpBT.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Goldenrod;
            Label1.Location = new Point(411, 9);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(259, 37);
            Label1.TabIndex = 255;
            Label1.Text = "Add Item";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ListTypeDgv
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(824, 474);
            Controls.Add(Label1);
            Controls.Add(DeleteBT);
            Controls.Add(CancelBT);
            Controls.Add(SubmitBT);
            Controls.Add(EditBT);
            Controls.Add(AddBT);
            Controls.Add(Label4);
            Controls.Add(ItemTB);
            Controls.Add(DownBT);
            Controls.Add(UpBT);
            Controls.Add(_Dgv);
            Name = "ListTypeDgv";
            Text = "ListTypeDgv";
            ((System.ComponentModel.ISupportInitialize)_Dgv).EndInit();
            Load += new EventHandler(ListTypeDgv_Load);
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
                    _Dgv.SelectionChanged -= Dgv_SelectionChanged;
                }

                _Dgv = value;
                if (_Dgv != null)
                {
                    _Dgv.SelectionChanged += Dgv_SelectionChanged;
                }
            }
        }
        internal Button DeleteBT;
        internal Button CancelBT;
        internal Button SubmitBT;
        internal Button EditBT;
        internal Button AddBT;
        internal Label Label4;
        internal TextBox ItemTB;
        internal Button DownBT;
        internal Button UpBT;
        internal Label Label1;
        internal DataGridViewTextBoxColumn SrNo;
        internal DataGridViewTextBoxColumn Column2;
    }
}
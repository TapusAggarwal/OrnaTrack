using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BookMode : Form
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
            _Dgv.CellClick += new DataGridViewCellEventHandler(Dgv_CellClick);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            CoustID = new DataGridViewButtonColumn();
            Column4 = new DataGridViewTextBoxColumn();
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
            _Dgv.BackgroundColor = Color.FromArgb(36, 35, 80);
            _Dgv.BorderStyle = BorderStyle.None;
            _Dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _Dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, CoustID, Column4 });
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = SystemColors.Window;
            DataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _Dgv.DefaultCellStyle = DataGridViewCellStyle3;
            _Dgv.Dock = DockStyle.Fill;
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
            _Dgv.Size = new Size(566, 266);
            _Dgv.TabIndex = 140;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "Kitty Type";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 146;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "Entry Range";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.HeaderText = "Total";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.ToolTipText = "Click To Open A New Form For The Coustmer";
            Column3.Width = 64;
            // 
            // CoustID
            // 
            CoustID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CoustID.FlatStyle = FlatStyle.Flat;
            CoustID.HeaderText = "Book Mode";
            CoustID.MinimumWidth = 8;
            CoustID.Name = "CoustID";
            CoustID.ReadOnly = true;
            CoustID.Resizable = DataGridViewTriState.True;
            CoustID.Text = "Start";
            CoustID.ToolTipText = "Open In Book Mode";
            CoustID.UseColumnTextForButtonValue = true;
            CoustID.Width = 118;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ids";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            Column4.Width = 150;
            // 
            // BookMode
            // 
            AutoScaleDimensions = new SizeF(144.0f, 144.0f);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(36, 35, 80);
            ClientSize = new Size(566, 266);
            Controls.Add(_Dgv);
            Name = "BookMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Open Kitty In Book Mode";
            ((System.ComponentModel.ISupportInitialize)_Dgv).EndInit();
            Load += new EventHandler(Kittyreport_Load);
            ResumeLayout(false);

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
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewButtonColumn CoustID;
        internal DataGridViewTextBoxColumn Column4;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Report : Form
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
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            AbsoluteButton = new FontAwesome.Sharp.IconButton();
            AbsoluteButton.Click += new EventHandler(AbsoluteButton_Click);
            RelativeButton = new FontAwesome.Sharp.IconButton();
            RelativeButton.Click += new EventHandler(RelativeButton_Click);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            _Dgv = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Dgv).BeginInit();
            SuspendLayout();
            // 
            // AbsoluteButton
            // 
            AbsoluteButton.BackColor = Color.FromArgb(25, 25, 70);
            AbsoluteButton.FlatAppearance.BorderSize = 0;
            AbsoluteButton.FlatStyle = FlatStyle.Flat;
            AbsoluteButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AbsoluteButton.ForeColor = Color.MediumPurple;
            AbsoluteButton.IconChar = FontAwesome.Sharp.IconChar.Clock;
            AbsoluteButton.IconColor = Color.Black;
            AbsoluteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AbsoluteButton.IconSize = 40;
            AbsoluteButton.Location = new Point(37, 20);
            AbsoluteButton.Margin = new Padding(4, 5, 4, 5);
            AbsoluteButton.Name = "AbsoluteButton";
            AbsoluteButton.Size = new Size(193, 50);
            AbsoluteButton.TabIndex = 158;
            AbsoluteButton.Text = "Absolute";
            AbsoluteButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            AbsoluteButton.UseVisualStyleBackColor = false;
            // 
            // RelativeButton
            // 
            RelativeButton.BackColor = Color.FromArgb(25, 25, 70);
            RelativeButton.FlatAppearance.BorderSize = 0;
            RelativeButton.FlatStyle = FlatStyle.Flat;
            RelativeButton.Font = new Font("Century Gothic", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelativeButton.ForeColor = Color.MediumPurple;
            RelativeButton.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            RelativeButton.IconColor = Color.Black;
            RelativeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RelativeButton.IconSize = 40;
            RelativeButton.Location = new Point(238, 20);
            RelativeButton.Margin = new Padding(4, 5, 4, 5);
            RelativeButton.Name = "RelativeButton";
            RelativeButton.Size = new Size(193, 50);
            RelativeButton.TabIndex = 169;
            RelativeButton.Text = "Relative";
            RelativeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            RelativeButton.UseVisualStyleBackColor = false;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AllowDrop = true;
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.BackColor = Color.FromArgb(32, 32, 50);
            FlowLayoutPanel1.Controls.Add(_Dgv);
            FlowLayoutPanel1.Location = new Point(2, 90);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1606, 618);
            FlowLayoutPanel1.TabIndex = 174;
            // 
            // Dgv
            // 
            _Dgv.AllowUserToAddRows = false;
            _Dgv.AllowUserToDeleteRows = false;
            _Dgv.AllowUserToResizeColumns = false;
            _Dgv.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            _Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            _Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _Dgv.BackgroundColor = Color.FromArgb(32, 32, 50);
            _Dgv.BorderStyle = BorderStyle.None;
            _Dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = SystemColors.Control;
            DataGridViewCellStyle8.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _Dgv.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column1, Column4 });
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = SystemColors.Window;
            DataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            _Dgv.DefaultCellStyle = DataGridViewCellStyle11;
            _Dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            _Dgv.Location = new Point(4, 5);
            _Dgv.Margin = new Padding(4, 5, 4, 5);
            _Dgv.MultiSelect = false;
            _Dgv.Name = "_Dgv";
            _Dgv.ReadOnly = true;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = SystemColors.Control;
            DataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            _Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle12;
            _Dgv.RowHeadersVisible = false;
            _Dgv.RowHeadersWidth = 62;
            _Dgv.Size = new Size(592, 568);
            _Dgv.TabIndex = 170;
            _Dgv.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column2.DefaultCellStyle = DataGridViewCellStyle9;
            Column2.HeaderText = "Instalments";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 210;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "Kitties";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.ToolTipText = "Click To Open A New Form For The Coustmer";
            Column3.Width = 79;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column1.DefaultCellStyle = DataGridViewCellStyle10;
            Column1.HeaderText = "Amount";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Interest";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 50);
            ClientSize = new Size(1610, 712);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(AbsoluteButton);
            Controls.Add(RelativeButton);
            DoubleBuffered = true;
            Name = "Report";
            Text = "Kitty Report";
            FlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_Dgv).EndInit();
            ResumeLayout(false);

        }

        internal FontAwesome.Sharp.IconButton AbsoluteButton;
        internal FontAwesome.Sharp.IconButton RelativeButton;
        internal FlowLayoutPanel FlowLayoutPanel1;
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
                _Dgv = value;
            }
        }
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column4;
    }
}
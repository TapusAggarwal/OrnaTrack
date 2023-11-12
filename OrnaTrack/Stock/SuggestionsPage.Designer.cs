using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SuggestionsPage : Form
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
            FlowLayoutPanel1 = new FlowLayoutPanel();
            _dgv = new DataGridView();
            SelectBT = new FontAwesome.Sharp.IconButton();
            SelectBT.Click += new EventHandler(SelectBT_Click);
            SaveBT = new FontAwesome.Sharp.IconButton();
            SaveBT.Click += new EventHandler(SaveBT_Click);
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Dock = DockStyle.Right;
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(194, 0);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(517, 615);
            FlowLayoutPanel1.TabIndex = 1;
            // 
            // dgv
            // 
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            _dgv.AllowUserToResizeColumns = false;
            _dgv.AllowUserToResizeRows = false;
            DataGridViewCellStyle17.BackColor = Color.FromArgb(224, 224, 224);
            _dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17;
            _dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _dgv.BackgroundColor = Color.FromArgb(0, 0, 50);
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle18.BackColor = SystemColors.Control;
            DataGridViewCellStyle18.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            _dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18;
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle19.BackColor = SystemColors.Window;
            DataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle19.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = DataGridViewCellStyle19;
            _dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            _dgv.Location = new Point(12, 77);
            _dgv.Margin = new Padding(4, 5, 4, 5);
            _dgv.MultiSelect = false;
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle20.BackColor = SystemColors.Control;
            DataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            _dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle20;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 62;
            _dgv.Size = new Size(175, 523);
            _dgv.TabIndex = 245;
            // 
            // SelectBT
            // 
            SelectBT.AutoSize = true;
            SelectBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectBT.BackColor = Color.Transparent;
            SelectBT.FlatAppearance.BorderSize = 0;
            SelectBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 30, 90);
            SelectBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 30, 75);
            SelectBT.FlatStyle = FlatStyle.Flat;
            SelectBT.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectBT.ForeColor = Color.MediumPurple;
            SelectBT.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            SelectBT.IconColor = Color.Goldenrod;
            SelectBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SelectBT.IconSize = 50;
            SelectBT.Location = new Point(134, 14);
            SelectBT.Margin = new Padding(0);
            SelectBT.Name = "SelectBT";
            SelectBT.Size = new Size(56, 56);
            SelectBT.TabIndex = 9998;
            SelectBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            SelectBT.UseVisualStyleBackColor = false;
            // 
            // SaveBT
            // 
            SaveBT.AutoSize = true;
            SaveBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveBT.BackColor = Color.FromArgb(25, 25, 70);
            SaveBT.FlatAppearance.BorderSize = 0;
            SaveBT.FlatStyle = FlatStyle.Flat;
            SaveBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBT.ForeColor = Color.MediumPurple;
            SaveBT.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            SaveBT.IconColor = Color.White;
            SaveBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveBT.IconSize = 45;
            SaveBT.Location = new Point(9, 14);
            SaveBT.Margin = new Padding(4, 5, 4, 5);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(124, 51);
            SaveBT.TabIndex = 9999;
            SaveBT.Text = "Save";
            SaveBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveBT.UseVisualStyleBackColor = false;
            // 
            // SuggestionsPage
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(711, 615);
            Controls.Add(SaveBT);
            Controls.Add(_dgv);
            Controls.Add(SelectBT);
            Controls.Add(FlowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuggestionsPage";
            Text = "SuggestionsPage";
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            Load += new EventHandler(SuggestionsPage_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FontAwesome.Sharp.IconButton SelectBT;
        private DataGridView _dgv;

        protected virtual DataGridView dgv
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgv;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _dgv = value;
            }
        }
        internal FontAwesome.Sharp.IconButton SaveBT;
    }
}
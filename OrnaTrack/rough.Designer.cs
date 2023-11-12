using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class rough : Form
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
            txtFilenName = new TextBox();
            Button1 = new Button();
            cboSheet = new ComboBox();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            _DataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtFilenName
            // 
            txtFilenName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFilenName.Location = new Point(13, 490);
            txtFilenName.Name = "txtFilenName";
            txtFilenName.Size = new Size(1023, 26);
            txtFilenName.TabIndex = 2;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button1.Location = new Point(1043, 493);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 3;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // cboSheet
            // 
            cboSheet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboSheet.FormattingEnabled = true;
            cboSheet.Location = new Point(12, 553);
            cboSheet.Name = "cboSheet";
            cboSheet.Size = new Size(121, 28);
            cboSheet.TabIndex = 0;
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button2.Location = new Point(1034, 558);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 4;
            Button2.Text = "Button2";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button3.Location = new Point(590, 534);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 5;
            Button3.Text = "Button3";
            Button3.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            _DataGridView1.AllowUserToAddRows = false;
            _DataGridView1.AllowUserToDeleteRows = false;
            _DataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            _DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _DataGridView1.BackgroundColor = Color.FromArgb(0, 0, 50);
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = SystemColors.Window;
            DataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _DataGridView1.DefaultCellStyle = DataGridViewCellStyle3;
            _DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DataGridView1.Location = new Point(12, 14);
            _DataGridView1.Margin = new Padding(4, 5, 4, 5);
            _DataGridView1.MultiSelect = false;
            _DataGridView1.Name = "_DataGridView1";
            _DataGridView1.ReadOnly = true;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = SystemColors.Control;
            DataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _DataGridView1.RowHeadersVisible = false;
            _DataGridView1.RowHeadersWidth = 62;
            _DataGridView1.Size = new Size(1106, 468);
            _DataGridView1.TabIndex = 246;
            // 
            // rough
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 100);
            ClientSize = new Size(1130, 593);
            Controls.Add(_DataGridView1);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(txtFilenName);
            Controls.Add(cboSheet);
            Name = "rough";
            Text = "rough";
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal TextBox txtFilenName;
        internal Button Button1;
        internal ComboBox cboSheet;
        internal Button Button2;
        internal Button Button3;
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
                _DataGridView1 = value;
            }
        }
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CBoxForm : Form
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
            DataGridView1 = new DataGridView();
            DataGridView1.SelectionChanged += new EventHandler(DataGridView1_SelectionChanged);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Label4 = new Label();
            TextBox6 = new TextBox();
            TextBox6.KeyDown += new KeyEventHandler(TextBox6_KeyDown);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Label1 = new Label();
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.AllowUserToResizeRows = false;
            DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridView1.Location = new Point(0, 0);
            DataGridView1.Margin = new Padding(4, 5, 4, 5);
            DataGridView1.MultiSelect = false;
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.Size = new Size(233, 428);
            DataGridView1.TabIndex = 0;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.Location = new Point(233, 55);
            Button1.Margin = new Padding(4, 5, 4, 5);
            Button1.Name = "Button1";
            Button1.Size = new Size(39, 51);
            Button1.TabIndex = 1;
            Button1.Text = "↑";
            Button1.TextAlign = ContentAlignment.BottomCenter;
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button2.Location = new Point(233, 105);
            Button2.Margin = new Padding(4, 5, 4, 5);
            Button2.Name = "Button2";
            Button2.Size = new Size(39, 49);
            Button2.TabIndex = 2;
            Button2.Text = "↓";
            Button2.TextAlign = ContentAlignment.BottomCenter;
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(249, 174);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(107, 25);
            Label4.TabIndex = 123;
            Label4.Text = "Add Item";
            // 
            // TextBox6
            // 
            TextBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextBox6.Location = new Point(358, 172);
            TextBox6.Margin = new Padding(4, 5, 4, 5);
            TextBox6.Name = "TextBox6";
            TextBox6.Size = new Size(142, 26);
            TextBox6.TabIndex = 3;
            // 
            // Button3
            // 
            Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button3.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button3.Location = new Point(417, 237);
            Button3.Margin = new Padding(4, 5, 4, 5);
            Button3.Name = "Button3";
            Button3.Size = new Size(82, 35);
            Button3.TabIndex = 4;
            Button3.Text = "Add";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button4.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button4.Location = new Point(332, 237);
            Button4.Margin = new Padding(4, 5, 4, 5);
            Button4.Name = "Button4";
            Button4.Size = new Size(82, 35);
            Button4.TabIndex = 5;
            Button4.Text = "Edit";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(242, 0);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(255, 37);
            Label1.TabIndex = 126;
            Label1.Text = "Add Item";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button5
            // 
            Button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button5.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button5.Location = new Point(246, 369);
            Button5.Margin = new Padding(4, 5, 4, 5);
            Button5.Name = "Button5";
            Button5.Size = new Size(114, 48);
            Button5.TabIndex = 127;
            Button5.Text = "Submit";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button6.Font = new Font("Century Schoolbook", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button6.Location = new Point(386, 369);
            Button6.Margin = new Padding(4, 5, 4, 5);
            Button6.Name = "Button6";
            Button6.Size = new Size(114, 48);
            Button6.TabIndex = 128;
            Button6.Text = "Cancel";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button7.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button7.Location = new Point(246, 237);
            Button7.Margin = new Padding(4, 5, 4, 5);
            Button7.Name = "Button7";
            Button7.Size = new Size(82, 35);
            Button7.TabIndex = 129;
            Button7.Text = "Delete";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            DataGridViewCellStyle1.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column1.DefaultCellStyle = DataGridViewCellStyle1;
            Column1.HeaderText = "SrNo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 60;
            // 
            // Column2
            // 
            DataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column2.DefaultCellStyle = DataGridViewCellStyle2;
            Column2.HeaderText = "Items";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 170;
            // 
            // CBoxForm
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(508, 428);
            Controls.Add(Button7);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Label1);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Label4);
            Controls.Add(TextBox6);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(DataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CBoxForm";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Form5_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal Button Button1;
        internal Button Button2;
        internal Label Label4;
        internal TextBox TextBox6;
        internal Button Button3;
        internal Button Button4;
        internal Label Label1;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
    }
}
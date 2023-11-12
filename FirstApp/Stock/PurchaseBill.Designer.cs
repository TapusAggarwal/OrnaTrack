using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PurchaseBill : Form
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
            AttrCategoryCB = new ComboBox();
            CtgLB = new Label();
            Label1 = new Label();
            DateTimePicker1 = new DateTimePicker();
            ImageBox = new PictureBox();
            NameLB = new Label();
            AttrNameTB = new TextBox();
            Label4 = new Label();
            TextBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // AttrCategoryCB
            // 
            AttrCategoryCB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AttrCategoryCB.DropDownHeight = 200;
            AttrCategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AttrCategoryCB.FlatStyle = FlatStyle.Flat;
            AttrCategoryCB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttrCategoryCB.FormattingEnabled = true;
            AttrCategoryCB.IntegralHeight = false;
            AttrCategoryCB.Items.AddRange(new object[] { "Purchase Attr.", "Product Attr.", "Sale Attribute" });
            AttrCategoryCB.Location = new Point(137, 23);
            AttrCategoryCB.Margin = new Padding(4, 5, 4, 5);
            AttrCategoryCB.MaxDropDownItems = 20;
            AttrCategoryCB.Name = "AttrCategoryCB";
            AttrCategoryCB.Size = new Size(293, 34);
            AttrCategoryCB.TabIndex = 317;
            AttrCategoryCB.Tag = "";
            // 
            // CtgLB
            // 
            CtgLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CtgLB.AutoSize = true;
            CtgLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CtgLB.ForeColor = Color.Peru;
            CtgLB.Location = new Point(26, 23);
            CtgLB.Margin = new Padding(4, 0, 4, 0);
            CtgLB.Name = "CtgLB";
            CtgLB.Size = new Size(92, 30);
            CtgLB.TabIndex = 316;
            CtgLB.Text = "Seller:";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label1.AutoSize = true;
            Label1.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Peru;
            Label1.Location = new Point(493, 23);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(79, 30);
            Label1.TabIndex = 318;
            Label1.Text = "Date:";
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Location = new Point(602, 23);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(236, 26);
            DateTimePicker1.TabIndex = 319;
            // 
            // ImageBox
            // 
            ImageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ImageBox.BackColor = Color.FromArgb(36, 30, 60);
            ImageBox.Image = My.Resources.Resources.addSign;
            ImageBox.Location = new Point(12, 456);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(227, 71);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 320;
            ImageBox.TabStop = false;
            // 
            // NameLB
            // 
            NameLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NameLB.AutoSize = true;
            NameLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLB.ForeColor = Color.Peru;
            NameLB.Location = new Point(26, 95);
            NameLB.Margin = new Padding(4, 0, 4, 0);
            NameLB.Name = "NameLB";
            NameLB.Size = new Size(228, 30);
            NameLB.TabIndex = 326;
            NameLB.Text = "Amt. Before GST:";
            // 
            // AttrNameTB
            // 
            AttrNameTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AttrNameTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttrNameTB.Location = new Point(262, 93);
            AttrNameTB.Margin = new Padding(4, 5, 4, 5);
            AttrNameTB.Name = "AttrNameTB";
            AttrNameTB.Size = new Size(293, 36);
            AttrNameTB.TabIndex = 325;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label4.AutoSize = true;
            Label4.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.Peru;
            Label4.Location = new Point(608, 95);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(73, 30);
            Label4.TabIndex = 328;
            Label4.Text = "GST:";
            // 
            // TextBox1
            // 
            TextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBox1.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBox1.Location = new Point(689, 93);
            TextBox1.Margin = new Padding(4, 5, 4, 5);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(293, 36);
            TextBox1.TabIndex = 327;
            // 
            // PurchaseBill
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1054, 539);
            Controls.Add(Label4);
            Controls.Add(TextBox1);
            Controls.Add(NameLB);
            Controls.Add(AttrNameTB);
            Controls.Add(ImageBox);
            Controls.Add(DateTimePicker1);
            Controls.Add(Label1);
            Controls.Add(AttrCategoryCB);
            Controls.Add(CtgLB);
            Name = "PurchaseBill";
            Text = "PurchaseBill";
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal ComboBox AttrCategoryCB;
        internal Label CtgLB;
        internal Label Label1;
        internal DateTimePicker DateTimePicker1;
        internal PictureBox ImageBox;
        internal Label NameLB;
        internal TextBox AttrNameTB;
        internal Label Label4;
        internal TextBox TextBox1;
    }
}
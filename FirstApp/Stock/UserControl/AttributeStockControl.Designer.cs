using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AttributeStockControl : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
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
            AttributeLB = new Label();
            DefaultValueTB = new TextBox();
            DefaultValueTB.Leave += new EventHandler(DefaultValueTB_Leave);
            DefaultValueTB.GotFocus += new EventHandler(DefaultValueTB_GotFocus);
            DefaultValueTB.KeyPress += new KeyPressEventHandler(DefaultValueTB_KeyPress);
            TrueChB = new CheckBox();
            TrueChB.CheckedChanged += new EventHandler(TrueChB_CheckedChanged);
            FalseChB = new CheckBox();
            FalseChB.CheckedChanged += new EventHandler(FalseChB_CheckedChanged);
            ListValues = new ComboBox();
            SuspendLayout();
            // 
            // AttributeLB
            // 
            AttributeLB.AutoSize = true;
            AttributeLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttributeLB.ForeColor = Color.Peru;
            AttributeLB.Location = new Point(8, 13);
            AttributeLB.Margin = new Padding(4, 0, 4, 0);
            AttributeLB.Name = "AttributeLB";
            AttributeLB.Size = new Size(0, 30);
            AttributeLB.TabIndex = 253;
            // 
            // DefaultValueTB
            // 
            DefaultValueTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DefaultValueTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DefaultValueTB.Location = new Point(20, 11);
            DefaultValueTB.Margin = new Padding(4, 5, 4, 5);
            DefaultValueTB.Name = "DefaultValueTB";
            DefaultValueTB.Size = new Size(229, 36);
            DefaultValueTB.TabIndex = 291;
            DefaultValueTB.Visible = false;
            // 
            // TrueChB
            // 
            TrueChB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TrueChB.AutoSize = true;
            TrueChB.BackColor = Color.Transparent;
            TrueChB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrueChB.ForeColor = SystemColors.ActiveCaption;
            TrueChB.Location = new Point(43, 11);
            TrueChB.Margin = new Padding(4, 5, 4, 5);
            TrueChB.Name = "TrueChB";
            TrueChB.Size = new Size(88, 34);
            TrueChB.TabIndex = 294;
            TrueChB.TabStop = false;
            TrueChB.Text = "True";
            TrueChB.UseVisualStyleBackColor = false;
            TrueChB.Visible = false;
            // 
            // FalseChB
            // 
            FalseChB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FalseChB.AutoSize = true;
            FalseChB.BackColor = Color.Transparent;
            FalseChB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FalseChB.ForeColor = SystemColors.ActiveCaption;
            FalseChB.Location = new Point(139, 11);
            FalseChB.Margin = new Padding(4, 5, 4, 5);
            FalseChB.Name = "FalseChB";
            FalseChB.Size = new Size(99, 34);
            FalseChB.TabIndex = 293;
            FalseChB.TabStop = false;
            FalseChB.Text = "False";
            FalseChB.UseVisualStyleBackColor = false;
            FalseChB.Visible = false;
            // 
            // ListValues
            // 
            ListValues.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListValues.DropDownHeight = 200;
            ListValues.DropDownStyle = ComboBoxStyle.DropDownList;
            ListValues.FlatStyle = FlatStyle.Flat;
            ListValues.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListValues.FormattingEnabled = true;
            ListValues.IntegralHeight = false;
            ListValues.Location = new Point(20, 13);
            ListValues.Margin = new Padding(4, 5, 4, 5);
            ListValues.MaxDropDownItems = 20;
            ListValues.Name = "ListValues";
            ListValues.Size = new Size(229, 34);
            ListValues.TabIndex = 295;
            ListValues.Tag = "";
            ListValues.Visible = false;
            // 
            // AttributeStockControl
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 100);
            Controls.Add(DefaultValueTB);
            Controls.Add(TrueChB);
            Controls.Add(ListValues);
            Controls.Add(AttributeLB);
            Controls.Add(FalseChB);
            Name = "AttributeStockControl";
            Size = new Size(259, 57);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label AttributeLB;
        internal TextBox DefaultValueTB;
        internal CheckBox TrueChB;
        internal CheckBox FalseChB;
        internal ComboBox ListValues;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddFormulaForm : Form
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
            FlowLayoutPanel1 = new FlowLayoutPanel();
            FormulaPanel = new FlowLayoutPanel();
            LeftBracketBT = new FontAwesome.Sharp.IconButton();
            LeftBracketBT.Click += new EventHandler(MathOperations_Click);
            RightBracketBT = new FontAwesome.Sharp.IconButton();
            RightBracketBT.Click += new EventHandler(MathOperations_Click);
            DivideBT = new FontAwesome.Sharp.IconButton();
            DivideBT.Click += new EventHandler(MathOperations_Click);
            PlusBT = new FontAwesome.Sharp.IconButton();
            PlusBT.Click += new EventHandler(MathOperations_Click);
            MinusBT = new FontAwesome.Sharp.IconButton();
            MinusBT.Click += new EventHandler(MathOperations_Click);
            MultiplyBT = new FontAwesome.Sharp.IconButton();
            MultiplyBT.Click += new EventHandler(MathOperations_Click);
            UseBT = new FontAwesome.Sharp.IconButton();
            UseBT.Click += new EventHandler(UseBT_Click);
            FormulaTB = new ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl();
            FormulaTB.TextChanged += new EventHandler(FormulaTB_KeyDown);
            FormulaTB.KeyPress += new KeyPressEventHandler(FormulaTB_KeyPress);
            AddParametersBT = new FontAwesome.Sharp.IconButton();
            FormulaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Dock = DockStyle.Bottom;
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(0, 141);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1325, 524);
            FlowLayoutPanel1.TabIndex = 0;
            // 
            // FormulaPanel
            // 
            FormulaPanel.Controls.Add(LeftBracketBT);
            FormulaPanel.Controls.Add(RightBracketBT);
            FormulaPanel.Controls.Add(DivideBT);
            FormulaPanel.Controls.Add(PlusBT);
            FormulaPanel.Controls.Add(MinusBT);
            FormulaPanel.Controls.Add(MultiplyBT);
            FormulaPanel.Location = new Point(14, 74);
            FormulaPanel.Name = "FormulaPanel";
            FormulaPanel.Size = new Size(370, 61);
            FormulaPanel.TabIndex = 323;
            // 
            // LeftBracketBT
            // 
            LeftBracketBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LeftBracketBT.AutoSize = true;
            LeftBracketBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LeftBracketBT.BackColor = Color.FromArgb(25, 25, 70);
            LeftBracketBT.FlatStyle = FlatStyle.Flat;
            LeftBracketBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftBracketBT.ForeColor = Color.MediumPurple;
            LeftBracketBT.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            LeftBracketBT.IconColor = Color.White;
            LeftBracketBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LeftBracketBT.IconSize = 45;
            LeftBracketBT.ImageAlign = ContentAlignment.TopCenter;
            LeftBracketBT.Location = new Point(4, 5);
            LeftBracketBT.Margin = new Padding(4, 5, 4, 5);
            LeftBracketBT.Name = "LeftBracketBT";
            LeftBracketBT.Size = new Size(53, 53);
            LeftBracketBT.TabIndex = 312;
            LeftBracketBT.TextAlign = ContentAlignment.TopCenter;
            LeftBracketBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            LeftBracketBT.UseVisualStyleBackColor = false;
            // 
            // RightBracketBT
            // 
            RightBracketBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RightBracketBT.AutoSize = true;
            RightBracketBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RightBracketBT.BackColor = Color.FromArgb(25, 25, 70);
            RightBracketBT.FlatStyle = FlatStyle.Flat;
            RightBracketBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightBracketBT.ForeColor = Color.MediumPurple;
            RightBracketBT.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            RightBracketBT.IconColor = Color.White;
            RightBracketBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RightBracketBT.IconSize = 45;
            RightBracketBT.ImageAlign = ContentAlignment.TopCenter;
            RightBracketBT.Location = new Point(65, 5);
            RightBracketBT.Margin = new Padding(4, 5, 4, 5);
            RightBracketBT.Name = "RightBracketBT";
            RightBracketBT.Size = new Size(53, 53);
            RightBracketBT.TabIndex = 313;
            RightBracketBT.TextAlign = ContentAlignment.TopCenter;
            RightBracketBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            RightBracketBT.UseVisualStyleBackColor = false;
            // 
            // DivideBT
            // 
            DivideBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DivideBT.AutoSize = true;
            DivideBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DivideBT.BackColor = Color.FromArgb(25, 25, 70);
            DivideBT.FlatStyle = FlatStyle.Flat;
            DivideBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DivideBT.ForeColor = Color.MediumPurple;
            DivideBT.IconChar = FontAwesome.Sharp.IconChar.Divide;
            DivideBT.IconColor = Color.White;
            DivideBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DivideBT.IconSize = 45;
            DivideBT.ImageAlign = ContentAlignment.TopCenter;
            DivideBT.Location = new Point(126, 5);
            DivideBT.Margin = new Padding(4, 5, 4, 5);
            DivideBT.Name = "DivideBT";
            DivideBT.Size = new Size(53, 53);
            DivideBT.TabIndex = 307;
            DivideBT.TextAlign = ContentAlignment.TopCenter;
            DivideBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            DivideBT.UseVisualStyleBackColor = false;
            // 
            // PlusBT
            // 
            PlusBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PlusBT.AutoSize = true;
            PlusBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PlusBT.BackColor = Color.FromArgb(25, 25, 70);
            PlusBT.FlatStyle = FlatStyle.Flat;
            PlusBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlusBT.ForeColor = Color.MediumPurple;
            PlusBT.IconChar = FontAwesome.Sharp.IconChar.Plus;
            PlusBT.IconColor = Color.White;
            PlusBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PlusBT.IconSize = 45;
            PlusBT.ImageAlign = ContentAlignment.TopCenter;
            PlusBT.Location = new Point(187, 5);
            PlusBT.Margin = new Padding(4, 5, 4, 5);
            PlusBT.Name = "PlusBT";
            PlusBT.Size = new Size(53, 53);
            PlusBT.TabIndex = 309;
            PlusBT.TextAlign = ContentAlignment.TopCenter;
            PlusBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            PlusBT.UseVisualStyleBackColor = false;
            // 
            // MinusBT
            // 
            MinusBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MinusBT.AutoSize = true;
            MinusBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MinusBT.BackColor = Color.FromArgb(25, 25, 70);
            MinusBT.FlatStyle = FlatStyle.Flat;
            MinusBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinusBT.ForeColor = Color.MediumPurple;
            MinusBT.IconChar = FontAwesome.Sharp.IconChar.Minus;
            MinusBT.IconColor = Color.White;
            MinusBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MinusBT.IconSize = 45;
            MinusBT.ImageAlign = ContentAlignment.TopCenter;
            MinusBT.Location = new Point(248, 5);
            MinusBT.Margin = new Padding(4, 5, 4, 5);
            MinusBT.Name = "MinusBT";
            MinusBT.Size = new Size(53, 53);
            MinusBT.TabIndex = 310;
            MinusBT.TextAlign = ContentAlignment.TopCenter;
            MinusBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            MinusBT.UseVisualStyleBackColor = false;
            // 
            // MultiplyBT
            // 
            MultiplyBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MultiplyBT.AutoSize = true;
            MultiplyBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MultiplyBT.BackColor = Color.FromArgb(25, 25, 70);
            MultiplyBT.FlatStyle = FlatStyle.Flat;
            MultiplyBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MultiplyBT.ForeColor = Color.MediumPurple;
            MultiplyBT.IconChar = FontAwesome.Sharp.IconChar.Times;
            MultiplyBT.IconColor = Color.White;
            MultiplyBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MultiplyBT.IconSize = 45;
            MultiplyBT.ImageAlign = ContentAlignment.TopCenter;
            MultiplyBT.Location = new Point(309, 5);
            MultiplyBT.Margin = new Padding(4, 5, 4, 5);
            MultiplyBT.Name = "MultiplyBT";
            MultiplyBT.Size = new Size(53, 53);
            MultiplyBT.TabIndex = 308;
            MultiplyBT.TextAlign = ContentAlignment.TopCenter;
            MultiplyBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            MultiplyBT.UseVisualStyleBackColor = false;
            // 
            // UseBT
            // 
            UseBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UseBT.AutoSize = true;
            UseBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UseBT.BackColor = Color.ForestGreen;
            UseBT.FlatAppearance.BorderSize = 0;
            UseBT.FlatStyle = FlatStyle.Flat;
            UseBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UseBT.ForeColor = Color.GhostWhite;
            UseBT.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            UseBT.IconColor = Color.White;
            UseBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UseBT.IconSize = 45;
            UseBT.Location = new Point(1017, 80);
            UseBT.Margin = new Padding(4, 5, 4, 5);
            UseBT.Name = "UseBT";
            UseBT.Size = new Size(294, 51);
            UseBT.TabIndex = 322;
            UseBT.Text = "Use This Calculation";
            UseBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            UseBT.UseVisualStyleBackColor = false;
            // 
            // FormulaTB
            // 
            FormulaTB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FormulaTB.AutoWordSelection = true;
            FormulaTB.BackColor = Color.Lavender;
            FormulaTB.Font = new Font("Century Schoolbook", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormulaTB.Location = new Point(12, 12);
            FormulaTB.Name = "FormulaTB";
            FormulaTB.Size = new Size(1299, 56);
            FormulaTB.TabIndex = 321;
            FormulaTB.Text = "";
            // 
            // AddParametersBT
            // 
            AddParametersBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddParametersBT.AutoSize = true;
            AddParametersBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddParametersBT.BackColor = Color.FromArgb(25, 25, 70);
            AddParametersBT.FlatAppearance.BorderSize = 0;
            AddParametersBT.FlatStyle = FlatStyle.Flat;
            AddParametersBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddParametersBT.ForeColor = Color.MediumPurple;
            AddParametersBT.IconChar = FontAwesome.Sharp.IconChar.Plus;
            AddParametersBT.IconColor = Color.White;
            AddParametersBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddParametersBT.IconSize = 45;
            AddParametersBT.Location = new Point(410, 79);
            AddParametersBT.Margin = new Padding(4, 5, 4, 5);
            AddParametersBT.Name = "AddParametersBT";
            AddParametersBT.Size = new Size(110, 51);
            AddParametersBT.TabIndex = 320;
            AddParametersBT.Text = "Prm";
            AddParametersBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddParametersBT.UseVisualStyleBackColor = false;
            // 
            // AddFormulaForm
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1325, 665);
            Controls.Add(FormulaPanel);
            Controls.Add(UseBT);
            Controls.Add(FormulaTB);
            Controls.Add(AddParametersBT);
            Controls.Add(FlowLayoutPanel1);
            Name = "AddFormulaForm";
            Text = "Select The Attribute";
            FormulaPanel.ResumeLayout(false);
            FormulaPanel.PerformLayout();
            Load += new EventHandler(AddFormulaForm_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FlowLayoutPanel FormulaPanel;
        internal FontAwesome.Sharp.IconButton LeftBracketBT;
        internal FontAwesome.Sharp.IconButton RightBracketBT;
        internal FontAwesome.Sharp.IconButton DivideBT;
        internal FontAwesome.Sharp.IconButton PlusBT;
        internal FontAwesome.Sharp.IconButton MinusBT;
        internal FontAwesome.Sharp.IconButton MultiplyBT;
        internal FontAwesome.Sharp.IconButton UseBT;
        internal ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl FormulaTB;
        internal FontAwesome.Sharp.IconButton AddParametersBT;
    }
}
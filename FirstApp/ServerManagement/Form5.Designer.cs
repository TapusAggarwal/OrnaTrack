using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    internal partial class Form5 : Form
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
            CmdTB = new TextBox();
            RunBT = new Button();
            RunBT.Click += new EventHandler(RunBT_Click);
            RichTextBox1 = new RichTextBox();
            RichTextBox1.KeyPress += new KeyPressEventHandler(RichTextBox1_KeyPress);
            RichTextBox1.TextChanged += new EventHandler(RichTextBox1_TextChanged);
            StartBT = new Button();
            StartBT.Click += new EventHandler(StartBT_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            SuspendLayout();
            // 
            // CmdTB
            // 
            CmdTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            CmdTB.Location = new Point(68, 38);
            CmdTB.Name = "CmdTB";
            CmdTB.Size = new Size(549, 26);
            CmdTB.TabIndex = 0;
            // 
            // RunBT
            // 
            RunBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RunBT.Location = new Point(447, 336);
            RunBT.Name = "RunBT";
            RunBT.Size = new Size(195, 67);
            RunBT.TabIndex = 1;
            RunBT.Text = "Run";
            RunBT.UseVisualStyleBackColor = true;
            // 
            // RichTextBox1
            // 
            RichTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            RichTextBox1.Location = new Point(68, 70);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(549, 260);
            RichTextBox1.TabIndex = 4;
            RichTextBox1.Text = "";
            // 
            // StartBT
            // 
            StartBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartBT.Location = new Point(45, 336);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(195, 67);
            StartBT.TabIndex = 5;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button1.Location = new Point(246, 336);
            Button1.Name = "Button1";
            Button1.Size = new Size(195, 67);
            Button1.TabIndex = 6;
            Button1.Text = "Cmd";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(Button1);
            Controls.Add(StartBT);
            Controls.Add(RichTextBox1);
            Controls.Add(RunBT);
            Controls.Add(CmdTB);
            Name = "Form5";
            Text = "Form5";
            Load += new EventHandler(Form5_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox CmdTB;
        internal Button RunBT;
        internal RichTextBox RichTextBox1;
        internal Button StartBT;
        internal Button Button1;
    }
}
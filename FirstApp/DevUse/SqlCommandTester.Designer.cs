using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class sqlcommandtester : Form
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
            Button1 = new Button();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_click);
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(33, 308);
            Button1.Name = "Button1";
            Button1.Size = new Size(170, 103);
            Button1.TabIndex = 0;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(493, 288);
            Button2.Name = "Button2";
            Button2.Size = new Size(170, 103);
            Button2.TabIndex = 1;
            Button2.Text = "Button2";
            Button2.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(44, 12);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(630, 205);
            TextBox1.TabIndex = 2;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(93, 238);
            TextBox2.Multiline = true;
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(494, 44);
            TextBox2.TabIndex = 3;
            // 
            // SqlCommandTester
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Name = "SqlCommandTester";
            Text = "SqlCommandTester";
            Disposed += new EventHandler(Frmsimple_disposed);
            Closed += new EventHandler(Frmsimple_disposed);
            Load += new EventHandler(Form1_load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Button1;
        internal Button Button2;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
    }
}
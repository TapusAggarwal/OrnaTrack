using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MessengerForIndividual : Form
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
            Panel1 = new Panel();
            TemplateBT = new FontAwesome.Sharp.IconButton();
            TemplateBT.Click += new EventHandler(TemplateBT_Click);
            ReceiptBT = new FontAwesome.Sharp.IconButton();
            ReceiptBT.Click += new EventHandler(ReceiptBT_Click);
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel1.Location = new Point(1, 54);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1206, 681);
            Panel1.TabIndex = 10000;
            // 
            // TemplateBT
            // 
            TemplateBT.AutoSize = true;
            TemplateBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TemplateBT.BackColor = Color.FromArgb(25, 25, 70);
            TemplateBT.FlatAppearance.BorderSize = 0;
            TemplateBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 100);
            TemplateBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 85);
            TemplateBT.FlatStyle = FlatStyle.Flat;
            TemplateBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TemplateBT.ForeColor = Color.SlateBlue;
            TemplateBT.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            TemplateBT.IconColor = Color.White;
            TemplateBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TemplateBT.IconSize = 36;
            TemplateBT.Location = new Point(310, 6);
            TemplateBT.Margin = new Padding(4, 5, 4, 5);
            TemplateBT.Name = "TemplateBT";
            TemplateBT.Size = new Size(315, 44);
            TemplateBT.TabIndex = 9999;
            TemplateBT.Text = "Message Template";
            TemplateBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            TemplateBT.UseVisualStyleBackColor = false;
            // 
            // ReceiptBT
            // 
            ReceiptBT.AutoSize = true;
            ReceiptBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ReceiptBT.BackColor = Color.FromArgb(25, 25, 70);
            ReceiptBT.FlatAppearance.BorderSize = 0;
            ReceiptBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 100);
            ReceiptBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 85);
            ReceiptBT.FlatStyle = FlatStyle.Flat;
            ReceiptBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptBT.ForeColor = Color.SlateBlue;
            ReceiptBT.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            ReceiptBT.IconColor = Color.White;
            ReceiptBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReceiptBT.IconSize = 36;
            ReceiptBT.Location = new Point(9, 6);
            ReceiptBT.Margin = new Padding(4, 5, 4, 5);
            ReceiptBT.Name = "ReceiptBT";
            ReceiptBT.Size = new Size(293, 44);
            ReceiptBT.TabIndex = 9998;
            ReceiptBT.Text = "Message Receipt";
            ReceiptBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            ReceiptBT.UseVisualStyleBackColor = false;
            // 
            // MessengerForIndividual
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1208, 737);
            Controls.Add(Panel1);
            Controls.Add(TemplateBT);
            Controls.Add(ReceiptBT);
            Name = "MessengerForIndividual";
            Text = "MessengerForIndividual";
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(MessengerForIndividual_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal FontAwesome.Sharp.IconButton TemplateBT;
        internal FontAwesome.Sharp.IconButton ReceiptBT;
        internal Panel Panel1;
    }
}
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ServerUpdateForm : Form
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
            UpdateBT = new FontAwesome.Sharp.IconButton();
            RichTextBox1 = new RichTextBox();
            RichTextBox1.TextChanged += new EventHandler(RichTextBox1_TextChanged);
            LogoffBT = new FontAwesome.Sharp.IconButton();
            LogoffBT.Click += new EventHandler(LogoffBT_Click);
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(4, 106);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(277, 379);
            FlowLayoutPanel1.TabIndex = 1;
            FlowLayoutPanel1.WrapContents = false;
            // 
            // UpdateBT
            // 
            UpdateBT.AutoSize = true;
            UpdateBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UpdateBT.BackColor = Color.FromArgb(0, 114, 0);
            UpdateBT.FlatAppearance.BorderSize = 0;
            UpdateBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            UpdateBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            UpdateBT.FlatStyle = FlatStyle.Flat;
            UpdateBT.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBT.ForeColor = Color.Linen;
            UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Connectdevelop;
            UpdateBT.IconColor = Color.White;
            UpdateBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UpdateBT.IconSize = 36;
            UpdateBT.Location = new Point(13, 14);
            UpdateBT.Margin = new Padding(4, 5, 4, 5);
            UpdateBT.Name = "UpdateBT";
            UpdateBT.Size = new Size(120, 42);
            UpdateBT.TabIndex = 10009;
            UpdateBT.Text = "Login";
            UpdateBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateBT.UseVisualStyleBackColor = false;
            // 
            // RichTextBox1
            // 
            RichTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RichTextBox1.Font = new Font("Century Gothic", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTextBox1.Location = new Point(296, 104);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.ReadOnly = true;
            RichTextBox1.Size = new Size(697, 381);
            RichTextBox1.TabIndex = 10012;
            RichTextBox1.Text = "";
            // 
            // LogoffBT
            // 
            LogoffBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoffBT.AutoSize = true;
            LogoffBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogoffBT.BackColor = Color.FromArgb(114, 0, 0);
            LogoffBT.FlatAppearance.BorderSize = 0;
            LogoffBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            LogoffBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            LogoffBT.FlatStyle = FlatStyle.Flat;
            LogoffBT.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoffBT.ForeColor = Color.Linen;
            LogoffBT.IconChar = FontAwesome.Sharp.IconChar.Bed;
            LogoffBT.IconColor = Color.White;
            LogoffBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoffBT.IconSize = 36;
            LogoffBT.Location = new Point(859, 14);
            LogoffBT.Margin = new Padding(4, 5, 4, 5);
            LogoffBT.Name = "LogoffBT";
            LogoffBT.Size = new Size(134, 42);
            LogoffBT.TabIndex = 10013;
            LogoffBT.Text = "LogOff";
            LogoffBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoffBT.UseVisualStyleBackColor = false;
            LogoffBT.Visible = false;
            // 
            // ServerUpdateForm
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 489);
            Controls.Add(LogoffBT);
            Controls.Add(RichTextBox1);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(UpdateBT);
            Name = "ServerUpdateForm";
            Text = "ServerUpdateForm";
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(ServerUpdateForm_Load);
            Closing += new System.ComponentModel.CancelEventHandler(ServerUpdateForm_Closed);
            Disposed += new EventHandler(ServerUpdateForm_Closed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal FontAwesome.Sharp.IconButton UpdateBT;
        internal RichTextBox RichTextBox1;
        internal FontAwesome.Sharp.IconButton LogoffBT;
    }
}
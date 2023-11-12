using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Graph : Form
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
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            FlowLayoutPanel2019 = new FlowLayoutPanel();
            FlowLayoutPanel2020 = new FlowLayoutPanel();
            FlowLayoutPanel2021 = new FlowLayoutPanel();
            FlowLayoutPanel2022 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(627, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Label1";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(627, 111);
            Label2.Name = "Label2";
            Label2.Size = new Size(57, 20);
            Label2.TabIndex = 2;
            Label2.Text = "Label2";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(627, 235);
            Label3.Name = "Label3";
            Label3.Size = new Size(57, 20);
            Label3.TabIndex = 3;
            Label3.Text = "Label3";
            // 
            // FlowLayoutPanel2019
            // 
            FlowLayoutPanel2019.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel2019.AutoScroll = true;
            FlowLayoutPanel2019.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel2019.Location = new Point(6, 5);
            FlowLayoutPanel2019.Name = "FlowLayoutPanel2019";
            FlowLayoutPanel2019.Size = new Size(143, 439);
            FlowLayoutPanel2019.TabIndex = 4;
            // 
            // FlowLayoutPanel2020
            // 
            FlowLayoutPanel2020.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel2020.AutoScroll = true;
            FlowLayoutPanel2020.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel2020.Location = new Point(159, 5);
            FlowLayoutPanel2020.Name = "FlowLayoutPanel2020";
            FlowLayoutPanel2020.Size = new Size(143, 439);
            FlowLayoutPanel2020.TabIndex = 5;
            // 
            // FlowLayoutPanel2021
            // 
            FlowLayoutPanel2021.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel2021.AutoScroll = true;
            FlowLayoutPanel2021.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel2021.Location = new Point(312, 5);
            FlowLayoutPanel2021.Name = "FlowLayoutPanel2021";
            FlowLayoutPanel2021.Size = new Size(143, 439);
            FlowLayoutPanel2021.TabIndex = 6;
            // 
            // FlowLayoutPanel2022
            // 
            FlowLayoutPanel2022.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FlowLayoutPanel2022.AutoScroll = true;
            FlowLayoutPanel2022.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel2022.Location = new Point(465, 5);
            FlowLayoutPanel2022.Name = "FlowLayoutPanel2022";
            FlowLayoutPanel2022.Size = new Size(143, 439);
            FlowLayoutPanel2022.TabIndex = 7;
            // 
            // Graph
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(FlowLayoutPanel2022);
            Controls.Add(FlowLayoutPanel2021);
            Controls.Add(FlowLayoutPanel2020);
            Controls.Add(FlowLayoutPanel2019);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "Graph";
            Text = "Graph";
            Load += new EventHandler(Graph_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal FlowLayoutPanel FlowLayoutPanel2019;
        internal FlowLayoutPanel FlowLayoutPanel2020;
        internal FlowLayoutPanel FlowLayoutPanel2021;
        internal FlowLayoutPanel FlowLayoutPanel2022;
    }
}
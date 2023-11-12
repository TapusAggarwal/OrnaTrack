using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class PhoneNoTag
    {

        protected string _data;

        public string TagData
        {

            get
            {
                string My_Data = "";
                foreach (TextBox TB in FlowLayoutPanel1.Controls)
                {
                    if (TB.TextLength == 10)
                    {
                        My_Data += TB.Text + ", ";
                    }
                }
                try
                {
                    My_Data = My_Data.Substring(0, My_Data.Length - 2);
                }
                catch (Exception ex)
                {
                    My_Data = "";
                }
                return My_Data;
            }
            set
            {

                if (value.Length < 10)
                {
                    foreach (TextBox textbox in FlowLayoutPanel1.Controls)
                    {
                        if (!ReferenceEquals(textbox, InitialTB))
                        {
                            FlowLayoutPanel1.Controls.Remove(textbox);
                        }
                    }
                    InitialTB.Text = "";
                    return;
                }
                var TB = new TextBox();
                TB = InitialTB;
                FlowLayoutPanel1.Controls.Clear();
                FlowLayoutPanel1.Controls.Add(TB);
                InitialTB.Text = "";
                int a = 3;
                foreach (var no in value.Split(','))
                {
                    no = no.Trim();
                    if (string.IsNullOrEmpty(InitialTB.Text))
                    {
                        InitialTB.Text = no;
                        continue;
                    }
                    var DynamicTB = new TextBox()
                    {
                        Font = InitialTB.Font,
                        Size = InitialTB.Size,
                        TabIndex = a
                    };
                    DynamicTB.KeyDown += (_, __) => this.TB_KeyDownEvent();
                    DynamicTB.Leave += (_, __) => this.TB_Leave();
                    DynamicTB.GotFocus += (_, __) => this.TB_GotFocus();
                    FlowLayoutPanel1.Controls.Add(DynamicTB);
                    DynamicTB.Text = no;
                    a += 1;
                }

            }
        }

        public event UP_keyPressedEventHandler UP_keyPressed;

        public delegate void UP_keyPressedEventHandler();
        public event DOWN_keyPressedEventHandler DOWN_keyPressed;

        public delegate void DOWN_keyPressedEventHandler();
        public event LeftTextBoxEventHandler LeftTextBox;

        public delegate void LeftTextBoxEventHandler();

        public PhoneNoTag()
        {
            InitializeComponent();
        }

        private void TB_KeyDownEvent(TextBox sender, KeyEventArgs e)
        {

            if (sender.TextLength == 0 | sender.TextLength == 10)
            {
                if (e.KeyCode == Keys.Up)
                {
                    InitialTB.Select();
                    UP_keyPressed?.Invoke();
                    return;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    InitialTB.Select();
                    DOWN_keyPressed?.Invoke();
                    return;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (FlowLayoutPanel1.Controls.Count >= 4)
                {
                    DOWN_keyPressed?.Invoke();
                }
                if (sender.TextLength != 10)
                {
                    MessageBox.Show("PhNo Must Be 10 Digit Long This No Is " + sender.TextLength + " Digit Long.", "Typing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sender.Text = "";
                    sender.Select();
                    return;
                }
                else
                {
                    var DynamicTB = new TextBox()
                    {
                        Font = InitialTB.Font,
                        Size = InitialTB.Size,
                        WordWrap = false
                    };
                    DynamicTB.KeyDown += (_, __) => this.TB_KeyDownEvent();
                    DynamicTB.Leave += (_, __) => this.TB_Leave();
                    DynamicTB.GotFocus += (_, __) => this.TB_GotFocus();
                    FlowLayoutPanel1.Controls.Add(DynamicTB);
                    DynamicTB.Select();
                }
            }

        }

        private void TB_Leave(TextBox sender, EventArgs e)
        {
            LeftTextBox?.Invoke();

            if (sender.TextLength > 0 && sender.TextLength != 10)
            {
                MessageBox.Show("PhNo Must Be 10 Digit Long This No Is " + sender.TextLength + " Digit Long.", "Typing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sender.Text = "";
                sender.Select();
                return;
            }

            sender.BackColor = Color.White;

            if (sender.TextLength == 0 & !ReferenceEquals(sender, ActiveControl))
            {

                if (ReferenceEquals(sender, InitialTB))
                {
                    TagData = TagData; // Gets Data From The Get Method And Then Sets It
                }
                else
                {
                    FlowLayoutPanel1.Controls.Remove(sender);
                    if (FlowLayoutPanel1.Controls.Count >= 4)
                    {
                        return;
                    }
                }

            }

        }

        private void TB_GotFocus(TextBox sender, EventArgs e)
        {
            foreach (TextBox TB in FlowLayoutPanel1.Controls)
                TB.BackColor = Color.White;
            ActiveControl.BackColor = Color.Goldenrod;
        }

        public object CheckRegistration()
        {
            var Registered_Numbers = new List<string>();

            FlowLayoutPanel1.Invoke(new Action(async () => { foreach (TextBox TB in FlowLayoutPanel1.Controls) { string status = await ProjectModule.Isregistered(TB.Text.Trim()); if (status == "true") { Registered_Numbers.Add(TB.Text.Trim()); TB.ForeColor = Color.Green; } else if (status == "false") { TB.ForeColor = Color.Maroon; } else { return; } } }));
            return Registered_Numbers;
        }

    }
}
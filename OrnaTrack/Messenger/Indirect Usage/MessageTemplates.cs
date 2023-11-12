using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class MessageTemplates
    {

        private List<string> MessagesList { get; set; }

        public MessageTemplates()
        {
            InitializeComponent();
        }

        private void MessageTemplates_Load(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select SavedMessages From Message_Data Where id=1");

            while (dr.Read())
            {
                try
                {
                    string SavedMessages = "";
                    SavedMessages = Conversions.ToString(dr["SavedMessages"]);

                    if (SavedMessages.Length < 1)
                        return;

                    MessagesList = SavedMessages.Split('|').ToList();

                    ShowMessages();
                }

                catch (Exception ex)
                {

                }
            }

        }

        private void ShowMessages()
        {
            FlowLayoutPanel1.Controls.Clear();

            int MsgIndex = 1;

            foreach (var i in MessagesList)
            {

                if (i.Length < 1)
                    continue;

                var _lbl = new Label()
                {
                    Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Visible = true,
                    AutoEllipsis = true,
                    ForeColor = Color.Green,
                    BackColor = Color.FromArgb(36, 60, 60),
                    Margin = new Padding(5),
                    Tag = MsgIndex
                };

                _lbl.Text = $"{MsgIndex}-" + i;

                _lbl.MaximumSize = (Size)new Point(500, 0);
                _lbl.AutoSize = true;

                FlowLayoutPanel1.Controls.Add(_lbl);

                _lbl.Click += (Sender, e) =>
                    {

                        EditBT.Click -= Edit_Click;
                        DeleteBT.Click -= DeleteBT_Click;
                        CancelEditBT.Click -= CancelBT_Click;

                        if (SelectMsgBT.Enabled)
                        {
                            Label _selectedLabel = (Label)FlowLayoutPanel1.Controls.Item(EditBT.Tag);
                            _selectedLabel.BackColor = Color.FromArgb(36, 60, 60);
                        }

                        MessageTB.Text = MessagesList[Conversions.ToInteger(Operators.SubtractObject(_lbl.Tag, 1))];

                        _lbl.BackColor = SystemColors.ActiveCaption;

                        AddMsgBT.Visible = false;
                        EditBT.Visible = true;
                        DeleteBT.Visible = true;
                        CancelEditBT.Visible = true;
                        SelectMsgBT.Enabled = true;
                        EditBT.Tag = Operators.SubtractObject(_lbl.Tag, 1);

                        EditBT.Click += Edit_Click;
                        DeleteBT.Click += DeleteBT_Click;
                        CancelEditBT.Click += CancelBT_Click;

                    };

                MsgIndex += 1;

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (MessageTB.TextLength < 1)
            {
                return;
            }

            if (HandsCheckBox.Checked)
                MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}";

            MessagesList[Conversions.ToInteger(EditBT.Tag)] = MessageTB.Text;
            MessageTB.Text = "";
            ShowMessages();
            ProjectModule.SqlCommand($"Update Message_Data set SavedMessages='{string.Join("|", MessagesList)}' Where id=1");

            AddMsgBT.Visible = true;
            EditBT.Visible = false;
            DeleteBT.Visible = false;
            CancelEditBT.Visible = false;
            SelectMsgBT.Enabled = false;
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Message Template.", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            MessagesList.RemoveAt(Conversions.ToInteger(EditBT.Tag));
            ProjectModule.SqlCommand($"Update Message_Data set SavedMessages='{string.Join("|", MessagesList)}' Where id=1");
            ShowMessages();
            MessageTB.Text = "";
            MessageTB.Select();
            AddMsgBT.Enabled = true;
            EditBT.Visible = false;
            DeleteBT.Visible = false;
            CancelEditBT.Visible = false;

        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Label _lbl = (Label)FlowLayoutPanel1.Controls.Item(EditBT.Tag);
            _lbl.BackColor = Color.FromArgb(36, 60, 60);
            SelectMsgBT.Enabled = false;
            MessageTB.Text = "";
            MessageTB.ZoomFactor = 0.6d;
            MessageTB.Select();

            AddMsgBT.Visible = true;
            EditBT.Visible = false;
            DeleteBT.Visible = false;
            CancelEditBT.Visible = false;
            SelectMsgBT.Enabled = false;
        }

        private void AddMsgBT_Click(object sender, EventArgs e)
        {
            if (MessageTB.TextLength < 1)
                return;

            if (HandsCheckBox.Checked)
                MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}";

            MessagesList.Add(MessageTB.Text);

            ShowMessages();

            ProjectModule.SqlCommand($"Update Message_Data set SavedMessages='{string.Join("|", MessagesList)}' Where id=1");

            MessageTB.Text = "";
            MessageTB.Select();

        }

        private void MessageTB_TextChanged(object sender, EventArgs e)
        {
            if (MessageTB.Text.Contains("|"))
            {
                MessageBox.Show("Character |(Pipe) Is Not Allowed In Message Templates. Use Other Symbols Instead.", "Used Non Accessible Character.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageTB.Text = MessageTB.Text.Replace("|", "");
            }
            else if (MessageTB.Text.Contains("'"))
            {
                MessageBox.Show("Character '(Apostrophe) Is Not Allowed In Message Templates. Use Other Symbols Like Double Apostrophe Instead->(\").", "Used Non Accessible Character.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageTB.Text = MessageTB.Text.Replace("'", "");
            }

            HandsCheckBox.Checked = MessageTB.Text.Contains("{hands}");

            MessageTB.ZoomFactor = 0.6d;
        }

        public event MessageSelectedEventHandler MessageSelected;

        public delegate void MessageSelectedEventHandler(string Msg);

        private void SelectMsgBT_Click(object sender, EventArgs e)
        {
            MessageSelected?.Invoke(MessagesList[Conversions.ToInteger(EditBT.Tag)]);
        }

        private void HandsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HandsCheckBox.Checked && MessageTB.Text.Replace(" ", "").Length > 1)
            {
                MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}";
            }
            else if (!HandsCheckBox.Checked && MessageTB.Text.Replace(" ", "").Length > 1)
            {
                MessageTB.Text = MessageTB.Text.Replace("{hands}", "");
            }
        }
    }
}
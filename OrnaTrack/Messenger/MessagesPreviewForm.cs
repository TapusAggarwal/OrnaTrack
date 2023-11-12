using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class MessagesPreviewForm
    {

        public List<Tuple<string, Kitty>> MessagesToSend { get; set; } = new List<Tuple<string, Kitty>>();
        public List<string> ImagePaths { get; set; } = new List<string>();

        public List<string> SentList { get; set; } = new List<string>();
        public List<string> FailedList { get; set; } = new List<string>();
        public List<string> UnRegisteredList { get; set; } = new List<string>();
        public List<string> RemovedList { get; set; } = new List<string>();

        private string MessageText { get; set; }
        private int MessagesPerPage { get; set; } = 9;
        public int CurrentMsgSetStartIndex { get; set; } = 0;

        public MessagesPreviewForm()
        {


            UpdateTimer = new Timer() { Interval = 500, Enabled = false };
            InitializeComponent();
        }


        #region Load Data
        private List<string> LoadList(string listName)
        {
            var result = new List<string>();

            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("SELECT " + listName + " FROM Message_Data WHERE id = 1");
            while (dr.Read())
            {
                string[] values = dr[0].ToString().Split(',');
                foreach (var value in values)
                {
                    if (value.Length > 10)
                        result.Add(value);
                }
            }

            dr.Close();

            return result;
        }

        private void LoadData()
        {

            SentList = LoadList("Sent");
            FailedList = LoadList("Failed");
            UnRegisteredList = LoadList("UnRegistered");
            RemovedList = LoadList("Removed");


            foreach (var i in LoadList("Initial")) // i is in the form -> PhNo_KittyNo
                MessagesToSend.Add(new Tuple<string, Kitty>(i.Split('_')[0], new Kitty(Conversions.ToInteger(i.Split('_')[1]), true, true)));

            OleDbDataReader _dr = (OleDbDataReader)ProjectModule.DataReader("Select MessageText,ImagePaths From Message_Data where id=1");
            while (_dr.Read())
            {
                MessageText = _dr[0]?.ToString();
                ImagePaths = _dr[1]?.ToString().Split(',').ToList();
            }
            _dr.Close();

            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select CurrentSetStartIndex,MessagesPerPage From Message_Data where id=1");
            while (dr.Read())
            {
                if (!(dr[0] is DBNull) && Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(dr[0], 0, false)))
                {
                    CurrentMsgSetStartIndex = Conversions.ToInteger(dr[0]);
                }
                if (!(dr[1] is DBNull) && Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(dr[1], 0, false)))
                {
                    MessagesPerPageTB.Text = dr[1].ToString();
                }
            }
            dr.Close();

        }
        #endregion

        private void PreviewForm_Load(object sender, EventArgs e)
        {

            KeyPreview = true;

            LoadData();
            // OneTimeControlTB.Text will be Updated In The Above Function Which Will Trigger The EventHandler To Call PopulatePreviewcontrolWithCurrentSettings()
            if (ImagePaths.Count > 0)
                ImagesPreview.Visible = true;

        }

        #region Routines For Preview-Msg Control

        // Cross Button Clicked On The Preview Control
        private void Close_Clicked(MessagePreviewControl sender)
        {
            if (sender.Status != "NotSent")
            {
                MessageBox.Show("Can't Disable After Message Is Sent.", "Illegal Selection");
                return;
            }
            foreach (var phno in sender.CurrentKitty.Owner.GetPhNo())
            {
                string id = $"{phno}_{sender.CurrentKitty.KittyUID}";

                var correspondingControl = FlowLayoutPanel1.Controls.OfType<MessagePreviewControl>().Where(c => (c.Name ?? "") == (id ?? "")).ElementAtOrDefault(0);

                if (!RemovedList.Remove(id))
                {
                    RemovedList.Add(id);
                    if (correspondingControl is not null)
                        correspondingControl.Enabled = false;
                }
                else if (correspondingControl is not null)
                    correspondingControl.Enabled = true;
                FailedList.Remove(id);
                UnRegisteredList.Remove(id);
            }

            ProjectModule.SqlCommand($"Update Message_Data set Removed='{string.Join(",", RemovedList)}' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set Failed='{string.Join(",", FailedList)}' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set Sent='{string.Join(",", SentList)}' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set UnRegistered='{string.Join(",", UnRegisteredList)}' where id=1");

            UpdateStatuses();
        }

        private async void PopulatePreviewcontrolWithCurrentSettings()
        {

            NextButton.Enabled = false;
            BackButton.Enabled = false;
            MessagesPerPageTB.Enabled = false;

            List<Tuple<string, Kitty>> KittiesToShow;

            // Check if the current index plus messages per page is coming out to be greater than the total number of messages in the list
            if (CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count)
            {
                PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{MessagesToSend.Count}/{MessagesToSend.Count}";
                // Get a list of the remaining messages in the list starting from the current index
                KittiesToShow = MessagesToSend.Skip(CurrentMsgSetStartIndex).ToList();
            }
            else
            {
                PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{CurrentMsgSetStartIndex + MessagesPerPage}/{MessagesToSend.Count}";
                // Get a list of messages per page starting from the current index
                KittiesToShow = MessagesToSend.Skip(CurrentMsgSetStartIndex).Take(MessagesPerPage).ToList();
            }

            var T_controls = TaskOfPreviewControls(KittiesToShow);

            if (T_controls is null | T_controls.Count == 0)
                return;

            FlowLayoutPanel1.Controls.Clear();
            MessagePreviewControl[] _controls = await Task.WhenAll(T_controls);

            FlowLayoutPanel1.Invoke(new Action(() =>
                {
                    FlowLayoutPanel1.Controls.Clear();
                    FlowLayoutPanel1.Controls.AddRange(_controls);
                }));


            UpdateStatuses();

            NextButton.Enabled = true;
            BackButton.Enabled = true;
            MessagesPerPageTB.Enabled = true;

        }

        private List<Task<MessagePreviewControl>> TaskOfPreviewControls(List<Tuple<string, Kitty>> _kittiesToShow)
        {
            var _controlsList = new List<Task<MessagePreviewControl>>();

            foreach (var i in _kittiesToShow)
            {
                _controlsList.Add(Task.Run(() =>
                    {
                        string message = ProjectModule.ReplaceTemplateWithDetails(i.Item2, MessageText);

                        MessagePreviewControl x = null;
                        FlowLayoutPanel1.Invoke(new Action(() =>
{
                            MessagePreviewControl @init = new MessagePreviewControl();
                            x = (@init.PhNo = i.Item1, @init.PreviewText = message, @init.CurrentKitty = i.Item2, @init.Name = $"{@init.PhNo}_{@init.CurrentKitty.KittyUID}", @init.SrNo = MessagesToSend.IndexOf(i) + 1, @init.Status = Conversions.ToString(TryParseStatus(@init.PhNo, @init.CurrentKitty.KittyUID)), @init).@init;

                            if (RemovedList.Contains(x.Name))
                                x.Enabled = false;

                            x.DetailsButton_Clicked += (sender) =>
{
                                var Fm = new PreviewKitty() { _kitty = sender.CurrentKitty };
                                Fm.ShowDialog();
                                PopulatePreviewcontrolWithCurrentSettings();
                            };
                            x.CloseBT_Clicked += Close_Clicked;
                            x.SendBT_Clicked += async () =>
{
                                x.Status = "Sending";
                                string id = $"{x.PhNo}_{x.CurrentKitty.KittyUID}";
                                FailedList.Remove(id);
                                UnRegisteredList.Remove(id);
                                string status = "";
                                var MessageList = Strings.Split(message, $"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}").ToList();
                                var _resp = await ProjectModule.UniversalWhatsappMessageBundle(x.PhNo, MessageList, ImagePaths);
                                if (_resp is not null)
                                    status = _resp.SelectToken("result").ToString();
                                UpdateList(x.PhNo, x.CurrentKitty.KittyUID, status);
                                x.Status = status;
                                UpdateStatuses();
                            };
                            x.TestMessageClicked += async sender =>
{
                                string phno = Interaction.InputBox("Enter Phone Number For Test Messsage.");
                                var MessageList = Strings.Split(message, $"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}").ToList();
                                var _resp = await ProjectModule.UniversalWhatsappMessageBundle(x.PhNo, MessageList, ImagePaths);
                                MessageBox.Show(_resp.ToString());
                            };
                        }));

                        return x;
                    }));

            }

            return _controlsList;
        }


        private void UpdateList(string phNo, int kittyUID, string status)
        {
            string id = $"{phNo}_{kittyUID}";
            switch (status ?? "")
            {
                case "fail":
                    {
                        FailedList.Add(id);
                        FailedList = FailedList.Distinct().ToList();
                        ProjectModule.SqlCommand($"Update Message_Data set Failed='{string.Join(",", FailedList)}' where id=1");
                        break;
                    }
                case "pass":
                    {
                        SentList.Add(id);
                        SentList = SentList.Distinct().ToList();
                        ProjectModule.SqlCommand($"Update Message_Data set Sent='{string.Join(",", SentList)}' where id=1");
                        break;
                    }

                default:
                    {
                        UnRegisteredList.Add(id);
                        UnRegisteredList = UnRegisteredList.Distinct().ToList();
                        ProjectModule.SqlCommand($"Update Message_Data set UnRegistered='{string.Join(",", UnRegisteredList)}' where id=1");
                        break;
                    }
            }
        }

        private object TryParseStatus(string phno, int kittyUID)
        {
            string id = $"{phno}_{kittyUID}";
            if (SentList.Contains(id))
                return "pass";
            if (FailedList.Contains(id))
                return "fail";
            if (UnRegisteredList.Contains(id))
                return "UnRegistered";
            return "NotSent";
        }

        private Timer UpdateTimer; // Delay of 500m

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (CurrentMsgSetStartIndex - MessagesPerPage >= 0)
                CurrentMsgSetStartIndex -= MessagesPerPage;
            ProjectModule.SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1");


            if (CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count)
            {
                PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{MessagesToSend.Count}/{MessagesToSend.Count}";
            }
            else
            {
                PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{CurrentMsgSetStartIndex + MessagesPerPage}/{MessagesToSend.Count}";
            }

            UpdateTimer.Stop();
            UpdateTimer.Start();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurrentMsgSetStartIndex + MessagesPerPage < MessagesToSend.Count)
                CurrentMsgSetStartIndex += MessagesPerPage;
            ProjectModule.SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1");
            if (CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count)
            {
                PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{MessagesToSend.Count}/{MessagesToSend.Count}";
            }
            else
            {
                PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{CurrentMsgSetStartIndex + MessagesPerPage}/{MessagesToSend.Count}";
            }

            UpdateTimer.Stop();
            UpdateTimer.Start();

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            PopulatePreviewcontrolWithCurrentSettings();
        }

        #endregion


        #region Directly Used Form EventHandlers

        private async void SendButton_Click(object sender, EventArgs e)
        {
            Panel1.Enabled = false;
            List<Tuple<string, Kitty>> _messagesToSend;

            if (AllCB.Checked)
            {
                _messagesToSend = MessagesToSend;
            }
            else if (CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count)
            {
                _messagesToSend = MessagesToSend.Skip(CurrentMsgSetStartIndex).ToList();
            }
            else
            {
                _messagesToSend = MessagesToSend.Skip(CurrentMsgSetStartIndex).Take(MessagesPerPage).ToList();
            }

            foreach (var msg in _messagesToSend)
            {
                if (msg.Item1.Length < 9)
                    continue;
                string id = $"{msg.Item1}_{msg.Item2.KittyUID}";
                if (RemovedList.Contains(id))
                    continue;
                if (SentList.Contains(id))
                    continue;
                string message = ProjectModule.ReplaceTemplateWithDetails(msg.Item2, MessageText);
                var MessageList = Strings.Split(message, $"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}").ToList();

                Invoke(new Action(() =>
                    {
                        UpdateStatuses();
                        var correspondingControl = FlowLayoutPanel1.Controls.OfType<MessagePreviewControl>().Where(c => (c.Name ?? "") == (id ?? "")).ElementAtOrDefault(0);
                        if (correspondingControl is not null)
                        {
                            correspondingControl.Status = "Sending";
                        }
                    }));

                var _resp = await ProjectModule.UniversalWhatsappMessageBundle(msg.Item1, MessageList, ImagePaths);

                if (_resp is null)
                {
                    MessageBox.Show("An Error Occured While Sending Messages: Server Sent No Response Back. No More Further Messages Will Be Sent. Error Code:ERR01", "Unexpected Error", MessageBoxButtons.OK);
                    return;
                }

                string status = _resp.SelectToken("result").ToString();

                UpdateList(msg.Item1, msg.Item2.KittyUID, status);
                Invoke(new Action(() =>
                    {
                        UpdateStatuses();
                        var correspondingControl = FlowLayoutPanel1.Controls.OfType<MessagePreviewControl>().Where(c => (c.Name ?? "") == (id ?? "")).ElementAtOrDefault(0);
                        if (correspondingControl is not null)
                        {
                            correspondingControl.Status = status;
                        }
                    }));

            }

            Panel1.Enabled = true;
        }


        private void OneTimeControlTB_TextChanged(object sender, EventArgs e)
        {
            int x = -1;
            try
            {
                x = Conversions.ToInteger(MessagesPerPageTB.Text);
            }
            catch (Exception ex)
            {
            }

            if (x > 0)
            {
                MessagesPerPage = x;
                CurrentMsgSetStartIndex = (int)Math.Round(MessagesPerPage * Conversion.Int(CurrentMsgSetStartIndex / (double)MessagesPerPage));
                ProjectModule.SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1");
                PopulatePreviewcontrolWithCurrentSettings();
            }
            ProjectModule.SqlCommand($"Update Message_Data set MessagesPerPage={x} where id=1");
        }


        private void RetryButton_Click(object sender, EventArgs e)
        {
            if (SendButton.Enabled != false)
            {
                MessageBox.Show("First Send Message To All Selected Kitties. To Be Able To Retry.", "Illegal Selection");
                return;
            }
            if (AllCB.Checked)
            {
                UnRegisteredList.Clear();
                FailedList.Clear();
                UpdateStatuses();
                SendButton.PerformClick();
            }
            else
            {

            }
        }

        private void AllCB_CheckedChanged(object sender, EventArgs e)
        {
            if (MessagesToSend.Count == 0)
                return;
            if (AllCB.Checked == false & CurrentCB.Checked == false)
            {
                AllCB.Checked = true;
            }
            UpdateStatuses();
            CurrentCB.Checked = false;
        }

        private void CurrentCB_CheckedChanged(object sender, EventArgs e)
        {
            if (MessagesToSend.Count == 0)
                return;
            if (AllCB.Checked == false & CurrentCB.Checked == false)
            {
                CurrentCB.Checked = true;
            }
            UpdateStatuses();
            AllCB.Checked = false;
        }

        private void OneTimeControlTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.KeyCode == Keys.Enter)
            {
                try
                {
                    string x = Interaction.InputBox("Enter No. To Jump Upon", "?");
                    CurrentMsgSetStartIndex = (int)Math.Round(MessagesPerPage * Conversion.Int(Conversions.ToDouble(x) / MessagesPerPage));
                    ProjectModule.SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1");
                    PopulatePreviewcontrolWithCurrentSettings();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void PreviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                NextButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Left)
            {
                BackButton.PerformClick();
            }
        }

        private void ImagesPreview_Click(object sender, EventArgs e)
        {
            var Fm = new Form();

        }

        #endregion

        public void ClearPreviousFields()
        {
            ProjectModule.SqlCommand($"Update Message_Data set Removed='' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set Failed='' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set Sent='' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set UnRegistered='' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set CurrentSetStartIndex='0' where id=1");
        }


        private void UpdateStatuses()
        {
            SentText.Text = $"{SentList.Count}/{MessagesToSend.Count - RemovedList.Count}";

            if (UnRegisteredList.Count > 0)
            {
                UnRegisteredLB.Visible = true;
                UnRegisteredText.Visible = true;
                UnRegisteredText.Text = UnRegisteredList.Count.ToString();
            }
            else
            {
                UnRegisteredLB.Visible = false;
                UnRegisteredText.Visible = false;
            }

            if (FailedList.Count > 0)
            {
                FailedLB.Visible = true;
                FailedText.Visible = true;
                FailedText.Text = FailedList.Count.ToString();
            }
            else
            {
                FailedLB.Visible = false;
                FailedText.Visible = false;
            }

            if (AllCB.Checked)
            {
                if (SentList.Count + UnRegisteredList.Count + FailedList.Count + RemovedList.Count == MessagesToSend.Count)
                {
                    SendButton.Enabled = false;
                }
                else
                {
                    SendButton.Enabled = true;
                }
            }
            else
            {
                List<Tuple<string, Kitty>> _currentMessages;

                if (CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count)
                {
                    _currentMessages = MessagesToSend.Skip(CurrentMsgSetStartIndex).ToList();
                }
                else
                {
                    _currentMessages = MessagesToSend.Skip(CurrentMsgSetStartIndex).Take(MessagesPerPage).ToList();
                }

                bool enbl = false;

                foreach (var msg in _currentMessages)
                {
                    string id = $"{msg.Item1}_{msg.Item2.KittyUID}";
                    if (RemovedList.Contains(id))
                        continue;
                    if (SentList.Contains(id))
                        continue;
                    if (UnRegisteredList.Contains(id))
                        continue;
                    if (FailedList.Contains(id))
                        continue;

                    enbl = true;
                    break;
                }

                if (_currentMessages.Count > 0)
                {
                    if (enbl)
                    {
                        SendButton.Enabled = true;
                    }
                    else
                    {
                        SendButton.Enabled = false;
                    }
                }
            }

        }

    }
}
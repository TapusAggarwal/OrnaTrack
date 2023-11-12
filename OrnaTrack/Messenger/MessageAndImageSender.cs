using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class MessageAndImageSender
    {

        public List<Kitty> SelectedKitties { get; set; } = new List<Kitty>();
        private readonly List<string> MessagesList = new List<string>();

        public struct Templates
        {
            public const string Greeting = "{Greet}";
            public const string CoustName = "{CoustName}";
            public const string CoustPhNo = "{CoustPhNo}";
            public const string KittyType = "{KittyType}";
            public const string KittyNo = "{KittyNo}";
            public const string InstalmentsCompleted = "{InstCompl}";
            public const string PeriodIntalmentsCompleted = "{InstCompMonth}";
            public const string GivenAmount = "{GivenAmt}";
            public const string InstalmentsPending = "{InstPend}";
            public const string PeriodInstalmentsPending = "{InstPendMonth}";
            public const string PendingAmount = "{PendingAmt}";
        }

        public MessageAndImageSender()
        {
            InitializeComponent();
        }

        #region Direct Method Events
        private void CoustNameButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.CoustName;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void CoustNameButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show("Add Coustmer's Name To The Message" + Environment.NewLine + "Ex: Tapus Aggarwal", CoustNameButton, 3000);
            }
        }

        private void PhNo_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.CoustPhNo;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void PhNoButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show("Add Coustmer's PhNo To The Message" + Environment.NewLine + "Ex: 9882960863,9816057863", PhNoButton, 3000);
            }
        }

        private void KittyTypeButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.KittyType;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void KittyTypeButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show("Adds KittyType To The Message" + Environment.NewLine + "Ex: ₹2,000", KittyTypeButton, 3000);
            }
        }

        private void KittyNoButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.KittyNo;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void KittyNoButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show("Adds KittyNo To The Message" + Environment.NewLine + "Ex: 984", KittyNoButton, 3000);
            }
        }

        private void InstCompletedButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.InstalmentsCompleted;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void InstCompletedButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show("Adds Till Date Instalments Completed To The Message" + Environment.NewLine + "Ex: 3", InstCompletedButton, 3000);
            }
        }

        private void CompMonthButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.PeriodIntalmentsCompleted;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void CompMonthButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show($"Adds Till Date Instalments Completed As Months To The Message{Environment.NewLine}Ex1: Dec(2020){Environment.NewLine}Ex2: Dec(2020),Jan(2021){Environment.NewLine}Ex3: Dec(2020)-Feb(2021)", InstCompletedButton, 4000);
            }
        }

        private void GivenAmountButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.GivenAmount;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void GivenAmountButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show($"Adds Till Date Given Amount To The Message{Environment.NewLine}Ex: ₹4,000", GivenAmountButton, 3000);
            }
        }

        private void PendingInstButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.InstalmentsPending;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void PendingInstButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show("Adds Total Instalments Pending To The Message" + Environment.NewLine + "Ex: 2", InstCompletedButton, 3000);
            }
        }

        private void PendingMonthButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.PeriodInstalmentsPending;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void PendingMonthButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show($"Adds Total Instalments Pending As Months To The Message{Environment.NewLine}Ex1: Dec(2020){Environment.NewLine}Ex2: Dec(2020),Jan(2021){Environment.NewLine}Ex3: Dec(2020)-Feb(2021)", PendingMonthButton, 4000);
            }
        }

        private void PendingAmountButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.PendingAmount;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void PendingAmountButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show($"Adds Total Pending Amount To The Message{Environment.NewLine}Ex: ₹3,000", GivenAmountButton, 3000);
            }
        }

        private void GreetButton_Click(object sender, EventArgs e)
        {
            MessageTB.SelectedText = Templates.Greeting;
            MessageTB.Select();
            SendKeys.Send("{End}");
        }

        private void GreetButton_MouseHover(object sender, EventArgs e)
        {
            if (ToolTipChB.Checked)
            {
                ToolTip1.Show($"Adds A Greeting To Template.{Environment.NewLine}Ex: {ProjectModule.Greet()}", GreetButton, 3000);
            }
        }
        #endregion

        private void MessageSender_Load(object sender, EventArgs e)
        {
            if (TopLevel)
            {
                FormBorderStyle = (FormBorderStyle)BorderStyle.FixedSingle;
            }
            else if (SelectedKitties.Count == 1)
            {
                PreviewBT.Visible = false;
                SendBT.Visible = true;
            }
            ProjectModule.InitaliseConnection();
            try
            {
                ProjectModule.myconnection.Open();
            }
            catch
            {
            }

            ImagePanel.Visible = false;
            Size = (Size)new Point(Width - ImagePanel.Width + 7, Height);

            MessageTB.Text = @"{Greet}
Dear, {CoustName} Ji
Have A Nice Day Ahead.";

        }

        private void ToolTipChB_CheckedChanged(object sender, EventArgs e)
        {
            if (!ToolTipChB.Checked)
            {
                ToolTip1.Hide(this);
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
                    Tag = MsgIndex,
                    Text = $"{MsgIndex}-" + i,
                    MaximumSize = (Size)new Point(500, 0),
                    AutoSize = true
                };

                FlowLayoutPanel1.Controls.Add(_lbl);

                _lbl.Click += (Sender, e) =>
                    {

                        EditBT.Click -= Edit_Click;
                        DeleteBT.Click -= DeleteBT_Click;
                        CancelEditBT.Click -= CancelBT_Click;

                        if (AddMsgBT.Enabled == false)
                        {
                            Label _selectedLabel = (Label)FlowLayoutPanel1.Controls.Item(EditBT.Tag);
                            _selectedLabel.BackColor = Color.FromArgb(36, 60, 60);
                        }

                        MessageTB.Text = MessagesList[Conversions.ToInteger(Operators.SubtractObject(_lbl.Tag, 1))];
                        MessageTB.ZoomFactor = 0.6d;


                        _lbl.BackColor = SystemColors.ActiveCaption;

                        EditBT.Visible = true;
                        DeleteBT.Visible = true;
                        CancelEditBT.Visible = true;
                        AddMsgBT.Enabled = false;
                        EditBT.Tag = Operators.SubtractObject(_lbl.Tag, 1);

                        EditBT.Click += Edit_Click;
                        DeleteBT.Click += DeleteBT_Click;
                        CancelEditBT.Click += CancelBT_Click;

                    };

                MsgIndex += 1;

            }
        }

        private void AddMsgBT_Click(object sender, EventArgs e)
        {
            if (MessageTB.TextLength < 1)
                return;

            if (HandsCheckBox.Checked)
                MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}";

            if (SelectedKitties.Count == 1)
            {
                string msgString = "";
                try
                {
                    msgString = ProjectModule.ReplaceTemplateWithDetails(SelectedKitties.First(), MessageTB.Text);
                }
                catch (Exception ex)
                {
                }
                if (!string.IsNullOrEmpty(msgString))
                {
                    MessagesList.Add(msgString);
                }
                else
                {
                    MessagesList.Add(MessageTB.Text);
                }
            }
            else
            {
                MessagesList.Add(MessageTB.Text);
            }

            ShowMessages();

            MessageTB.Text = "";
            MessageTB.Select();
        }

        // Preview Button

        private void PreviewBT_Click(object sender, EventArgs e)
        {
            var imgPaths = GetPathForImages();
            if (MessagesList.Count == 0 && imgPaths.Count == 0)
                return;

            Cursor.Current = Cursors.WaitCursor;

            string MessageText = string.Join($"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}", MessagesList);
            SelectedKitties = SelectedKitties.OrderByDescending(k => k.KittyType).ThenBy(k => k.KittyNo).ToList();



            var MessagesToSend = new Dictionary<string, List<Kitty>>();
            var _trackDict = new Dictionary<string, List<string>>();

            foreach (var _kitty in SelectedKitties)
            {
                foreach (var phno in _kitty.Owner.GetPhNo())
                {
                    if (MessagesToSend.ContainsKey(phno))
                    {
                        string _convMsg = ProjectModule.ReplaceTemplateWithDetails(_kitty, MessageText);
                        if (_trackDict[phno].Contains(_convMsg))
                        {
                            continue;
                        }
                        MessagesToSend[phno].Add(_kitty);
                    }
                    else
                    {
                        MessagesToSend.Add(phno, new List<Kitty>(new[] { _kitty }));
                        string _convMsg = ProjectModule.ReplaceTemplateWithDetails(_kitty, MessageText);
                        _trackDict.Add(phno, new List<string>(new[] { _convMsg }));
                    }
                }
            }

            var Initial_ids = new List<string>();

            foreach (var i in MessagesToSend)
            {
                foreach (var _kitty in i.Value)
                    Initial_ids.Add($"{i.Key}_{_kitty.KittyUID}");
            }

            string Initial = string.Join(",", Initial_ids);
            ProjectModule.SqlCommand($"Update Message_Data set MessageText='{MessageText}' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set Initial='{Initial}' where id=1");
            ProjectModule.SqlCommand($"Update Message_Data set ImagePaths='{string.Join(",", imgPaths)}' where id=1");

            Cursor.Current = Cursors.Default;

            using (var Fm = new MessagesPreviewForm())
            {

                Fm.ClearPreviousFields();
                Fm.ShowDialog();
            }
        }

        private List<string> GetPathForImages()
        {
            var imgPaths = new List<string>();

            foreach (var cntrl in ImagePanel.Controls)
            {
                try
                {
                    PictureBox imgBox = (PictureBox)cntrl;
                    imgPaths.Add(imgBox.ImageLocation);
                }
                catch (Exception ex)
                {
                }
            }

            return imgPaths;
        }

        private void AddImageBT_Click(object sender, EventArgs e)
        {
            try
            {

                var img = new OpenFileDialog() { Filter = "Choose Image(*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif" };

                if (img.ShowDialog() == DialogResult.OK)
                {
                    PictureBox @init = new PictureBox();
                    var ImageBox = (@init.Image = Image.FromFile(img.FileName), @init.ImageLocation = img.FileName, @init.Size = (Size)new Point(@init.Image.Width, @init.Image.Height), @init.SizeMode = PictureBoxSizeMode.Zoom, @init).@init;

                    if (ImageBox.Height > 300)
                    {
                        ImageBox.Height = 300;
                    }

                    if (ImageBox.Width > 280)
                    {
                        ImageBox.Width = 280;
                    }

                    ImagePanel.Controls.Add(ImageBox);

                    ImageBox.DoubleClick += () =>
                        {
                            ImagePanel.Controls.Remove(ImageBox);
                            if (ImagePanel.Controls.Count == 0)
                            {
                                ImageRemoveLB.Visible = false;
                                ImagePanel.Visible = false;
                                Size = (Size)new Point(Width - ImagePanel.Width + 7, Height);
                            }
                        };

                    if (ImagePanel.Visible == false)
                    {
                        ImageRemoveLB.Visible = true;
                        ImagePanel.Visible = true;
                        Size = (Size)new Point(Width + ImagePanel.Width - 7, Height);
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void SavedTemplatesBT_Click(object sender, EventArgs e)
        {
            var Fm = new MessageTemplates();

            Fm.MessageSelected += (Msg) =>
                {
                    MessageTB.Text = Msg;
                    Fm.Close();
                };

            Fm.Show();

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

        #region Handlers For MessageSender Control

        private void Edit_Click(object sender, EventArgs e)
        {
            if (MessageTB.TextLength < 1)
            {
                return;
            }

            if (HandsCheckBox.Checked)
                MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}";

            MessagesList[Conversions.ToInteger(EditBT.Tag)] = SelectedKitties.Count == 1 ? ProjectModule.ReplaceTemplateWithDetails(SelectedKitties.First(), MessageTB.Text) : MessageTB.Text;
            MessageTB.Text = "";
            ShowMessages();

            AddMsgBT.Enabled = true;
            EditBT.Visible = false;
            DeleteBT.Visible = false;
            CancelEditBT.Visible = false;
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Message Template.", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            MessagesList.RemoveAt(Conversions.ToInteger(EditBT.Tag));
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
            MessageTB.Text = "";
            MessageTB.Select();

            AddMsgBT.Enabled = true;
            EditBT.Visible = false;
            DeleteBT.Visible = false;
            CancelEditBT.Visible = false;
        }

        #endregion

        // Send Button
        private async void SendBT_Click(object sender, EventArgs e)
        {

            var _imagePath = GetPathForImages();

            if (_imagePath.Count == 0 & MessagesList.Count == 0)
                return;

            FlowLayoutPanel1.Controls.Clear();

            foreach (var _kitty in SelectedKitties)
            {

                foreach (var phno in _kitty.Owner.GetPhNo())
                {
                    if (MessagesList.Count > 0 | _imagePath.Count > 0)
                    {

                        var toSendMsgList = MessagesList.Select(f => ProjectModule.ReplaceTemplateWithDetails(_kitty, f)).ToList();

                        var response = await ProjectModule.UniversalWhatsappMessageBundle(phno, toSendMsgList, _imagePath);

                        string status = "fail";

                        if (response is not null)
                            status = response.SelectToken("result").ToString();

                        var _temp = new Label()
                        {
                            Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point),
                            Visible = true,
                            AutoSize = true
                        };

                        if (status == "pass")
                        {
                            _temp.ForeColor = Color.ForestGreen;
                            _temp.Text = $"+91{phno.Trim()}: Messages Sent";
                        }
                        else if (status == "fail")
                        {
                            _temp.ForeColor = Color.Firebrick;
                            _temp.Text = $"+91{phno.Trim()}: Messages Not Sent : Failed";
                        }
                        else
                        {
                            _temp.ForeColor = Color.Firebrick;
                            _temp.Text = $"+91{phno.Trim()}: Messages Not Sent : NotRegistered";
                        }
                        FlowLayoutPanel1.Controls.Add(_temp);

                    }
                }

            }
        }

        private void ImageFirstChB_CheckedChanged(object sender, EventArgs e)
        {
            ProjectModule.ImageFirst = ImageFirstChB.Checked;
        }
    }
}

// ReadOnly SelectedColour As Color = Color.Wheat
// ReadOnly UnselectedColour As Color = Color.Transparent
// ReadOnly OverColour As Color = Color.FromArgb(36, 30, 70)

// Private Sub BoldButton_Click_1() Handles BoldButton.Click
// If Not String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then

// If MessageTB.SelectionFont.Style = FontStyle.Bold Then
// MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
// FontStyle.Regular)
// Else
// 'MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size, FontStyle.Bold)
// 'PreviewTB.Select()
// MessageTB.Text = MakeBold(MessageTB.Text, MessageTB.SelectedText)
// 'PreviewTB.SelectionStart = MessageTB.SelectionStart
// 'PreviewTB.SelectionLength = MessageTB.SelectionLength
// 'PreviewTB.SelectedText = $"'{PreviewTB.SelectedText}'"
// End If
// End If

// MessageTB.Select()
// SendKeys.Send("{End}")
// End Sub

// Private Function MakeBold(allstring As String, toFind As String) As String
// Return allstring.Replace(toFind, [String].Format("'{0}'", toFind))
// End Function

// Private Sub ItalicButton_Click() Handles ItalicButton.Click
// If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
// If MessageTB.SelectionFont.Style = FontStyle.Italic Then
// MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
// FontStyle.Regular)
// Else
// MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size, FontStyle.Italic)
// End If
// MessageTB_SelectionChanged()
// MessageTB.Select()
// End Sub

// Private Sub UnderlineButton_Click() Handles UnderlinedButton.Click
// If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
// If MessageTB.SelectionFont.Style = FontStyle.Underline Then
// MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
// FontStyle.Regular)
// Else
// MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
// FontStyle.Underline)
// End If
// MessageTB_SelectionChanged()
// MessageTB.Select()
// End Sub

// Private Sub StrikeoutButton_Click() Handles StrikeoutButton.Click
// If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
// If MessageTB.SelectionFont.Style = FontStyle.Strikeout Then
// MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
// FontStyle.Regular)
// Else
// MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
// FontStyle.Strikeout)
// End If
// MessageTB_SelectionChanged()
// MessageTB.Select()
// End Sub

// Private Sub RedoButton_Click(sender As Object, e As EventArgs) Handles RedoButton.Click
// MessageTB.Redo()
// End Sub

// Private Sub UndoButton_Click(sender As Object, e As EventArgs) Handles UndoButton.Click
// MessageTB.Undo()
// End Sub

// Private Sub MessageTB_SelectionChanged() Handles MessageTB.SelectionChanged
// 'Updates the properties for the selected text
// Try
// If MessageTB.SelectionFont.Style = FontStyle.Bold Then
// BoldButton.BackColor = SelectedColour
// BoldButton.FlatAppearance.MouseOverBackColor = SelectedColour
// BoldButton.FlatAppearance.MouseDownBackColor = UnselectedColour
// Else
// BoldButton.FlatAppearance.MouseOverBackColor = OverColour
// BoldButton.FlatAppearance.MouseDownBackColor = SelectedColour
// BoldButton.BackColor = UnselectedColour
// End If
// If MessageTB.SelectionFont.Style = FontStyle.Italic Then
// ItalicButton.FlatAppearance.MouseOverBackColor = SelectedColour
// ItalicButton.FlatAppearance.MouseDownBackColor = UnselectedColour
// ItalicButton.BackColor = SelectedColour
// Else
// ItalicButton.FlatAppearance.MouseOverBackColor = OverColour
// ItalicButton.FlatAppearance.MouseDownBackColor = SelectedColour
// ItalicButton.BackColor = UnselectedColour
// End If
// If MessageTB.SelectionFont.Style = FontStyle.Underline Then
// UnderlinedButton.FlatAppearance.MouseOverBackColor = SelectedColour
// UnderlinedButton.FlatAppearance.MouseDownBackColor = UnselectedColour
// UnderlinedButton.BackColor = SelectedColour
// Else
// UnderlinedButton.FlatAppearance.MouseOverBackColor = OverColour
// UnderlinedButton.FlatAppearance.MouseDownBackColor = SelectedColour
// UnderlinedButton.BackColor = UnselectedColour
// End If
// If MessageTB.SelectionFont.Style = FontStyle.Strikeout Then
// StrikeoutButton.FlatAppearance.MouseOverBackColor = SelectedColour
// StrikeoutButton.FlatAppearance.MouseDownBackColor = UnselectedColour
// StrikeoutButton.BackColor = SelectedColour
// Else
// StrikeoutButton.FlatAppearance.MouseOverBackColor = OverColour
// StrikeoutButton.FlatAppearance.MouseDownBackColor = SelectedColour
// StrikeoutButton.BackColor = UnselectedColour
// End If
// Catch ex As Exception
// End Try
// End Sub

// Private Sub MessageTB_TextChanged(sender As Object, e As EventArgs) Handles MessageTB.TextChanged
// PreviewTB.Text = PreviewTB.Text.Replace("a", "")
// 'PreviewTB.Text = MessageTB.Text
// End Sub

// Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
// Dim dr As OleDb.OleDbDataReader = DataReader("Select SrNo From Coustmers_Data")

// End Sub

// Private Sub MessageSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

// End Sub

// Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

// End Sub


// {Greet}
// Dear, {CoustName}
// Your Kitty({KittyNo}-{KittyType})
// Is Due From - {InstPendMonth}
// Pending Amt. - {PendingAmt}
// Instalments Completed - {InstCompl}:{InstCompMonth}
// You Can Also Pay Online Account Info Below.
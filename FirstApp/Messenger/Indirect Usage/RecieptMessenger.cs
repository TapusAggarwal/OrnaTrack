using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class RecieptMessenger
    {
        private readonly Dictionary<string, List<string>> MessageImgs_Dict = new Dictionary<string, List<string>>();
        private readonly List<Bitmap> MessageImgs_List = new List<Bitmap>();

        public List<Kitty> ListOfKitties { get; set; } = new List<Kitty>();

        public RecieptMessenger()
        {
            InitializeComponent();
        }

        private async void MakeBills()
        {
            var Fm = new KittyRecievedReciept();
            Panel1.Controls.Add(Fm.Panel1);

            int SrNo = 1;
            foreach (var _kitty in ListOfKitties)
            {
                foreach (var _no in _kitty.Owner.GetPhNo())
                {
                    Fm.RecieptDate = _kitty.Record.Last().Key;
                    Fm.KittyNo = _kitty.KittyNo;
                    Fm.CustomerName = _kitty.Owner.FullName();
                    Fm.PhNo = $"+91{_no}";
                    if (_no.Length == 0)
                        Fm.PhNo = "UnKnown";
                    Fm.AmountRecieved = _kitty.Record.Last().Value;
                    Fm.AmountBeforePayment = _kitty.GivenAmount() - _kitty.Record.Last().Value;
                    Fm.Total = _kitty.GivenAmount();
                    Fm.First_Month = _kitty.Record.First().Key;
                    Fm.CompletedTill_Month = _kitty.Record.First().Key.AddMonths(_kitty.GetInstalmentsCompleted() - 1);
                    Fm.Status = _kitty.GetInstalmentsPending();
                    Fm.BarCodeData = $"{_kitty.KittyUID}000{_kitty.Owner.CustomerID}000{new Random(_kitty.GivenAmount()).Next()}";
                    await Task.Delay(500);
                    ClickMe(_no, SrNo);
                    SrNo += 1;
                }
            }
            Panel1.Visible = false;
            ImgBox.Visible = true;
            ImgBox.Image = MessageImgs_List[0];
            if (MessageImgs_List.Count > 1)
            {
                NextButton.Visible = true;
                BackButton.Visible = true;
            }
            else
            {
                NextButton.Visible = false;
                BackButton.Visible = false;
            }
            SendButton.Enabled = true;
            // ServerCall(state)
        }

        private void ClickMe(string PhNo, int SrNo)
        {
            var tmpImg = new Bitmap(Panel1.Width, Panel1.Height);
            using (var g = Graphics.FromImage(tmpImg))
            {
                g.CopyFromScreen(Panel1.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(Panel1.Width, Panel1.Height));
            }
            string path = $@"C:\Users\tapus\OneDrive\Desktop\Bills\{PhNo}_{SrNo}.jpg";
            tmpImg.Save(path);

            if (MessageImgs_Dict.ContainsKey(PhNo))
            {
                MessageImgs_Dict[PhNo].Add(path);
            }
            else
            {
                MessageImgs_Dict.Add(PhNo, new List<string>(new[] { path }));
            }
            MessageImgs_List.Add(tmpImg);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    ref var withBlock = ref this.MessageImgs_List;
                    ImgBox.Image = MessageImgs_List[withBlock.IndexOf((Bitmap)ImgBox.Image) + 1];
                }
            }
            catch
            {
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    ref var withBlock = ref this.MessageImgs_List;
                    ImgBox.Image = MessageImgs_List[withBlock.IndexOf((Bitmap)ImgBox.Image) - 1];
                }
            }
            catch
            {
            }
        }

        public void ServerCall(string recievedData)
        {
            try
            {
                if (recievedData == "qr")
                {
                    WarningLabel.Visible = true;
                    SendButton.Enabled = false;
                    SendButton.UseWaitCursor = true;
                }
                else
                {
                    WarningLabel.Visible = false;
                    SendButton.Enabled = true;
                    SendButton.UseWaitCursor = false;
                }
            }

            // If recievedData.SelectToken("webReady") = "False" Then
            // QrBox.Invoke(Sub()
            // QrBox.Visible = True : MessageTB.Visible = False : WarningLabel.Visible = True : SendButton.Enabled = False : SendButton.UseWaitCursor = True
            // End Sub)
            // Dim gen As New QRCodeGenerator
            // Dim data = gen.CreateQrCode(recievedData.SelectToken("qrData").ToString, QRCodeGenerator.ECCLevel.Q)
            // Dim code As New QRCode(data)
            // QrBox.Image = code.GetGraphic(10)
            // ElseIf recievedData.SelectToken("webReady") = "True" Then
            // MessageTB.Invoke(Sub()
            // QrBox.Visible = False : MessageTB.Visible = True : WarningLabel.Visible = False : SendButton.Enabled = True : SendButton.UseWaitCursor = False
            // End Sub)
            // webReady = True
            // End If
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void GlobalKittyBillView_Load(object sender, EventArgs e)
        {
            MessageTB.Text = "Thank You";
            Panel1.Size = My.MyProject.Forms.KittyRecievedReciept.Size;
            Cursor.Hide();
            await Task.Delay(500);
            if (ListOfKitties is not null)
                MakeBills();
            Cursor.Show();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel1.Controls.Clear();
            {
                ref var withBlock = ref this;
                withBlock.Cursor = Cursors.AppStarting;
                withBlock.Refresh();
            }
            SendButton.Enabled = false;
            foreach (var _entry in MessageImgs_Dict)
            {

                var msgList = new List<string>() { Conversions.ToString(Operators.AddObject(MessageTB.Text, Interaction.IIf(HandsCheckBox.Checked, "{hands}", ""))) };

                var response = await ProjectModule.UniversalWhatsappMessageBundle(_entry.Key, msgList, _entry.Value);

                if (response is not null)
                {
                    var _temp = new Label()
                    {
                        Font = MessageResultLB.Font,
                        Visible = true,
                        AutoSize = true
                    };

                    if (response.SelectToken("result").ToString() == "pass")
                    {
                        _temp.ForeColor = Color.ForestGreen;
                        _temp.Text = $"+91{_entry.Key.Trim()}: Sent";
                    }
                    else if (response.SelectToken("result").ToString() == "fail")
                    {
                        _temp.ForeColor = Color.Firebrick;
                        _temp.Text = $"+91{_entry.Key.Trim()}: Failed";
                    }
                    else
                    {
                        _temp.ForeColor = Color.Firebrick;
                        _temp.Text = $"+91{_entry.Key.Trim()}: NotRegistered";
                    }
                    FlowLayoutPanel1.Controls.Add(_temp);
                }
            }

            {
                ref var withBlock1 = ref this;
                withBlock1.Cursor = Cursors.Default;
                withBlock1.Refresh();
            }
            SendButton.Enabled = true;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SendRecieptCB.Checked)
            {
                Panel1.Enabled = true;
                ImgBox.Enabled = true;
                NextButton.Enabled = true;
                BackButton.Enabled = true;
                SendButton.Text = "Send Receipt";
                try
                {
                    ImgBox.Image = MessageImgs_List[0];
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                Panel1.Enabled = false;
                ImgBox.Enabled = false;
                NextButton.Enabled = false;
                BackButton.Enabled = false;
                var OrignalImage = new Bitmap(ImgBox.Image);
                var BlackAndWhite = new Bitmap(OrignalImage.Width, OrignalImage.Height);

                for (int i = 0, loopTo = OrignalImage.Width - 1; i <= loopTo; i++)
                {
                    for (int y = 0, loopTo1 = OrignalImage.Height - 1; y <= loopTo1; y++)
                    {
                        var c = OrignalImage.GetPixel(i, y);
                        int sum = (short)(Conversion.Int(c.R) + Conversion.Int(c.B)) + Conversion.Int(c.G);
                        int av = (int)Math.Round(sum / 3d);
                        var v = Color.FromArgb(c.A, av, av, av);
                        BlackAndWhite.SetPixel(i, y, v);
                    }
                }

                ImgBox.Image = BlackAndWhite;
                SendButton.Text = "Send Message";
            }
        }

    }
}
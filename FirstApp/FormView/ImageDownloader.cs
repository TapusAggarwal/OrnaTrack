using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WebSocket4Net;

namespace FirstApp
{

    public partial class ImageDownloader
    {

        public string SelectedPhNo { get; set; }
        private Frame fm = null;

        public ImageDownloader()
        {
            InitializeComponent();
        }

        public void UpdateImage()
        {
            var req = WebRequest.Create($"http://{My.MySettingsProperty.Settings.connection_url}?purpose=latest_images");
            req.Method = "POST";

            // Get the response and extract the base64 encoded string
            var response = req.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream());
            string base64String = streamReader.ReadToEnd();

            // Convert the base64 encoded string to a byte array
            byte[] imageBytes = Convert.FromBase64String(base64String);
            if (string.IsNullOrEmpty(base64String))
                return;

            // Convert the byte array to an image
            using (var memoryStream = new MemoryStream(imageBytes))
            {
                var image = Image.FromStream(memoryStream);
                if (ImageBox.IsHandleCreated)
                {
                    ImageBox.Invoke(new Action(() => ImageBox.Image = new Bitmap(image)));
                }
                // Do something with the image, such as display it
            }

        }


        private async void StartListeningForMessages()
        {

            if (ProjectModule.WebSocket is null || !(ProjectModule.WebSocket.State == WebSocketState.Open))
            {
                await fm?.StartServer(false);
            }

            if (ProjectModule.WebSocket.State == WebSocketState.Open)
            {
                foreach (var i in SelectedPhNo.Split(','))
                {
                    if (string.IsNullOrEmpty(i.Trim()))
                        continue;
                    var req = WebRequest.Create($"http://{My.MySettingsProperty.Settings.connection_url}?purpose=listen_phno&phno={i}&listen=true");
                    req.Method = "POST";
                    req.Timeout = 3000;
                    using (var request = req.GetResponse())
                    {
                        using (var reader = new StreamReader(request.GetResponseStream()))
                        {
                            string response = reader.ReadToEnd();

                            if (response == "added")
                            {
                                MessageBox.Show($"PhNo:{i} Added As A New Listener", "Success");
                                fm.NewMessage_Socket += UpdateImage;
                                My.MySettingsProperty.Settings.ListenerPhNo = i;
                                SelectedPhNo = i;
                                UpdateRecentListeners(SelectedPhNo);
                                if (FlowLayoutPanel1.IsHandleCreated)
                                {
                                    FlowLayoutPanel1.Invoke(new Action(() => LoadRecentListeners()));
                                }
                                ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                                ListenPhNoBT.BackColor = Color.Maroon;
                                ListenPhNoBT.Text = "Stop";
                            }
                            else if (response == "removed")
                            {
                                MessageBox.Show($"PhNo:{i} removed As A New Listener", "Success");
                                fm.NewMessage_Socket -= UpdateImage;
                                SelectedPhNo = i;
                                ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye;
                                ListenPhNoBT.BackColor = Color.FromArgb(0, 64, 0);
                                ListenPhNoBT.Text = "Start";
                            }
                            else
                            {
                                MessageBox.Show($"Can't Add PhNo: {i} Either This No. Is Not Registered With Whatsapp Or An Internal Error Occured.");
                            }
                        }
                    }
                }
            }

        }

        private void LoadRecentListeners()
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select RecentListeners From Message_Data Where id=1");
            string num = "";
            while (dr.Read())
                num = Conversions.ToString(dr[0] is DBNull ? "" : dr[0]);

            SelectedPhNo = num.Split(',').Last();

            FlowLayoutPanel1.Controls.Clear();

            foreach (var i in num.Split(',').Reverse())
            {
                if (string.IsNullOrEmpty(i.Trim()))
                    continue;

                var lbl = new Label()
                {
                    Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0),
                    ForeColor = Color.ForestGreen,
                    Visible = true,
                    AutoSize = true,
                    Text = $"+{i.Substring(0, i.Length - 10)}-" + i.Trim().Substring(i.Length - 10),
                    Tag = i,
                    TabStop = true
                };

                lbl.Click += (Sender, e) =>
                    {

                        foreach (Label _lbl in FlowLayoutPanel1.Controls)
                        {
                            if ((_lbl.Tag.ToString() ?? "") == (SelectedPhNo ?? ""))
                            {
                                // set focus to the label
                                _lbl.BorderStyle = BorderStyle.None;
                                break;
                            }
                        }

                        SelectedPhNo = Conversions.ToString(Sender.Tag);
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.Select();

                        SelectBT.Visible = true;
                        DeleteBT.Visible = true;
                        CancelEditBT.Visible = true;

                    };

                Invoke(new Action(() => FlowLayoutPanel1.Controls.Add(lbl)));
            }

        }

        #region Dierct Events
        private void Select_Click(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select RecentListeners From Message_Data Where id=1");
            string num = "";
            while (dr.Read())
                num = Conversions.ToString(dr[0] is DBNull ? "" : dr[0]);

            var _list = num.Split(',').ToList();
            // Removing From Current Position
            _list.Remove(SelectedPhNo.Trim());
            // Adding To Current Position
            _list.Add(SelectedPhNo);

            ProjectModule.SqlCommand($"Update Message_Data set RecentListeners='{string.Join(",", _list)}'");
            LoadRecentListeners();

            PhNoTB.Text = SelectedPhNo;
            CancelBT_Click(sender, e);
            ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ListenPhNoBT.BackColor = Color.FromArgb(0, 64, 0);
            ListenPhNoBT.Text = "Start";
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            UpdateRecentListeners(SelectedPhNo, true);
            CancelBT_Click(sender, e);
            SelectedPhNo = "";
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            SelectBT.Visible = false;
            DeleteBT.Visible = false;
            CancelEditBT.Visible = false;

            foreach (Label lbl in FlowLayoutPanel1.Controls)
            {
                if ((lbl.Tag.ToString() ?? "") == (SelectedPhNo ?? ""))
                {
                    // set focus to the label
                    lbl.BorderStyle = BorderStyle.None;
                    break;
                }
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ImageBox.Image is not null)
            {
                SaveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png";
                SaveFileDialog1.FileName = "Whatsapp-Image.jpg";
                SaveFileDialog1.ShowDialog();
                if (!string.IsNullOrEmpty(SaveFileDialog1.FileName))
                {
                    ImageBox.Image.Save(SaveFileDialog1.FileName);
                }
            }
        }



        private void AddNewListenerBT_Click(object sender, EventArgs e)
        {
            string newPhno = Interaction.InputBox($"Enter New PhNo With Country Code Which Will Be Used As A Listener. Add Comma To Add Multiple Numbers).{Constants.vbNewLine}Current PhNo: {SelectedPhNo}", "Listener PhNo");
            if (newPhno.Length != 12)
                return;

            SelectedPhNo = newPhno;
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select RecentListeners From Message_Data Where id=1");
            string num = "";
            while (dr.Read())
                num = Conversions.ToString(dr[0] is DBNull ? "" : dr[0]);

            var _list = num.Split(',').ToList();
            // Removing From Current Position
            _list.Remove(SelectedPhNo.Trim());
            // Adding To Current Position
            _list.Add(SelectedPhNo);

            ProjectModule.SqlCommand($"Update Message_Data set RecentListeners='{string.Join(",", _list)}'");
            LoadRecentListeners();

            StartListeningForMessages();
        }

        private async void ImageDownloader_Load(object sender, EventArgs e)
        {
            LoadRecentListeners();
            PhNoTB.Text = SelectedPhNo;

            foreach (Form _form in Application.OpenForms)
            {
                if (!(_form is Frame))
                    continue;
                fm = (Frame)_form;
                break;
            }

            var req = WebRequest.Create($"http://{My.MySettingsProperty.Settings.connection_url}?purpose=phno_listeners");
            req.Method = "POST";
            req.Timeout = 3000;
            using (var request = req.GetResponse())
            {
                using (var reader = new StreamReader(request.GetResponseStream()))
                {
                    string response = reader.ReadToEnd();

                    if (response.Trim().Length == 0)
                        return;
                    PhNoTB.Text = response.Trim();
                    ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    ListenPhNoBT.BackColor = Color.Maroon;
                    ListenPhNoBT.Text = "Stop";

                    if (ProjectModule.WebSocket is null || !(ProjectModule.WebSocket.State == WebSocketState.Open))
                    {
                        await fm?.StartServer(false);
                    }

                    fm.NewMessage_Socket += UpdateImage;

                }
            }


        }

        private void ListenPhNoBT_Click(object sender, EventArgs e)
        {
            string i = SelectedPhNo;
            if (string.IsNullOrEmpty(i))
                return;
            if (ListenPhNoBT.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                var req = WebRequest.Create($"http://{My.MySettingsProperty.Settings.connection_url}?purpose=listen_phno&phno={i}&listen=false");
                req.Method = "POST";
                req.Timeout = 3000;
                using (var request = req.GetResponse())
                {
                    using (var reader = new StreamReader(request.GetResponseStream()))
                    {
                        string response = reader.ReadToEnd();

                        if (response == "removed")
                        {
                            MessageBox.Show($"PhNo:{i} removed As A New Listener", "Success");
                            fm.NewMessage_Socket -= UpdateImage;
                            ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye;
                            ListenPhNoBT.BackColor = Color.FromArgb(0, 64, 0);
                            ListenPhNoBT.Text = "Start";
                        }
                        else
                        {
                            MessageBox.Show($"Can't Remove PhNo: {i} Either This No. Is Not Registered With Whatsapp Or An Internal Error Occured.");
                        }
                    }
                }
            }
            else
            {
                StartListeningForMessages();
            }
        }

        #endregion

        private void UpdateRecentListeners(string phno, bool @remove = false)
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select RecentListeners From Message_Data Where id=1");
            string num = "";
            while (dr.Read())
                num = Conversions.ToString(dr[0] is DBNull ? "" : dr[0]);

            var _list = num.Split(',').ToList();
            if (!_list.Contains(phno.Trim()))
                _list.Add(phno.Trim());
            if (@remove)
                _list.Remove(phno.Trim());

            ProjectModule.SqlCommand($"Update Message_Data set RecentListeners='{string.Join(",", _list)}'");
            LoadRecentListeners();
        }

        private void ReloadImgBT_Click(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void ImageDownloader_Closed(object sender, EventArgs e)
        {
            fm.NewMessage_Socket -= UpdateImage;
            Dispose();
        }
    }
}
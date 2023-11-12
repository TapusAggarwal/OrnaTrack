using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using Squirrel;
using WebSocket4Net;

namespace FirstApp
{

    public partial class Frame
    {

        private string qrData = null;

        [DllImport("User32.Dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("User32.Dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;

        private UpdateManager manager;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        #region Me.Load
        private async void Frame_Load(object sender, EventArgs e)
        {
            // ' Fade in when started
            Opacity = 0d;
            var tmr = new Timer() { Interval = 2 };
            tmr.Start();
            tmr.Tick += () =>
                {
                    Opacity += 0.1d;
                    if (Opacity == 1d)
                        tmr.Stop();
                };

            foreach (Control c in Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.DimGray;
                    int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);
                    windowLong = windowLong & ~WS_EX_CLIENTEDGE;
                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);
                    c.Width += 1;
                    break;
                }
            }
            foreach (Control ctl in Controls)
            {
                if (ctl is MdiClient)
                {
                    // got the control, so cast it
                    MdiClient mdiClientControl = (MdiClient)ctl;
                    // undock it
                    mdiClientControl.Dock = DockStyle.None;
                    // resize it
                    mdiClientControl.Bounds = ClientRectangle;
                    mdiClientControl.Height += 20;
                    mdiClientControl.Width += 20;
                    // set the anchors
                    mdiClientControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

                    // bail out
                    break;
                }
            }

            ProjectModule.InitaliseConnection();
            try
            {
                ProjectModule.myconnection.Open();
            }
            catch
            {
            }

            WindowState = FormWindowState.Maximized;
            QuickSearchButton_Click(QuickSearchButton, e);
            KeyPreview = true;

            try
            {
                manager = await UpdateManager.GitHubUpdateManager("https://github.com/TapusAggarwal/Test_App");
                VersionLB.Text = manager.CurrentlyInstalledVersion().ToString();
                VersionLB.Visible = true;
                var updateInfo = await manager.CheckForUpdate();
                if (updateInfo.ReleasesToApply.Count <= 0)
                {
                    VersionLB.IconColor = Color.White;
                }
                else
                {
                    VersionLB.Text = "New Update";
                    VersionLB.IconColor = Color.Goldenrod;
                }
            }
            catch (Exception ex)
            {
            }

        }
        #endregion

        #region Server
        public async Task StartServer(bool isFresh)
        {
            string rawresponse = null;

            try
            {
                var dict = new Dictionary<string, string>() { { "purpose", "test" } };
                rawresponse = Conversions.ToString(await ProjectModule.ServerHttpRequest(dict));
            }
            catch (Exception ex)
            {
            }

            if (rawresponse == "true")
            {
                ProjectModule.state = "STANDBY";
                InitialiseStates();

                var dict = new Dictionary<string, string>() { { "purpose", "state" } };
                rawresponse = Conversions.ToString(await ProjectModule.ServerHttpRequest(dict));
                if (rawresponse == "NOTCONNECTED" | rawresponse == "DISCONNECTED")
                {
                    dict = new Dictionary<string, string>() { { "purpose", "new_web" }, { "headless", "true" }, { "ignorePrevious", isFresh ? "true" : "false" } };
                    rawresponse = Conversions.ToString(await ProjectModule.ServerHttpRequest(dict));
                    if (rawresponse != "started")
                        MessageBox.Show("Unable To Perform The Action: '" + rawresponse + "'");
                }
                else if (rawresponse != "CONNECTED" & rawresponse != "qr" & rawresponse != "STANDBY" & rawresponse != "OPENING" & rawresponse != "PAIRING")
                {
                    dict = new Dictionary<string, string>() { { "purpose", "close" } };
                    rawresponse = Conversions.ToString(await ProjectModule.ServerHttpRequest(dict));
                    await StartServer(true);
                }

                string url = $"ws://{My.MySettingsProperty.Settings.connection_url}";
                ProjectModule.WebSocket = new WebSocket(url);
                ProjectModule.WebSocket.Opened += (s, Eventargs) => SocketOpened(s, Eventargs);
                ProjectModule.WebSocket.Error += (s, Eventargs) => SocketError(s, Eventargs);
                ProjectModule.WebSocket.Closed += (s, Eventargs) => SocketClosed(s, Eventargs);
                ProjectModule.WebSocket.MessageReceived += (s, Eventargs) => SocketMessage(s, Eventargs);
                ProjectModule.WebSocket.DataReceived += (s, Eventargs) => SocketDataReceived(s, Eventargs);
                ProjectModule.WebSocket.Open();
            }
            else
            {
                MessageBox.Show($"Unable To Get A Response From Server. Either Server Is Not Running Or Server Address Is Not Correct.{Constants.vbNewLine}Make Sure Server Is Running And Address Provided Is Correct.", "Server Not Responding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void SocketOpened(object s, EventArgs e)
        {
            ProjectModule.state = "STANDBY";
            InitialiseStates();
        }

        public void SocketClosed(object s, EventArgs e)
        {
            ProjectModule.state = "NOTCONNECTED";
            InitialiseStates();
            try
            {
                ProjectModule.WebSocket.Opened -= SocketOpened;
                ProjectModule.WebSocket.Closed -= SocketClosed;
                ProjectModule.WebSocket.MessageReceived -= SocketMessage;
                ProjectModule.WebSocket.DataReceived -= SocketDataReceived;
            }
            catch (Exception ex)
            {
            }
        }

        public void SocketError(object s, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            if (e.Exception.Message == "HTTP/1.0 200 OK")
            {
                MessageBox.Show($"Server Error: Possibly unable to start the server {e.Exception.Message}");
            }
            else
            {
                MessageBox.Show("Server Error: " + e.Exception.Message);
            }
        }

        public void SocketDataReceived(object s, WebSocket4Net.DataReceivedEventArgs e)
        {
            Interaction.MsgBox("Message From Server This Must Be Informed To The Developer: " + e.ToString());
        }

        public async void SocketMessage(object sender, MessageReceivedEventArgs e)
        {
            // Try
            string recievedData_string = e.Message.ToString();
            var recievedData = JObject.Parse(recievedData_string);
            JObject msgInfo = (JObject)recievedData.SelectToken("msgInfo");
            JObject clientInfo = (JObject)recievedData.SelectToken("clientInfo");
            string oldState = ProjectModule.state;
            ProjectModule.state = (string)recievedData.SelectToken("serverState");

            if ((string)msgInfo.SelectToken("purpose") == "connection_welcome_msg")
            {
                Invoke(new Action(() => UserPhNo.Text = (string)clientInfo.SelectToken("phoneno")));
            }

            if (ProjectModule.state == "qr")
            {

                if (msgInfo.SelectToken("msg").ToString().Length > 1)
                {
                    QrCodeView fm = null;

                    foreach (Form _form in Application.OpenForms)
                    {
                        if (!(_form is QrCodeView))
                            continue;
                        fm = (QrCodeView)_form;
                        break;
                    }

                    qrData = (string)msgInfo.SelectToken("msg");
                    if (fm is not null)
                    {
                        Invoke(new Action(() => fm.QrNew((string)msgInfo.SelectToken("msg"))));
                    }
                }

            }

            if ((string)msgInfo.SelectToken("purpose") == "reconnect")
            {
                ProjectModule.WebSocket.Close();
                await StartServer(true);
            }

            if (ProjectModule.state == "CONNECTED")
            {
                Invoke(new Action(() => UserPhNo.Text = clientInfo.SelectToken("phoneno").ToString()));
            }

            InitialiseStates();

            if ((string)msgInfo.SelectToken("purpose") == "new_msg")
            {
                NewMessage_Socket?.Invoke();
            }

            if ((oldState ?? "") != (ProjectModule.state ?? ""))
            {
                State_Changed?.Invoke(ProjectModule.state, oldState);
            }

            // Catch ex As Exception
            // MessageBox.Show(ex.Message)
            // End Try
        }

        public event NewMessage_SocketEventHandler NewMessage_Socket;

        public delegate void NewMessage_SocketEventHandler();
        public event State_ChangedEventHandler State_Changed;

        public delegate void State_ChangedEventHandler(string newState, string oldState);


        public void InitialiseStates()
        {

            RecieptMessenger fm = null;
            var forms = Application.OpenForms;
            foreach (Form form in forms)
            {
                if (form is RecieptMessenger)
                {
                    fm = (RecieptMessenger)form;
                    break;
                }
            }
            if (fm is not null)
            {
                Invoke(new Action(() => fm.ServerCall(ProjectModule.state)));
            }

            if (ProjectModule.state == "STANDBY")
            {
                ConnectionLabel.Invoke(new Action(() =>
                    {
                        ConnectionLabel.IconChar = IconChar.Spinner;
                        ConnectionLabel.IconColor = Color.Goldenrod;
                        ConnectionLabel.Text = "Connecting...";
                        ConnectionLabel.ForeColor = Color.Olive;
                        UserPhNo.Visible = false;
                    }));
                return;
            }

            if (ProjectModule.state == "CONNECTED")
            {
                ConnectionLabel.Invoke(new Action(() =>
                    {

                        foreach (Form _form in Application.OpenForms)
                        {
                            if (!(_form is QrCodeView))
                                continue;
                            Invoke(new Action(() => _form.Close()));
                            break;
                        }

                        ConnectionLabel.IconChar = IconChar.Whatsapp;
                        ConnectionLabel.IconColor = Color.SeaGreen;
                        ConnectionLabel.Text = $"Connected";
                        ConnectionLabel.ForeColor = Color.SeaGreen;
                        UserPhNo.Visible = true;
                    }));
                return;
            }

            if (ProjectModule.state == "offline")
            {
                ConnectionLabel.Invoke(new Action(() =>
                    {
                        ConnectionLabel.IconChar = IconChar.ExclamationTriangle;
                        ConnectionLabel.IconColor = Color.Goldenrod;
                        ConnectionLabel.Text = "Device Offline";
                        ConnectionLabel.ForeColor = Color.Red;
                        UserPhNo.Visible = false;
                    }));
                return;
            }
            if (ProjectModule.state == "qr")
            {
                ConnectionLabel.Invoke(new Action(() =>
                    {
                        ConnectionLabel.IconChar = IconChar.Qrcode;
                        ConnectionLabel.ImageAlign = ContentAlignment.MiddleCenter;
                        ConnectionLabel.IconColor = Color.Goldenrod;
                        ConnectionLabel.Text = "QrCode";
                        UserPhNo.Visible = false;
                        ConnectionLabel.ForeColor = Color.Olive;
                    }));
                return;
            }
            else
            {
                ConnectionLabel.Invoke(new Action(() =>
                    {
                        ConnectionLabel.IconChar = IconChar.ExclamationTriangle;
                        ConnectionLabel.IconColor = Color.Goldenrod;
                        ConnectionLabel.Text = "Not Connected";
                        UserPhNo.Visible = false;
                        ConnectionLabel.ForeColor = Color.Red;
                    }));
                return;
            }
        }

        public async void ConnectionLabel_Click(object sender, EventArgs e)
        {
            if (ProjectModule.state == "STANDBY")
            {
                return;
            }
            if (ProjectModule.state == "qr")
            {
                if (qrData is not null)
                {
                    My.MyProject.Forms.QrCodeView.Tag = qrData;
                    My.MyProject.Forms.QrCodeView.Show();
                }
                return;
            }

            try
            {
                if (!(ProjectModule.WebSocket.State == WebSocketState.Closed) && !(ProjectModule.WebSocket.State == WebSocketState.Closing))
                {
                    ProjectModule.WebSocket.Close();
                }
                ProjectModule.WebSocket.Opened -= SocketOpened;
                ProjectModule.WebSocket.Closed -= SocketClosed;
                ProjectModule.WebSocket.MessageReceived -= SocketMessage;
                ProjectModule.WebSocket.DataReceived -= SocketDataReceived;
            }
            catch (Exception ex)
            {
            }
            await StartServer(false);

        }

        #region Tool Strip Methods

        private void WhatsappWebVisibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ans = (int)MessageBox.Show($"Currently Visible:{(My.MySettingsProperty.Settings.server_headless == true ? "False" : "True")}.{Constants.vbNewLine}Do You Want To Turn Visiblity To: {(My.MySettingsProperty.Settings.server_headless == true ? "On" : "Off")}.{(My.MySettingsProperty.Settings.server_headless == true ? $"{Constants.vbNewLine}Note: Press 'Yes' Only If Machine On Which Server Is Running Is Capable Of Displaying Content." : "")}", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == 7)
                return;
            My.MySettingsProperty.Settings.server_headless = !My.MySettingsProperty.Settings.server_headless;
            My.MySettingsProperty.Settings.Save();
        }

        private void NotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)sender).Text.Split(":")(1).Trim, "Turned On", false)))
            {
                int ans = (int)MessageBox.Show("This Selection Will Turn Of Whatsapp Web Notifications. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == 7)
                    return;
                ((dynamic)sender).Text = "Notifications: Turned Off";
                My.MySettingsProperty.Settings.server_notify = false;
                ServerContextMenuStrip.Show();
            }
            else
            {
                int ans = (int)MessageBox.Show("This Selection Will Turn On Whatsapp Web Notifications. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == 7)
                    return;
                ((dynamic)sender).Text = "Notifications: Turned On";
                ServerContextMenuStrip.Show();
            }
            My.MySettingsProperty.Settings.Save();
        }

        private async void RestartServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ans = (int)MessageBox.Show("This Selection Will Force Restart The Server i.e All Previous Sessions Will Be Lost And You Have To Scan Whatsapp QR Code Again. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == 7)
                return;

            await StartServer(true);

        }

        private void CloseServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ans = (int)MessageBox.Show("This Selection Will Close The Server. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == 7)
                return;
            var dict = new Dictionary<string, string>() { { "purpose", "close" } };
            ProjectModule.ServerHttpRequest(dict);
            ProjectModule.state = "NOTCONNECTED";
            InitialiseStates();
        }

        private void CleanAllSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ans = (int)MessageBox.Show("This Selection Will Clean All The Sessions, Including The Existing Session. Do You Still Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == 7)
                return;
            var CleanerBat = new Process();
            var info = new ProcessStartInfo() { FileName = @"C:\Users\hp\source\repos\TapusAggarwal\FirstApp-ReBuild\FirstApp\whatsapp-web.js-main\ServerClear.bat" };
            CleanerBat.StartInfo = info;
            CleanerBat.Start();
        }

        private void ChangeServerAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ans = (int)MessageBox.Show("This Selection Will Allow You To Change Server Address, Do You Want To Continue.", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == 7)
                return;
            string newAddress = Interaction.InputBox($"Enter New Address Which Will Be Used To Send All Http Requests.{Constants.vbNewLine}Connection Format -> 'Address:Port'.{Constants.vbNewLine}Current Address->'{My.MySettingsProperty.Settings.connection_url}'.{Constants.vbNewLine}(Enter Correct Address To Avoid Future Errors.)", "New Server Address");
            if (newAddress.Length != 0)
            {
                My.MySettingsProperty.Settings.connection_url = newAddress.Trim();
            }
            My.MySettingsProperty.Settings.Save();
        }

        private async void TestConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rawresponse = "false";
            try
            {
                var dict = new Dictionary<string, string>() { { "purpose", "test" } };
                rawresponse = Conversions.ToString(await ProjectModule.ServerHttpRequest(dict));
            }
            catch (Exception ex)
            {
            }
            if (rawresponse != "false" && !string.IsNullOrEmpty(rawresponse))
            {
                MessageBox.Show($"The Server Is Responding Appropriately. All Good!!", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("The Server Is Not Responding Appropriately. SomeThing Went Wrong", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Fm = new ServerUpdateForm();
            Fm.ShowDialog();
        }

        #endregion

        #endregion

        public Frame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            // Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        }

        public void QuickSearchButton_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Main.IsMdiChild)
            {
                My.MyProject.Forms.Main.Activate();
            }
            else
            {
                Make_MdiChild(My.MyProject.Forms.Main, null);
            }
            SidePanel();
        }

        public void NewCoustmerButton_Click()
        {
            foreach (Form i in MdiChildren)
            {
                if (i.Name != "Main")
                {
                    i.Dispose();
                }
            }
            var Fm = new CoustProfileUpdated()
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                Tag = Tag
            };
            Fm.Show();
        }

        private void LeftArrowButton_Click(object sender, EventArgs e)
        {
            // If Main Is ActiveMdiChild Then CoustProfileUpdated.Activate() Else Main.Activate()
            SendKeys.SendWait("^{Tab}");
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            SidePanel();
        }

        private void SidePanelButton_Click(object sender, EventArgs e)
        {
            SidePanel(true);
        }

        private void SidePanel(object click = false)
        {
            if (Conversions.ToBoolean(Operators.AndObject(!PanelMenu.Visible, click)))
            {
                PanelMenu.Visible = true;
            }
            else
            {
                PanelMenu.Visible = false;
            }
        }

        #region All KeyDown Events Ex.-Ctrl+S
        private void Frame_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control & e.KeyCode == Keys.N)
                {
                    NewCoustmerButton_Click();
                    return;
                }
                if (e.Control & e.KeyCode == Keys.Q)
                {
                    QuickSearchButton_Click(QuickSearchButton, e);
                    My.MyProject.Forms.Main.NameTB.Select();
                    return;
                }
                if (e.Control & e.KeyCode == Keys.R)
                {
                    // Form2.Show()
                }
                if (e.Control & e.KeyCode == Keys.B)
                {
                    if (ReferenceEquals(ActiveMdiChild, My.MyProject.Forms.m_Main))
                    {
                        My.MyProject.Forms.BookMode.Show();
                    }
                }
                if (e.Control & e.KeyCode == Keys.M)
                {
                    if (ReferenceEquals(ActiveMdiChild, My.MyProject.Forms.m_Main))
                    {
                        My.MyProject.Forms.BulkMessagesEntryForm.Show();
                    }
                }
                if (e.Control & e.KeyCode == Keys.E)
                {
                    if (ReferenceEquals(ActiveMdiChild, My.MyProject.Forms.m_Main))
                    {
                        My.MyProject.Forms.Graph.Show();
                    }
                }
                if (e.Control & e.KeyCode == Keys.D)
                {
                    if (ReferenceEquals(ActiveMdiChild, My.MyProject.Forms.m_Main))
                    {
                        var Fm = new ImageDownloader();
                        Fm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        private void IconCurrentForm_Click(object sender, EventArgs e)
        {
            Close();
            // If Not WantToContinue("Do You Want To Put system on sleep.", "Confirm") Then Exit Sub
            // Application.SetSuspendState(PowerState.Suspend, True, False)
        }

        private void Frame_MdiChildActivate()
        {
            var ButtonsOreientaion = new System.Threading.Thread(() => Invoke(new Action(() =>
{
if (MdiChildren.Count() <= 1)
{
LeftArrowButton.ForeColor = Color.Black;
LeftArrowButton.Enabled = false;
RightArrowButton.ForeColor = Color.Black;
RightArrowButton.Enabled = false;
return;
}
if (ReferenceEquals(ActiveMdiChild, My.MyProject.Forms.m_Main))
{
RightArrowButton.ForeColor = Color.LightGreen;
RightArrowButton.Enabled = true;
LeftArrowButton.ForeColor = Color.Black;
LeftArrowButton.Enabled = false;
}
else
{
LeftArrowButton.ForeColor = Color.LightGreen;
LeftArrowButton.Enabled = true;
RightArrowButton.ForeColor = Color.Black;
RightArrowButton.Enabled = false;
}
})))
            {
                IsBackground = true,
                Priority = System.Threading.ThreadPriority.AboveNormal
            };
            ButtonsOreientaion.Start();
        }

        public void Make_MdiChild(Form Fm, object Tag)
        {
            try
            {
                foreach (Form ExistingFm in MdiChildren)
                {
                    if (ReferenceEquals(ExistingFm, Fm))
                    {
                        ExistingFm.Dispose();
                    }
                }
                Fm.MdiParent = this;
                Fm.Tag = Tag;
                Fm.Dock = DockStyle.Fill;
                Fm.Show();
            }
            // make_thread.Abort()
            catch (Exception ex)
            {
                MessageBox.Show($"Error: (Make_MdiChild/Frame)-> {ex.Message}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WindowsRestoreButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                WindowsRestoreButton.IconChar = IconChar.WindowRestore;
                Refresh();
                foreach (Form fm in MdiChildren)
                    fm.Refresh();
            }
            else
            {
                WindowState = FormWindowState.Normal;
                WindowsRestoreButton.IconChar = IconChar.WindowMaximize;
                Location = new Point(0, 0);
                Refresh();
                foreach (Form fm in MdiChildren)
                    fm.Refresh();
            }
            Select();
        }

        private void WindowsMinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Select();
        }

        private void Frame_Resize(object sender, EventArgs e)
        {
            Refresh();
            foreach (Form fm in MdiChildren)
                fm.Refresh();
        }

        private void GoldButton_Click(object sender, EventArgs e)
        {
            var fm = new MainStockPage();
            fm.Show();
        }

        private void SilverButton_Click(object sender, EventArgs e)
        {
            var fm_trns = new AllTransactionsForm();
            fm_trns.Size = (Size)new Point(fm_trns.Width, 10000);
            fm_trns.AddTransactionButton_Clicked += () =>
                {
                    var fm = new TransactionDetailsForm();
                    fm.CurrentTransaction = new Transaction(-1);
                    fm.ShowDialog();
                };
            fm_trns.Show();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            var fm = new PaymentReport();
            fm.ShowDialog();
        }

        private async void IconButton2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            VersionLB.Visible = false;
            ProgressBar1.Visible = true;
            try
            {
                var updateInfo = await manager.CheckForUpdate();
                ProgressBar1.Value = 0;
                if (updateInfo.ReleasesToApply.Count > 0)
                {

                    await manager.UpdateApp(f => ProgressBar1.Value = f);
                    MessageBox.Show("Updated Succesfully. Close The Application To See The New Changes.", "Task Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"While Updating The Application Error Occured: {ex.Message}", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            VersionLB.Visible = true;
            ProgressBar1.Visible = false;
            Cursor = Cursors.Default;
        }

        private void RoughButton_Click(object sender, EventArgs e)
        {
            var Fm = new MainStockPage();
            Fm.ShowDialog();
        }

        private void ImageDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Fm = new ImageDownloader();
            Fm.ShowDialog();
        }

        private void ServerContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void IconButton2_Click_1(object sender, EventArgs e)
        {
            var Fm = new rough1();
            Fm.ShowDialog();
        }

        private void DBSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ans = (int)MessageBox.Show($"Select New Database File Which Will Be Used To Send All Database Related Queries.{Constants.vbNewLine}Current Path->'{My.MySettingsProperty.Settings.Db_source}'.{Constants.vbNewLine}(Enter Correct Database To Avoid Future Errors.)", "New DB Path", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == 7)
                return;
            var db_file = new OpenFileDialog() { Filter = "Access Database Files (*.accdb)|*.accdb" };

            if (db_file.ShowDialog() == DialogResult.OK)
            {
                My.MySettingsProperty.Settings.Db_source = db_file.FileName.Trim();
                My.MySettingsProperty.Settings.Save();
            }

        }

        private void Frame_MdiChildActivate(object sender, EventArgs e) => Frame_MdiChildActivate();
        private void NewCoustmerButton_Click(object sender, EventArgs e) => NewCoustmerButton_Click();
    }
}
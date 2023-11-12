using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Renci.SshNet;

namespace FirstApp
{

    public partial class ServerUpdateForm
    {

        public string Host { get; set; } = "3.16.198.57";
        public string Username { get; set; } = "ec2-user";
        public string Password { get; set; } = "tapus123";

        public static SshClient Client { get; set; }
        public ShellStream ShellStream { get; set; }

        public List<Tuple<string, string>> MyList_Of_Commands { get; set; } = new List<Tuple<string, string>>();

        public ServerUpdateForm()
        {
            InitializeComponent();
        }

        private void ServerUpdateForm_Load(object sender, EventArgs e)
        {

            FlowLayoutPanel1.Controls.Clear();

            UpdateBT.Enabled = true;
            UpdateBT.BackColor = Color.FromArgb(0, 114, 0);
            UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Clock;
            UpdateBT.Text = "Login";
            UpdateBT.Location = new Point(14, 14);
            UpdateBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 94, 0);
            UpdateBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 124, 0);

            UpdateBT.Click += LoginRoutine;

            // sudo lsof - i tcp:  3966
            // Kill -9 {PID}
            // Kill -9 $(lsof -t -i:  8080)
            // AddCommand("sudo npm cache clean -f", "$")
            // AddCommand("sudo npm install -g n", "$")
            // AddCommand("sudo n stable", "$")
            // AddCommand("sudo su", "#")
            // AddCommand("exit", "$")

            string _branch = "auto-wa-web-update";
            AddCommand("sudo yum -y update", "$");
            AddCommand("cd MyNode_Application", "$");
            AddCommand($"rm -rf {_branch}", "$");
            AddCommand($"git clone https://github.com/pedroslopez/whatsapp-web.js.git {_branch}", "$");
            AddCommand($"cd {_branch}", "$");
            AddCommand("sudo npm install -g npm", "$");
            AddCommand("sudo npm --version", "$");
            AddCommand("npm install", "$");
            foreach (var i in "fs-extra is-online-emitter express multer".Split(' '))
                AddCommand($"npm install {i}", "$");
            AddCommand("cd", "$");
            AddCommand($"cp -r MyNode_Application/ServerMain.mjs MyNode_Application/{_branch}/", "$");
            AddCommand($"cd MyNode_Application/{_branch}", "$");
            AddCommand($"pm2 kill", "$");
            AddCommand($"pm2 start ServerMain.mjs", "$");

            // AddCommand("tmux kill-server", "$")
            // AddCommand("tmux new -d -s my_session ""bash --init-file <(node ServerMain.mjs)""", "$")
        }

        public void AddCommand(string _str, string _symbl)
        {
            MyList_Of_Commands.Add(new Tuple<string, string>(_str, _symbl));
        }

        private async void LoginRoutine(object sender, EventArgs e)
        {
            UpdateBT.Enabled = false;
            UpdateBT.BackColor = Color.Goldenrod;
            UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            UpdateBT.Text = "Logging In...";
            UpdateBT.Location = new Point(0, 14);

            // Logging Sequence
            await Task.Run(() => LoginToServer());


            // MessageBox.Show("Succesfully Logged In To Server. Press 'Connect' To Continue.", "Step 1. Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateBT.Click -= LoginRoutine;
            UpdateBT.Click += ConnectingRoutine;
        }


        private bool LoginToServer()
        {
            try
            {
                Client = new SshClient(Host, Username, Password);
                Client.Connect();
                ShellStream = Client.CreateShellStream("dumb", 80U, 24U, 800U, 600U, 1024);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            Invoke(new Action(() =>
                {
                    UpdateBT.Enabled = true;
                    UpdateBT.BackColor = Color.FromArgb(0, 114, 0);
                    UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Link;
                    UpdateBT.Text = "Connect";
                    UpdateBT.Location = new Point(14, 14);
                }));
            return true;
        }

        private async void ConnectingRoutine(object sender, EventArgs e)
        {
            UpdateBT.Enabled = false;
            UpdateBT.BackColor = Color.Goldenrod;
            UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            UpdateBT.Text = "Connecting...";
            UpdateBT.Location = new Point(0, 14);

            // Connecting Sequence
            await Task.Run(() =>
                {
                    string x = ShellStream.Read();
                    Invoke(new Action(async () =>
     {
                        RichTextBox1.AppendText(x);
                        var T_List = CommandsControls();
                        if (T_List is not null && Conversions.ToBoolean(T_List.Count))
                        {
                            ServerUpdateProgressBar[] res = await Task.WhenAll(T_List);
                            FlowLayoutPanel1.Controls.Clear();
                            int _srno = 0;
                            foreach (var i in res)
                            {
                                _srno += 1;
                                i.SrNo = _srno;
                                i.Name = $"cmd_{_srno}";
                                FlowLayoutPanel1.Controls.Add(i);
                            }
                        }
                    }));

                });

            UpdateBT.Enabled = true;
            UpdateBT.BackColor = Color.FromArgb(0, 114, 0);
            UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Upload;
            UpdateBT.Text = "Update Server";
            UpdateBT.Location = new Point(14, 14);

            // MessageBox.Show("Succesfully Connected To Server. Press 'Update Server' To Continue.", "Step 2. Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            char _prevChar = Conversions.ToChar("");
            string _prevStr = "";

            NewRespone += async (_rsp, _tag, _lastRsp) => await Task.Run(() => Invoke(new Action(() =>
{
if (string.IsNullOrEmpty(_rsp) | (_rsp ?? "") == (_prevStr ?? ""))
return;
if (char.IsWhiteSpace(_rsp.Last()) && _prevChar == _rsp.Last())
return;

ServerUpdateProgressBar _ctrl = (ServerUpdateProgressBar)FlowLayoutPanel1.Controls.Find($"cmd_{_tag}", true)[0];

RichTextBox1.AppendText(_rsp);
if (!char.IsWhiteSpace(Conversions.ToChar(_rsp)))
{
foreach (var _str in _rsp.Split(Conversions.ToChar(Constants.vbCr)))
{
if (string.IsNullOrEmpty(_str))
continue;
_ctrl.StatusLB.Text = _str;
}
}

_ctrl.TitleLB.ForeColor = Color.Goldenrod;
_ctrl.TitleLB.IconColor = Color.Goldenrod;
_ctrl.TitleLB.IconChar = FontAwesome.Sharp.IconChar.Spinner;

if (_lastRsp)
{
_ctrl.StatusLB.ForeColor = Color.DarkGray;
_ctrl.StatusLB.Text = "Command Executed Successfully...";
_ctrl.TitleLB.ForeColor = Color.DarkGreen;
_ctrl.TitleLB.IconColor = Color.Goldenrod;
_ctrl.TitleLB.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
_ctrl.StartBT.Enabled = false;
}

_prevChar = _rsp.Last();
_prevStr = _rsp;
})));

            UpdateBT.Click -= ConnectingRoutine;
            UpdateBT.Click += UpdatingRoutine;
        }

        private List<Task<ServerUpdateProgressBar>> CommandsControls()
        {
            var T_List = new List<Task<ServerUpdateProgressBar>>();
            int _srno = 1;
            foreach (var i in MyList_Of_Commands)
            {
                T_List.Add(Task.Run(() =>
                    {
                        int _index = MyList_Of_Commands.IndexOf(new Tuple<string, string>(i.Item1, i.Item2));
                        var _ctrl = new ServerUpdateProgressBar(i.Item1, _index + 1, Conversions.ToChar(i.Item2)) { Title = i.Item1 };
                        _ctrl.TitleLB.IconChar = FontAwesome.Sharp.IconChar.Pause;
                        _ctrl.StatusLB.Visible = false;

                        _ctrl.StartBT.Click += async () =>
    {
                            if (UpdateBT.Enabled == false)
                                return;
                            _ctrl.StartBT.Enabled = false;
                            await Task.Run(() => RunCommand(_ctrl.Cmd, Conversions.ToInteger(_ctrl.TagData), _ctrl.ExpectedChar));
                        };
                        _ctrl.StartBT.EnabledChanged += () => _ctrl.StartBT.BackColor = Color.DarkGray;
                        return _ctrl;
                    }));
                _srno += 1;
            }
            return T_List;
        }

        private async void UpdatingRoutine(object sender, EventArgs e)
        {

            UpdateBT.Enabled = false;

            await Task.Run(() =>
                {
                    Invoke(new Action(() => { foreach (var i in FlowLayoutPanel1.Controls) { if (ReferenceEquals(i.GetType(), typeof(ServerUpdateProgressBar))) { ServerUpdateProgressBar _ctrl = (ServerUpdateProgressBar)i; _ctrl.StatusLB.Visible = true; } } }));
                    return true;
                });

            int _srno = 0;

            foreach (var i in MyList_Of_Commands)
            {
                _srno += 1;
                ServerUpdateProgressBar _ctrl = (ServerUpdateProgressBar)FlowLayoutPanel1.Controls.Find($"cmd_{_srno}", true)[0];
                if (!_ctrl.StartBT.Enabled)
                    continue;
                _ctrl.StartBT.Enabled = false;
                await Task.Run(() => RunCommand(_ctrl.Cmd, Conversions.ToInteger(_ctrl.TagData), _ctrl.ExpectedChar));
            }

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox1.SelectionStart = RichTextBox1.Text.Length;
            RichTextBox1.SelectionLength = 0;
            RichTextBox1.ScrollToCaret();
        }

        public event NewResponeEventHandler NewRespone;

        public delegate void NewResponeEventHandler(string _rsp, int _tag, bool _lastRsp);

        public void RunCommand(string cmdi, int _tag, char expectedChar = '$')
        {
            ShellStream.WriteLine(cmdi);

            var reader = new StreamReader(ShellStream);

            while (true)
            {

                string asd = ShellStream.ReadLine(new TimeSpan(0, 0, 3));
                if (asd is not null)
                {
                    string _filteredText = "";

                    string symbols = @"`~!@#$%^&*()-_=+[{]}\|;:''""<,>.?/";

                    foreach (char i in asd)
                    {

                        if (char.IsLetterOrDigit(i) | symbols.Contains(Conversions.ToString(i)) | char.IsWhiteSpace(i))
                        {
                            _filteredText += Conversions.ToString(i);
                        }
                    }

                    NewRespone?.Invoke(_filteredText, _tag, false);
                    NewRespone?.Invoke(Constants.vbNewLine, _tag, false);
                }
                else
                {
                    break;
                }
            }

            string qwe = " ";

            while (qwe.Last() != expectedChar)
            {
                qwe = ShellStream.Read().Trim();
                if (qwe is not null && !string.IsNullOrEmpty(qwe))
                {
                    NewRespone?.Invoke(qwe, _tag, true);
                }
                // RichTextBox1.AppendText(qwe)
                else
                {
                    qwe = " ";
                }
            }

        }

        private void LogoffBT_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Disconnect();
                Client.Dispose();
                MessageBox.Show("Server Logged Off Successfully", "Confrimation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            }
        }

        private void ServerUpdateForm_Closed(object sender, EventArgs e)
        {
            LogoffBT_Click(LogoffBT, EventArgs.Empty);
        }

    }
}
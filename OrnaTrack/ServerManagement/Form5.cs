using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Renci.SshNet;

namespace FirstApp
{

    // Public Class Form5

    // Dim client As SshClient

    // Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    // Dim host = "3.16.198.57"
    // Dim username = "ec2-user"
    // Dim password = "tapus123"

    // client = New SshClient(host, username, password)
    // client.Connect()

    // client.CreateShellStream("dumb", 80, 24, 800, 600, 1024)



    // End Sub

    // Private Sub ClearBT_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
    // DisplayTB.Text = ""
    // CmdTB.Text = ""
    // CmdTB.Select()
    // End Sub

    // Private Sub RunBT_Click(sender As Object, e As EventArgs) Handles RunBT.Click
    // RunCommand(CmdTB.Text)
    // End Sub

    // Private Sub CmdTB_KeyDown(sender As Object, e As KeyEventArgs) Handles CmdTB.KeyDown
    // If e.KeyCode = Keys.Enter Then
    // RunBT_Click(sender, e)
    // End If
    // End Sub


    // Private Sub RunCommand(cmdi As String)
    // Dim cmd = client.CreateCommand(cmdi)
    // Dim result = cmd.BeginExecute()

    // Using reader = New StreamReader(cmd.OutputStream, Encoding.UTF8, True, 1024, True)

    // While Not result.IsCompleted OrElse Not reader.EndOfStream
    // Dim line As String = reader.ReadLine()

    // If line IsNot Nothing Then
    // DisplayTB.Invoke(Sub()
    // DisplayTB.AppendText($"{line}{Environment.NewLine}")
    // End Sub)
    // End If
    // End While
    // End Using

    // Using reader = New StreamReader(cmd.ExtendedOutputStream, Encoding.UTF8, True, 1024, True)

    // While Not result.IsCompleted OrElse Not reader.EndOfStream
    // Dim line As String = reader.ReadLine()

    // If line IsNot Nothing Then
    // DisplayTB.Invoke(Sub()
    // DisplayTB.AppendText($"{line}{Environment.NewLine}")
    // End Sub)
    // End If
    // End While
    // End Using


    // cmd.EndExecute(result)



    // End Sub


    // End Class


    internal partial class Form5
    {

        public string host { get; set; } = "3.16.198.57";
        public string username { get; set; } = "ec2-user";
        public string password { get; set; } = "tapus123";

        public static SshClient client { get; set; }
        public ShellStream shellStream { get; set; }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {

                client = new SshClient(host, username, password);
                client.Connect();
                // Dim reply As String = String.Empty
                shellStream = client.CreateShellStream("dumb", 80U, 24U, 800U, 600U, 1024);
            }
            // reply = shellStream.Expect(New Regex(":.*>#"), New TimeSpan(0, 0, 3))

            // ShellRunner("date")


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {


                // shellStream.WriteLine(cmdi)
                // RichTextBox1.AppendText(shellStream.Read())


                // Dim totalLines As Integer = RichTextBox1.Lines.Length
                // inputTo = RichTextBox1.Lines(totalLines - 2)
                // ShellRunner(inputTo.Split("$")(1).Trim)
            }
        }
        private void StartBT_Click(object sender, EventArgs e)
        {
            RichTextBox1.AppendText(shellStream.Read());
        }

        private void RunCommand(string cmdi, char expectedChar = '$')
        {
            shellStream.WriteLine(cmdi);

            var reader = new StreamReader(shellStream);

            while (true)
            {

                string asd = shellStream.ReadLine(new TimeSpan(0, 0, 3));

                if (asd is not null)
                {

                    string _filteredText = "";
                    char _prev = Conversions.ToChar("");

                    string symbols = @"`~!@#$%^&*()-_=+[{]}\|;:''""<,>.?/";

                    foreach (char i in asd)
                    {

                        if (char.IsLetterOrDigit(i) | symbols.Contains(Conversions.ToString(i)) | char.IsWhiteSpace(i))
                        {
                            _filteredText += Conversions.ToString(i);
                        }
                    }

                    RichTextBox1.AppendText(_filteredText);
                    RichTextBox1.AppendText(Constants.vbNewLine);
                }
                else
                {
                    break;
                }
            }

            string qwe = " ";

            while (qwe.Last() != expectedChar)
            {
                qwe = shellStream.Read().Trim();
                if (qwe is not null && !string.IsNullOrEmpty(qwe))
                {
                    RichTextBox1.AppendText(qwe);
                }
                else
                {
                    qwe = " ";
                }
            }

        }

        private void RunBT_Click(object sender, EventArgs e)
        {
            RunCommand(CmdTB.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // RunCommand("sudo yum -y update")
            // RunCommand("cp -r MyNode_Application/whatsapp-web.js/.wwebjs_auth MyNode_Application")
            RunCommand("cd MyNode_Application");
            RunCommand("rm -rf whatsapp-web.js");
            RunCommand("ls -a");
            RunCommand("git clone https://github.com/pedroslopez/whatsapp-web.js.git");

            var _client = new SftpClient(host, username, password);
            _client.Connect();
            if (client.IsConnected)
            {
                RichTextBox1.AppendText($"{Constants.vbNewLine}Sftp Client Connected......");
            }

            var _fileStream = new FileStream(@"C:\Users\hp\Desktop\ServerMain.mjs", FileMode.Open);
            _client.UploadFile(_fileStream, "/home/ec2-user/MyNode_Application/whatsapp-web.js/ServerMain.mjs");
            RunCommand("cd whatsapp-web.js");
            RunCommand("ls -a");
            RunCommand("sudo npm cache clean -f");
            RunCommand("sudo npm install -g n");
            RunCommand("sudo n stable");
            RunCommand("sudo su", '#');
            RunCommand("npm install -g npm", '#');
            RunCommand("npm --version", '#');
            RunCommand("exit");
            // tmux new -d -s my_session "bash --init-file <(node ServerMain.js)"
            RunCommand("npm install");
            foreach (var i in "fs-extra,is-online-emitter".Split(','))
                RunCommand($"npm install {i}");
            RunCommand("ls -a");
            RunCommand("cd");
            RunCommand("cp -r MyNode_Application/.wwebjs_auth MyNode_Application/whatsapp-web.js");
            RunCommand("cd MyNode_Application/whatsapp-web.js");
            RunCommand("ls -a");
            // RunCommand("node ServerMain.js")
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox1.SelectionStart = RichTextBox1.Text.Length;
            RichTextBox1.SelectionLength = 0;
            RichTextBox1.ScrollToCaret();
        }
    }
}


// Dim _client As New SftpClient(host, username, password)
// _client.Connect()
// If client.IsConnected Then
// RichTextBox1.AppendText($"{vbNewLine}Sftp Client Connected......")
// End If

// Dim _fileStream As New FileStream("C:\Users\hp\Desktop\testapp101.accdb", FileMode.Open)
// _client.UploadFile(_fileStream, "/home/ec2-user/test.accdb")

// Using _output As FileStream = File.Create("C:\Users\hp\Desktop\test.accdb")
// _client.DownloadFile("/home/ec2-user/test.accdb", _output)
// End Using

// _client.Disconnect()
// _client.Dispose()
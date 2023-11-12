using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class sqlcommandtester
    {
        private StreamWriter writer;
        private Process oprocess = new Process();
        public string value;

        public sqlcommandtester()
        {
            InitializeComponent();
        }

        private void Frmsimple_disposed(object sender, EventArgs e)
        {
            var p = new Process();
            var pi = new ProcessStartInfo()
            {
                Arguments = " /k" + " " + Interaction.Command() + "taskkill /im python.exe /f",
                FileName = "cmd.exe",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            p.StartInfo = pi;
            p.Start();
        }

        private void Initialiseprocess()
        {
            string s = "";
            try
            {
                s = File.ReadAllLines(@"c:\users\hp\desktop\tapustextfile.txt").ElementAt(0).ToString();
            }
            catch (Exception ex)
            {
            }
            try
            {
                oprocess = Process.GetProcessById(Conversions.ToInteger(Conversion.Int(s)));
                MessageBox.Show("using previous"); // ex as argumentexception
            }
            catch
            {
                var ostartinfo = new ProcessStartInfo(@"c:\users\hp\desktop\pycharmprojects\tapuspycharm\helo.pyw")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                oprocess.StartInfo = ostartinfo;
                oprocess.Start();
                File.WriteAllText(@"c:\users\hp\desktop\tapustextfile.txt", oprocess.Id.ToString());
            }
        }

        private void Form1_load(object sender, EventArgs e)
        {
            Initialiseprocess();
        }

        private async void Button2_click(object sender, EventArgs e)
        {
            oprocess.StandardInput.WriteLine("send");
            TextBox1.Text = await oprocess.StandardOutput.ReadLineAsync();
        }
    }
}
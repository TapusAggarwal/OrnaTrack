using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace FirstApp
{


    public partial class Form7
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            var client = new Ssh();
            string output = client.Execute("ls");
        }
    }

    public class Log
    {
        public static void Verbose(string message)
        {
            Console.WriteLine(message);
        }

        public static void Error(string message)
        {
            Console.WriteLine(message);
        }
    }

    static class StringExt
    {
        public static string StringBeforeLastRegEx(this string str, Regex regex)
        {
            var matches = regex.Matches(str);
            return matches.Count > 0 ? str.Substring(0, matches[matches.Count - 1].Index) : str;
        }

        public static bool EndsWithRegEx(this string str, Regex regex)
        {
            var matches = regex.Matches(str);
            return matches.Count > 0 && str.Length == matches.Count - 1 + matches[matches.Count - 1].Length;
        }

        public static string StringAfter(this string str, string substring)
        {
            int index = str.IndexOf(substring, StringComparison.Ordinal);
            return index >= 0 ? str.Substring(index + substring.Length) : "";
        }

        public static string[] GetLines(this string str)
        {
            return Regex.Split(str, Constants.vbCrLf + "|" + Constants.vbCr + "|" + Constants.vbLf);
        }
    }

    static class UtilExt
    {
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> func)
        {
            foreach (var item in sequence)
                func(item);
        }
    }

    public class Ssh
    {
        private SshClient sshClient;
        private ShellStream shell;
        private string pwd = "tapus123";
        private string lastCommand = "";
        private static Regex prompt = new Regex(@"[a-zA-Z0-9_.-]*\@[a-zA-Z0-9_.-]*\:\~[#$] ", RegexOptions.Compiled);
        private static Regex pwdPrompt = new Regex(@"password for .*\:", RegexOptions.Compiled);
        private static Regex promptOrPwd = new Regex(prompt.ToString() + "|" + pwdPrompt.ToString());

        public void Connect()
        {
            string host = "3.16.198.57";
            string username = "ec2-user";
            string password = "tapus123";

            sshClient = new SshClient(host, username, password);
            sshClient.Connect();
            var terminalMode = new Dictionary<TerminalModes, uint>();
            terminalMode.Add(TerminalModes.ECHO, 53U);
            shell = sshClient.CreateShellStream("", 0U, 0U, 0U, 0U, 4096, terminalMode);

            try
            {
                Expect(prompt);
            }
            catch (Exception ex)
            {
                Log.Error("Exception - " + ex.Message);
                throw;
            }
        }

        public void Disconnect()
        {
            Log.Verbose($"Ssh Disconnect");
            sshClient?.Disconnect();
            sshClient = null;
        }

        private void Write(string commandLine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Log.Verbose("> " + commandLine);
            Console.ResetColor();
            lastCommand = commandLine;
            shell.WriteLine(commandLine);
        }

        private string Expect(Regex _expect, double timeoutSeconds = 60.0d)
        {
            string result = shell.Expect(_expect, TimeSpan.FromSeconds(timeoutSeconds));

            if (result is null)
            {
                throw new Exception($"Timeout {timeoutSeconds}s executing {lastCommand}");
            }

            result = result.Contains(lastCommand) ? result.StringAfter(lastCommand) : result;
            result = result.StringBeforeLastRegEx(prompt);
            result = result.Trim();
            result.GetLines().ForEach(x => Log.Verbose(x));
            return result;
        }

        public string Execute(string commandLine, double timeoutSeconds = 30.0d)
        {
            Exception exception = null;
            string result = "";
            string errorMessage = "failed";
            string errorCode = "exception";

            try
            {
                Write(commandLine);
                result = Expect(promptOrPwd);

                if (result.EndsWithRegEx(pwdPrompt))
                {
                    Write(pwd);
                    Expect(prompt);
                }

                Write("echo $?");
                errorCode = Expect(prompt);

                if (errorCode == "0")
                {
                    return result;
                }
                else if (result.Length > 0)
                {
                    errorMessage = result;
                }
            }

            catch (Exception ex)
            {
                exception = ex;
                errorMessage = ex.Message;
            }

            throw new Exception($"Ssh error: {errorMessage}, code: {errorCode}, command: {commandLine}", exception);
        }
    }
}
Imports System.IO

Public Class sqlcommandtester
    Dim writer As StreamWriter
    Dim oprocess As New Process()
    Public value As String

    Private Sub Frmsimple_disposed(sender As Object, e As EventArgs) Handles Me.Disposed, Me.Closed
        Dim p = New Process()
        Dim pi = New ProcessStartInfo With {
                .Arguments = " /k" + " " + Command() + "taskkill /im python.exe /f",
                .FileName = "cmd.exe",
                .CreateNoWindow = True,
                .WindowStyle = ProcessWindowStyle.Hidden
                }
        p.StartInfo = pi
        p.Start()
    End Sub

    Private Sub Initialiseprocess()
        Dim s = ""
        Try
            s = File.ReadAllLines("c:\users\hp\desktop\tapustextfile.txt").ElementAt(0).ToString
        Catch ex As Exception
        End Try
        Try
            oprocess = Process.GetProcessById(Int(s))
            MessageBox.Show("using previous")
        Catch ' ex as argumentexception
            Dim ostartinfo As New ProcessStartInfo("c:\users\hp\desktop\pycharmprojects\tapuspycharm\helo.pyw") With {
                    .UseShellExecute = False,
                    .RedirectStandardInput = True,
                    .RedirectStandardOutput = True,
                    .RedirectStandardError = True,
                    .WindowStyle = ProcessWindowStyle.Hidden
                    }
            oprocess.StartInfo = ostartinfo
            oprocess.Start()
            File.WriteAllText("c:\users\hp\desktop\tapustextfile.txt", oprocess.Id.ToString)
        End Try
    End Sub

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialiseprocess()
    End Sub

    Private Async Sub Button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        oprocess.StandardInput.WriteLine("send")
        TextBox1.Text = Await oprocess.StandardOutput.ReadLineAsync
    End Sub
End Class
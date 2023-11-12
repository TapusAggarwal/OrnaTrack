Imports System.IO

Public Class FormTester
    Dim writer As StreamWriter
    Dim oProcess As New Process()
    Public Value As String

    'Private Sub FrmSimple_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed, Me.Closed
    '    Dim p As Process = New Process()
    '    Dim pi As ProcessStartInfo = New ProcessStartInfo With {
    '        .Arguments = " /K" + " " + Command() + "TaskKill /IM python.exe /F",
    '        .FileName = "cmd.exe",
    '        .CreateNoWindow = True,
    '        .WindowStyle = ProcessWindowStyle.Hidden
    '    }
    '    p.StartInfo = pi
    '    p.Start()
    '    p.Close()
    '    p = New Process()
    '    pi = New ProcessStartInfo With {
    '        .Arguments = " /K" + " " + Command() + "TaskKill /IM chromedriver.exe /F",
    '        .FileName = "cmd.exe",
    '        .CreateNoWindow = True,
    '        .WindowStyle = ProcessWindowStyle.Hidden
    '    }
    '    p.StartInfo = pi
    '    p.Start()
    '    p.Close()
    '    p = New Process()
    '    pi = New ProcessStartInfo With {
    '        .Arguments = " /K" + " " + Command() + "TaskKill /IM chrome.exe /F",
    '        .FileName = "cmd.exe",
    '        .CreateNoWindow = True,
    '        .WindowStyle = ProcessWindowStyle.Hidden
    '    }
    '    p.StartInfo = pi
    '    p.Start()
    '    p.Close()
    '    p = New Process()
    '    pi = New ProcessStartInfo With {
    '        .Arguments = " /K" + " " + Command() + "TaskKill /IM cmd.exe /F",
    '        .FileName = "cmd.exe",
    '        .CreateNoWindow = True,
    '        .WindowStyle = ProcessWindowStyle.Hidden
    '    }
    '    p.StartInfo = pi
    '    p.Start()
    '    p.Close()
    'End Sub

    Private Async Sub InitialiseProcess()
        'Dim s As String = ""
        'Try
        '    s = File.ReadAllLines("C:\Users\hp\Desktop\TapusTextFile.txt").ElementAt(0).ToString
        'Catch ex As Exception
        'End Try
        'Try
        '    oProcess = Process.GetProcessById(Int(s))
        '    MessageBox.Show("Using Previous")
        'Catch ' ex As ArgumentException
        Dim oStartInfo As New ProcessStartInfo("python.exe", "C:\Users\hp\Desktop\PycharmProjects\TapusPycharm\helo.pyw") With {
                .UseShellExecute = False,
                .RedirectStandardInput = True,
                .RedirectStandardOutput = True,
                .RedirectStandardError = True,
                .CreateNoWindow = True
                }

        'Dim oStartInfo As New ProcessStartInfo("C:\Users\hp\Desktop\PycharmProjects\TapusPycharm\helo.pyw") With {
        '    .WindowStyle = ProcessWindowStyle.Hidden,
        '    .CreateNoWindow = True
        '}

        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        File.WriteAllText("C:\Users\hp\Desktop\Bills\123.txt", "send")
        'Await Task.Delay(5000)
        'While True
        '    Dim x As String = File.ReadAllText("C:\Users\hp\Desktop\output.txt")
        '    MessageBox.Show("Output.txt:- " & x)
        '    If x = "Ready" Then Exit While
        '    Await Task.Delay(5000)
        'End While
        'PictureBox1.Image = Image.FromFile("C:\Users\hp\Desktop\screen.png")
        'PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        'Await Task.Delay(2000)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiseProcess()
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As String = oProcess.StandardOutput.ReadLine
        If res = "Ready" Then
            MessageBox.Show("Web Ready")
        End If
        Dim x As Integer = 0
        While True
            x += 1
            oProcess.StandardInput.WriteLine("send1234")
            res = oProcess.StandardOutput.ReadLine
            MessageBox.Show(res)
            If res = "scan" Then
                PictureBox1.Image = Image.FromFile("C:\Users\hp\Desktop\screen.png")
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                Await Task.Delay(2000)
                Label1.Text = x
            ElseIf res = "Logged In" Then
                MessageBox.Show("Exit")
                Exit While
            End If
        End While
    End Sub

    Private Async Sub AddImage()
        MessageBox.Show("Adding")
        PictureBox1.Image = Image.FromFile("C:\Users\hp\Desktop\photos\IMG_20210613_131135.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Await Task.Delay(5000)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddImage()
    End Sub
End Class
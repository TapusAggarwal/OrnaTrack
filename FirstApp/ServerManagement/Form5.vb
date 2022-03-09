Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports Renci.SshNet

'Public Class Form5

'    Dim client As SshClient

'    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        Dim host = "3.16.198.57"
'        Dim username = "ec2-user"
'        Dim password = "tapus123"

'        client = New SshClient(host, username, password)
'        client.Connect()

'        client.CreateShellStream("dumb", 80, 24, 800, 600, 1024)



'    End Sub

'    Private Sub ClearBT_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
'        DisplayTB.Text = ""
'        CmdTB.Text = ""
'        CmdTB.Select()
'    End Sub

'    Private Sub RunBT_Click(sender As Object, e As EventArgs) Handles RunBT.Click
'        RunCommand(CmdTB.Text)
'    End Sub

'    Private Sub CmdTB_KeyDown(sender As Object, e As KeyEventArgs) Handles CmdTB.KeyDown
'        If e.KeyCode = Keys.Enter Then
'            RunBT_Click(sender, e)
'        End If
'    End Sub


'    Private Sub RunCommand(cmdi As String)
'        Dim cmd = client.CreateCommand(cmdi)
'        Dim result = cmd.BeginExecute()

'        Using reader = New StreamReader(cmd.OutputStream, Encoding.UTF8, True, 1024, True)

'            While Not result.IsCompleted OrElse Not reader.EndOfStream
'                Dim line As String = reader.ReadLine()

'                If line IsNot Nothing Then
'                    DisplayTB.Invoke(Sub()
'                                         DisplayTB.AppendText($"{line}{Environment.NewLine}")
'                                     End Sub)
'                End If
'            End While
'        End Using

'        Using reader = New StreamReader(cmd.ExtendedOutputStream, Encoding.UTF8, True, 1024, True)

'            While Not result.IsCompleted OrElse Not reader.EndOfStream
'                Dim line As String = reader.ReadLine()

'                If line IsNot Nothing Then
'                    DisplayTB.Invoke(Sub()
'                                         DisplayTB.AppendText($"{line}{Environment.NewLine}")
'                                     End Sub)
'                End If
'            End While
'        End Using


'        cmd.EndExecute(result)



'    End Sub


'End Class


Class Form5

    Public Property host As String = "3.16.198.57"
    Public Property username As String = "ec2-user"
    Public Property password As String = "tapus123"

    Public Shared Property client As SshClient
    Public Property shellStream As ShellStream

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            client = New SshClient(host, username, password)
            client.Connect()
            'Dim reply As String = String.Empty
            shellStream = client.CreateShellStream("dumb", 80, 24, 800, 600, 1024)
            'reply = shellStream.Expect(New Regex(":.*>#"), New TimeSpan(0, 0, 3))

            'ShellRunner("date")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If e.KeyChar = ChrW(13) Then


            'shellStream.WriteLine(cmdi)
            'RichTextBox1.AppendText(shellStream.Read())


            'Dim totalLines As Integer = RichTextBox1.Lines.Length
            'inputTo = RichTextBox1.Lines(totalLines - 2)
            'ShellRunner(inputTo.Split("$")(1).Trim)
        End If
    End Sub
    Private Sub StartBT_Click(sender As Object, e As EventArgs) Handles StartBT.Click
        RichTextBox1.AppendText(shellStream.Read())
    End Sub

    Private Sub RunCommand(cmdi As String, Optional expectedChar As Char = "$")
        shellStream.WriteLine(cmdi)

        Dim reader As New StreamReader(shellStream)

        While True

            Dim asd = shellStream.ReadLine(New TimeSpan(0, 0, 3))

            If asd IsNot Nothing Then

                Dim _filteredText As String = ""
                Dim _prev As Char = ""

                Dim symbols As String = "`~!@#$%^&*()-_=+[{]}\|;:''""<,>.?/"

                For Each i As Char In asd

                    If Char.IsLetterOrDigit(i) Or symbols.Contains(i) Or Char.IsWhiteSpace(i) Then
                        _filteredText += i
                    End If
                Next

                RichTextBox1.AppendText(_filteredText)
                RichTextBox1.AppendText(vbNewLine)
            Else
                Exit While
            End If
        End While

        Dim qwe As String = " "

        While qwe.Last <> expectedChar
            qwe = shellStream.Read().Trim
            If qwe IsNot Nothing AndAlso qwe <> "" Then
                RichTextBox1.AppendText(qwe)
            Else
                qwe = " "
            End If
        End While

    End Sub

    Private Sub RunBT_Click(sender As Object, e As EventArgs) Handles RunBT.Click
        RunCommand(CmdTB.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'RunCommand("sudo yum -y update")
        'RunCommand("cp -r MyNode_Application/whatsapp-web.js/.wwebjs_auth MyNode_Application")
        RunCommand("cd MyNode_Application")
        RunCommand("rm -rf whatsapp-web.js")
        RunCommand("ls -a")
        RunCommand("git clone https://github.com/pedroslopez/whatsapp-web.js.git")

        Dim _client As New SftpClient(host, username, password)
        _client.Connect()
        If client.IsConnected Then
            RichTextBox1.AppendText($"{vbNewLine}Sftp Client Connected......")
        End If

        Dim _fileStream As New FileStream("C:\Users\hp\Desktop\ServerMain.mjs", FileMode.Open)
        _client.UploadFile(_fileStream, "/home/ec2-user/MyNode_Application/whatsapp-web.js/ServerMain.mjs")
        RunCommand("cd whatsapp-web.js")
        RunCommand("ls -a")
        RunCommand("sudo npm cache clean -f")
        RunCommand("sudo npm install -g n")
        RunCommand("sudo n stable")
        RunCommand("sudo su", "#")
        RunCommand("npm install -g npm", "#")
        RunCommand("npm --version", "#")
        RunCommand("exit")
        'tmux new -d -s my_session "bash --init-file <(node ServerMain.js)"
        RunCommand("npm install")
        For Each i In "fs-extra,is-online-emitter".Split(",")
            RunCommand($"npm install {i}")
        Next
        RunCommand("ls -a")
        RunCommand("cd")
        RunCommand("cp -r MyNode_Application/.wwebjs_auth MyNode_Application/whatsapp-web.js")
        RunCommand("cd MyNode_Application/whatsapp-web.js")
        RunCommand("ls -a")
        'RunCommand("node ServerMain.js")
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.SelectionStart = RichTextBox1.Text.Length
        RichTextBox1.SelectionLength = 0
        RichTextBox1.ScrollToCaret()
    End Sub
End Class


'Dim _client As New SftpClient(host, username, password)
'_client.Connect()
'If client.IsConnected Then
'    RichTextBox1.AppendText($"{vbNewLine}Sftp Client Connected......")
'End If

'Dim _fileStream As New FileStream("C:\Users\hp\Desktop\testapp101.accdb", FileMode.Open)
'_client.UploadFile(_fileStream, "/home/ec2-user/test.accdb")

'Using _output As FileStream = File.Create("C:\Users\hp\Desktop\test.accdb")
'    _client.DownloadFile("/home/ec2-user/test.accdb", _output)
'End Using

'_client.Disconnect()
'_client.Dispose()
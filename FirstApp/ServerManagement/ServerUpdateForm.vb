Imports System.IO
Imports Renci.SshNet

Public Class ServerUpdateForm

    Public Property Host As String = "3.16.198.57"
    Public Property Username As String = "ec2-user"
    Public Property Password As String = "tapus123"

    Public Shared Property Client As SshClient
    Public Property ShellStream As ShellStream

    Public Property MyList_Of_Commands As New List(Of Tuple(Of String, String))

    Private Sub ServerUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FlowLayoutPanel1.Controls.Clear()

        UpdateBT.Enabled = True
        UpdateBT.BackColor = Color.FromArgb(0, 114, 0)
        UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Clock
        UpdateBT.Text = "Login"
        UpdateBT.Location = New Point(14, 14)
        UpdateBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 94, 0)
        UpdateBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 124, 0)

        AddHandler UpdateBT.Click, AddressOf LoginRoutine

        'sudo lsof -i tcp:3966
        'kill -9 {PID}

        'AddCommand("sudo yum -y update", "$")
        'AddCommand("cd MyNode_Application", "$")
        'AddCommand("rm -rf whatsapp-web.js", "$")
        'AddCommand("git clone https://github.com/pedroslopez/whatsapp-web.js.git", "$")
        'AddCommand("cd whatsapp-web.js", "$")
        'AddCommand("sudo npm cache clean -f", "$")
        'AddCommand("sudo npm install -g n", "$")
        'AddCommand("sudo n stable", "$")
        'AddCommand("sudo su", "#")
        'AddCommand("npm install -g npm", "#")
        'AddCommand("npm --version", "#")
        'AddCommand("exit", "$")
        'AddCommand("npm install", "$")
        'For Each i In "fs-extra,is-online-emitter".Split(",")
        '    AddCommand($"npm install {i}", "$")
        'Next
        'AddCommand("cd", "$")
        'AddCommand("cp -r MyNode_Application/ServerMain.mjs MyNode_Application/whatsapp-web.js/", "$")
        AddCommand("cd MyNode_Application/whatsapp-web.js", "$")
        AddCommand("tmux kill-server", "$")
        AddCommand("tmux new -d -s my_session ""bash --init-file <(node ServerMain.mjs)""", "$")
    End Sub

    Public Sub AddCommand(_str As String, _symbl As String)
        MyList_Of_Commands.Add(New Tuple(Of String, String)(_str, _symbl))
    End Sub

    Private Async Sub LoginRoutine(sender As Object, e As EventArgs)
        UpdateBT.Enabled = False
        UpdateBT.BackColor = Color.Goldenrod
        UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Spinner
        UpdateBT.Text = "Logging In..."
        UpdateBT.Location = New Point(0, 14)

        'Logging Sequence
        Await Task.Run(Sub()
                           LoginToServer()
                       End Sub)


        'MessageBox.Show("Succesfully Logged In To Server. Press 'Connect' To Continue.", "Step 1. Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RemoveHandler UpdateBT.Click, AddressOf LoginRoutine
        AddHandler UpdateBT.Click, AddressOf ConnectingRoutine
    End Sub


    Private Function LoginToServer() As Boolean
        Try
            Client = New SshClient(Host, Username, Password)
            Client.Connect()
            ShellStream = Client.CreateShellStream("dumb", 80, 24, 800, 600, 1024)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Invoke(Sub()
                   UpdateBT.Enabled = True
                   UpdateBT.BackColor = Color.FromArgb(0, 114, 0)
                   UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Link
                   UpdateBT.Text = "Connect"
                   UpdateBT.Location = New Point(14, 14)
               End Sub)
        Return True
    End Function

    Private Async Sub ConnectingRoutine(sender As Object, e As EventArgs)
        UpdateBT.Enabled = False
        UpdateBT.BackColor = Color.Goldenrod
        UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Spinner
        UpdateBT.Text = "Connecting..."
        UpdateBT.Location = New Point(0, 14)

        'Connecting Sequence
        Await Task.Run(Sub()
                           Dim x As String = ShellStream.Read()
                           Invoke(Async Sub()
                                      RichTextBox1.AppendText(x)
                                      Dim T_List = CommandsControls()
                                      If T_List IsNot Nothing AndAlso T_List.Count Then
                                          Dim res = Await Task.WhenAll(T_List)
                                          FlowLayoutPanel1.Controls.Clear()
                                          Dim _srno As Integer = 0
                                          For Each i In res
                                              _srno += 1
                                              i.SrNo = _srno
                                              i.Name = $"cmd_{_srno}"
                                              FlowLayoutPanel1.Controls.Add(i)
                                          Next
                                      End If
                                  End Sub)

                       End Sub)

        UpdateBT.Enabled = True
        UpdateBT.BackColor = Color.FromArgb(0, 114, 0)
        UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Upload
        UpdateBT.Text = "Update Server"
        UpdateBT.Location = New Point(14, 14)

        'MessageBox.Show("Succesfully Connected To Server. Press 'Update Server' To Continue.", "Step 2. Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RemoveHandler UpdateBT.Click, AddressOf ConnectingRoutine
        AddHandler UpdateBT.Click, AddressOf UpdatingRoutine
    End Sub

    Private Function CommandsControls() As List(Of Task(Of ServerUpdateProgressBar))
        Dim T_List As New List(Of Task(Of ServerUpdateProgressBar))
        For Each i In MyList_Of_Commands
            T_List.Add(Task.Run(Function()
                                    Dim _ctrl As New ServerUpdateProgressBar With {
                                        .Title = i.Item1
                                    }
                                    _ctrl.TitleLB.IconChar = FontAwesome.Sharp.IconChar.Pause
                                    _ctrl.StatusLB.Visible = False

                                    Return _ctrl
                                End Function))
        Next
        Return T_List
    End Function

    Private Async Sub UpdatingRoutine(sender As Object, e As EventArgs)
        'Try

        UpdateBT.Enabled = False

        Await Task.Run(Function()
                           Invoke(Sub()
                                      For Each i In FlowLayoutPanel1.Controls
                                          If i.GetType() Is GetType(ServerUpdateProgressBar) Then
                                              Dim _ctrl As ServerUpdateProgressBar = i
                                              _ctrl.StatusLB.Visible = True
                                          End If
                                      Next
                                  End Sub)
                           Return True
                       End Function)

        Dim _srno As Integer = 1
        Dim _prevChar As Char = ""
        Dim _prevStr As String = ""

        For Each i In MyList_Of_Commands
            AddHandler NewRespone, Async Sub(_rsp As String, _tag As Integer, _lastRsp As Boolean)
                                       Await Task.Run(Sub()
                                                          Invoke(Sub()
                                                                     If _rsp = "" Or _rsp = _prevStr Then Exit Sub
                                                                     If Char.IsWhiteSpace(_rsp.Last()) AndAlso _prevChar = _rsp.Last() Then Exit Sub

                                                                     Dim _ctrl As ServerUpdateProgressBar = FlowLayoutPanel1.Controls.Find($"cmd_{_tag}", True)(0)

                                                                     RichTextBox1.AppendText(_rsp)
                                                                     If Not Char.IsWhiteSpace(_rsp) Then
                                                                         For Each _str In _rsp.Split(vbCr)
                                                                             If _str = "" Then Continue For
                                                                             _ctrl.StatusLB.Text = _str
                                                                         Next
                                                                     End If

                                                                     _ctrl.TitleLB.ForeColor = Color.Goldenrod
                                                                     _ctrl.TitleLB.IconColor = Color.Goldenrod
                                                                     _ctrl.TitleLB.IconChar = FontAwesome.Sharp.IconChar.Spinner

                                                                     If _lastRsp Then
                                                                         _ctrl.StatusLB.ForeColor = Color.DarkGray
                                                                         _ctrl.StatusLB.Text = "Command Executed Successfully..."
                                                                         _ctrl.TitleLB.ForeColor = Color.DarkGreen
                                                                         _ctrl.TitleLB.IconColor = Color.Goldenrod
                                                                         _ctrl.TitleLB.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
                                                                     End If

                                                                     _prevChar = _rsp.Last()
                                                                     _prevStr = _rsp
                                                                 End Sub)
                                                      End Sub)
                                   End Sub
            Await Task.Run(Sub()
                               RunCommand(i.Item1, _srno, i.Item2)
                           End Sub)
            _srno += 1
        Next
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.SelectionStart = RichTextBox1.Text.Length
        RichTextBox1.SelectionLength = 0
        RichTextBox1.ScrollToCaret()
    End Sub

    Public Event NewRespone(_rsp As String, _tag As Integer, _lastRsp As Boolean)

    Private Sub RunCommand(cmdi As String, _tag As Integer, Optional expectedChar As Char = "$")
                                                                             ShellStream.WriteLine(cmdi)

        Dim reader As New StreamReader(ShellStream)

        While True

            Dim asd = ShellStream.ReadLine(New TimeSpan(0, 0, 3))
            If asd IsNot Nothing Then
                Dim _filteredText As String = ""

                Dim symbols As String = "`~!@#$%^&*()-_=+[{]}\|;:''""<,>.?/"

                For Each i As Char In asd

                    If Char.IsLetterOrDigit(i) Or symbols.Contains(i) Or Char.IsWhiteSpace(i) Then
                        _filteredText += i
                    End If
                Next

                RaiseEvent NewRespone(_filteredText, _tag, False)
                RaiseEvent NewRespone(vbNewLine, _tag, False)
            Else
                Exit While
            End If
        End While

        Dim qwe As String = " "

        While qwe.Last <> expectedChar
            qwe = ShellStream.Read().Trim
            If qwe IsNot Nothing AndAlso qwe <> "" Then
                RaiseEvent NewRespone(qwe, _tag, True)
                'RichTextBox1.AppendText(qwe)
            Else
                qwe = " "
            End If
        End While

    End Sub

End Class
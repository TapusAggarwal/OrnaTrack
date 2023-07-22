Imports FontAwesome.Sharp
Imports Newtonsoft.Json.Linq
Imports Squirrel
Imports WebSocket4Net

Public Class Frame

    Dim qrData As String = Nothing

    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (hWnd As IntPtr, nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200

    Dim manager As UpdateManager

    Protected Overrides ReadOnly Property createParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

#Region "Me.Load"
    Private Async Sub Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Fade in when started
        Me.Opacity = 0
        Dim tmr As New Timer With {
                .Interval = 2
                }
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity += 0.1
                                 If Me.Opacity = 1 Then tmr.Stop()
                             End Sub

        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                c.BackColor = Color.DimGray
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width += 1
                Exit For
            End If
        Next
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                'got the control, so cast it
                Dim mdiClientControl = DirectCast(ctl, MdiClient)
                'undock it
                mdiClientControl.Dock = DockStyle.None
                'resize it
                mdiClientControl.Bounds = Me.ClientRectangle
                mdiClientControl.Height += 20
                mdiClientControl.Width += 20
                'set the anchors
                mdiClientControl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or
                                          AnchorStyles.Top

                'bail out
                Exit For
            End If
        Next

        InitaliseConnection()
        Try : myconnection.Open() : Catch : End Try

        WindowState = FormWindowState.Maximized
        QuickSearchButton_Click(QuickSearchButton, e)
        KeyPreview = True

        Try
            manager = Await UpdateManager.GitHubUpdateManager("https://github.com/TapusAggarwal/Test_App")
            VersionLB.Text = manager.CurrentlyInstalledVersion().ToString()
            VersionLB.Visible = True
            Dim updateInfo = Await manager.CheckForUpdate()
            If updateInfo.ReleasesToApply.Count <= 0 Then
                VersionLB.IconColor = Color.White
            Else
                VersionLB.Text = "New Update"
                VersionLB.IconColor = Color.Goldenrod
            End If
        Catch ex As Exception
        End Try

    End Sub
#End Region

#Region "Server"
    Async Function StartServer(isFresh As Boolean) As Task
        Dim rawresponse As String = Nothing

        Try
            Dim dict As New Dictionary(Of String, String) From {{"purpose", "test"}}
            rawresponse = Await ServerHttpRequest(dict)
        Catch ex As Exception
        End Try

        If rawresponse = "true" Then
            state = "STANDBY"
            InitialiseStates()

            Dim dict As New Dictionary(Of String, String) From {{"purpose", "state"}}
            rawresponse = Await ServerHttpRequest(dict)
            If rawresponse = "NOTCONNECTED" Or rawresponse = "DISCONNECTED" Then
                dict = New Dictionary(Of String, String) From {
                {"purpose", "new_web"},
                {"headless", "true"},
                {"ignorePrevious", If(isFresh, "true", "false")}
                }
                rawresponse = Await ServerHttpRequest(dict)
                If rawresponse <> "started" Then MessageBox.Show("Unable To Perform The Action: '" & rawresponse & "'")
            ElseIf rawresponse <> "CONNECTED" And rawresponse <> "qr" And rawresponse <> "STANDBY" And rawresponse <> "OPENING" And rawresponse <> "PAIRING" Then
                dict = New Dictionary(Of String, String) From {{"purpose", "close"}}
                rawresponse = Await ServerHttpRequest(dict)
                Await StartServer(True)
            End If

            Dim url = $"ws://{My.Settings.connection_url}"
            WebSocket = New WebSocket(url)
            AddHandler WebSocket.Opened, Sub(s, Eventargs) SocketOpened(s, Eventargs)
            AddHandler WebSocket.Error, Sub(s, Eventargs) SocketError(s, Eventargs)
            AddHandler WebSocket.Closed, Sub(s, Eventargs) SocketClosed(s, Eventargs)
            AddHandler WebSocket.MessageReceived, Sub(s, Eventargs) SocketMessage(s, Eventargs)
            AddHandler WebSocket.DataReceived, Sub(s, Eventargs) SocketDataReceived(s, Eventargs)
            WebSocket.Open()
        Else
            MessageBox.Show($"Unable To Get A Response From Server. Either Server Is Not Running Or Server Address Is Not Correct.{vbNewLine}Make Sure Server Is Running And Address Provided Is Correct.", "Server Not Responding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Function

    Sub SocketOpened(s As Object, e As EventArgs)
        state = "STANDBY"
        InitialiseStates()
    End Sub

    Sub SocketClosed(s As Object, e As EventArgs)
        state = "NOTCONNECTED"
        InitialiseStates()
        Try
            RemoveHandler WebSocket.Opened, AddressOf SocketOpened
            RemoveHandler WebSocket.Closed, AddressOf SocketClosed
            RemoveHandler WebSocket.MessageReceived, AddressOf SocketMessage
            RemoveHandler WebSocket.DataReceived, AddressOf SocketDataReceived
        Catch ex As Exception
        End Try
    End Sub

    Sub SocketError(s As Object, e As SuperSocket.ClientEngine.ErrorEventArgs)
        If e.Exception.Message = "HTTP/1.0 200 OK" Then
            MessageBox.Show($"Server Error: Possibly unable to start the server {e.Exception.Message}")
        Else
            MessageBox.Show("Server Error: " + e.Exception.Message)
        End If
    End Sub

    Sub SocketDataReceived(s As Object, e As DataReceivedEventArgs)
        MsgBox("Message From Server This Must Be Informed To The Developer: " + e.ToString)
    End Sub

    Async Sub SocketMessage(sender As Object, e As MessageReceivedEventArgs)
        'Try
        Dim recievedData_string As String = e.Message.ToString
        Dim recievedData As JObject = JObject.Parse(recievedData_string)
        Dim msgInfo As JObject = recievedData.SelectToken("msgInfo")
        Dim clientInfo As JObject = recievedData.SelectToken("clientInfo")
        Dim oldState = state
        state = recievedData.SelectToken("serverState")

        If msgInfo.SelectToken("purpose") = "connection_welcome_msg" Then
            Invoke(Sub()
                       UserPhNo.Text = clientInfo.SelectToken("phoneno")
                   End Sub)
        End If

        If state = "qr" Then

            If msgInfo.SelectToken("msg").ToString.Length > 1 Then
                Dim fm As QrCodeView = Nothing

                For Each _form As Form In Application.OpenForms
                    If TypeOf _form IsNot QrCodeView Then Continue For
                    fm = _form
                    Exit For
                Next

                qrData = msgInfo.SelectToken("msg")
                If fm IsNot Nothing Then
                    Invoke(Sub()
                               fm.QrNew(msgInfo.SelectToken("msg"))
                           End Sub)
                End If
            End If

        End If

        If msgInfo.SelectToken("purpose") = "reconnect" Then
            WebSocket.Close()
            Await StartServer(True)
        End If

        If state = "CONNECTED" Then
            Invoke(Sub()
                       UserPhNo.Text = clientInfo.SelectToken("phoneno").ToString
                   End Sub)
        End If

        InitialiseStates()

        If msgInfo.SelectToken("purpose") = "new_msg" Then
            RaiseEvent NewMessage_Socket()
        End If

        If oldState <> state Then
            RaiseEvent State_Changed(state, oldState)
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Public Event NewMessage_Socket()
    Public Event State_Changed(newState As String, oldState As String)


    Public Sub InitialiseStates()

        Dim fm As RecieptMessenger = Nothing
        Dim forms As FormCollection = Application.OpenForms
        For Each form As Form In forms
            If TypeOf form Is RecieptMessenger Then
                fm = form
                Exit For
            End If
        Next
        If fm IsNot Nothing Then
            Invoke(Sub()
                       fm.ServerCall(state)
                   End Sub)
        End If

        If state = "STANDBY" Then
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.Spinner
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "Connecting..."
                                       ConnectionLabel.ForeColor = Color.Olive
                                       UserPhNo.Visible = False
                                   End Sub)
            Exit Sub
        End If

        If state = "CONNECTED" Then
            ConnectionLabel.Invoke(Sub()

                                       For Each _form As Form In Application.OpenForms
                                           If TypeOf _form IsNot QrCodeView Then Continue For
                                           Invoke(Sub()
                                                      _form.Close()
                                                  End Sub)
                                           Exit For
                                       Next

                                       ConnectionLabel.IconChar = IconChar.Whatsapp
                                       ConnectionLabel.IconColor = Color.SeaGreen
                                       ConnectionLabel.Text = $"Connected"
                                       ConnectionLabel.ForeColor = Color.SeaGreen
                                       UserPhNo.Visible = True
                                   End Sub)
            Exit Sub
        End If

        If state = "offline" Then
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.ExclamationTriangle
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "Device Offline"
                                       ConnectionLabel.ForeColor = Color.Red
                                       UserPhNo.Visible = False
                                   End Sub)
            Exit Sub
        End If
        If state = "qr" Then
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.Qrcode
                                       ConnectionLabel.ImageAlign = ContentAlignment.MiddleCenter
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "QrCode"
                                       UserPhNo.Visible = False
                                       ConnectionLabel.ForeColor = Color.Olive
                                   End Sub)
            Exit Sub
        Else
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.ExclamationTriangle
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "Not Connected"
                                       UserPhNo.Visible = False
                                       ConnectionLabel.ForeColor = Color.Red
                                   End Sub)
            Exit Sub
        End If
    End Sub

    Public Async Sub ConnectionLabel_Click(sender As Object, e As EventArgs) Handles ConnectionLabel.Click
        If state = "STANDBY" Then
            Exit Sub
        End If
        If state = "qr" Then
            If qrData IsNot Nothing Then
                QrCodeView.Tag = qrData
                QrCodeView.Show()
            End If
            Exit Sub
        End If

        Try
            If Not WebSocket.State = WebSocketState.Closed AndAlso Not WebSocket.State = WebSocketState.Closing Then
                WebSocket.Close()
            End If
            RemoveHandler WebSocket.Opened, AddressOf SocketOpened
            RemoveHandler WebSocket.Closed, AddressOf SocketClosed
            RemoveHandler WebSocket.MessageReceived, AddressOf SocketMessage
            RemoveHandler WebSocket.DataReceived, AddressOf SocketDataReceived
        Catch ex As Exception
        End Try
        Await StartServer(False)

    End Sub

#Region "Tool Strip Methods"

    Private Sub WhatsappWebVisibilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsappWebVisibilityToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show($"Currently Visible:{If(My.Settings.server_headless = True, "False", "True")}.{vbNewLine}Do You Want To Turn Visiblity To: {If(My.Settings.server_headless = True, "On", "Off")}.{If(My.Settings.server_headless = True, $"{vbNewLine}Note: Press 'Yes' Only If Machine On Which Server Is Running Is Capable Of Displaying Content.", "")}", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub
        My.Settings.server_headless = Not My.Settings.server_headless
    End Sub

    Private Sub NotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationToolStripMenuItem.Click
        Exit Sub
        If sender.Text.Split(":")(1).Trim = "Turned On" Then
            Dim ans As Integer = MessageBox.Show("This Selection Will Turn Of Whatsapp Web Notifications. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = 7 Then Exit Sub
            sender.Text = "Notifications: Turned Off"
            My.Settings.server_notify = False
            ServerContextMenuStrip.Show()
        Else
            Dim ans As Integer = MessageBox.Show("This Selection Will Turn On Whatsapp Web Notifications. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = 7 Then Exit Sub
            sender.Text = "Notifications: Turned On"
            ServerContextMenuStrip.Show()
        End If
    End Sub

    Private Async Sub RestartServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartServerToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show("This Selection Will Force Restart The Server i.e All Previous Sessions Will Be Lost And You Have To Scan Whatsapp QR Code Again. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub

        Await StartServer(True)

    End Sub

    Private Sub CloseServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseServerToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show("This Selection Will Close The Server. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub
        Dim dict As New Dictionary(Of String, String) From {{"purpose", "close"}}
        ServerHttpRequest(dict)
        state = "NOTCONNECTED"
        InitialiseStates()
    End Sub

    Private Sub CleanAllSessionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanAllSessionsToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show("This Selection Will Clean All The Sessions, Including The Existing Session. Do You Still Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub
        Dim CleanerBat As New Process()
        Dim info As New ProcessStartInfo With {
                .FileName = "C:\Users\hp\source\repos\TapusAggarwal\FirstApp-ReBuild\FirstApp\whatsapp-web.js-main\ServerClear.bat"
        }
        CleanerBat.StartInfo = info
        CleanerBat.Start()
    End Sub

    Private Sub ChangeServerAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeServerAddressToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show("This Selection Will Allow You To Change Server Address, Do You Want To Continue.", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub
        Dim newAddress As String = InputBox($"Enter New Address Which Will Be Used To Send All Http Requests.{vbNewLine}Connection Format -> 'Address:Port'.{vbNewLine}Current Address->'{My.Settings.connection_url}'.{vbNewLine}(Enter Correct Address To Avoid Future Errors.)", "New Server Address")
        If newAddress.Length <> 0 Then
            My.Settings.connection_url = newAddress.Trim
        End If
    End Sub

    Private Async Sub TestConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestConnectionToolStripMenuItem.Click
        Dim rawresponse As String = "false"
        Try
            Dim dict As New Dictionary(Of String, String) From {{"purpose", "test"}}
            rawresponse = Await ServerHttpRequest(dict)
        Catch ex As Exception
        End Try
        If rawresponse <> "false" AndAlso Not String.IsNullOrEmpty(rawresponse) Then
            MessageBox.Show($"The Server Is Responding Appropriately. All Good!!", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("The Server Is Not Responding Appropriately. SomeThing Went Wrong", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UpdateServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateServerToolStripMenuItem.Click
        Dim Fm As New ServerUpdateForm
        Fm.ShowDialog()
    End Sub

#End Region

#End Region

    Public Sub New()
        InitializeComponent()
        DoubleBuffered = True
        'Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Public Sub QuickSearchButton_Click(sender As Object, e As EventArgs) Handles QuickSearchButton.Click
        If Main.IsMdiChild Then
            Main.Activate()
        Else
            Make_MdiChild(Main, Nothing)
        End If
        SidePanel()
    End Sub

    Public Sub NewCoustmerButton_Click() Handles NewCoustmerButton.Click
        For Each i As Form In MdiChildren
            If i.Name <> "Main" Then
                i.Dispose()
            End If
        Next
        Dim Fm As New CoustProfileUpdated With {
            .MdiParent = Me,
            .Dock = DockStyle.Fill,
            .Tag = Tag
        }
        Fm.Show()
    End Sub

    Private Sub LeftArrowButton_Click(sender As Object, e As EventArgs) Handles LeftArrowButton.Click, RightArrowButton.Click
        'If Main Is ActiveMdiChild Then CoustProfileUpdated.Activate() Else Main.Activate()
        SendKeys.SendWait("^{Tab}")
    End Sub

    Private Sub SendMessageButton_Click(sender As Object, e As EventArgs) Handles SendMessageButton.Click
        SidePanel()
    End Sub

    Private Sub SidePanelButton_Click(sender As Object, e As EventArgs) Handles SidePanelButton.Click
        SidePanel(True)
    End Sub

    Private Sub SidePanel(Optional click = False)
        If Not PanelMenu.Visible And click Then
            PanelMenu.Visible = True
        Else
            PanelMenu.Visible = False
        End If
    End Sub

#Region "All KeyDown Events Ex.-Ctrl+S"
    Private Sub Frame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Control And e.KeyCode = Keys.N Then
                NewCoustmerButton_Click()
                Exit Sub
            End If
            If e.Control And e.KeyCode = Keys.Q Then
                QuickSearchButton_Click(QuickSearchButton, e)
                Main.NameTB.Select()
                Exit Sub
            End If
            If e.Control And e.KeyCode = Keys.R Then
                'Form2.Show()
            End If
            If e.Control And e.KeyCode = Keys.B Then
                If ActiveMdiChild Is Main Then
                    BookMode.Show()
                End If
            End If
            If e.Control And e.KeyCode = Keys.M Then
                If ActiveMdiChild() Is Main Then
                    BulkMessagesEntryForm.Show()
                End If
            End If
            If e.Control And e.KeyCode = Keys.E Then
                If ActiveMdiChild() Is Main Then
                    Graph.Show()
                End If
            End If
            If e.Control And e.KeyCode = Keys.D Then
                If ActiveMdiChild() Is Main Then
                    Dim Fm As New ImageDownloader
                    Fm.Show()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

    Private Sub IconCurrentForm_Click(sender As Object, e As EventArgs)
        Close()
        'If Not WantToContinue("Do You Want To Put system on sleep.", "Confirm") Then Exit Sub
        'Application.SetSuspendState(PowerState.Suspend, True, False)
    End Sub

    Private Sub Frame_MdiChildActivate() Handles Me.MdiChildActivate
        Dim ButtonsOreientaion As New Threading.Thread(Sub()
                                                           Invoke(Sub()
                                                                      If MdiChildren.Count <= 1 Then
                                                                          LeftArrowButton.ForeColor = Color.Black
                                                                          LeftArrowButton.Enabled = False
                                                                          RightArrowButton.ForeColor = Color.Black
                                                                          RightArrowButton.Enabled = False
                                                                          Exit Sub
                                                                      End If
                                                                      If ActiveMdiChild Is Main Then
                                                                          RightArrowButton.ForeColor = Color.LightGreen
                                                                          RightArrowButton.Enabled = True
                                                                          LeftArrowButton.ForeColor = Color.Black
                                                                          LeftArrowButton.Enabled = False
                                                                      Else
                                                                          LeftArrowButton.ForeColor = Color.LightGreen
                                                                          LeftArrowButton.Enabled = True
                                                                          RightArrowButton.ForeColor = Color.Black
                                                                          RightArrowButton.Enabled = False
                                                                      End If
                                                                  End Sub)
                                                       End Sub) With {
            .IsBackground = True,
            .Priority = Threading.ThreadPriority.AboveNormal
                                                                          }
        ButtonsOreientaion.Start()
    End Sub

    Public Sub Make_MdiChild(Fm As Form, Tag As Object)
        Try
            For Each ExistingFm As Form In MdiChildren
                If ExistingFm Is Fm Then
                    ExistingFm.Dispose()
                End If
            Next
            Fm.MdiParent = Me
            Fm.Tag = Tag
            Fm.Dock = DockStyle.Fill
            Fm.Show()
            'make_thread.Abort()
        Catch ex As Exception
            MessageBox.Show($"Error: (Make_MdiChild/Frame)-> {ex.Message}")
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub WindowsRestoreButton_Click(sender As Object, e As EventArgs) Handles WindowsRestoreButton.Click
        If WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            WindowsRestoreButton.IconChar = IconChar.WindowRestore
            Refresh()
            For Each fm As Form In MdiChildren
                fm.Refresh()
            Next
        Else
            Me.WindowState = FormWindowState.Normal
            WindowsRestoreButton.IconChar = IconChar.WindowMaximize
            Me.Location = New Point(0, 0)
            Refresh()
            For Each fm As Form In MdiChildren
                fm.Refresh()
            Next
        End If
        [Select]()
    End Sub

    Private Sub WindowsMinimizeButton_Click(sender As Object, e As EventArgs) Handles WindowsMinimizeButton.Click
        WindowState = FormWindowState.Minimized
        [Select]()
    End Sub

    Private Sub Frame_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Refresh()
        For Each fm As Form In MdiChildren
            fm.Refresh()
        Next
    End Sub

    Private Sub GoldButton_Click(sender As Object, e As EventArgs)
        Dim fm As New MainStockPage
        fm.Show()
    End Sub

    Private Sub SilverButton_Click(sender As Object, e As EventArgs) Handles SilverButton.Click
        Dim fm_trns As New AllTransactionsForm
        fm_trns.Size = New Point(fm_trns.Width, 10000)
        AddHandler fm_trns.AddTransactionButton_Clicked, Sub()
                                                             Dim fm As New TransactionDetailsForm
                                                             fm.CurrentTransaction = New Transaction(-1)
                                                             fm.ShowDialog()
                                                         End Sub
        fm_trns.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim fm As New PaymentReport
        fm.ShowDialog()
    End Sub

    Private Async Sub IconButton2_Click(sender As Object, e As EventArgs) Handles VersionLB.Click
        Cursor = Cursors.AppStarting
        VersionLB.Visible = False
        ProgressBar1.Visible = True
        Try
            Dim updateInfo = Await manager.CheckForUpdate()
            ProgressBar1.Value = 0
            If updateInfo.ReleasesToApply.Count > 0 Then

                Await manager.UpdateApp(Sub(f)
                                            ProgressBar1.Value = f
                                        End Sub)
                MessageBox.Show("Updated Succesfully. Close The Application To See The New Changes.", "Task Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            End If
        Catch ex As Exception

            MessageBox.Show($"While Updating The Application Error Occured: {ex.Message}", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        VersionLB.Visible = True
        ProgressBar1.Visible = False
        Cursor = Cursors.Default
    End Sub

    Private Sub RoughButton_Click(sender As Object, e As EventArgs) Handles RoughButton.Click
        Dim Fm As New MainStockPage
        Fm.ShowDialog()
    End Sub

    Private Sub ImageDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageDownloadToolStripMenuItem.Click
        Dim Fm As New ImageDownloader
        Fm.ShowDialog()
    End Sub

    Private Sub ServerContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ServerContextMenuStrip.Opening

    End Sub

    Private Sub IconButton2_Click_1(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim Fm As New rough1
        Fm.ShowDialog()
    End Sub
End Class
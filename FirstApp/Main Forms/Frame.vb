Imports FontAwesome.Sharp
Imports WebSocket4Net
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class Frame

    Dim qrData As String = Nothing

    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (hWnd As IntPtr, nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200

    Protected Overrides ReadOnly Property createParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

#Region "Me.Load"
    Private Sub Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'If My.Settings.server_headless Then
        '    WhatsappWebVisibilityToolStripMenuItem.Text = "WhatsappWeb: Hidden"
        'Else
        '    WhatsappWebVisibilityToolStripMenuItem.Text = "WhatsappWeb: Visible"
        'End If
        'Dim x1 As Threading.Thread = New Threading.Thread(Async Sub()
        '                                                      Await StartServer(True)
        '                                                  End Sub) With {
        '    .Priority = Threading.ThreadPriority.Lowest
        '                                                  }
        'x1.Start()

        'Form2.Show()

    End Sub
#End Region

    Async Function StartServer(fresh As Boolean) As Task
        Dim server_path As String = "C:\Users\hp\source\repos\TapusAggarwal\FirstApp-ReBuild\FirstApp\whatsapp-web.js-main\Server.vbs"
        Dim rawresponse As String = Nothing

        Try
            Dim dict As New Dictionary(Of String, String) From {{"purpose", "test"}}
            rawresponse = ServerHttpRequest(dict)
        Catch ex As Exception
        End Try

        If rawresponse = "true" Then
            Dim dict As New Dictionary(Of String, String) From {{"purpose", "state"}}
            rawresponse = ServerHttpRequest(dict)
            If rawresponse <> "NOTCONNECTED" And rawresponse <> "OPENING" And rawresponse <> "PAIRING" And rawresponse <> "CONNECTED" Then
                dict = New Dictionary(Of String, String) From {{"purpose", "close"}}
                rawresponse = ServerHttpRequest(dict)

                Dim p = New Process()
                Dim pi = New ProcessStartInfo With {
                .FileName = server_path}
                p.StartInfo = pi
                p.Start()
                Await StartServer(True)
            ElseIf rawresponse = "NOTCONNECTED" Then
                dict = New Dictionary(Of String, String) From {
                {"purpose", "new_web"},
                {"headless", IIf(My.Settings.server_headless, "true", "false")},
                {"ignorePrevious", "false"},
                {"createNewWebBol", "true"}
                }
                rawresponse = ServerHttpRequest(dict)
                If rawresponse <> "started" Then MessageBox.Show("Unable To Perform The Action: '" & rawresponse & "'")
            End If

            Dim url = "ws://localhost:3966"
            WebSocket = New WebSocket(url)
            AddHandler WebSocket.Opened, Sub(s, Eventargs) SocketOpened(s, Eventargs)
            AddHandler WebSocket.Error, Sub(s, Eventargs) SocketError(s, Eventargs)
            AddHandler WebSocket.Closed, Sub(s, Eventargs) SocketClosed(s, Eventargs)
            AddHandler WebSocket.MessageReceived, Sub(s, Eventargs) SocketMessage(s, Eventargs)
            AddHandler WebSocket.DataReceived, Sub(s, Eventargs) SocketDataReceived(s, Eventargs)
            WebSocket.Open()
        Else
            Dim p = New Process()
            Dim pi = New ProcessStartInfo With {
                .FileName = server_path}
            '.WindowStyle = ProcessWindowStyle.Hidden,
            '.CreateNoWindow = True
            '}
            p.StartInfo = pi
            p.Start()
            Await StartServer(fresh:=True)
        End If

    End Function

    Sub SocketOpened(s As Object, e As EventArgs)
    End Sub

    Sub SocketClosed(s As Object, e As EventArgs)
        state = "NOTCONNECTED"
        InitialiseStates()
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

#Region "Socket Messages"

    Async Sub SocketMessage(s As Object, e As MessageReceivedEventArgs)
        'Try
        Dim recievedData_string As String = e.Message.ToString
        Dim recievedData As JObject = JObject.Parse(recievedData_string)
        Dim msgInfo As JObject = recievedData.SelectToken("msgInfo")
        Dim clientInfo As JObject = recievedData.SelectToken("clientInfo")
        state = recievedData.SelectToken("serverState").ToString

        InitialiseStates()
        If msgInfo.SelectToken("purpose") = "connection_welcome_msg" Then
            BatteryUpdate(clientInfo.SelectToken("battery").ToString, clientInfo.SelectToken("plugged").ToString)
        End If

        If state = "qr" Then
            If msgInfo.SelectToken("msg").ToString.Length > 1 Then
                Dim fm As QrCodeView = Nothing
                Dim forms As FormCollection = Application.OpenForms
                For Each form As Form In forms
                    If TypeOf form Is QrCodeView Then
                        fm = form
                        Exit For
                    End If
                Next
                qrData = msgInfo.SelectToken("msg")
                If fm IsNot Nothing Then
                    Invoke(Sub()
                               fm.QrNew(msgInfo.SelectToken("msg"))
                           End Sub)
                End If
                Exit Sub
            End If
        End If
        If msgInfo.SelectToken("purpose") = "state changed" Then
            If state = "CONNECTED" Then
                Dim fm As QrCodeView = Nothing
                Dim forms As FormCollection = Application.OpenForms
                For Each form As Form In forms
                    If TypeOf form Is QrCodeView Then
                        fm = form
                        Exit For
                    End If
                Next
                If fm IsNot Nothing Then
                    Invoke(Sub()
                               fm.Close()
                           End Sub)
                End If
                BatteryUpdate(clientInfo.SelectToken("battery").ToString, clientInfo.SelectToken("plugged").ToString)
            Else
                InitialiseStates()
            End If
        ElseIf msgInfo.SelectToken("purpose") = "new_msg" Then
            MessageBox.Show(msgInfo.SelectToken("msg"))
        ElseIf msgInfo.SelectToken("purpose") = "reconnect" Then
            WebSocket.Close()
            Await StartServer(True)
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

#End Region

#Region "BatteryUpdate"

    Public Sub BatteryUpdate(battery As String, plugged As Boolean)
        Try
            If battery <> "" Then
                BatteryStatus.Invoke(Sub()
                                         BatteryStatus.Visible = True
                                         BatteryStatus.Text = battery + "%"
                                         With BatteryStatus
                                             If plugged = "True" Then
                                                 .IconChar = IconChar.ChargingStation
                                                 .IconColor = Color.Green
                                                 .ForeColor = Color.Green
                                             Else
                                                 If battery >= 75 Then
                                                     .IconChar = IconChar.BatteryFull
                                                     .IconColor = Color.Green
                                                     .ForeColor = Color.Green
                                                 ElseIf battery < 75 And battery > 50 Then
                                                     .IconChar = IconChar.BatteryThreeQuarters
                                                     .IconColor = Color.Green
                                                     .ForeColor = Color.Green
                                                 ElseIf battery <= 50 And battery > 25 Then
                                                     .IconChar = IconChar.BatteryHalf
                                                     .IconColor = Color.Goldenrod
                                                     .ForeColor = Color.Goldenrod
                                                 ElseIf battery <= 25 Then
                                                     .IconChar = IconChar.BatteryQuarter
                                                     .IconColor = Color.Maroon
                                                     .ForeColor = Color.Maroon
                                                 End If
                                             End If
                                         End With
                                         BatteryStatus.Visible = True
                                     End Sub)
            End If
        Catch
        End Try 'Battery Percentage
    End Sub

#End Region

    Public Sub InitialiseStates()

        Dim fm As Messenger = Nothing
        Dim forms As FormCollection = Application.OpenForms
        For Each form As Form In forms
            If TypeOf form Is Messenger Then
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
            Dim local_state As String = Nothing
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.Spinner
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "Connecting..."
                                       ConnectionLabel.ForeColor = Color.Olive
                                       BatteryStatus.Visible = False
                                       Dim dict As New Dictionary(Of String, String) From {{"purpose", "state"}}
                                       local_state = ServerHttpRequest(dict)
                                       If local_state = "CONNECTED" Then state = local_state
                                   End Sub)
            If local_state <> "CONNECTED" Then
                Exit Sub
            End If
        End If

        If state = "CONNECTED" Then
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.Whatsapp
                                       ConnectionLabel.IconColor = Color.SeaGreen
                                       ConnectionLabel.Text = $"Connected"
                                       ConnectionLabel.ForeColor = Color.SeaGreen
                                       BatteryStatus.Visible = True
                                   End Sub)
            Exit Sub
        End If
        If state = "offline" Then
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.ExclamationTriangle
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "Device Offline"
                                       ConnectionLabel.ForeColor = Color.Red
                                       BatteryStatus.Visible = False
                                   End Sub)
            Exit Sub
        End If
        If state = "qr" Then
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.Qrcode
                                       ConnectionLabel.ImageAlign = ContentAlignment.MiddleCenter
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "QrCode"
                                       BatteryStatus.Visible = False
                                       ConnectionLabel.ForeColor = Color.Olive
                                   End Sub)
            Exit Sub
        Else
            ConnectionLabel.Invoke(Sub()
                                       ConnectionLabel.IconChar = IconChar.ExclamationTriangle
                                       ConnectionLabel.IconColor = Color.Goldenrod
                                       ConnectionLabel.Text = "Not Connected"
                                       BatteryStatus.Visible = False
                                       ConnectionLabel.ForeColor = Color.Red
                                   End Sub)
            Exit Sub
        End If
    End Sub

    Private Async Sub ConnectionLabel_Click() Handles ConnectionLabel.Click
        If state = "qr" Then
            If qrData IsNot Nothing Then
                QrCodeView.Tag = qrData
                QrCodeView.Show()
            End If
            Exit Sub
        End If
        ConnectionLabel.IconChar = IconChar.Spinner
        ConnectionLabel.IconColor = Color.Goldenrod
        ConnectionLabel.Text = "Reconnecting..."
        ConnectionLabel.ForeColor = Color.Olive
        Try
            WebSocket.Close()
            Await Task.Delay(1000)
            WebSocket.Open()
        Catch ex As Exception
        End Try
    End Sub

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
                Report.Show()
            End If
            If e.Control And e.KeyCode = Keys.B Then
                BookMode.Show()
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
        Me.Select()
    End Sub

    Private Sub WindowsMinimizeButton_Click(sender As Object, e As EventArgs) Handles WindowsMinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Select()
    End Sub

    Private Sub Frame_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Refresh()
        For Each fm As Form In MdiChildren
            fm.Refresh()
        Next
    End Sub

    Private Sub WhatsappWebVisibilityToolStripMenuItem_Click(sender As ToolStripMenuItem, e As EventArgs) Handles WhatsappWebVisibilityToolStripMenuItem.Click
        If sender.Text.Split(":")(1).Trim = "Hidden" Then
            Dim ans As Integer = MessageBox.Show("This Selection Will Re-Open Whatsapp Web In Visible Mode. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = 7 Then Exit Sub
            sender.Text = "WhatsappWeb: Visible"
            My.Settings.server_headless = False
            ServerContextMenuStrip.Show()
        Else
            Dim ans As Integer = MessageBox.Show("This Selection Will Re-Open Whatsapp Web In Hidden Mode. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = 7 Then Exit Sub
            sender.Text = "WhatsappWeb: Hidden"
            My.Settings.server_headless = True
            ServerContextMenuStrip.Show()
        End If
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

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show("This Selection Will Restart The Server. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub

        Dim server_path As String = "C:\Users\hp\source\repos\TapusAggarwal\FirstApp-ReBuild\FirstApp\whatsapp-web.js-main\Server.vbs"

        Dim p = New Process()
        Dim pi = New ProcessStartInfo With {
                .FileName = server_path}
        '.WindowStyle = ProcessWindowStyle.Hidden,
        '.CreateNoWindow = True
        '}
        p.StartInfo = pi
        p.Start()

        Dim dict = New Dictionary(Of String, String) From {
                {"purpose", "new_web"},
                {"headless", IIf(My.Settings.server_headless, "true", "false")},
                {"ignorePrevious", "true"},
                {"createNewWebBol", "true"}
                }
        Dim rawresponse = ServerHttpRequest(dict)
        If rawresponse <> "started" Then MessageBox.Show($"Unable To Perform The Action: '{rawresponse}'")

        Dim url = "ws://localhost:3966"
        WebSocket = New WebSocket(url)
        AddHandler WebSocket.Opened, Sub(s, Eventargs) SocketOpened(s, Eventargs)
        AddHandler WebSocket.Error, Sub(s, Eventargs) SocketError(s, Eventargs)
        AddHandler WebSocket.Closed, Sub(s, Eventargs) SocketClosed(s, Eventargs)
        AddHandler WebSocket.MessageReceived, Sub(s, Eventargs) SocketMessage(s, Eventargs)
        AddHandler WebSocket.DataReceived, Sub(s, Eventargs) SocketDataReceived(s, Eventargs)
        WebSocket.Open()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show("This Selection Will Close The Server. Do You Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub
        Dim dict As New Dictionary(Of String, String) From {{"purpose", "close"}}
        ServerHttpRequest(dict)
        state = "NOTCONNECTED"
        InitialiseStates()
    End Sub

    Private Sub CleanPreviousSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanPreviousSessionToolStripMenuItem.Click
        Dim ans As Integer = MessageBox.Show("This Selection Will Clean All The Sessions, Including The Existing Session. Do You Still Want To Continue?", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 7 Then Exit Sub
        Dim CleanerBat As New Process()
        Dim info As New ProcessStartInfo With {
                .FileName = "C:\Users\hp\source\repos\TapusAggarwal\FirstApp-ReBuild\FirstApp\whatsapp-web.js-main\ServerClear.bat"
        }
        CleanerBat.StartInfo = info
        CleanerBat.Start()
    End Sub

End Class
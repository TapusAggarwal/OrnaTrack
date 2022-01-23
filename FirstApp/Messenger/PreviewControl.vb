Public Class PreviewControl

    Private _status As String = "NotSent"
    Private _enabled As Boolean = True

    Public Overloads Property Enabled As Boolean
        Get
            Return _enabled
        End Get
        Set(value As Boolean)
            If value Then
                Panel1.Enabled = True
                Label1.Enabled = True
                CloseButton.BackColor = Color.FromArgb(65, 0, 0)
                CloseButton.FlatAppearance.MouseDownBackColor = Color.Red
                CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 0, 0)
                CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times
            Else
                Panel1.Enabled = False
                Label1.Enabled = False
                CloseButton.BackColor = Color.FromArgb(0, 65, 0)
                CloseButton.FlatAppearance.MouseDownBackColor = Color.Green
                CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 90, 0)
                CloseButton.IconChar = FontAwesome.Sharp.IconChar.Check
            End If
            _enabled = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(updatedStatus As String)
            If updatedStatus = "NotSent" Then Exit Property

            StatusLB.Visible = True
            Select Case updatedStatus
                Case "fail"
                    StatusLB.Text = $"+91{PhNo}: Failed"
                    StatusLB.ForeColor = Color.Red
                    SendBT.Text = "Retry"
                    SendBT.IconChar = FontAwesome.Sharp.IconChar.RedoAlt
                    SendBT.Enabled = True
                Case "Sending"
                    StatusLB.Text = $"+91{PhNo}: Sending.."
                    StatusLB.ForeColor = Color.Goldenrod
                    SendBT.Text = "Wait"
                    SendBT.IconChar = FontAwesome.Sharp.IconChar.Spinner
                    SendBT.Enabled = False
                Case "pass"
                    StatusLB.Text = $"+91{PhNo}: Sent"
                    StatusLB.ForeColor = Color.Green
                    SendBT.Text = "Done"
                    SendBT.IconChar = FontAwesome.Sharp.IconChar.Check
                    SendBT.Enabled = False
                Case Else
                    StatusLB.Text = $"+91{PhNo}: {updatedStatus}"
                    StatusLB.ForeColor = Color.Red
                    SendBT.Text = "Retry"
                    SendBT.IconChar = FontAwesome.Sharp.IconChar.RedoAlt
                    SendBT.Enabled = True
            End Select
            _status = updatedStatus
        End Set
    End Property

    Public Property PhNo As String

    Public WriteOnly Property PreviewText As String
        Set(value As String)
            Label1.Text = value
            If Label1.Width > Width Then
                Size = New Size(Label1.Width, Height)
            End If
            If Label1.Height > Height Then
                Size = New Size(Width, Label1.Height + Height)
            End If
        End Set
    End Property

    Public WriteOnly Property SrNo As Integer
        Set(value As Integer)
            SrNoLB.Text = $"#{value}"
        End Set
    End Property

    Public Property CurrentKitty As Kitty

    Public Event DetailsButton_Clicked(sender As PreviewControl)

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        RaiseEvent DetailsButton_Clicked(Me)
    End Sub

    Public Event CloseBT_Clicked(sender As PreviewControl)

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        RaiseEvent CloseBT_Clicked(Me)
    End Sub

    Public Event SendBT_Clicked(sender As PreviewControl)

    Private Sub SendBT_Click(sender As Object, e As EventArgs) Handles SendBT.Click
        RaiseEvent SendBT_Clicked(Me)
    End Sub

    Public Event TestMessageClicked(sender As PreviewControl)

    Private Async Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        RaiseEvent TestMessageClicked(Me)
    End Sub
End Class

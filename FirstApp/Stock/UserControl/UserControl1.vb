Imports System.ComponentModel
Public Class UserControl1

    Private _title As String

    <Browsable(True)>
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            HeaderLB.Text = value
        End Set
    End Property

    Public Sub AddControl(_cntrl As Control)
        FlowLayoutPanel1.Controls.Add(_cntrl)
    End Sub

    Public Sub AutoReSize()
        Dim count As Integer = FlowLayoutPanel1.Controls.Count
        If count > 0 Then
            Size = New Point(0, Height + FlowLayoutPanel1.Controls(FlowLayoutPanel1.Controls.Count - 1).Height + 5)
        End If
    End Sub

End Class
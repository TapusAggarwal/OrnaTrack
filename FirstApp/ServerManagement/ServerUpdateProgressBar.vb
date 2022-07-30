﻿Public Class ServerUpdateProgressBar
    Private _title As String
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            TitleLB.Text = $"#{_srno}. {value}"
        End Set
    End Property

    Private _srno As Integer
    Public Property SrNo As Integer
        Get
            Return _srno
        End Get
        Set(value As Integer)
            _srno = value
            TitleLB.Text = $"#{value}. {_title}"
        End Set
    End Property

    Private Sub TitleLB_TextChanged(sender As Object, e As EventArgs) Handles TitleLB.TextChanged
        Dim textSize As Size = TextRenderer.MeasureText(TitleLB.Text, New Font("Century Gothic", 12.0F, FontStyle.Bold))
        Size = New Point(97 + textSize.Width, Height)
    End Sub

End Class

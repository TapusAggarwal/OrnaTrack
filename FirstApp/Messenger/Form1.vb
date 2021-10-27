Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Show(Me.Size.Width / 2, Me.Size.Height / 2)
    End Sub

    Private Sub MaturedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaturedToolStripMenuItem.Click

    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip1.Show(Me.Size.Width / 2, Me.Size.Height / 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To 10
            CheckedListBox3.Items.Add($"{i} Instalment")
        Next
    End Sub

    Private Sub CheckedListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox3.SelectedIndexChanged

    End Sub
End Class
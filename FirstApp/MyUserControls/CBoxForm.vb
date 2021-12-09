Imports System.Data.OleDb

Public Class CBoxForm
    Dim cell_loc As Integer = 0
    Dim passed_Data As New List(Of String)

    Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        TextBox6.Select()
        passed_Data = Tag
        Label1.Text = passed_Data(2)
        DataGridView1.Columns(1).HeaderText = passed_Data(1)

        Dim dr As OleDbDataReader =
                DataReader("select " & passed_Data(0) & " from CBox_Data Where (NOT (" & passed_Data(0) & " = ''))")
        While dr.Read
            Add_data(dr(0).ToString)
        End While
        dr.Close()
    End Sub

    Private Sub Add_data(Data)
        Dim num As Integer = DataGridView1.Rows.Count
        DataGridView1.Rows.Add()

        For i = 0 To num
            If DataGridView1.Rows(i).Cells(1).Value Is Nothing Then
                DataGridView1.Rows(num).Cells(1).Value = Data
                Srno_update()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Srno_update()
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub Locate_selection()
        Dim change As Integer = cell_loc
        Dim total As Integer = DataGridView1.Rows.Count

        Try
            For i = 0 To total - 1
                If DataGridView1.Rows(i).Cells(1).Selected Then
                    cell_loc = i
                    Exit For
                End If
            Next
        Catch
            cell_loc = 0
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim text As String = TextBox6.Text
        Add_data(text)
        TextBox6.Text = String.Empty
        TextBox6.Select()
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SendKeys.Send("{Tab}")
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{Tab}")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Locate_selection()
            Dim current As Integer = cell_loc
            Dim temp_dta As String = DataGridView1.Rows(current - 1).Cells(1).Value
            DataGridView1.Rows(current - 1).Cells(1).Value = DataGridView1.Rows(current).Cells(1).Value
            DataGridView1.Rows(current).Cells(1).Value = temp_dta
            DataGridView1.Rows(current - 1).Cells(1).Selected = True
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim current As Integer = cell_loc
            Dim temp_dta As String = DataGridView1.Rows(current + 1).Cells(1).Value
            DataGridView1.Rows(current + 1).Cells(1).Value = DataGridView1.Rows(current).Cells(1).Value
            DataGridView1.Rows(current).Cells(1).Value = temp_dta
            DataGridView1.Rows(current + 1).Cells(1).Selected = True

        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim check = False
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(1).Selected Then
                check = True
                Exit For
            End If
        Next

        If Not check Then
            MessageBox.Show("First Select Item To Edit!")
            Exit Sub
        End If

        Locate_selection()
        If TextBox6.TextLength = 0 Then
            DataGridView1.Rows.RemoveAt(cell_loc)
            TextBox6.Text = String.Empty
            TextBox6.Select()
            DataGridView1.Rows(cell_loc).Cells(1).Selected = False
            Srno_update()
            Exit Sub
        End If

        DataGridView1.Rows(cell_loc).Cells(1).Value = TextBox6.Text
        TextBox6.Text = String.Empty
        DataGridView1.Rows(cell_loc).Cells(1).Selected = False
        TextBox6.Select()
        Srno_update()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Locate_selection()
        Try
            TextBox6.Text = DataGridView1.Rows(cell_loc).Cells(1).Value
        Catch ex As Exception
        End Try

        Dim total As Integer = DataGridView1.Rows.Count
        Dim check = False
        For i = 0 To total - 1
            If DataGridView1.Rows(i).Cells(1).Selected Then
                check = True
                Exit For
            End If
        Next

        If Not check Then
            TextBox6.Text = String.Empty
            TextBox6.Select()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim my_str As String

        my_str = "select max(SrNo) from CBox_Data"
        Dim cmd = New OleDbCommand(my_str, myconnection)
        Dim x As OleDbDataReader
        Dim max_recod As Integer
        Try
            x = cmd.ExecuteReader()
            x.Read()
            max_recod = x(0)
            x.Close()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SqlCommand("UPDATE CBox_Data SET " & passed_Data(0) & " = Null;")
        For i = 0 To DataGridView1.Rows.Count - 1
            If i >= max_recod Then
                'MessageBox.Show("Inserting " & DataGridView1.Rows(i).Cells(1).Value.ToString)
                SqlCommand(
                    "insert into CBox_Data (" & passed_Data(0) & ") values('" &
                    DataGridView1.Rows(i).Cells(1).Value.ToString & "')")
            Else
                'MessageBox.Show("updating " & DataGridView1.Rows(i).Cells(1).Value.ToString)
                SqlCommand(
                    "update CBox_Data set " & passed_Data(0) & "='" & DataGridView1.Rows(i).Cells(1).Value.ToString &
                    "' where SrNo=" & i + 1)
            End If
        Next
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Locate_selection()
        DataGridView1.Rows.RemoveAt(cell_loc)
        Srno_update()
    End Sub
End Class
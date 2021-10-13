Imports System.Data.OleDb

Public Class KittyView

    Protected _currentCustomer As Customer

    'ENUM Dgv-> KittyView
    Enum DgvEnum
        CheckBoxColumn = 0
        SrNoColumn = 1
        KittyNoColumn = 2
        KittyTypeColumn = 3
        PendingInstalments = 4
        GivenAmountColumn = 5
        TotalAmountColumn = 6
        StatusColumn = 7
        DetailsButtonColumn = 8
        MakeEntryColumn = 9
        KittyIDColumn = 10
    End Enum

    'ENUM MessageDGv-> KittyView
    Enum MessageDgvEnum
        CheckBoxColumn = 0
        SrNoColumn = 1
        KittyNoColumn = 2
        KittyTypeColumn = 3
        PendingInstalments = 4
        GivenAmountColumn = 5
        TotalAmountColumn = 6
        StatusColumn = 7
        MessageBoxColumn = 8
        KittyIDColumn = 9
    End Enum

    'Dim CustomerId As String

    'FUNCTION:- Loads Kitty Data On To A DataGridView
    Public Sub LoadKittyData(Dgv As DataGridView)
        Dgv.Rows.Clear()
        Dim LastInstalmentList = ""
        'Try
        For Each _kitty In _currentCustomer.OwnedKitties.OrderBasedOnStatus()

            Dgv.Rows.Add()
            Dim RowNo As Integer = Dgv.Rows.Count - 1

            With Dgv.Rows(RowNo)
                .Cells(DgvEnum.KittyNoColumn).Value = _kitty.KittyNo
                .Cells(DgvEnum.KittyTypeColumn).Value = Format(Int(_kitty.KittyType), "C0")
                .Cells(DgvEnum.GivenAmountColumn).Value = Format(_kitty.GivenAmount, "C0")
                .Cells(DgvEnum.TotalAmountColumn).Value = Format(Int(_kitty.TotalAmount), "C0") &
                                                                  " + " & Format(Int(_kitty.KittyInterest), "C0")
                .Cells(DgvEnum.PendingInstalments).Value = _kitty.PendingInstalmentsInWords
                .Cells(DgvEnum.StatusColumn).Value = _kitty.Status
                If Dgv Is DgvMessage Then
                    .Cells(MessageDgvEnum.KittyIDColumn).Value = _kitty
                Else
                    .Cells(DgvEnum.KittyIDColumn).Value = _kitty
                End If
            End With

            With Dgv.Rows(RowNo).Cells(DgvEnum.PendingInstalments).Style
                If _kitty.GetInstalmentsPending >= 1 Then
                    .ForeColor = Color.Red
                Else
                    .ForeColor = Color.Green
                End If
            End With

            If _kitty.IsMatured Then
                With Dgv.Rows(RowNo)
                    .Cells(DgvEnum.CheckBoxColumn).Value = True
                    .Cells(DgvEnum.PendingInstalments).Value = String.Empty
                    .Cells(DgvEnum.CheckBoxColumn).Style.BackColor = SystemColors.Highlight
                    .Cells(DgvEnum.CheckBoxColumn).Style.ForeColor = SystemColors.Highlight
                    .Cells(DgvEnum.GivenAmountColumn).Style.BackColor = SystemColors.Highlight
                    .Cells(DgvEnum.TotalAmountColumn).Style.BackColor = SystemColors.Highlight
                    .Cells(DgvEnum.GivenAmountColumn).Style.ForeColor = Color.White
                    .Cells(DgvEnum.TotalAmountColumn).Style.ForeColor = Color.White
                End With
            End If

        Next
        'Catch ex As Exception
        '    MessageBox.Show("kittyview kittydataload error:- " & ex.Message)
        'End Try

        'SrNoUpdate(Dgv, DgvEnum.SrNoColumn)

    End Sub

    Public Sub KittyView_Load() Handles MyBase.Load
        If Tag.GetType Is GetType(List(Of String)) Then
            _currentCustomer = Tag(0)
        Else
            _currentCustomer = Tag
        End If
        LoadKittyData(DgvMain)
        'If DgvMain.Rows.Count = 1 Then
        '    Dim T_Data As New List(Of String) From {
        '            CustomerId,
        '            DgvMain.Rows(0).Cells(DgvEnum.KittyIDColumn).Value,
        '            1
        '            }
        '    Dim Fm As New KittyForm With {
        '            .CustomerId = T_Data
        '            }
        '    Fm.ShowDialog()
        '    UpdateKittyId(CustomerId)
        '    LoadKittyData(DgvMain)
        'End If
    End Sub

    ''EVENT:- ShowDetailsBUTTON MakeEntryBUTTON CLICK->(Shows KittyForm / UpdatesKittyID / ReLoadsKittyData)
    'Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMain.CellClick

    '    If e.ColumnIndex = DgvEnum.DetailsButtonColumn And e.RowIndex >= 0 Then         'EVENT-> (Show Details) Click On Dvg
    '        If Tag.GetType Is GetType(List(Of String)) Then
    '            If Tag(1) = "callback" Then
    '                For Each i As Form In Frame.MdiChildren
    '                    If i.Name = "KittyModeCoustView" Then
    '                        Dim x As KittyModeCoustView = i
    '                        x.KittyIdTB.Text = ""
    '                        x.KittyIdTB.Text = DgvMain.Rows(e.RowIndex).Cells(DgvEnum.KittyIDColumn).Value
    '                    End If
    '                Next
    '                Exit Sub
    '            End If
    '        End If
    '        Dim T_Data As New List(Of String) From {CustomerId, DgvMain.Rows(e.RowIndex).Cells(DgvEnum.KittyIDColumn).Value, 1}
    '        Dim Fm As New KittyForm With {
    '            .Tag = T_Data
    '            }
    '        Fm.ShowDialog()
    '        LoadKittyData(DgvMain)
    '        Dim Tag1 As String = Tag(1)
    '        If Tag1 <> "callback" Then
    '            For Each i As Form In Frame.MdiChildren
    '                If i.Name = "CoustProfileUpdated" Then
    '                    Dim x As CoustProfileUpdated = i
    '                    x.CoustmerIdTB_TextChanged()
    '                End If
    '            Next
    '        End If

    '    ElseIf e.ColumnIndex = DgvEnum.MakeEntryColumn And e.RowIndex >= 0 Then         'EVENT-> Make Entry Click On Dvg

    '        If DgvMain.Rows(e.RowIndex).Cells(DgvEnum.StatusColumn).Value = "Matured" Then 'Raising Error:- When Making Entry On Completed Kitty's
    '            MessageBox.Show("This Kitty Is Matured, Can't Make Entry.", "EntryError")
    '            Exit Sub
    '        ElseIf DgvMain.Rows(e.RowIndex).Cells(DgvEnum.StatusColumn).Value = "Availed" Then
    '            MessageBox.Show("This Kitty Is Already Availed, Can't Make Entry.", "EntryError")
    '            Exit Sub
    '        End If

    '        Dim drName As OleDbDataReader = DataReader("Select CName,CsName From Coustmers_Data Where SrNo=" & CustomerId)
    '        Dim CName = ""
    '        While drName.Read() : CName = drName("CName") & drName("Csname") : End While
    '        drName.Close()
    '        If _
    '            Not _
    '            WantToContinue(
    '                "Entry Of Amount " & DgvMain.Rows(e.RowIndex).Cells(DgvEnum.KittyTypeColumn).Value & " To " & CName,
    '                "Confirm") Then Exit Sub


    '        Dim dr As OleDbDataReader =
    '                DataReader(
    '                    "Select Dates,KittyType From Kitty_Data Where CoustID='" & CustomerId & "' And KittyID='" &
    '                    DgvMain.Rows(e.RowIndex).Cells(DgvEnum.KittyIDColumn).Value & "'")
    '        Dim Record = ""
    '        Dim EntryDate As String = Today.Date.ToShortDateString
    '        While dr.Read
    '            Dim LastRecord As String = "," + EntryDate + Str(dr("KittyType"))
    '            Record = dr("Dates") + LastRecord.Replace(" ", "")
    '            Exit While
    '        End While
    '        dr.Close()
    '        Try
    '            SqlCommand(
    '                "UPDATE Kitty_Data Set Dates='" & Record & "' Where CoustID='" & CustomerId & "' And KittyID='" &
    '                DgvMain.Rows(e.RowIndex).Cells(DgvEnum.KittyIDColumn).Value & "'")
    '        Catch ex As Exception
    '            MessageBox.Show("KittyView Dgv_CellClick Error:- " & ex.Message, "Error")
    '        End Try
    '        myconnection.Close()
    '        LoadKittyData(DgvMain)
    '    End If
    'End Sub

    'EVENT:- Message CheckBox Checked->(Shows Message Dgv) 
    Private Sub MarriedCheckBox_CheckedChanged(sender As CheckBox, e As EventArgs) _
        Handles MessageCheckBox.CheckedChanged
        If sender.Checked Then
            LoadKittyData(DgvMessage)
            DgvMain.Visible = False
            DgvMessage.Visible = True
        Else
            DgvMain.Visible = True
            DgvMessage.Visible = False
            ActivateButton(Activate:=False)
        End If
    End Sub

    'FUNCTION:- Activate Send Message Button
    Private Sub ActivateButton(Activate As Boolean)
        If Activate Then
            SendMessageButton.ForeColor = Color.MediumPurple
            SendMessageButton.Enabled = True
        Else
            SendMessageButton.ForeColor = Color.DimGray
            SendMessageButton.Enabled = False
        End If
    End Sub

    'EVENT:- CheckBox On Message Dgv Clicked->(Checks CheckBox / Activates Button)
    Private Sub DgvMessage_CellClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles DgvMessage.CellClick
        If e.ColumnIndex = MessageDgvEnum.MessageBoxColumn And e.RowIndex >= 0 Then
            With sender.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If .Value Then
                    .Value = False
                Else
                    .Value = True
                End If
            End With

            For i = 0 To sender.Rows.Count - 1
                If sender.Rows(i).Cells(DgvEnum.DetailsButtonColumn).Value Then
                    ActivateButton(Activate:=True)
                    Exit Sub
                End If
            Next
            ActivateButton(Activate:=False)
        End If
    End Sub

    'Private Function GetCoustmersForMessages()
    '    Dim CoustmerList As New List(Of List(Of String))
    '    For RowNo = 0 To DgvMessage.Rows.Count - 1
    '        With DgvMessage.Rows(RowNo)
    '            If .Cells(MessageDgvEnum.MessageBoxColumn).Value Then
    '                CoustmerList.Add(New List(Of String) From {CustomerId, .Cells(MessageDgvEnum.KittyIDColumn).Value})
    '            End If
    '        End With
    '    Next
    '    Return CoustmerList
    'End Function

    'Private Sub SendMessageButton_Click(sender As Object, e As EventArgs) Handles SendMessageButton.Click
    '    'If SendMessageButton.Enabled Then
    '    '    For Each Record In GetCoustmersForMessages()
    '    '    Next
    '    'End If
    '    Dim Fm As New Form
    '    Fm = GlobalKittyBillView
    '    Fm.Tag = GetCoustmersForMessages()
    '    Fm.ShowDialog()
    '    Fm.Dispose()
    '    'Dim s As String = File.ReadAllLines("C:\Users\hp\Desktop\TapusTextFile.txt").ElementAt(0).ToString
    '    'Try
    '    '    Dim x As Process = Process.GetProcessById(Int(s))
    '    '    x.Close()
    '    'Catch ex As ArgumentException
    '    '    RunCommandCom("C:\Users\hp\PycharmProjects\ChiragProject\neww.py", "/W", True)
    '    'Catch ex As Exception
    '    '    MessageBox.Show(ex.Message)
    '    'End Try
    'End Sub

    'Private Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
    '    Dim p = New Process
    '    Dim ps = New ProcessStartInfo With {
    '            .Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments,
    '            .FileName = "cmd.exe"
    '            }
    '    p.StartInfo = ps
    '    p.Start()
    '    'File.WriteAllText("C:\Users\hp\Desktop\TapusTextFile.txt", p.Id.ToString)
    'End Sub

    'Private Sub MarriedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MessageCheckBox.CheckedChanged

    'End Sub
End Class
Imports System.Data.OleDb
Imports System.Threading
Imports Newtonsoft.Json

Public Class rough

    Dim AllKitties As New List(Of Kitty)

    Dim cts As New CancellationTokenSource

    Private Async Sub rough_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Cursor = Cursors.AppStarting
        Dim dr As OleDbDataReader = DataReader("Select KittyUID From Kitty_Data")
        Dim T_List As New List(Of Task(Of Kitty))
        While dr.Read
            Dim _id = Int(dr(0))
            T_List.Add(Task.Run(Function()
                                    Return New Kitty(_id, True, True)
                                End Function))
        End While
        Dim res = Await Task.WhenAll(T_List)
        AllKitties = res.ToList
        dr.Close()

        Dim x As New Dictionary(Of Date, List(Of Kitty))
        For Each i In AllKitties.Select(Function(f) New Tuple(Of Dictionary(Of Date, Integer), Kitty)(f.Record, f))
            For Each j In i.Item1
                If x.ContainsKey(j.Key) Then
                    x(j.Key).Add(i.Item2)
                Else
                    x.Add(j.Key, New List(Of Kitty)({i.Item2}))
                End If
            Next
        Next

        Dim sorted = From pair In x
                     Order By pair.Key
        x = sorted.ToDictionary(Function(k) k.Key, Function(v) v.Value)
        Dim _dict = x.Reverse
        Dim _date As Date = _dict.First.Key

        Dim Cntrl_List As New List(Of Task(Of PerUnitTimeControl))

        Cursor = Cursors.Default

        While _date > _dict.Last.Key
            Dim _val = _date
            Cntrl_List.Add(Task.Run(Function()
                                        Dim _cntrl As New PerUnitTimeControl
                                        Dim d = _dict.Where(Function(f) f.Key.Year = _val.Year AndAlso f.Key.Month = _val.Month).ToDictionary(Function(k) k.Key, Function(v) v.Value)
                                        If d.Count = 0 Then Return Nothing
                                        _cntrl.MakeOneMonthControl(d)
                                        Return _cntrl
                                    End Function, cts.Token))
            _date = _date.AddMonths(-1)
        End While

        For Each i In Cntrl_List
            If i.IsCanceled Then Exit For
            Dim f = Await i
            If f Is Nothing Then Continue For
            FlowLayoutPanel1.Controls.Add(f)
        Next

        cts.Dispose()
        cts = Nothing

    End Sub

    Private Sub Rough_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If cts IsNot Nothing Then
            cts.Cancel()
            Dispose()
        End If
    End Sub

    Private Sub PreviewCustomers_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'MessageBox.Show(FlowLayoutPanel1.VerticalScroll.Value)
        FlowLayoutPanel1.VerticalScroll.SmallChange = 48
        Try
            If e.KeyCode = Keys.Up Then
                Dim change As Integer = FlowLayoutPanel1.VerticalScroll.Value - FlowLayoutPanel1.VerticalScroll.SmallChange
                FlowLayoutPanel1.AutoScrollPosition = New Point(0, change)
            ElseIf e.KeyCode = Keys.Down Then
                Dim change As Integer = FlowLayoutPanel1.VerticalScroll.Value + FlowLayoutPanel1.VerticalScroll.SmallChange
                FlowLayoutPanel1.AutoScrollPosition = New Point(0, change)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub c()
        Dim dr As OleDbDataReader = DataReader("Select * From Transaction_Data")

        While dr.Read
            Dim _ids As String = dr("KittyIds")
            If _ids.Contains(",") Then Continue While

            Dim _id As Integer = Int(_ids)
            Dim _trns As New Transaction(dr("TrnsID"))

            '_trns.KittyIds.Add(_id, dr("Structure"))
            _trns.Save()
        End While

    End Sub


    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Dim distinct As New Dictionary(Of String, List(Of String))
    '    Dim _good As New Dictionary(Of String, List(Of String))
    '    Dim _letters As New Dictionary(Of String, List(Of String))

    '    For Each i In AllKitties
    '        Dim dr As OleDbDataReader = DataReader($"Select TransactionDetails From Kitty_Data Where KittyUID={i.KittyUID}")
    '        Dim _str As String = ""

    '        While dr.Read
    '            _str = If(IsDBNull(dr(0)), "", dr(0))
    '        End While
    '        If _str = "" Then Continue For

    '        For Each j In Split(_str, "|,|", , CompareMethod.Text)

    '            If j.Length = 10 Then Continue For

    '            Dim SavedData As Linq.JObject = Linq.JObject.Parse(j.Substring(10))

    '            Dim _date As Date = j.Substring(0, 10)

    '            Dim dict As New Dictionary(Of String, String) From {
    '                {"TrnsDate", _date.ToShortDateString},
    '                {"Mode", SavedData.SelectToken("Mode")},
    '                {"Account", SavedData.SelectToken("Account")},
    '                {"Amount", i.Record(_date)},
    '                {"RefNo", SavedData.SelectToken("RefNo")},
    '                {"Notes", SavedData.SelectToken("Notes")},
    '                {"KittyIds", i.KittyUID},
    '                {"Structure", i.Record(_date)}
    '            }

    '            If dict("Mode").ToLower = "cash" Then
    '                Continue For
    '            End If
    '            If distinct.ContainsKey(dict("RefNo")) Then
    '                distinct(dict("RefNo")).Add(JsonConvert.SerializeObject(dict, Formatting.Indented))
    '            Else
    '                Dim _str1 = JsonConvert.SerializeObject(dict, Formatting.Indented)
    '                distinct.Add(dict("RefNo"), New List(Of String)({_str1}))
    '            End If

    '            'Dim _mode = dict.Item("Mode")
    '            'Dim _acc = dict.Item("Account")
    '            'Dim _ref = dict.Item("RefNo")
    '            'Dim _note = dict.Item("Notes")
    '            'SqlCommand($"Insert Into Transaction_Data (TrnsDate,Mode,Account,RefNo,Notes,KittyIds)" &
    '            '           $"Values('{j}','{_mode}','{_acc}','{_ref}','{_note}'),'{i.KittyUID}'")
    '        Next
    '    Next

    '    For Each i In distinct
    '        If i.Value.Count = 1 Then
    '            Dim SavedData As Linq.JObject = Linq.JObject.Parse(i.Value.First)
    '            Dim _date As String = SavedData.SelectToken("TrnsDate")
    '            Dim _amt As Integer = SavedData.SelectToken("Amount")
    '            Dim _id As Integer = SavedData.SelectToken("KittyIds")
    '            Dim _kitty = AllKitties.Where(Function(f) f.KittyUID = _id)(0)
    '            If _kitty.Record.Item(_date) = _amt Then
    '                _good.Add(i.Key, i.Value)
    '            End If
    '        End If
    '    Next

    '    For Each i In _good
    '        distinct.Remove(i.Key)
    '    Next

    '    For Each i In _good
    '        Dim f = System.Text.RegularExpressions.Regex.Replace(i.Key, "\d", "")
    '        If f <> "" Then
    '            'Contains letter
    '            _letters.Add(i.Key, i.Value)
    '        End If
    '    Next
    '    Dim d = ""

    '    For Each i In _letters
    '        _good.Remove(i.Key)
    '    Next


    '    For Each i In distinct("")

    '        Dim SavedData As Linq.JObject = Linq.JObject.Parse(i)

    '        SavedData.SelectToken("Notes")
    '        Dim _date = SavedData.SelectToken("TrnsDate")
    '        Dim _mode = SavedData.SelectToken("Mode")
    '        Dim _acc = SavedData.SelectToken("Account")
    '        Dim _amt = SavedData.SelectToken("Amount")
    '        Dim _ref = SavedData.SelectToken("RefNo")
    '        Dim _id = SavedData.SelectToken("KittyIds")
    '        Dim _note = SavedData.SelectToken("Notes")
    '        Dim _structure = SavedData.SelectToken("Structure")

    '        SqlCommand($"Insert Into Transaction_Data (TrnsDate,Mode,Amount,Account,RefNo,KittyIds,Notes,Structure)" &
    '                       $"Values('{_date}','{_mode}','{_amt}','{_acc}','{_ref}','{_id}','{_note}','{_structure}')")
    '    Next

    '    distinct.Remove("")

    '    '_good.Add(_letters.First.Key, _letters.First.Value)
    '    '_good.Add(_letters.Last.Key, _letters.Last.Value)

    '    Dim sdf As String = ""
    '    For Each i In distinct.Values
    '        For Each j In i
    '            sdf += j + "|,|"
    '        Next
    '    Next


    '    Dim ewq As String = Str(sdf)

    '    Dim sorted = From pair In _good
    '                 Order By pair.Key.Length

    '    For Each i In distinct.First.Value

    '        If i = "" Then Exit Sub

    '        Dim SavedData As Linq.JObject = Linq.JObject.Parse(i)

    '        SavedData.SelectToken("Notes")
    '        Dim _date = SavedData.SelectToken("TrnsDate")
    '        Dim _mode = SavedData.SelectToken("Mode")
    '        Dim _acc = SavedData.SelectToken("Account")
    '        Dim _amt = SavedData.SelectToken("Amount")
    '        Dim _ref = SavedData.SelectToken("RefNo")
    '        Dim _id = SavedData.SelectToken("KittyIds")
    '        Dim _note = SavedData.SelectToken("Notes")
    '        SqlCommand($"Insert Into Transaction_Data (TrnsDate,Mode,Amount,Account,RefNo,KittyIds,Notes)" &
    '                   $"Values('{_date}','{_mode}','{_amt}','{_acc}','{_ref}','{_id}','{_note}')")
    '    Next

    '    Dim s = ""
    'End Sub

End Class
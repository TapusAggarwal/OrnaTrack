Imports System.IO
Imports ExcelDataReader

Public Class rough


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _set As New HashSet(Of OnlineTransaction)

        Using ofd As New OpenFileDialog() With {.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"}

            ofd.Multiselect = True

            If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

            DataGridView1.Rows.Clear()


            For Each _fileName In ofd.FileNames
                Using Stream = File.Open(_fileName, FileMode.Open, FileAccess.Read)

                    Dim _name As String = _fileName.Split("\").Last.Split(".").First.Split("_").First

                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(Stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                     .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                     .UseHeaderRow = True}})

                        Dim dt As DataTable = result.Tables.Item(0)

                        For i = 1 To 20
                            dt.Rows.RemoveAt(0)
                        Next


                        For i = 0 To dt.Rows.Count - 1

                            Dim _row = dt.Rows.Item(i)
                            If IsDBNull(_row.Item(0)) Then Continue For
                            If _row.Item(0).ToString.Trim.StartsWith("*") Then Exit For

                            Dim x = Function(f As Object, _int As Boolean)
                                        If IsDBNull(f) OrElse f.ToString.Trim = "" Then
                                            If _int Then Return -1
                                            Return ""
                                        End If
                                        If _int Then
                                            Dim h As Single = Split(f.ToString.Trim, " ", , CompareMethod.Text).First
                                            Return h
                                        End If
                                        Return f.ToString.Trim
                                    End Function

                            Dim _amt As Single = x(_row.Item(6), True)
                            If _amt = -1 Then _amt = -x(_row.Item(5), True)
                            Dim trns As New OnlineTransaction

                            trns.TrnsDate = x(_row.Item(0), False)
                            trns.Account = _name
                            trns.BranchCode = x(_row.Item(2), True)
                            trns.ChequeNumber = x(_row.Item(3), True)
                            trns.Description = x(_row.Item(4), False)
                            trns.Amount = _amt
                            trns.Balance = x(_row.Item(7), True)

                            _set.Add(trns)
                        Next

                    End Using
                End Using

            Next

        End Using


        Dim _orderedTrns = From i In _set
                           Order By i.TrnsDate

        Dim _selectedTrns = (From i In _orderedTrns
                             Select i
                             Where (i.Description.StartsWith("BY TRANSFER/UPI/RRN") OrElse i.Description.StartsWith("BY TRANSFER/IMPSP2A"))).ToList

        For Each i In _selectedTrns
            If i.Description.StartsWith("BY TRANSFER/UPI/RRN") Then
                i.Description = i.Description.Split("|").First.Split("/")(2).Split(" ").Last.Trim
            Else
                i.Description = i.Description.Replace("BY TRANSFER/IMPSP2A", "").Split(" ").First.Trim
            End If
        Next


        Dim _acc = From i In _selectedTrns Select i.Account Distinct
        Dim _list = AllTransactionsForm.GetAllTransactions()
        Dim _unCommon = _list.Where(Function(f) _selectedTrns.Where(
                                        Function(r) (r.Description = f.RefNo AndAlso r.Amount = f.Amount) OrElse Not _acc.Contains(f.Account)).Count = 0).ToList


        Dim _type As Type = _selectedTrns.First.GetType
        Dim _prop = From i In _type.GetProperties() Select i.Name
        Dim _abc As New DataTable
        _abc.Columns.Add("SrNo")
        _abc.Columns(0).AutoIncrement = True

        For Each i In _prop
            _abc.Columns.Add(i)
        Next

        For Each i In _selectedTrns
            Dim _row As DataRow = _abc.NewRow
            For j As Integer = 0 To _prop.Count - 1
                _row(j + 1) = CallByName(i, _prop(j), CallType.Get, Nothing)
            Next
            _abc.Rows.Add(_row)
            _prev = i.TrnsDate
        Next

        Dim _colors As New Dictionary(Of String, Color)

        Dim rnd As New Random
        Dim _cl = Color.FromArgb(255, rnd.Next(200, 255), rnd.Next(200, 255), rnd.Next(200, 255))
        _colors.Add(_acc.First, _cl)

        For Each i In _acc
            If _colors.ContainsKey(i) Then Continue For
            _colors.Add(i, Color.FromArgb(255, _cl.R - rnd.Next(0, 50), _cl.G - rnd.Next(0, 50), _cl.B - rnd.Next(0, 50)))
        Next

        DataGridView1.DataSource = _abc

        For i = 0 To DataGridView1.Rows.Count - 1
            If _prev <> Date.Parse(DataGridView1.Rows(i).Cells(1).Value) Then _color = If(_color = Color.White, Color.LightGray, Color.White)
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = _color
            _prev = DataGridView1.Rows(i).Cells(1).Value

            DataGridView1.Rows(i).Cells(2).Style.BackColor = _colors(DataGridView1.Rows(i).Cells(2).Value)
        Next
    End Sub

    Dim _color As Color = Color.LightGray
    Dim _prev As Date = Nothing

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim x As New HashSet(Of OnlineTransaction)

        Dim y As New Dictionary(Of OnlineTransaction, Int16)

        Dim trns1 As New OnlineTransaction With {
            .TrnsDate = "23-04-2003",
            .BranchCode = 2004,
            .ChequeNumber = 98723,
            .Description = "By Transfer",
            .Amount = 340000,
            .Balance = 987823123
        }

        Dim trns2 As New OnlineTransaction With {
            .TrnsDate = "23-04-2003",
            .BranchCode = 2004,
            .ChequeNumber = 98723,
            .Description = "By Transfer",
            .Amount = 340000,
            .Balance = 987823123
        }

        Dim f = trns1 = trns2

        x.Add(trns2)
        x.Add(trns1)

        Console.WriteLine(trns2)

    End Sub
End Class

Public Class OnlineTransaction

    Public Property TrnsDate As Date
    Public Property Account As String = ""
    Public Property Description As String
    Public Property Amount As Single = -1
    Public Property Balance As Integer = -1
    Public Property BranchCode As Integer = -1
    Public Property ChequeNumber As Integer = -1

    Public Overrides Function GetHashCode() As Integer
        Return (TrnsDate, BranchCode, ChequeNumber, Description, Amount, Balance).GetHashCode()
    End Function

    Public Function Equals1(other As OnlineTransaction) As Boolean
        Return GetHashCode() = other.GetHashCode
    End Function

    Public Shared Operator =(left As OnlineTransaction, right As OnlineTransaction) As Boolean
        Return left.GetHashCode = right.GetHashCode
    End Operator

    Public Shared Operator <>(left As OnlineTransaction, right As OnlineTransaction) As Boolean
        Return Not left = right
    End Operator

End Class
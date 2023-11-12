Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class OrganiseStock

    Dim _width As Integer = -1
    Dim _height As Integer = -1

    Private Sub OrganiseStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MakePlace()
        FlowLayoutPanel1.Controls.Clear()
        Integer.TryParse(TrayWidthTB.Text, _width)
        Integer.TryParse(TrayHeightTB.Text, _height)

        For i = 0 To _width * _height - 1
            Dim _cntrl As New ItemsUserControl
            FlowLayoutPanel1.Controls.Add(_cntrl)
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TrayWidthTB.TextChanged
        MakePlace()
    End Sub

    Private Sub TrayHeightTB_TextChanged(sender As Object, e As EventArgs) Handles TrayHeightTB.TextChanged
        MakePlace()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Stock_Data")

        Dim _list As New List(Of Double)
        Dim _count As Integer = 0
        While dr.Read
            _count += 1
            Dim _str As String = dr("Item_Data").ToString
            Dim _id As Integer = dr("ID")
            Dim jsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(_str)

            Try
                Dim _weight As Double = jsonObject("12").ToObject(Of Double)()
                _list.Add(_weight)
            Catch ex As Exception
            End Try

        End While



        Dim sum As Double = _list.Sum()
        Dim g = ""

    End Sub
End Class
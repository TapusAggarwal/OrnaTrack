Imports Newtonsoft

Public Class AddItemPage

    Dim x As New Item.Feature

    Private Sub CoustNameButton_Click(sender As Object, e As EventArgs) Handles CoustNameButton.Click
        Try
            x.Name = AttrNameTB.Text
            x.Type = AttrTypeCB.SelectedItem

            If x.Name.Length < 1 Then MessageBox.Show($"{x.Name.Length}-{x.Name}") : Exit Sub
            If x.Type.Length < 1 Then MessageBox.Show($"{x.Type.Length}-{x.Type}") : Exit Sub
            Dim z As New FontAwesome.Sharp.IconButton() With {
                .ForeColor = IconButton1.ForeColor,
                .BackColor = IconButton1.BackColor,
                .IconColor = IconButton1.IconColor,
                .Size = IconButton1.Size,
                .FlatStyle = FlatStyle.Flat,
                .TextImageRelation = TextImageRelation.ImageBeforeText,
                .AutoSize = True,
                .Font = IconButton1.Font
            }

            z.FlatAppearance.BorderSize = 0

            z.Text = $"{{{x.Type}}} {x.Name}"
            z.IconChar = x.Icon
            FlowLayoutPanel2.Controls.Add(z)
            x = New Item.Feature
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddItemPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitaliseConnection()
        'Try : myconnection.Open() : Catch : End Try

        'Dim databaseStorageType As List(Of Dictionary(Of String, String))

        'Dim y As New Dictionary(Of String, String) From {
        '    {"data_type", "integer"},
        '    {"default_value", "1234"}
        '}

        'Dim x As String = Json.JsonConvert.SerializeObject(y)

        'SqlCommand($"Insert INTO StockData (attributes) VALUES('{x}')")

        ''Dim jsonDataAsString As JObject = JObject.Parse()

        'AttrTypeCB.Items.AddRange(Item.DataType_List.ToArray)
        'Console.WriteLine(NameOf(x))
        'Dim xa As New Item.Feature("", Item.DataType.Integer_Type)

        'Dim x As New Item
        'Dim y As New Item.ItemType.Type_Integer(Item.Types.Boolean_Type, FontAwesome.Sharp.IconChar.AccessibleIcon)

        AttrTypeCB.Items.Clear()

        Dim sbOutput As New Text.StringBuilder
        Dim t As Type = GetType(Item.DataType)
        For Each p As Reflection.FieldInfo In t.GetFields()
            AttrTypeCB.Items.Add(p.GetValue(p))
            sbOutput.AppendLine(p.GetValue(p))
        Next

    End Sub

End Class
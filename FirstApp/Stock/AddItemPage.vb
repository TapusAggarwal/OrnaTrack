Imports Newtonsoft

Public Class AddItemPage

    Dim dragging As Boolean
    Dim startX As Integer
    Dim startY As Integer

    Public Property CurrentItem As Item

    Private Sub AddAttributeButton_Click(sender As Object, e As EventArgs) Handles AddAttributeButton.Click
        'Try

        If AttrNameTB.TextLength < 1 Then
            MessageBox.Show("Please Enter Attribute Name In Order To Make Entry.", "Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If AttrTypeCB.SelectedItem.ToString.Length < 1 Then
            MessageBox.Show("Please Select Attribute Type In Order To Make Entry.", "Type Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim _property As New Item.Item_Property With {
                .Name = AttrNameTB.Text,
                .DataType = AttrTypeCB.SelectedItem,
                .Attr_Ctg = AttrCategoryCB.SelectedItem,
                .IsConstant = ConstantChB.Checked,
                .IsOptional = OptionalChB.Checked,
                .IsCurrency = CurrencyChB.Checked,
                .IsFormula = CheckBox1.Checked
        }

        If _property.IsCurrency And _property.DataType <> Item.DataType.Integer_Type Then
            MessageBox.Show("Only Integers Are Allowed To Be Declared As Currency.", "Illegal Selection")
            Exit Sub
        End If

        Select Case _property.DataType
            Case Item.DataType.Boolean_Type
                _property.DefaultValue = IIf(TrueChB.Checked, "True", "False")
            Case Item.DataType.List_Type
                If ListValues.Items.Count = 0 Then MessageBox.Show("First Add Items To The Add List Type Property.") : Exit Sub
                If ListValues.SelectedIndex < 0 Then MessageBox.Show("First Select An Item To Be Used As Default Value.") : Exit Sub
                _property.DefaultValue = $"{ListValues.SelectedItem}`{String.Join(",", ListValues.Items.Cast(Of String))}"
            Case Item.DataType.Integer_Type
                If DefaultValueTB.TextLength = 0 Then MessageBox.Show("Enter A Default Value To Add Integer Type Property.") : Exit Sub
                If Not _property.IsFormula Then
                    If DefaultValueTB.Text.Contains("{") Or DefaultValueTB.Text.Contains("}") Then MessageBox.Show("Characters '{' or '}' Are Not Allowed Unless The Property Uses A Formula.") : Exit Sub
                    _property.DefaultValue = DefaultValueTB.Text
                Else
                    _property.DefaultValue = FormulaTB.Text
                    _property.IsConstant = True
                End If
            Case Item.DataType.String_Type
                If DefaultValueTB.TextLength = 0 Then MessageBox.Show("Enter A Default Value To Add String Type Property.") : Exit Sub
                _property.DefaultValue = DefaultValueTB.Text
        End Select

        If CurrentItem.MyProperties.Where(Function(f) f.Name = _property.Name).Count > 0 Then
            MessageBox.Show("Attribute With Same Name Already Exists. Try Another Name.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            AttrNameTB.Select()
            Exit Sub
        End If

        CurrentItem.MyProperties.Add(_property)

        ShowProperties()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Dim PanelMaxWidth As Integer = 0

    Private Sub ShowProperties()

        PurchaseFP.FlowLayoutPanel1.Controls.Clear()
        ProductFP.FlowLayoutPanel1.Controls.Clear()
        SaleFP.FlowLayoutPanel1.Controls.Clear()

        PurchaseFP.Size = New Point(0, 50)
        ProductFP.Size = New Point(0, 50)
        SaleFP.Size = New Point(0, 50)

        For Each _property In CurrentItem.MyProperties
            Dim z1 As New AttributeControl
            z1.CurrentProperty = _property

            'Dim z As New FontAwesome.Sharp.IconButton() With {
            '    .ForeColor = Color.MediumPurple,
            '    .BackColor = Color.FromArgb(25, 25, 70),
            '    .IconColor = Color.White,
            '    .FlatStyle = FlatStyle.Flat,
            '    .TextImageRelation = TextImageRelation.ImageBeforeText,
            '    .AutoSize = True,
            '    .Font = New Font("Century Gothic ", 11.25),
            '    .Tag = _property
            '}

            'z.FlatAppearance.BorderSize = 0
            'z.Text = $"{{{_property.DataType}}} {_property.Name}*"
            'z.IconChar = _property.Icon

            'AddHandler z1.MouseDown, AddressOf StartDrag
            'AddHandler z1.MouseMove, AddressOf WhileDragging
            'AddHandler z1.MouseUp, AddressOf EndDrag

            AddHandler z1.ButtonClick,
                Sub(Ctrl_property As Item.Item_Property)
                    If AddParameters = False Then
                        If MessageBox.Show("Are You Sure You Want To Remove This Property.", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
                        CurrentItem.MyProperties.Remove(Ctrl_property)
                        ShowProperties()
                    Else
                        FormulaTB.SelectedText = $"{{{_property.Name}}}"
                        FormulaTB.Select()
                        'For Each i As AttributeControl In FlowLayoutPanel2.Controls
                        '    i.UsedButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose
                        '    i.UsedButton.IconColor = Color.DarkRed
                        '    i.Enabled = True
                        'Next
                        AddParameters = False
                    End If
                End Sub

            If _property.Attr_Ctg = Item.AttributeCategory.Purchase_Type Then
                PurchaseFP.AddControl(z1)
                PurchaseFP.AutoReSize()
            ElseIf _property.Attr_Ctg = Item.AttributeCategory.Product_Type Then
                ProductFP.AddControl(z1)
                ProductFP.AutoReSize()
            Else
                SaleFP.AddControl(z1)
                SaleFP.AutoReSize()
            End If

            PanelMaxWidth = Math.Max(PanelMaxWidth, z1.Width)

            'FlowLayoutPanel2.Controls.Add(z1)
            'Panel1.Size = New Point(FlowLayoutPanel2.Controls.Cast(Of AttributeControl).Max(Function(f) f.Size.Width), 0)
        Next

        Size = New Point(Width + PanelMaxWidth - Panel1.Width + 55, Height)

    End Sub

    Private Sub AddItemPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AttrTypeCB.Items.Clear()

        Dim sbOutput As New Text.StringBuilder
        Dim t As Type = GetType(Item.DataType)
        For Each p As Reflection.FieldInfo In t.GetFields()
            AttrTypeCB.Items.Add(p.GetValue(p))
            sbOutput.AppendLine(p.GetValue(p))
        Next

        If CurrentItem.ItemID > 0 Then
            ItemNameTB.Text = CurrentItem.Name
            ShowProperties()
            Exit Sub
        End If

        ShowProperties()

    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        If CurrentItem.Name.Length = 0 Then
            MessageBox.Show("First Add Item Name To Save Item.")
            Exit Sub
        End If

        If CurrentItem.MyProperties.Count = 0 Then
            MessageBox.Show("Add Atleast One Property Inorder To Save This Item.")
            Exit Sub
        End If

        If CurrentItem.ItemID > 0 Then
            SqlCommand($"UPDATE Item_Data SET ItemName='{CurrentItem.Name}',ItemAttr='{CurrentItem.MyProperties_JSON}' WHERE ID={CurrentItem.ItemID}")
        Else
            SqlCommand($"INSERT INTO Item_Data (ItemName,ItemAttr) VALUES ('{CurrentItem.Name}','{CurrentItem.MyProperties_JSON}')")
        End If

        Try
            Dim dr As OleDb.OleDbDataReader = DataReader("Select max(ID) From Item_Data")
            While dr.Read
                Dim _temp As Integer = dr(0)
                CurrentItem.ItemID = _temp
            End While
        Catch ex As Exception
        End Try

        Close()

    End Sub

    Private Sub ItemNameTB_LostFocus(sender As Object, e As EventArgs) Handles ItemNameTB.LostFocus
        If ItemNameTB.TextLength = 0 Then Exit Sub
        CurrentItem.Name = ItemNameTB.Text
    End Sub

    Private Sub AttrTypeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttrTypeCB.SelectedIndexChanged
        Dim typeSelected As String = AttrTypeCB.SelectedItem
        If typeSelected.Length > 0 Then

            DefaultValueTB.Visible = False
            TrueChB.Visible = False
            FalseChB.Visible = False
            ListValues.Visible = False
            EditListBT.Visible = False
            'FormulaBT.Visible = False
            CheckBox1.Visible = False

            Select Case typeSelected
                Case Item.DataType.Boolean_Type
                    TrueChB.Visible = True
                    FalseChB.Visible = True
                    TrueChB.Checked = True
                Case Item.DataType.List_Type
                    ListValues.Visible = True
                    EditListBT.Visible = True
                Case Item.DataType.Integer_Type
                    DefaultValueTB.Visible = True
                    DefaultValueTB.Text = 0
                    'FormulaBT.Visible = True
                    CheckBox1.Visible = True
                    CheckBox1.Checked = False
                Case Item.DataType.String_Type
                    DefaultValueTB.Visible = True
                    DefaultValueTB.Text = "none"
            End Select
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles TrueChB.CheckedChanged
        If TrueChB.Checked Then FalseChB.Checked = False
        If Not (TrueChB.Checked) And Not (FalseChB.Checked) Then TrueChB.Checked = True
    End Sub

    Private Sub FalseChB_CheckedChanged(sender As Object, e As EventArgs) Handles FalseChB.CheckedChanged
        If FalseChB.Checked Then TrueChB.Checked = False
        If Not (TrueChB.Checked) And Not (FalseChB.Checked) Then FalseChB.Checked = True
    End Sub

    Private Sub EditListBT_Click(sender As Object, e As EventArgs) Handles EditListBT.Click
        Dim Fm As New ListTypeDgv
        AddHandler Fm.Submit_CLick, Sub()
                                        Fm.Close()
                                        ListValues.Items.Clear()
                                        ListValues.Items.AddRange(Fm.ListItems.ToArray)
                                    End Sub
        AddHandler Fm.Cancel_CLick, Sub()
                                        Fm.Close()
                                    End Sub
        Fm.Show()

        Dim x As New PropertyControl
    End Sub

    Private AddParameters As Boolean = False

    Private Sub AddParametersBT_Click(sender As Object, e As EventArgs) Handles AddParametersBT.Click
        'For Each i As AttributeControl In FlowLayoutPanel2.Controls
        '    Dim _property As Item.Item_Property = i.CurrentProperty
        '    If _property.DataType <> Item.DataType.Integer_Type Then
        '        i.Enabled = False
        '    Else
        '        i.UsedButton.IconChar = FontAwesome.Sharp.IconChar.CheckSquare
        '        i.UsedButton.IconColor = Color.ForestGreen
        '    End If
        'Next
        AddParameters = True
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            FormulaTB.Visible = True
            AddParametersBT.Visible = True
            UseBT.Visible = True
        Else
            FormulaTB.Visible = False
            AddParametersBT.Visible = False
            UseBT.Visible = False
        End If
    End Sub

    Private Sub MathOPerations_Click(sender As FontAwesome.Sharp.IconButton, e As EventArgs) Handles LeftBracketBT.Click, RightBracketBT.Click, DivideBT.Click, MultiplyBT.Click, PlusBT.Click, MinusBT.Click
        Dim Operation As String = ""

        If sender Is LeftBracketBT Then
            Operation = "("
        ElseIf sender Is RightBracketBT Then
            Operation = ")"
        ElseIf sender Is DivideBT Then
            Operation = "/"
        ElseIf sender Is MultiplyBT Then
            Operation = "*"
        ElseIf sender Is PlusBT Then
            Operation = "+"
        ElseIf sender Is MinusBT Then
            Operation = "-"
        End If

        FormulaTB.SelectedText = Operation
    End Sub


    Private Sub UseBT_Click(sender As Object, e As EventArgs) Handles UseBT.Click
        Dim equation As String = FormulaTB.Text
        Dim result = New DataTable().Compute(equation, Nothing)
    End Sub

    Private Sub FormulaTB_KeyDown(sender As Object, e As EventArgs) Handles FormulaTB.TextChanged
        'Dim filteredText As String = FormulaTB.Text

        'Dim cursorIndex As Integer = FormulaTB.SelectionStart

        'For Each i In filteredText
        '    Dim ascVal As Integer = Asc(i)

        '    If i = "(" Or i = ")" Or i = "/" Or i = "*" Or i = "+" Or i = "-" Then
        '        Continue For
        '    End If

        '    If ascVal < 48 Or ascVal > 57 Then
        '        MessageBox.Show($"Invalid Character Found ('{i}'). This Property Is Declared As Integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        filteredText = filteredText.Replace(i, "")
        '    End If
        'Next

        'If FormulaTB.Text <> filteredText Then
        '    FormulaTB.Text = filteredText
        '    FormulaTB.SelectionStart = cursorIndex - 1
        'End If

        HighLightOperations()

    End Sub

    Private Sub HighLightOperations()
        Dim x As Integer = 0
        FormulaTB.SelectionColor = Color.Black
        For Each i In FormulaTB.Text
            Dim cursorIndex As Integer = FormulaTB.SelectionStart
            If i = "%" Or i = "(" Or i = ")" Or i = "/" Or i = "*" Or i = "+" Or i = "-" Then
                FormulaTB.SelectionStart = x
                FormulaTB.SelectionLength = 1
                FormulaTB.SelectionColor = Color.Red
                FormulaTB.SelectionStart = cursorIndex
                FormulaTB.SelectionLength = 0
                FormulaTB.SelectionColor = Color.Black
            End If
            x += 1
        Next
    End Sub

    Private Sub MathOPerations_Click(sender As Object, e As EventArgs) Handles RightBracketBT.Click, PlusBT.Click, MultiplyBT.Click, MinusBT.Click, LeftBracketBT.Click, DivideBT.Click

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
    End Sub

    Private Sub FlowLayoutPanel2_SizeChanged(sender As Object, e As EventArgs)
        'MakeControlsEqualSize()
    End Sub


    'Private Sub MakeControlsEqualSize()
    '    SaleAttrFP.Size = New Point(FlowLayoutPanel2.Width, SaleAttrFP.Height)
    '    PurchaseAttrFP.Size = New Point(FlowLayoutPanel2.Width, PurchaseAttrFP.Height)
    '    ProductAttrFP.Size = New Point(FlowLayoutPanel2.Width, ProductAttrFP.Height)
    'End Sub

End Class
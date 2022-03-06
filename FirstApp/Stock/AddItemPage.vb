Imports Newtonsoft

Public Class AddItemPage

    Dim dragging As Boolean
    Dim startX As Integer
    Dim startY As Integer

    Public Property CurrentItem As New Item

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
                .IsConstant = ConstantChB.Checked,
                .IsOptional = OptionalChB.Checked,
                .IsCurrency = CurrencyChB.Checked
            }

        If _property.IsCurrency And _property.DataType <> Item.DataType.Integer_Type Then
            MessageBox.Show("Only Integers Are Allowed To Be Declared As Currency.", "Illegal Selection")
            Exit Sub
        End If

        CurrentItem.MyProperties.Add(_property)

        Select Case _property.DataType
            Case Item.DataType.Boolean_Type
                _property.DefaultValue = IIf(TrueChB.Checked, "True", "False")
            Case Item.DataType.List_Type
                If ListValues.Items.Count = 0 Then MessageBox.Show("First Add Items To The Add List Type Property.") : Exit Sub
                If ListValues.SelectedIndex < 0 Then MessageBox.Show("First Select An Item To Be Used As Default Value.") : Exit Sub
                _property.DefaultValue = $"{ListValues.SelectedItem}`{String.Join(",", ListValues.Items.Cast(Of String))}"
            Case Item.DataType.Integer_Type
                If DefaultValueTB.TextLength = 0 Then MessageBox.Show("Enter A Default Value To Add Integer Type Property.") : Exit Sub
                _property.DefaultValue = DefaultValueTB.Text
            Case Item.DataType.String_Type
                If DefaultValueTB.TextLength = 0 Then MessageBox.Show("Enter A Default Value To Add String Type Property.") : Exit Sub
                _property.DefaultValue = DefaultValueTB.Text
        End Select

        AddAttribute(_property)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub AddAttribute(_property As Item.Item_Property)

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

        AddHandler z1.MouseDown, AddressOf StartDrag
        AddHandler z1.MouseMove, AddressOf WhileDragging
        AddHandler z1.MouseUp, AddressOf EndDrag

        FlowLayoutPanel2.Controls.Add(z1)

        FlowLayoutPanel2.Size = New Point(FlowLayoutPanel2.Controls.Cast(Of AttributeControl).Max(Function(f) f.Size.Width), 0)

    End Sub

    Private Sub StartDrag(sender As Control, e As MouseEventArgs)
        dragging = True
    End Sub

    Private Sub WhileDragging(sender As Control, e As MouseEventArgs)
        If dragging = True Then
            Label5.Text = e.Y
            Try
                With FlowLayoutPanel2.Controls

                    If e.Y > sender.Height Then

                        Dim newIndex As Integer = .IndexOf(sender) + 1

                        .SetChildIndex(sender, newIndex)
                        Cursor.Position = FlowLayoutPanel2.Controls.Item(newIndex).PointToScreen(Point.Empty) + New Point(sender.Width / 2, sender.Height / 2)

                    ElseIf e.Y < 0 Then
                        Dim newIndex As Integer = .IndexOf(sender) - 1

                        .SetChildIndex(sender, newIndex)
                        Cursor.Position = FlowLayoutPanel2.Controls.Item(newIndex).PointToScreen(Point.Empty) + New Point(sender.Width / 2, sender.Height / 2)

                    End If
                End With


            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub EndDrag(sender As Object, e As EventArgs)
        dragging = False
    End Sub

    Private Sub AddItemPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitaliseConnection()
        Try : myconnection.Open() : Catch : End Try

        AttrTypeCB.Items.Clear()

        Dim sbOutput As New Text.StringBuilder
        Dim t As Type = GetType(Item.DataType)
        For Each p As Reflection.FieldInfo In t.GetFields()
            AttrTypeCB.Items.Add(p.GetValue(p))
            sbOutput.AppendLine(p.GetValue(p))
        Next

        If CurrentItem.ItemID > 0 Then
            ItemNameTB.Text = CurrentItem.Name
            For Each i In CurrentItem.MyProperties
                AddAttribute(i)
            Next
        End If

        Dim x As New Item.Item_Property
        x.Name = "Studed"
        x.DataType = Item.DataType.Boolean_Type
        x.DefaultValue = "True"

        Dim x1 As New Item.Item_Property
        x1.Name = "Mnfc."
        x1.DataType = Item.DataType.String_Type
        x1.DefaultValue = "Shilpi Anil"

        Dim x2 As New Item.Item_Property
        x2.Name = "Net Weight"
        x2.DataType = Item.DataType.Integer_Type
        x2.DefaultValue = 0

        Dim x3 As New Item.Item_Property
        x3.Name = "Gross Weight"
        x3.DataType = Item.DataType.Integer_Type
        x3.DefaultValue = 0

        Dim x4 As New Item.Item_Property
        x4.Name = "Price"
        x4.DataType = Item.DataType.Integer_Type
        x4.DefaultValue = 0

        AddAttribute(x)
        AddAttribute(x1)
        AddAttribute(x2)
        AddAttribute(x3)
        AddAttribute(x4)

        Dim equation As String = "200*3"
        Dim result = New DataTable().Compute(equation, Nothing)

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
            SqlCommand($"UPDATE Item_Data SET ItemName='{CurrentItem.Name}',ItemProperties='{CurrentItem.MyProperties_JSON}' WHERE ID={CurrentItem.ItemID}")
        Else
            SqlCommand($"INSERT INTO Item_Data (ItemName,ItemProperties) VALUES ('{CurrentItem.Name}','{CurrentItem.MyProperties_JSON}')")
        End If

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

    'Private Sub AddItemPage_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    '    e.Graphics.DrawRectangle(Pens.Red, rect)
    'End Sub

    'Private Sub AddItemPage_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
    '    IsMouseDown = True
    '    rect.Location = e.Location
    '    rect.Width = 0
    '    rect.Height = 0
    '    Invalidate()
    'End Sub

    'Private Sub AddItemPage_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    '    If IsMouseDown Then
    '        rect.Width = e.X - rect.X
    '        rect.Height = e.Y - rect.Y
    '        Invalidate()
    '    End If
    'End Sub

    'Private Sub AddItemPage_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
    '    IsMouseDown = False
    'End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs)
        Dim Fm As New Form With {
            .WindowState = FormWindowState.Maximized,
            .FormBorderStyle = FormBorderStyle.None
        }
        'Fm.Opacity = 0.3

        Dim IsMouseDown As Boolean
        Dim rect As Rectangle

        AddHandler Fm.Paint, Sub(_sender As Object, _e As PaintEventArgs)
                                 _e.Graphics.DrawRectangle(Pens.Red, rect)
                             End Sub

        AddHandler Fm.MouseDown, Sub(_sender As Object, _e As MouseEventArgs)
                                     IsMouseDown = True
                                     rect.Location = _e.Location
                                     rect.Width = 0
                                     rect.Height = 0
                                     Invalidate()
                                 End Sub

        AddHandler Fm.MouseMove, Sub(_sender As Object, _e As MouseEventArgs)
                                     If IsMouseDown Then
                                         rect.Width = _e.X - rect.X
                                         rect.Height = _e.Y - rect.Y
                                         Invalidate()
                                     End If
                                 End Sub

        AddHandler Fm.MouseUp, Sub()
                                   IsMouseDown = False
                                   MessageBox.Show("Hi")
                               End Sub

        Fm.Show()
    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles AddParametersBT.Click
        RemoveHandlerForButtons()
        For Each i As Control In FlowLayoutPanel2.Controls
            Dim _property As Item.Item_Property = i.Tag
            If _property.DataType = Item.DataType.Integer_Type Then
                AddHandler i.Click, AddressOf AddHandlerForButton
            Else
                i.Enabled = False
            End If
        Next
    End Sub

    Public Sub AddHandlerForButton(_sender As Object, _e As EventArgs)
        Dim _property As Item.Item_Property = _sender.Tag
        FormulaTB.SelectedText = $"{{{_property.Name}}}"
        FormulaTB.Select()
        RemoveHandlerForButtons()
        For Each i As Control In FlowLayoutPanel2.Controls
            i.Enabled = True
        Next
    End Sub

    Public Sub RemoveHandlerForButtons()
        For Each i As Control In FlowLayoutPanel2.Controls
            RemoveHandler i.Click, AddressOf AddHandlerForButton
        Next
    End Sub

    'Private Sub FormulaBT_Click(sender As Object, e As EventArgs) Handles FormulaBT.Click
    '    If CheckBox1.Checked Then
    '        CheckBox1.Checked = False
    '        FormulaNameLB.Visible = False
    '        FormulaNameTB.Visible = False
    '        FormulaTB.Visible = False
    '        AddParametersBT.Visible = False
    '        UseBT.Visible = False
    '    Else
    '        CheckBox1.Checked = True
    '        FormulaNameLB.Visible = True
    '        FormulaNameTB.Visible = True
    '        FormulaTB.Visible = True
    '        AddParametersBT.Visible = True
    '        UseBT.Visible = True
    '    End If
    'End Sub

    Private Sub UseBT_Click(sender As Object, e As EventArgs) Handles UseBT.Click

    End Sub
End Class
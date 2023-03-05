Imports System.Runtime.InteropServices

Public Class AddItemPage

    Private WithEvents FormulaForm As New AddFormulaForm()

    Public Property CurrentItem As Item

    Private Function ValidateInputFields() As Item.Item_Attribute
        If AttrNameTB.TextLength < 1 Then
            MessageBox.Show("Please Enter Attribute Name In Order To Make Entry.", "Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If

        If AttrTypeCB.SelectedItem.ToString.Length < 1 Then
            MessageBox.Show("Please Select Attribute Type In Order To Make Entry.", "Type Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If

        Dim _attribute As New Item.Item_Attribute With {
                .Name = AttrNameTB.Text,
                .DataType = AttrTypeCB.SelectedItem,
                .Attr_Ctg = AttrCategoryCB.SelectedItem,
                .IsConstant = ConstantChB.Checked,
                .IsOptional = OptionalChB.Checked,
                .IsCurrency = CurrencyChB.Checked,
                .IsFormula = FormulaForm.FormulaInUse
        }

        If _attribute.IsCurrency And _attribute.DataType <> Item.DataType.Integer_Type Then
            MessageBox.Show("Only Integers Are Allowed To Be Declared As Currency.", "Illegal Selection")
            Return Nothing
        End If

        Select Case _attribute.DataType

            Case Item.DataType.Boolean_Type

                _attribute.DefaultValue = IIf(TrueChB.Checked, "True", "False")


            Case Item.DataType.List_Type

                If ListValuesCB.Items.Count = 0 Then MessageBox.Show("You Must Add Items In The List In Order To Create A New List_Attribute.") : Return Nothing
                If ListValuesCB.SelectedIndex < 0 Then MessageBox.Show("You Must Select An Item To Be Used As Default Value In Order To Create A New List_Attribute.") : Return Nothing
                _attribute.DefaultValue = $"{ListValuesCB.SelectedItem}`{String.Join(",", ListValuesCB.Items.Cast(Of String))}"


            Case Item.DataType.Integer_Type
                Dim _text = DefaultValueTB.Text
                If _text.Length = 0 Then MessageBox.Show("Enter A Default Value To Add Integer Type Attribute.") : Return Nothing

                If Not _attribute.IsFormula Then
                    If Not Double.TryParse(_text, _attribute.DefaultValue) Then
                        MessageBox.Show("Provided Default Value Is Not An Integer.") : Return Nothing
                    End If
                Else
                    _attribute.DefaultValue = FormulaForm.FormulaTB.Text
                    _attribute.IsConstant = True
                End If


            Case Item.DataType.String_Type

                If DefaultValueTB.TextLength = 0 Then MessageBox.Show("Enter A Default Value To Add String Type Attribute.") : Return Nothing
                _attribute.DefaultValue = DefaultValueTB.Text


        End Select

        Return _attribute

    End Function

    Private Sub ClearAttributeFields()
        AttrNameTB.Text = ""
        AbbreviationTB.Text = ""
        AttrTypeCB.SelectedIndex = -1
        ConstantChB.Checked = False
        OptionalChB.Checked = False
        CurrencyChB.Checked = False

        FormulaBT.Visible = False
        FormulaForm.FormulaTB.Text = ""
        If FormulaForm.FormulaInUse Then FormulaForm.ToggleUseBT()
        FormulaBT.IconColor = Color.Goldenrod

        DefaultValueTB.Enabled = True
        DefaultValueTB.Text = ""
        ListValuesCB.Items.Clear()
        EditListBT.IconColor = Color.Goldenrod


        AddAttributeButton.Text = "Add Attribute"
        AddAttributeButton.IconColor = Color.White
        AddAttributeButton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt

        DeleteBT.Visible = False

        SelectedAttribute = Nothing

    End Sub

    Private Sub AddAttributeButton_Click(sender As Object, e As EventArgs) Handles AddAttributeButton.Click

        Dim _validatedAttr = ValidateInputFields()

        If _validatedAttr Is Nothing Then Exit Sub

        If SelectedAttribute Is Nothing Then

            If CurrentItem.Attributes.Where(Function(f) f.Name = _validatedAttr.Name).Count > 0 Then
                MessageBox.Show("Attribute With Same Name Already Exists. Try Another Name.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                AttrNameTB.Select()
                Exit Sub
            End If

            CurrentItem.Attributes.Add(_validatedAttr)
        Else
            Dim x = CurrentItem.Attributes.Where(Function(f) f.Name <> SelectedAttribute.Name)

            If x.Where(Function(f) f.Name = _validatedAttr.Name).Count > 0 Then
                MessageBox.Show("Attribute With Same Name Already Exists. Try Another Name.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                AttrNameTB.Select()
                Exit Sub
            End If

            With CurrentItem.Attributes.Item(CurrentItem.Attributes.IndexOf(SelectedAttribute))
                .Name = _validatedAttr.Name
                .DataType = _validatedAttr.DataType
                .Attr_Ctg = _validatedAttr.Attr_Ctg
                .IsConstant = _validatedAttr.IsConstant
                .IsOptional = _validatedAttr.IsOptional
                .IsCurrency = _validatedAttr.IsCurrency
                .IsFormula = _validatedAttr.IsFormula
                .DefaultValue = _validatedAttr.DefaultValue
            End With

        End If

        ShowAttributes()
        ClearAttributeFields()

    End Sub

    Dim PanelMaxWidth As Integer = 0

    Private Sub ShowAttributes()

        PurchaseFP.FlowLayoutPanel1.Controls.Clear()
        ProductFP.FlowLayoutPanel1.Controls.Clear()
        SaleFP.FlowLayoutPanel1.Controls.Clear()

        For Each _Attribute In CurrentItem.Attributes
            Dim z1 As New AttributeControl With {
                .CurrentAttribute = _Attribute
            }

            AddHandler z1.ButtonClick, AddressOf AttributeSelected

            If _Attribute.Attr_Ctg = Item.AttributeCategory.Purchase_Type Then
                PurchaseFP.AddControl(z1)
                PurchaseFP.AutoReSize()
            ElseIf _Attribute.Attr_Ctg = Item.AttributeCategory.Product_Type Then
                ProductFP.AddControl(z1)
                ProductFP.AutoReSize()
            Else
                SaleFP.AddControl(z1)
                SaleFP.AutoReSize()
            End If

            PanelMaxWidth = Math.Max(PanelMaxWidth, z1.Width)

        Next

    End Sub

    Dim SelectedAttribute As Item.Item_Attribute

    Private Sub AttributeSelected(_attr As Item.Item_Attribute)
        ClearAttributeFields()
        SelectedAttribute = _attr

        AttrNameTB.Text = _attr.Name
        AttrTypeCB.SelectedIndex = -1
        AttrTypeCB.SelectedItem = _attr.DataType
        AttrCategoryCB.SelectedItem = _attr.Attr_Ctg
        ConstantChB.Checked = _attr.IsConstant
        OptionalChB.Checked = _attr.IsOptional
        CurrencyChB.Checked = _attr.IsCurrency
        If _attr.IsFormula Then
            FormulaForm.FormulaTB.Text = _attr.DefaultValue
            DefaultValueTB.Text = "{Formula}"
            DefaultValueTB.Enabled = False
        Else
            DefaultValueTB.Text = _attr.DefaultValue
        End If

        AddAttributeButton.Text = "Edit Attribute"
        AddAttributeButton.IconColor = Color.Goldenrod
        AddAttributeButton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt

        DeleteBT.Visible = True
    End Sub

    Private Sub AddItemPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each i In GetType(Item.DataType).GetFields()
            AttrTypeCB.Items.Add(i.GetValue(i))
        Next

        If CurrentItem.ItemID > 0 Then
            ItemNameTB.Text = CurrentItem.Name
            ShowAttributes()
            Exit Sub
        End If

        ShowAttributes()

    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        If CurrentItem.Name.Length = 0 Then
            MessageBox.Show("First Add Item Name To Save Item.")
            Exit Sub
        End If

        If CurrentItem.Attributes.Count = 0 Then
            MessageBox.Show("Add Atleast One Attribute Inorder To Save This Item.")
            Exit Sub
        End If

        CurrentItem.Save()



        Close()

    End Sub

    Private Sub AttrTypeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttrTypeCB.SelectedIndexChanged
        Dim typeSelected As String = AttrTypeCB.SelectedItem
        If typeSelected Is Nothing OrElse typeSelected.Length = 0 Then Exit Sub

        DefaultValueTB.Visible = False
        TrueChB.Visible = False
        FalseChB.Visible = False
        ListValuesCB.Visible = False
        EditListBT.Visible = False
        FormulaBT.Visible = False

        Select Case typeSelected
            Case Item.DataType.Boolean_Type
                TrueChB.Visible = True
                FalseChB.Visible = True
                TrueChB.Checked = True
            Case Item.DataType.List_Type
                ListValuesCB.Visible = True
                EditListBT.Visible = True
            Case Item.DataType.Integer_Type
                DefaultValueTB.Visible = True
                DefaultValueTB.Text = 0
                FormulaBT.Visible = True
            Case Item.DataType.String_Type
                DefaultValueTB.Visible = True
                DefaultValueTB.Text = "none"
                DefaultValueTB.Enabled = True
        End Select

        If SelectedAttribute Is Nothing Then Exit Sub

        Dim defVal = SelectedAttribute.DefaultValue

        Select Case typeSelected

            Case Item.DataType.Boolean_Type

                If defVal = "True" Then
                    TrueChB.Checked = True
                Else
                    FalseChB.Checked = True
                End If


            Case Item.DataType.List_Type

                EditListBT.IconColor = Color.Lime
                Dim selectedVal As String = defVal.Split("`")(0)
                ListValuesCB.Items.Clear()
                ListValuesCB.Items.AddRange(defVal.Split("`")(1).ToString.Split(",").ToArray)
                ListValuesCB.SelectedItem = selectedVal
            Case Item.DataType.Integer_Type

                DefaultValueTB.Visible = True
                DefaultValueTB.Text = 0
                FormulaBT.Visible = True
                If SelectedAttribute.IsFormula Then
                    FormulaForm.FormulaTB.Text = SelectedAttribute.DefaultValue
                    If Not FormulaForm.FormulaInUse Then
                        FormulaForm.ToggleUseBT()
                    End If
                End If

            Case Item.DataType.String_Type

                DefaultValueTB.Text = defVal


        End Select

    End Sub

    Private Sub EditListBT_Click(sender As Object, e As EventArgs) Handles EditListBT.Click
        Dim Fm As New ListTypeDgv
        AddHandler Fm.Submit_CLick, Sub()
                                        Fm.Close()
                                        ListValuesCB.Items.Clear()
                                        ListValuesCB.Items.AddRange(Fm.ListItems.ToArray)
                                        If ListValuesCB.Items.Count > 0 Then EditListBT.IconColor = Color.Lime
                                    End Sub
        AddHandler Fm.Cancel_CLick, Sub()
                                        Fm.Close()
                                    End Sub

        If ListValuesCB.Items.Count > 0 Then
            For Each i In ListValuesCB.Items
                Fm.ListItems.Add(i.ToString)
            Next

        End If

        Fm.Show()
    End Sub

    Sub FormulaForm_UseBT_Toggled() Handles FormulaForm.UseBT_Toggled
        If FormulaForm.FormulaInUse Then
            FormulaBT.IconColor = Color.Lime
            DefaultValueTB.Text = "{Formula}"
            DefaultValueTB.Enabled = False
        Else
            FormulaBT.IconColor = Color.Goldenrod
            DefaultValueTB.Text = ""
            DefaultValueTB.Enabled = True
        End If
    End Sub

    Private Sub FormulaBT_Click(sender As Object, e As EventArgs) Handles FormulaBT.Click

        FormulaForm.Attributes = CurrentItem.Attributes.Where(Function(f) f.DataType = Item.DataType.Integer_Type).ToList

        FormulaForm.ShowDialog()

    End Sub


#Region "Direct Events"

    Private Sub ItemNameTB_LostFocus(sender As Object, e As EventArgs) Handles ItemNameTB.LostFocus
        If ItemNameTB.TextLength = 0 Then Exit Sub
        CurrentItem.Name = ItemNameTB.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles TrueChB.CheckedChanged
        If TrueChB.Checked Then FalseChB.Checked = False
        If Not (TrueChB.Checked) And Not (FalseChB.Checked) Then TrueChB.Checked = True
    End Sub

    Private Sub FalseChB_CheckedChanged(sender As Object, e As EventArgs) Handles FalseChB.CheckedChanged
        If FalseChB.Checked Then TrueChB.Checked = False
        If Not (TrueChB.Checked) And Not (FalseChB.Checked) Then FalseChB.Checked = True
    End Sub

    Private Sub NotNowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotNowToolStripMenuItem.Click
        DefaultValueTB.Text = "{NotNow}"
        DefaultValueTB.Enabled = False
    End Sub

    Private Sub UnKnownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnKnownToolStripMenuItem.Click
        DefaultValueTB.Text = "{UnKnown}"
        DefaultValueTB.Enabled = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        DefaultValueTB.Text = ""
        DefaultValueTB.Enabled = True
    End Sub

    Private Sub ClearBT_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
        ClearAttributeFields()
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        CurrentItem.Attributes.Remove(SelectedAttribute)
        ClearAttributeFields()
        ShowAttributes()
        DeleteBT.Visible = False
    End Sub

#End Region


End Class

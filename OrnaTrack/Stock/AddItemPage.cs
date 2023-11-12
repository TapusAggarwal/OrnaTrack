using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class AddItemPage
    {

        private AddFormulaForm FormulaForm;

        public Item CurrentItem { get; set; }

        public AddItemPage()
        {
            FormulaForm = new AddFormulaForm();
            InitializeComponent();
        }

        private Item.Item_Attribute ValidateInputFields()
        {
            if (AttrNameTB.TextLength < 1)
            {
                MessageBox.Show("Please Enter Attribute Name In Order To Make Entry.", "Name Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (AttrTypeCB.SelectedItem.ToString().Length < 1)
            {
                MessageBox.Show("Please Select Attribute Type In Order To Make Entry.", "Type Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var _attribute = new Item.Item_Attribute()
            {
                Name = AttrNameTB.Text,
                DataType = Conversions.ToString(AttrTypeCB.SelectedItem),
                Attr_Ctg = Conversions.ToString(AttrCategoryCB.SelectedItem),
                IsConstant = ConstantChB.Checked,
                IsOptional = OptionalChB.Checked,
                IsCurrency = CurrencyChB.Checked,
                IsFormula = FormulaForm.FormulaInUse
            };

            if (_attribute.IsCurrency & (_attribute.DataType ?? "") != Item.DataType.Integer_Type)
            {
                MessageBox.Show("Only Integers Are Allowed To Be Declared As Currency.", "Illegal Selection");
                return null;
            }

            switch (_attribute.DataType ?? "")
            {

                case Item.DataType.Boolean_Type:
                    {

                        _attribute.DefaultValue = Conversions.ToString(Interaction.IIf(TrueChB.Checked, "True", "False"));
                        break;
                    }


                case Item.DataType.List_Type:
                    {

                        if (ListValuesCB.Items.Count == 0)
                        {
                            MessageBox.Show("You Must Add Items In The List In Order To Create A New List_Attribute.");
                            return null;
                        }
                        if (ListValuesCB.SelectedIndex < 0)
                        {
                            MessageBox.Show("You Must Select An Item To Be Used As Default Value In Order To Create A New List_Attribute.");
                            return null;
                        }
                        _attribute.DefaultValue = $"{ListValuesCB.SelectedItem}`{string.Join(",", ListValuesCB.Items.Cast<string>())}";
                        break;
                    }


                case Item.DataType.Integer_Type:
                    {
                        string _text = DefaultValueTB.Text;
                        if (_text.Length == 0)
                        {
                            MessageBox.Show("Enter A Default Value To Add Integer Type Attribute.");
                            return null;
                        }

                        if (!_attribute.IsFormula)
                        {
                            bool localTryParse() { double argresult = Conversions.ToDouble(_attribute.DefaultValue); var ret = double.TryParse(_text, out argresult); _attribute.DefaultValue = argresult.ToString(); return ret; }

                            if (!localTryParse())
                            {
                                MessageBox.Show("Provided Default Value Is Not An Integer.");
                                return null;
                            }
                        }
                        else
                        {
                            _attribute.DefaultValue = FormulaForm.FormulaTB.Text;
                            _attribute.IsConstant = true;
                        }

                        break;
                    }


                case Item.DataType.String_Type:
                    {

                        if (DefaultValueTB.TextLength == 0)
                        {
                            MessageBox.Show("Enter A Default Value To Add String Type Attribute.");
                            return null;
                        }
                        _attribute.DefaultValue = DefaultValueTB.Text;
                        break;
                    }


            }

            return _attribute;

        }

        private void ClearAttributeFields()
        {
            AttrNameTB.Text = "";
            AbbreviationTB.Text = "";
            AttrTypeCB.SelectedIndex = -1;
            ConstantChB.Checked = false;
            OptionalChB.Checked = false;
            CurrencyChB.Checked = false;

            FormulaBT.Visible = false;
            FormulaForm.FormulaTB.Text = "";
            if (FormulaForm.FormulaInUse)
                FormulaForm.ToggleUseBT();
            FormulaBT.IconColor = Color.Goldenrod;

            DefaultValueTB.Enabled = true;
            DefaultValueTB.Text = "";
            ListValuesCB.Items.Clear();
            EditListBT.IconColor = Color.Goldenrod;


            AddAttributeButton.Text = "Add Attribute";
            AddAttributeButton.IconColor = Color.White;
            AddAttributeButton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;

            DeleteBT.Visible = false;

            SelectedAttribute = null;

        }

        private void AddAttributeButton_Click(object sender, EventArgs e)
        {

            var _validatedAttr = ValidateInputFields();

            if (_validatedAttr is null)
                return;

            if (SelectedAttribute is null)
            {

                if (CurrentItem.Attributes.Where(f => (f.Name ?? "") == (_validatedAttr.Name ?? "")).Count() > 0)
                {
                    MessageBox.Show("Attribute With Same Name Already Exists. Try Another Name.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AttrNameTB.Select();
                    return;
                }

                CurrentItem.Attributes.Add(_validatedAttr);
            }
            else
            {
                var x = CurrentItem.Attributes.Where(f => (f.Name ?? "") != (SelectedAttribute.Name ?? ""));

                if (x.Where(f => (f.Name ?? "") == (_validatedAttr.Name ?? "")).Count() > 0)
                {
                    MessageBox.Show("Attribute With Same Name Already Exists. Try Another Name.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AttrNameTB.Select();
                    return;
                }

                {
                    var withBlock = CurrentItem.Attributes[CurrentItem.Attributes.IndexOf(SelectedAttribute)];
                    withBlock.Name = _validatedAttr.Name;
                    withBlock.DataType = _validatedAttr.DataType;
                    withBlock.Attr_Ctg = _validatedAttr.Attr_Ctg;
                    withBlock.IsConstant = _validatedAttr.IsConstant;
                    withBlock.IsOptional = _validatedAttr.IsOptional;
                    withBlock.IsCurrency = _validatedAttr.IsCurrency;
                    withBlock.IsFormula = _validatedAttr.IsFormula;
                    withBlock.DefaultValue = _validatedAttr.DefaultValue;
                }

            }

            ShowAttributes();
            ClearAttributeFields();

        }

        private int PanelMaxWidth = 0;

        private void ShowAttributes()
        {

            PurchaseFP.FlowLayoutPanel1.Controls.Clear();
            ProductFP.FlowLayoutPanel1.Controls.Clear();
            SaleFP.FlowLayoutPanel1.Controls.Clear();

            foreach (var _Attribute in CurrentItem.Attributes)
            {
                var z1 = new AttributeControl() { CurrentAttribute = _Attribute };

                z1.ButtonClick += AttributeSelected;

                if ((_Attribute.Attr_Ctg ?? "") == Item.AttributeCategory.Purchase_Type)
                {
                    PurchaseFP.AddControl(z1);
                    PurchaseFP.AutoReSize();
                }
                else if ((_Attribute.Attr_Ctg ?? "") == Item.AttributeCategory.Product_Type)
                {
                    ProductFP.AddControl(z1);
                    ProductFP.AutoReSize();
                }
                else
                {
                    SaleFP.AddControl(z1);
                    SaleFP.AutoReSize();
                }

                PanelMaxWidth = Math.Max(PanelMaxWidth, z1.Width);

            }

        }

        private Item.Item_Attribute SelectedAttribute;

        private void AttributeSelected(Item.Item_Attribute _attr)
        {
            ClearAttributeFields();
            SelectedAttribute = _attr;

            AttrNameTB.Text = _attr.Name;
            AttrTypeCB.SelectedIndex = -1;
            AttrTypeCB.SelectedItem = _attr.DataType;
            AttrCategoryCB.SelectedItem = _attr.Attr_Ctg;
            ConstantChB.Checked = _attr.IsConstant;
            OptionalChB.Checked = _attr.IsOptional;
            CurrencyChB.Checked = _attr.IsCurrency;
            if (_attr.IsFormula)
            {
                FormulaForm.FormulaTB.Text = _attr.DefaultValue;
                DefaultValueTB.Text = "{Formula}";
                DefaultValueTB.Enabled = false;
            }
            else
            {
                DefaultValueTB.Text = _attr.DefaultValue;
            }

            AddAttributeButton.Text = "Edit Attribute";
            AddAttributeButton.IconColor = Color.Goldenrod;
            AddAttributeButton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;

            DeleteBT.Visible = true;
        }

        private void AddItemPage_Load(object sender, EventArgs e)
        {

            foreach (var i in typeof(Item.DataType).GetFields())
                AttrTypeCB.Items.Add(i.GetValue(i));

            if (CurrentItem.ItemID > 0)
            {
                ItemNameTB.Text = CurrentItem.Name;
                ShowAttributes();
                return;
            }

            ShowAttributes();

        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (CurrentItem.Name.Length == 0)
            {
                MessageBox.Show("First Add Item Name To Save Item.");
                return;
            }

            if (CurrentItem.Attributes.Count == 0)
            {
                MessageBox.Show("Add Atleast One Attribute Inorder To Save This Item.");
                return;
            }

            CurrentItem.Save();



            Close();

        }

        private void AttrTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeSelected = Conversions.ToString(AttrTypeCB.SelectedItem);
            if (typeSelected is null || typeSelected.Length == 0)
                return;

            DefaultValueTB.Visible = false;
            TrueChB.Visible = false;
            FalseChB.Visible = false;
            ListValuesCB.Visible = false;
            EditListBT.Visible = false;
            FormulaBT.Visible = false;

            switch (typeSelected ?? "")
            {
                case Item.DataType.Boolean_Type:
                    {
                        TrueChB.Visible = true;
                        FalseChB.Visible = true;
                        TrueChB.Checked = true;
                        break;
                    }
                case Item.DataType.List_Type:
                    {
                        ListValuesCB.Visible = true;
                        EditListBT.Visible = true;
                        break;
                    }
                case Item.DataType.Integer_Type:
                    {
                        DefaultValueTB.Visible = true;
                        DefaultValueTB.Text = 0.ToString();
                        FormulaBT.Visible = true;
                        break;
                    }
                case Item.DataType.String_Type:
                    {
                        DefaultValueTB.Visible = true;
                        DefaultValueTB.Text = "none";
                        DefaultValueTB.Enabled = true;
                        break;
                    }
            }

            if (SelectedAttribute is null)
                return;

            string defVal = SelectedAttribute.DefaultValue;

            switch (typeSelected ?? "")
            {

                case Item.DataType.Boolean_Type:
                    {

                        if (defVal == "True")
                        {
                            TrueChB.Checked = true;
                        }
                        else
                        {
                            FalseChB.Checked = true;
                        }

                        break;
                    }


                case Item.DataType.List_Type:
                    {

                        EditListBT.IconColor = Color.Lime;
                        string selectedVal = defVal.Split('`')[0];
                        ListValuesCB.Items.Clear();
                        ListValuesCB.Items.AddRange(defVal.Split('`')[1].ToString().Split(',').ToArray());
                        ListValuesCB.SelectedItem = selectedVal;
                        break;
                    }
                case Item.DataType.Integer_Type:
                    {

                        DefaultValueTB.Visible = true;
                        DefaultValueTB.Text = 0.ToString();
                        FormulaBT.Visible = true;
                        if (SelectedAttribute.IsFormula)
                        {
                            FormulaForm.FormulaTB.Text = SelectedAttribute.DefaultValue;
                            if (!FormulaForm.FormulaInUse)
                            {
                                FormulaForm.ToggleUseBT();
                            }
                        }

                        break;
                    }

                case Item.DataType.String_Type:
                    {

                        DefaultValueTB.Text = defVal;
                        break;
                    }


            }

        }

        private void EditListBT_Click(object sender, EventArgs e)
        {
            var Fm = new ListTypeDgv();
            Fm.Submit_CLick += () =>
                {
                    Fm.Close();
                    ListValuesCB.Items.Clear();
                    ListValuesCB.Items.AddRange(Fm.ListItems.ToArray());
                    if (ListValuesCB.Items.Count > 0)
                        EditListBT.IconColor = Color.Lime;
                };
            Fm.Cancel_CLick += () => Fm.Close();

            if (ListValuesCB.Items.Count > 0)
            {
                foreach (var i in ListValuesCB.Items)
                    Fm.ListItems.Add(i.ToString());

            }

            Fm.Show();
        }

        public void FormulaForm_UseBT_Toggled()
        {
            if (FormulaForm.FormulaInUse)
            {
                FormulaBT.IconColor = Color.Lime;
                DefaultValueTB.Text = "{Formula}";
                DefaultValueTB.Enabled = false;
            }
            else
            {
                FormulaBT.IconColor = Color.Goldenrod;
                DefaultValueTB.Text = "";
                DefaultValueTB.Enabled = true;
            }
        }

        private void FormulaBT_Click(object sender, EventArgs e)
        {

            FormulaForm.Attributes = CurrentItem.Attributes.Where(f => (f.DataType ?? "") == Item.DataType.Integer_Type).ToList();

            FormulaForm.ShowDialog();

        }


        #region Direct Events

        private void ItemNameTB_LostFocus(object sender, EventArgs e)
        {
            if (ItemNameTB.TextLength == 0)
                return;
            CurrentItem.Name = ItemNameTB.Text;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TrueChB.Checked)
                FalseChB.Checked = false;
            if (!TrueChB.Checked & !FalseChB.Checked)
                TrueChB.Checked = true;
        }

        private void FalseChB_CheckedChanged(object sender, EventArgs e)
        {
            if (FalseChB.Checked)
                TrueChB.Checked = false;
            if (!TrueChB.Checked & !FalseChB.Checked)
                FalseChB.Checked = true;
        }

        private void NotNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultValueTB.Text = "{NotNow}";
            DefaultValueTB.Enabled = false;
        }

        private void UnKnownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultValueTB.Text = "{UnKnown}";
            DefaultValueTB.Enabled = false;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultValueTB.Text = "";
            DefaultValueTB.Enabled = true;
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            ClearAttributeFields();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            CurrentItem.Attributes.Remove(SelectedAttribute);
            ClearAttributeFields();
            ShowAttributes();
            DeleteBT.Visible = false;
        }

        #endregion


    }
}
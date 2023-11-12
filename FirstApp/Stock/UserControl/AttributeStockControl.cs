using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class AttributeStockControl
    {

        private Item.Item_Attribute _currentAttribute;

        public object EnteredData
        {
            get
            {
                switch (_currentAttribute.DataType ?? "")
                {
                    case Item.DataType.Boolean_Type:
                        {
                            return TrueChB.Checked;
                        }
                    case Item.DataType.List_Type:
                        {
                            if (ListValues.SelectedIndex < 0)
                            {
                                MessageBox.Show($"No Data Entered In {_currentAttribute.Name} Attribute.");
                                return null;
                            }
                            return ListValues.SelectedItem;
                        }
                    case Item.DataType.Integer_Type:
                        {
                            string x = DefaultValueTB_ReadableData();
                            return x;
                        }
                    case Item.DataType.String_Type:
                        {
                            string x = DefaultValueTB_ReadableData();
                            return x;
                        }

                    default:
                        {
                            return null;
                            MessageBox.Show("Invalid DataType");
                            break;
                        }
                }
            }
        }

        public Item.Item_Attribute CurrentAttribute
        {
            set
            {
                _currentAttribute = value;

                AttributeLB.Text = _currentAttribute.Name;
                Size = (Size)new Point(Size.Width + TextRenderer.MeasureText(_currentAttribute.Name, AttributeLB.Font).Width, Size.Height);

                DefaultValueTB.Visible = false;
                TrueChB.Visible = false;
                FalseChB.Visible = false;
                ListValues.Visible = false;

                switch (_currentAttribute.DataType ?? "")
                {

                    case Item.DataType.Boolean_Type:
                        {

                            TrueChB.Visible = true;
                            FalseChB.Visible = true;
                            if (_currentAttribute.DefaultValue == "True")
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

                            ListValues.Visible = true;
                            ListValues.Items.AddRange(_currentAttribute.DefaultValue.Split('`')[1].Split(','));
                            ListValues.SelectedIndex = ListValues.FindStringExact(_currentAttribute.DefaultValue.Split('`')[0]);
                            break;
                        }


                    case Item.DataType.Integer_Type:
                        {

                            DefaultValueTB.Visible = true;
                            if (!_currentAttribute.IsFormula)
                            {
                                DefaultValueTB.Text = _currentAttribute.DefaultValue;

                                if (_currentAttribute.IsCurrency)
                                {
                                    DefaultValueTB.Text = DefaultValueTB.Text.ToCurrency();
                                }
                            }

                            else
                            {
                                DefaultValueTB.Text = "{RULE}";
                                DefaultValueTB.ReadOnly = true;
                            }

                            break;
                        }


                    case Item.DataType.String_Type:
                        {

                            DefaultValueTB.Visible = true;
                            DefaultValueTB.Text = _currentAttribute.DefaultValue;
                            break;
                        }

                    default:
                        {

                            MessageBox.Show("Invalid DataType");
                            break;
                        }


                }

                DefaultValueTB.ReadOnly = _currentAttribute.IsConstant;

            }
            get
            {
                return _currentAttribute;
            }
        }

        public AttributeStockControl()
        {
            InitializeComponent();
        }

        private void TrueChB_CheckedChanged(object sender, EventArgs e)
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

        private void DefaultValueTB_Leave(object sender, EventArgs e)
        {
            if (_currentAttribute.IsFormula)
                return;

            string _newVal = DefaultValueTB_ReadableData();
            if (string.IsNullOrEmpty(_newVal))
            {
                _newVal = _currentAttribute.DefaultValue;
            }

            if (_currentAttribute.IsCurrency)
            {
                _newVal = DefaultValueTB.Text.ToCurrency();
            }

            DefaultValueTB.Text = _newVal;

            // If _currentAttribute.Name = "HUID" AndAlso DefaultValueTB.Text <> "" Then
            // If CheckUIDExists(DefaultValueTB.Text) Then
            // DefaultValueTB.ForeColor = Color.Green
            // Else
            // DefaultValueTB.ForeColor = Color.Red
            // End If
            // End If

        }



        private void DefaultValueTB_GotFocus(object sender, EventArgs e)
        {
            if (_currentAttribute.IsFormula)
                return;
            if (string.IsNullOrEmpty(DefaultValueTB.Text))
                return;
            if ((_currentAttribute.DataType ?? "") == Item.DataType.Integer_Type)
            {
                DefaultValueTB.Text = Conversions.ToDouble(DefaultValueTB.Text).ToString();
            }
            if ((DefaultValueTB.Text ?? "") == (CurrentAttribute.DefaultValue ?? ""))
                DefaultValueTB.Text = "";
            SendKeys.Send("{End}");
        }

        private void DefaultValueTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                return;
            }
            if (Conversions.ToString(e.KeyChar) == "'")
            {
                e.Handled = true;
            }
            if ((_currentAttribute.DataType ?? "") != Item.DataType.Integer_Type)
                return;
            if (DefaultValueTB.Text.Contains(".") && Conversions.ToString(e.KeyChar) == ".")
                e.Handled = true;
            if (DefaultValueTB.Text.Contains("-") && Conversions.ToString(e.KeyChar) == "-")
                e.Handled = true;
            if (!char.IsDigit(e.KeyChar) && Conversions.ToString(e.KeyChar) != "." && Conversions.ToString(e.KeyChar) != "-" && Conversions.ToString(e.KeyChar) != Constants.vbBack)
            {
                e.Handled = true;
            }

        }

        private string DefaultValueTB_ReadableData()
        {
            if ((_currentAttribute.DataType ?? "") != Item.DataType.Integer_Type)
                return DefaultValueTB.Text;

            try
            {
                return Conversions.ToDouble(DefaultValueTB.Text).ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
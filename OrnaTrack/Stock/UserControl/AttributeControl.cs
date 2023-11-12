using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class AttributeControl
    {

        private Item.Item_Attribute _currentAttribute;

        public Item.Item_Attribute CurrentAttribute
        {
            get
            {
                return _currentAttribute;
            }
            set
            {
                _currentAttribute = value;
                {
                    ref var withBlock = ref _currentAttribute;
                    AttrIconBT.Text = $"{{{withBlock.DataType}{(withBlock.IsCurrency ? "-₹" : "")}}} {withBlock.Name}" + (withBlock.IsOptional ? "*" : "");
                    if (withBlock.IsConstant)
                    {
                        AttrIconBT.Font = new Font(AttrIconBT.Font, FontStyle.Underline);
                    }
                    Size = (Size)new Point(Size.Width + TextRenderer.MeasureText(AttrIconBT.Text, AttrIconBT.Font).Width + 2, Height);
                    if (withBlock.IsFormula)
                    {
                        DefValueLB.Text = "{RULE}";
                    }
                    else if ((withBlock.DataType ?? "") == Item.DataType.List_Type)
                    {
                        DefValueLB.Text = withBlock.DefaultValue.Split('`')[0];
                    }
                    else
                    {
                        DefValueLB.Text = withBlock.DefaultValue;
                    }

                    AttrIconBT.IconChar = withBlock.Icon;
                }

            }
        }

        public event ButtonClickEventHandler ButtonClick;

        public delegate void ButtonClickEventHandler(Item.Item_Attribute _property);

        public AttributeControl()
        {
            InitializeComponent();
        }
        private void UsedButton_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(_currentAttribute);
        }

    }
}
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class SuggestionControl
    {
        private Item.Item_Attribute _Attribute;

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
                if (value is null)
                    return;
                {
                    ref var withBlock = ref _currentAttribute;
                    AttrIconBT.Visible = true;
                    Label2.Visible = true;
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

        public SuggestionControl()
        {
            InitializeComponent();
        }
    }
}
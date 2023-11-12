using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class SelectAttributeForm
    {

        public Item.Item_Attribute SelectedAttribute { get; set; }

        public SelectAttributeForm()
        {
            InitializeComponent();
        }

        private void SelectAttributeForm_Load(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select ID From Item_Attributes");
            var _attributes = new List<Item.Item_Attribute>();

            while (dr.Read())
                _attributes.Add(new Item.Item_Attribute(Conversions.ToInteger(Conversion.Int(dr[0]))));

            foreach (var i in _attributes)
            {
                var _cntrl = new AttributeControl() { CurrentAttribute = i };
                _cntrl.UsedButton.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                _cntrl.UsedButton.IconColor = Color.ForestGreen;

                _cntrl.ButtonClick += () =>
                    {
                        SelectedAttribute = _cntrl.CurrentAttribute;
                        Close();
                    };

                FlowLayoutPanel1.Controls.Add(_cntrl);
            }

        }
    }
}
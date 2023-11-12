using System;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class ItemsUserControl
    {
        private int _StockID;
        public Item CurrentItem { get; set; }
        public int StockID
        {
            get
            {
                return _StockID;
            }
            set
            {
                _StockID = value;

                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select img_path From Stock_Data Where ID={StockID}");
                while (dr.Read())
                {
                    if (!(dr[0] is DBNull))
                    {
                        ImageBox.ImageLocation = Conversions.ToString(dr[0]);
                    }
                }

            }
        }

        public ItemsUserControl()
        {
            InitializeComponent();
            DetailsButton = _DetailsButton;
            _DetailsButton.Name = "DetailsButton";
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {

        }

    }
}
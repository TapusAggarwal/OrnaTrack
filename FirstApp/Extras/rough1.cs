using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class rough1
    {
        public rough1()
        {
            InitializeComponent();
        }
        private void rough1_Load(object sender, EventArgs e)
        {

            var schemaTable = ProjectModule.myconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, "Stock_Data", null });

            foreach (DataRow row in schemaTable.Rows)
                MessageBox.Show(Conversions.ToString(row["COLUMN_NAME"]));

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class BookMode
    {
        public BookMode()
        {
            InitializeComponent();
            Dgv = _Dgv;
            _Dgv.Name = "Dgv";
        }

        private void Kittyreport_Load(object sender, EventArgs e)
        {
            OleDbDataReader dr_Types = (OleDbDataReader)ProjectModule.DataReader("Select DISTINCT KittyType From Kitty_Data");
            while (dr_Types.Read())
            {
                if (ReferenceEquals(dr_Types["KittyType"].GetType(), typeof(DBNull)))
                    return;
                OleDbDataReader dr_UID = (OleDbDataReader)ProjectModule.DataReader($"Select KittyUID From Kitty_Data Where KittyType={dr_Types[0]} ORDER BY KittyNo ASC");
                var BookList = new List<int>();

                while (dr_UID.Read())
                    BookList.Add(Conversions.ToInteger(dr_UID["KittyUID"]));

                Dgv.Rows.Add();
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[0].Value = dr_Types["KittyType"].ToString().ToCurrency(AddSpace: true);
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[1].Value = $"{new Kitty(BookList.First(), true).KittyNo}-{new Kitty(BookList.Last(), true).KittyNo}";
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[2].Value = BookList.Count;
                dr_UID.Close();

                Dgv.Rows[Dgv.Rows.Count - 1].Cells[4].Value = Conversion.Str(new Kitty(BookList.First()).CustomerID) + "_" + Conversion.Str(BookList.First());
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex == 3)
            {
                foreach (Form ExistingFm in My.MyProject.Forms.Frame.MdiChildren)
                {
                    if (ExistingFm.Name != "Main")
                    {
                        ExistingFm.Dispose();
                    }
                }

                var Fm = new KittyModeCoustView()
                {
                    MdiParent = My.MyProject.MyForms.Frame,
                    Tag = Dgv.Rows[e.RowIndex].Cells[4].Value,
                    Dock = DockStyle.Fill
                };
                Close();
                Fm.Show();
            }
        }
    }
}
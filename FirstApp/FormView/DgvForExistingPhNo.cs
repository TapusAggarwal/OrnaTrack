using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class DgvForExistingPhno
    {

        public Customer CurrentCustomer { get; set; } = null;
        public string[] CurrentPhNo { get; set; }
        public int SelectedCustomer { get; set; } = -1;

        public DgvForExistingPhno()
        {
            InitializeComponent();
            Dgv = _Dgv;
            _Dgv.Name = "Dgv";
        }
        private void DgvForExistingPhno_Load(object sender, EventArgs e)
        {
            Dgv.Rows.Clear();

            foreach (int ID in Customer.SharedPhNo(CurrentPhNo))
            {
                var Record = new Customer(ID);
                if (CurrentCustomer is not null && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CurrentCustomer.CustomerID, Record.CustomerID, false)))
                    continue;

                Dgv.Rows.Add();
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[0].Value = Record.FullName();
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[1].Value = Record.PhNo(",");
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[3].Value = Record.CustomerID;
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    SelectedCustomer = Conversions.ToInteger(Dgv.Rows[e.RowIndex].Cells[3].Value);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DgvForExistingPhNo/CellClick Error: " + ex.Message);
            }
        }
    }
}
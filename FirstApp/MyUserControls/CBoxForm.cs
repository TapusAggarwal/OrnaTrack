using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class CBoxForm
    {
        private int cell_loc = 0;
        private List<string> passed_Data = new List<string>();

        public CBoxForm()
        {
            InitializeComponent();
        }

        public void Form5_Load(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            TextBox6.Select();
            passed_Data = (List<string>)Tag;
            Label1.Text = passed_Data[2];
            DataGridView1.Columns[1].HeaderText = passed_Data[1];

            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("select " + passed_Data[0] + " from CBox_Data Where (NOT (" + passed_Data[0] + " = ''))");
            while (dr.Read())
                Add_data(dr[0].ToString());
            dr.Close();
        }

        private void Add_data(object Data)
        {
            int num = DataGridView1.Rows.Count;
            DataGridView1.Rows.Add();

            for (int i = 0, loopTo = num; i <= loopTo; i++)
            {
                if (DataGridView1.Rows[i].Cells[1].Value is null)
                {
                    DataGridView1.Rows[num].Cells[1].Value = Data;
                    Srno_update();
                    return;
                }
            }
        }

        private void Srno_update()
        {
            for (int i = 0, loopTo = DataGridView1.Rows.Count - 1; i <= loopTo; i++)
                DataGridView1.Rows[i].Cells[0].Value = i + 1;
        }

        private void Locate_selection()
        {
            int change = cell_loc;
            int total = DataGridView1.Rows.Count;

            try
            {
                for (int i = 0, loopTo = total - 1; i <= loopTo; i++)
                {
                    if (DataGridView1.Rows[i].Cells[1].Selected)
                    {
                        cell_loc = i;
                        break;
                    }
                }
            }
            catch
            {
                cell_loc = 0;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            string text = TextBox6.Text;
            Add_data(text);
            TextBox6.Text = string.Empty;
            TextBox6.Select();
        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    Locate_selection();
                    int current = cell_loc;
                    string temp_dta = Conversions.ToString(DataGridView1.Rows[current - 1].Cells[1].Value);
                    DataGridView1.Rows[current - 1].Cells[1].Value = DataGridView1.Rows[current].Cells[1].Value;
                    DataGridView1.Rows[current].Cells[1].Value = temp_dta;
                    DataGridView1.Rows[current - 1].Cells[1].Selected = true;
                }
                catch (Exception ex)
                {
                    break;
                }
            }
            while (false);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    int current = cell_loc;
                    string temp_dta = Conversions.ToString(DataGridView1.Rows[current + 1].Cells[1].Value);
                    DataGridView1.Rows[current + 1].Cells[1].Value = DataGridView1.Rows[current].Cells[1].Value;
                    DataGridView1.Rows[current].Cells[1].Value = temp_dta;
                    DataGridView1.Rows[current + 1].Cells[1].Selected = true;
                }

                catch (Exception ex)
                {
                    break;
                }
            }
            while (false);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0, loopTo = DataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (DataGridView1.Rows[i].Cells[1].Selected)
                {
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                MessageBox.Show("First Select Item To Edit!");
                return;
            }

            Locate_selection();
            if (TextBox6.TextLength == 0)
            {
                DataGridView1.Rows.RemoveAt(cell_loc);
                TextBox6.Text = string.Empty;
                TextBox6.Select();
                DataGridView1.Rows[cell_loc].Cells[1].Selected = false;
                Srno_update();
                return;
            }

            DataGridView1.Rows[cell_loc].Cells[1].Value = TextBox6.Text;
            TextBox6.Text = string.Empty;
            DataGridView1.Rows[cell_loc].Cells[1].Selected = false;
            TextBox6.Select();
            Srno_update();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Locate_selection();
            try
            {
                TextBox6.Text = Conversions.ToString(DataGridView1.Rows[cell_loc].Cells[1].Value);
            }
            catch (Exception ex)
            {
            }

            int total = DataGridView1.Rows.Count;
            bool check = false;
            for (int i = 0, loopTo = total - 1; i <= loopTo; i++)
            {
                if (DataGridView1.Rows[i].Cells[1].Selected)
                {
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                TextBox6.Text = string.Empty;
                TextBox6.Select();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string my_str;

            my_str = "select max(SrNo) from CBox_Data";
            var cmd = new OleDbCommand(my_str, ProjectModule.myconnection);
            OleDbDataReader x;
            var max_recod = default(int);
            try
            {
                x = cmd.ExecuteReader();
                x.Read();
                max_recod = Conversions.ToInteger(x[0]);
                x.Close();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProjectModule.SqlCommand("UPDATE CBox_Data SET " + passed_Data[0] + " = Null;");
            for (int i = 0, loopTo = DataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (i >= max_recod)
                {
                    // MessageBox.Show("Inserting " & DataGridView1.Rows(i).Cells(1).Value.ToString)
                    ProjectModule.SqlCommand("insert into CBox_Data (" + passed_Data[0] + ") values('" + DataGridView1.Rows[i].Cells[1].Value.ToString() + "')");
                }
                else
                {
                    // MessageBox.Show("updating " & DataGridView1.Rows(i).Cells(1).Value.ToString)
                    ProjectModule.SqlCommand("update CBox_Data set " + passed_Data[0] + "='" + DataGridView1.Rows[i].Cells[1].Value.ToString() + "' where SrNo=" + (i + 1));
                }
            }
            Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Locate_selection();
            DataGridView1.Rows.RemoveAt(cell_loc);
            Srno_update();
        }
    }
}
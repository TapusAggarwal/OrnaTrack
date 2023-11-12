using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class ListTypeDgv
    {

        public List<string> ListItems { get; set; } = new List<string>();

        public ListTypeDgv()
        {
            InitializeComponent();
            Dgv = _Dgv;
            _Dgv.Name = "Dgv";
        }

        private void LoadItems()
        {
            Dgv.Rows.Clear();
            foreach (var i in ListItems)
            {
                Dgv.Rows.Add();
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[0].Value = Dgv.Rows.Count;
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[1].Value = i;
            }
            ItemTB.Text = "";
            ItemTB.Select();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            if (ItemTB.Text.Length <= 0)
                return;
            if (ListItems.Contains(ItemTB.Text))
                MessageBox.Show("All Items Must Be Distinct.");
            ListItems.Add(ItemTB.Text);
            LoadItems();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            int CurrentIndex = Dgv.CurrentRow.Index;
            if (CurrentIndex < 0)
                return;
            if (ItemTB.Text.Length <= 0)
                return;
            ListItems[CurrentIndex] = ItemTB.Text;
            LoadItems();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (Dgv.CurrentRow.Index < 0)
                return;
            ListItems.Remove(Conversions.ToString(Dgv.CurrentRow.Cells[1].Value));
            LoadItems();
        }

        private void UpBT_Click(object sender, EventArgs e)
        {
            if (Dgv.CurrentRow.Index <= 0)
                return;
            int newIndex = Dgv.CurrentRow.Index - 1;
            string currentItem = Conversions.ToString(Dgv.CurrentRow.Cells[1].Value);
            DeleteBT_Click(sender, e);
            ListItems.Insert(newIndex, currentItem);
            LoadItems();
            Dgv.Rows[newIndex].Cells[0].Selected = true;
        }

        private void DownBT_Click(object sender, EventArgs e)
        {
            if (Dgv.CurrentRow.Index == Dgv.Rows.Count - 1)
                return;
            int newIndex = Dgv.CurrentRow.Index + 1;
            string currentItem = Conversions.ToString(Dgv.CurrentRow.Cells[1].Value);
            DeleteBT_Click(sender, e);
            ListItems.Insert(newIndex, currentItem);
            LoadItems();
            Dgv.Rows[newIndex].Cells[0].Selected = true;
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv.CurrentRow.Index < 0)
                return;
            ItemTB.Text = Conversions.ToString(Dgv.CurrentRow.Cells[1].Value);
            ItemTB.Select();
        }

        public event Submit_CLickEventHandler Submit_CLick;

        public delegate void Submit_CLickEventHandler();

        private void SubmitBT_Click(object sender, EventArgs e)
        {
            Submit_CLick?.Invoke();
        }

        public event Cancel_CLickEventHandler Cancel_CLick;

        public delegate void Cancel_CLickEventHandler();
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Cancel_CLick?.Invoke();
        }

        private void ListTypeDgv_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
    }
}
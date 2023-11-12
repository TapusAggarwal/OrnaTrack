using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FirstApp
{

    public partial class MainStockPage
    {

        private Dictionary<string, object> StockStructure;

        public MainStockPage()
        {
            InitializeComponent();
        }

        private void CategoriesPage_Load(object sender, EventArgs e)
        {
            // InitaliseConnection()
            // myconnection.Open()
            LoadTreeViewData();

        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            Item N;
            var fm = new AddItemPage() { CurrentItem = new Item(-1) };

            if (TreeView1.SelectedNode is not null)
            {
                fm.CurrentItem.ParentCategory = new Item(Conversions.ToInteger(TreeView1.SelectedNode.Name));
            }
            else
            {
                fm.CurrentItem.ParentCategory = new Item(-1);
            }

            fm.ShowDialog();

            N = fm.CurrentItem;

            if (N.ItemID == -1)
                return;

            if (TreeView1.SelectedNode is null)
            {
                TreeView1.Nodes.Add(N.ItemID.ToString(), N.Name);
            }
            else
            {
                TreeView1.SelectedNode.Nodes.Add(N.ItemID.ToString(), N.Name);
            }

            SaveBT.PerformClick();

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Label1.Text = TreeView1.SelectedNode.FullPath;
        }

        private object TreeViewToDictionary(TreeNodeCollection _nodes)
        {
            var dict = new Dictionary<string, object>();

            foreach (TreeNode i in _nodes)
            {
                if (i.Nodes.Count == 0)
                {
                    dict[i.Name] = "";
                }
                else
                {
                    dict[i.Name] = TreeViewToDictionary(i.Nodes);
                }
            }

            return dict;
        }

        private void AddToTree(Dictionary<string, object> _dict, TreeNode _node = null)
        {

            foreach (var i in _dict)
            {
                TreeNode newlyAddedNode;

                var itm = new Item(Conversions.ToInteger(i.Key));

                if (_node is not null)
                {
                    TreeView1.SelectedNode = _node;
                    newlyAddedNode = TreeView1.SelectedNode.Nodes.Add(itm.ItemID.ToString(), itm.Name);
                }
                else
                {
                    newlyAddedNode = TreeView1.Nodes.Add(itm.ItemID.ToString(), itm.Name);
                }
                if (!ReferenceEquals(i.Value, ""))
                {
                    JObject _str = (JObject)i.Value;
                    var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(_str.ToString());
                    AddToTree(dict, newlyAddedNode);
                }
            }

        }

        private void LoadTreeViewData()
        {
            Dictionary<string, object> dict = null;

            System.Data.OleDb.OleDbDataReader dr_count = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select COUNT(Id) From Stock_Structure");

            while (dr_count.Read())
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr_count[0], 0, false)))
                    return;
            }

            try
            {
                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select ItemOrder From Stock_Structure Where Id=1");

                while (dr.Read())
                {
                    dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(Conversions.ToString(dr[0]));
                    break;
                }
            }
            catch (Exception ex)
            {
            }


            StockStructure = dict;

            TreeView1.Nodes.Clear();
            AddToTree(dict);
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dict = (Dictionary<string, object>)TreeViewToDictionary(TreeView1.Nodes);

            string myJ = JsonConvert.SerializeObject(dict);

            try
            {
                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select COUNT(Id) From Stock_Structure");

                while (dr.Read())
                {
                    int _temp = Conversions.ToInteger(dr[0]);
                    if (_temp == 0)
                    {
                        ProjectModule.SqlCommand($"INSERT INTO Stock_Structure (Id,ItemOrder) VALUES (1,'{myJ}')");
                    }
                    else
                    {
                        ProjectModule.SqlCommand($"UPDATE Stock_Structure SET ItemOrder='{myJ}' WHERE Id=1");
                    }
                }
            }
            catch (Exception ex)
            {
            }

            LoadTreeViewData();

        }

        private void StockEntryBT_Click(object sender, EventArgs e)
        {

            if (TreeView1.SelectedNode is null)
                return;

            int _id = Conversions.ToInteger(TreeView1.SelectedNode.Name);

            var fm = new StockEntry() { CurrentItem = new Item(_id) };
            fm.ShowDialog();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            var fm = new AddItemPage();
            if (TreeView1.SelectedNode is not null)
            {
                try
                {
                    var prevItem = new Item(Conversions.ToInteger(TreeView1.SelectedNode.Name));
                    fm.CurrentItem = prevItem;
                }
                catch (Exception ex)
                {
                }
            }

            fm.ShowDialog();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            var fm = new AllStock();
            fm.ShowDialog();
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            var fm = new OrganiseStock();
            fm.ShowDialog();
        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            var Fm = new PurchaseBill();
            Fm.Show();
        }
    }
}
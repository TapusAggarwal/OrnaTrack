using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace FirstApp
{

    public partial class HUID_Checker
    {

        public int Huid_Attrid { get; set; } = 15;

        public Dictionary<string, Dictionary<int, string>> SuggestionsList { get; set; } = new Dictionary<string, Dictionary<int, string>>();

        public HUID_Checker()
        {
            InitializeComponent();
        }

        // Public Property UsedSuggestion As 

        private void HUID_Checker_Load(object sender, EventArgs e)
        {

            if (Huid_Attrid == -1)
                return;

            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select * From Item_Suggestion");

            var _columnNames = new List<string>();

            var schemaTable = ProjectModule.myconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, "Item_Suggestion", null });

            foreach (DataRow row in schemaTable.Rows)
                _columnNames.Add(Conversions.ToString(row["COLUMN_NAME"]));

            while (dr.Read())
            {
                var _dict = new Dictionary<int, string>();
                string _huid = "";
                foreach (var i in _columnNames)
                {
                    if (i == "ID")
                    {
                        _dict.Add(-1, Conversions.ToString(dr["ID"]));
                        continue;
                    }
                    if ((i ?? "") == (Huid_Attrid.ToString() ?? ""))
                    {
                        _huid = Conversions.ToString(dr[i]);
                        continue;
                    }
                    _dict.Add(Conversions.ToInteger(Conversion.Int(i)), dr[i].ToString().Trim());
                }
                SuggestionsList.Add(_huid.Trim(), _dict);
            }

            // SearchTB.Text = "VXZSYD"
        }

        private async Task<string> CheckUIDExists(string huid)
        {
            Cursor = Cursors.WaitCursor;
            string url = "https://mobile.manakonline.in/MANAK/getAHCUIDdetails?uid=" + huid.Trim();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 10000;

            string responseString = "";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    var streamReader = new StreamReader(response.GetResponseStream());
                    responseString = streamReader.ReadToEnd();
                    streamReader.Close();
                }
            }
            catch (WebException ex)
            {
                HttpWebResponse response = (HttpWebResponse)ex.Response;
                if (response is not null)
                {
                    var reader = new StreamReader(response.GetResponseStream());
                    responseString = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                }
            }
            Cursor = Cursors.Default;

            return responseString;
        }

        public event HuidSelectedEventHandler HuidSelected;

        public delegate void HuidSelectedEventHandler(bool status, string huid);
        private bool _status = false;
        private string huid = "";

        private async void FindCoustmerButton_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = false;
            huid = SearchTB.Text;

            FlowLayoutPanel1.Controls.Clear();

            var title = new Label()
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                Margin = new Padding(10, 10, 0, 0),
                Text = "HUID NO: " + huid + " | Status: "
            };
            string _resp = await CheckUIDExists(huid);

            if (_resp == "[{\"Status\":\"false\"}]")
            {
                title.ForeColor = Color.Red;
                title.Text += "False";
                FlowLayoutPanel1.Controls.Add(title);
            }
            else if (string.IsNullOrEmpty(_resp))
            {
                title.ForeColor = Color.Goldenrod;
                title.Text += "No Response";
                FlowLayoutPanel1.Controls.Add(title);
            }
            else
            {
                title.ForeColor = Color.Green;
                title.Text += "Pass";
                _status = true;
                SelectBT.Visible = true;
                FlowLayoutPanel1.Controls.Add(title);

                var jsonData = JArray.Parse(_resp);
                foreach (JObject data in jsonData)
                {
                    foreach (KeyValuePair<string, JToken> kvp in data)
                    {
                        if (kvp.Key != "status")
                        {

                            var _lbl = new KeyValue_Control();
                            _lbl.KeyLB.Text = kvp.Key + ":";
                            _lbl.ValueLB.Text = kvp.Value.ToString();

                            FlowLayoutPanel1.Controls.Add(_lbl);
                        }
                    }
                }
            }

            SelectBT.Select();

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {

            if (SuggestionsList.ContainsKey(SearchTB.Text.Trim()))
            {

            }

            HuidSelected?.Invoke(_status, huid.Trim());
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            SelectBT.Visible = false;

            ListBox1.Items.Clear();
            if (string.IsNullOrEmpty(SearchTB.Text))
            {
                ListBox1.Visible = false;
                return;
            }

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)sender).Text.Trim, "", false)))
                return;

            string[] query = (from entry in SuggestionsList
                              where ContainsLettersInOrder(entry.Key, Conversions.ToString(((dynamic)sender).Text))
                              select entry.Key).ToArray();

            if (query.Count() > 7)
                return;

            ListBox1.Visible = true;
            ListBox1.Items.AddRange(query);

            ListBox1.Height = Math.Min(ListBox1.Items.Count * (ListBox1.ItemHeight + 5), 498);
        }

        public bool ContainsLettersInOrder(string origStr, string inpStr)
        {
            var filteredStr = from c in origStr
                              where inpStr.Contains(Conversions.ToString(c))
                              select c;
            string joinedStr = string.Join("", filteredStr);
            return (inpStr ?? "") == (joinedStr ?? "");
        }

        private void SearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindCoustmerButton.PerformClick();
            }
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchTB.Text = Conversions.ToString(ListBox1.SelectedItem);
        }
    }
}
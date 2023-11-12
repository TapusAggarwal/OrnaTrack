using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocket4Net;

namespace FirstApp
{

    public partial class StockEntry
    {

        public Item CurrentItem { get; set; }
        public int StockID { get; set; } = -1;
        private List<string> _huids = new List<string>();

        public StockEntry()
        {
            InitializeComponent();
        }

        private void StockEntry_Load(object sender, EventArgs e)
        {

            KeyPreview = true;

            if (CurrentItem.ItemID < 0)
                return;

            foreach (var _attribute in CurrentItem.Attributes)
            {
                var x = new AttributeStockControl()
                {
                    CurrentAttribute = _attribute,
                    Name = _attribute.Name
                };

                if ((_attribute.Attr_Ctg ?? "") == Item.AttributeCategory.Purchase_Type)
                {
                    PurchaseFP.AddControl(x);
                    PurchaseFP.AutoReSize();
                }
                else if ((_attribute.Attr_Ctg ?? "") == Item.AttributeCategory.Product_Type)
                {
                    ProductFP.AddControl(x);
                    ProductFP.AutoReSize();
                }
                else
                {
                    SaleFP.AddControl(x);
                    SaleFP.AutoReSize();
                }

                if (_attribute.Name == "Huid No")
                {

                    System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select * From Stock_Data");
                    while (dr.Read())
                    {
                        var _jsonObject = JsonConvert.DeserializeObject<JObject>(Conversions.ToString(dr["Item_Data"]));

                        if (_jsonObject.ContainsKey("15"))
                        {
                            var _list = _jsonObject["15"].ToString().Split(',').ToList();
                            _list.Remove("");
                            if (_list.Count > 0)
                            {
                                _huids.AddRange(_list);
                            }
                        }
                    }

                    _huids = _huids.Select(str => str.Trim()).ToList();

                    KeyDown += (_sender, _e) =>
                        {
                            if (_e.KeyCode == Keys.I && _e.Control == true)
                            {
                                string f = x.DefaultValueTB.Text;
                                var Fm = new HUID_Checker();
                                Fm.SearchTB.Select();
                                _e.Handled = true;
                                Fm.HuidSelected += (_status, _huid) =>
            {

                                    if (_huids.Contains(_huid.Trim()))
                                    {
                                        MessageBox.Show("This HUID No. Is Already Used For An Item Before.", "Duplication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    if (_status)
                                    {
                                        string _text = Conversions.ToString(x.EnteredData);
                                        if ((_text ?? "") == (_attribute.DefaultValue ?? ""))
                                            _text = "";
                                        var _list = _text.Split(',').ToList();
                                        _list.Remove("");
                                        _list.Add(_huid);
                                        Fm.Close();
                                        if (_list.Count == 1)
                                        {
                                            x.DefaultValueTB.Text = _huid;
                                        }
                                        else
                                        {
                                            x.DefaultValueTB.Text = string.Join(",", _list);
                                        }
                                    }
                                };
                                Fm.ShowDialog();
                            }
                        };
                }

            }

            foreach (var _attribute in CurrentItem.Attributes)
            {
                if (!_attribute.IsFormula)
                    continue;

                var DependentAttributes = _attribute.DependsUpon(CurrentItem);

                foreach (var i in DependentAttributes)
                {
                    AttributeStockControl _control = (AttributeStockControl)Panel1.Controls.Find(i.Name, true)[0];
                    _control.DefaultValueTB.TextChanged += (_sender, _e) =>
    {
        if (string.IsNullOrEmpty(((TextBox)_sender).Text))
            return;
        string formula = _attribute.DefaultValue;

        foreach (var _attr in DependentAttributes)
        {
            AttributeStockControl _cntrl = (AttributeStockControl)Panel1.Controls.Find(_attr.Name, true)[0];
            string _enteredData = Conversions.ToString(_cntrl.EnteredData);
            if (string.IsNullOrEmpty(_enteredData))
                _enteredData = 0.ToString();
            formula = formula.Replace($"{{{_attr.Name}}}", _enteredData);
        }

        try
        {
            string equation = formula;
            string result = Conversions.ToDouble(new DataTable().Compute(equation, null)).ToString();

            AttributeStockControl _ruleControl = (AttributeStockControl)Panel1.Controls.Find(_attribute.Name, true)[0];

            _ruleControl.DefaultValueTB.Text = result;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    };
                }

            }

            ListenerStatus();

            // PurchaseFP.Visible = False
            // SaleFP.Visible = False

            previousImage = ImageBox.Image;

            if (StockID != -1)
            {
                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select img_path,Item_Data From Stock_Data Where ID={StockID}");
                var x = new Dictionary<int, string>();
                while (dr.Read())
                {
                    x = JsonConvert.DeserializeObject<Dictionary<int, string>>(Conversions.ToString(dr[1]));
                    if (!(dr[0] is DBNull))
                    {
                        ImageBox.ImageLocation = Conversions.ToString(dr[0]);
                    }
                }

                foreach (var id in x.Keys)
                {
                    var f = CurrentItem.Attributes.Where(g => g.ID == id).ElementAtOrDefault(0);
                    AttributeStockControl _cntrl = (AttributeStockControl)Panel1.Controls.Find(f.Name, true)[0];
                    switch (f.DataType ?? "")
                    {
                        case Item.DataType.Boolean_Type:
                            {

                                if (x[id] == "True")
                                {
                                    _cntrl.TrueChB.Checked = true;
                                }
                                else
                                {
                                    _cntrl.FalseChB.Checked = true;
                                }

                                break;
                            }


                        case Item.DataType.List_Type:
                            {

                                _cntrl.ListValues.SelectedIndex = _cntrl.ListValues.FindStringExact(x[id].Split('`')[0]);
                                break;
                            }


                        case Item.DataType.Integer_Type:
                            {

                                _cntrl.DefaultValueTB.Text = x[id];
                                break;
                            }


                        case Item.DataType.String_Type:
                            {

                                _cntrl.DefaultValueTB.Text = x[id];
                                break;
                            }


                    }
                }

                SaveBT.Text = "Update";

            }

        }

        private Frame fm = null;

        public async void ListenerStatus()
        {
            foreach (Form _form in Application.OpenForms)
            {
                if (!(_form is Frame))
                    continue;
                fm = (Frame)_form;
                break;
            }

            var req = WebRequest.Create($"http://{My.MySettingsProperty.Settings.connection_url}?purpose=phno_listeners");
            req.Method = "POST";
            req.Timeout = 3000;
            try
            {
                using (var request = await req.GetResponseAsync())
                {
                    using (var reader = new StreamReader(request.GetResponseStream()))
                    {
                        string response = await reader.ReadToEndAsync();

                        if (response.Trim().Length == 0)
                            return;
                        ListeningStatusPanel.BackColor = Color.FromArgb(0, 64, 0);

                        if (ProjectModule.WebSocket is null || !(ProjectModule.WebSocket.State == WebSocketState.Open))
                        {
                            await fm?.StartServer(false);
                        }

                        fm.NewMessage_Socket -= UpdateImage;
                        fm.NewMessage_Socket += UpdateImage;

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private int _currentImageIndex = -1;

        public void UpdateImage()
        {
            Cursor = Cursors.AppStarting;
            var req = WebRequest.Create($"http://{My.MySettingsProperty.Settings.connection_url}?purpose=latest_images");
            req.Method = "POST";

            // Get the response and extract the base64 encoded string
            var response = req.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream());
            string base64String = streamReader.ReadToEnd();

            if (string.IsNullOrEmpty(base64String))
                return;

            // Convert the base64 encoded string to a byte array
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Convert the byte array to an image
            using (var memoryStream = new MemoryStream(imageBytes))
            {
                var image = Image.FromStream(memoryStream);
                if (ImageBox.IsHandleCreated)
                {
                    ImageBox.Invoke(new Action(() => ImageBox.Image = new Bitmap(image)));
                }
                // Do something with the image, such as display it
            }
            Cursor = Cursors.Default;
        }

        // Private Sub Panel1_SizeChanged(sender As Object, e As EventArgs) Handles Panel1.SizeChanged
        // Size = New Point(SaleFP.Size.Width + ListeningStatusPanel.Size.Width + 40, Size.Height)
        // End Sub
        private Image previousImage;

        private void SaveBT_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Save This Item.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            var x = new Dictionary<int, string>();

            foreach (var _attr in CurrentItem.Attributes)
            {
                if (_attr.IsFormula)
                    continue;
                AttributeStockControl _cntrl = (AttributeStockControl)Panel1.Controls.Find(_attr.Name, true)[0];
                var _enteredData = _cntrl.EnteredData;
                if ((_attr.DataType ?? "") == Item.DataType.List_Type)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(_enteredData, _attr.DefaultValue.Split('`')[0], false)))
                    {
                        x.Add(_attr.ID, Conversions.ToString(_enteredData));
                    }
                    continue;

                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(_enteredData, _attr.DefaultValue, false)))
                {
                    x.Add(_attr.ID, Conversions.ToString(_enteredData));
                }

            }

            string _str = JsonConvert.SerializeObject(x);

            if (x.ContainsKey(15))
            {
                if (_huids.Contains(x[15]))
                {
                    MessageBox.Show("This HUID No. Is Already Used For An Item Before.", "Duplication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (StockID > 0)
            {
                ProjectModule.SqlCommand($"UPDATE Stock_Data SET Ctg_ID='{CurrentItem.ItemID}',Item_Data='{_str}',entry_time='{DateTime.Now}' WHERE ID={StockID}");
            }
            else
            {
                ProjectModule.SqlCommand($"Insert INTO Stock_Data (Ctg_ID,Item_Data,entry_time) VALUES ('{CurrentItem.ItemID}','{_str}','{DateTime.Now}')");

                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select MAX(ID) FROM Stock_Data");
                int _int = -1;
                while (dr.Read())
                    _int = Conversions.ToInteger(dr[0] is DBNull ? -1 : dr[0]);

                if (_int == -1)
                    return;
                StockID = _int;
                SaveBT.Text = "Update";
            }

            if (!ImageBox.Image.Equals(previousImage))
            {
                ImageBox.Image.Save($@"C:\Users\hp\Desktop\stock_images\img{StockID}.jpg");
            }

            ProjectModule.SqlCommand($@"UPDATE Stock_Data SET img_path='{$@"C:\Users\hp\Desktop\stock_images\img{StockID}.jpg"}' WHERE ID={StockID}");

            Dispose();
            foreach (Form _form in Application.OpenForms)
            {
                if (!(_form is MainStockPage))
                    continue;
                ((MainStockPage)_form).Focus();
                ((MainStockPage)_form).StockEntryBT.PerformClick();
                break;
            }



        }

        private void ReloadImgBT_Click(object sender, EventArgs e)
        {
            _currentImageIndex = -1;
            UpdateImage();
        }

        // Private Sub NextImgButton_Click(sender As Object, e As EventArgs) Handles NextImgButton.Click
        // If _currentImageIndex < -1 Then
        // _currentImageIndex += 1
        // UpdateImage()
        // BackImgButton.Enabled = True
        // Else
        // NextImgButton.Enabled = False
        // _currentImageIndex = -1
        // End If
        // End Sub

        private void StockEntry_Closed(object sender, EventArgs e)
        {
            fm.NewMessage_Socket -= UpdateImage;
            Dispose();
        }


        // Private Sub BackImgButton_Click(sender As Object, e As EventArgs) Handles BackImgButton.Click
        // _currentImageIndex += 1
        // If Not UpdateImage() Then BackImgButton.Enabled = False
        // NextImgButton.Enabled = True
        // End Sub

    }
}
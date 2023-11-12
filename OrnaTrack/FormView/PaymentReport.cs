using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class PaymentReport
    {

        private List<Kitty> AllKitties = new List<Kitty>();

        private CancellationTokenSource cts = new CancellationTokenSource();

        public PaymentReport()
        {
            InitializeComponent();
        }

        private async void rough_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            Cursor = Cursors.AppStarting;
            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select KittyUID From Kitty_Data");
            var T_List = new List<Task<Kitty>>();
            while (dr.Read())
            {
                var _id = Conversion.Int(dr[0]);
                T_List.Add(Task.Run(() => new Kitty(Conversions.ToInteger(_id), true, true)));
            }
            Kitty[] res = await Task.WhenAll(T_List);
            AllKitties = res.ToList();
            dr.Close();

            var x = new Dictionary<DateTime, List<Kitty>>();
            foreach (var i in AllKitties.Select(f => new Tuple<Dictionary<DateTime, int>, Kitty>(f.Record, f)))
            {
                foreach (var j in i.Item1)
                {
                    if (x.ContainsKey(j.Key))
                    {
                        x[j.Key].Add(i.Item2);
                    }
                    else
                    {
                        x.Add(j.Key, new List<Kitty>(new[] { i.Item2 }));
                    }
                }
            }

            var sorted = from pair in x
                         orderby pair.Key
                         select pair;
            x = sorted.ToDictionary(k => k.Key, v => v.Value);
            var _dict = x.Reverse();
            var _date = _dict.First().Key;

            var Cntrl_List = new List<Task<PerUnitTimeControl>>();

            Cursor = Cursors.Default;

            while (_date > _dict.Last().Key)
            {
                var _val = _date;
                Cntrl_List.Add(Task.Run(() =>
                    {
                        var _cntrl = new PerUnitTimeControl();
                        var d = _dict.Where(f => f.Key.Year == _val.Year && f.Key.Month == _val.Month).ToDictionary(k => k.Key, v => v.Value);
                        if (d.Count == 0)
                            return null;
                        _cntrl.MakeOneMonthControl(d);
                        return _cntrl;
                    }, cts.Token));
                _date = _date.AddMonths(-1);
            }

            foreach (var i in Cntrl_List)
            {
                if (i.IsCanceled)
                    break;
                var f = await i;
                if (f is null)
                    continue;
                FlowLayoutPanel1.Controls.Add(f);
            }

            cts.Dispose();
            cts = null;

        }

        private void Rough_Closed(object sender, EventArgs e)
        {
            if (cts is not null)
            {
                cts.Cancel();
                Dispose();
            }
        }

        private void PreviewCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show(FlowLayoutPanel1.VerticalScroll.Value)
            FlowLayoutPanel1.VerticalScroll.SmallChange = 48;
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    int change = FlowLayoutPanel1.VerticalScroll.Value - FlowLayoutPanel1.VerticalScroll.SmallChange;
                    FlowLayoutPanel1.AutoScrollPosition = new Point(0, change);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    int change = FlowLayoutPanel1.VerticalScroll.Value + FlowLayoutPanel1.VerticalScroll.SmallChange;
                    FlowLayoutPanel1.AutoScrollPosition = new Point(0, change);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void c()
        {
            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select * From Transaction_Data");

            while (dr.Read())
            {
                string _ids = Conversions.ToString(dr["KittyIds"]);
                if (_ids.Contains(","))
                    continue;

                int _id = Conversions.ToInteger(Conversion.Int(_ids));
                var _trns = new Transaction(Conversions.ToInteger(dr["TrnsID"]));

                // _trns.KittyIds.Add(_id, dr("Structure"))
                _trns.Save();
            }

        }


        // Private Sub Button2_Click(sender As Object, e As EventArgs)
        // Dim distinct As New Dictionary(Of String, List(Of String))
        // Dim _good As New Dictionary(Of String, List(Of String))
        // Dim _letters As New Dictionary(Of String, List(Of String))

        // For Each i In AllKitties
        // Dim dr As OleDbDataReader = DataReader($"Select TransactionDetails From Kitty_Data Where KittyUID={i.KittyUID}")
        // Dim _str As String = ""

        // While dr.Read
        // _str = If(IsDBNull(dr(0)), "", dr(0))
        // End While
        // If _str = "" Then Continue For

        // For Each j In Split(_str, "|,|", , CompareMethod.Text)

        // If j.Length = 10 Then Continue For

        // Dim SavedData As Linq.JObject = Linq.JObject.Parse(j.Substring(10))

        // Dim _date As Date = j.Substring(0, 10)

        // Dim dict As New Dictionary(Of String, String) From {
        // {"TrnsDate", _date.ToShortDateString},
        // {"Mode", SavedData.SelectToken("Mode")},
        // {"Account", SavedData.SelectToken("Account")},
        // {"Amount", i.Record(_date)},
        // {"RefNo", SavedData.SelectToken("RefNo")},
        // {"Notes", SavedData.SelectToken("Notes")},
        // {"KittyIds", i.KittyUID},
        // {"Structure", i.Record(_date)}
        // }

        // If dict("Mode").ToLower = "cash" Then
        // Continue For
        // End If
        // If distinct.ContainsKey(dict("RefNo")) Then
        // distinct(dict("RefNo")).Add(JsonConvert.SerializeObject(dict, Formatting.Indented))
        // Else
        // Dim _str1 = JsonConvert.SerializeObject(dict, Formatting.Indented)
        // distinct.Add(dict("RefNo"), New List(Of String)({_str1}))
        // End If

        // 'Dim _mode = dict.Item("Mode")
        // 'Dim _acc = dict.Item("Account")
        // 'Dim _ref = dict.Item("RefNo")
        // 'Dim _note = dict.Item("Notes")
        // 'SqlCommand($"Insert Into Transaction_Data (TrnsDate,Mode,Account,RefNo,Notes,KittyIds)" &
        // '           $"Values('{j}','{_mode}','{_acc}','{_ref}','{_note}'),'{i.KittyUID}'")
        // Next
        // Next

        // For Each i In distinct
        // If i.Value.Count = 1 Then
        // Dim SavedData As Linq.JObject = Linq.JObject.Parse(i.Value.First)
        // Dim _date As String = SavedData.SelectToken("TrnsDate")
        // Dim _amt As Integer = SavedData.SelectToken("Amount")
        // Dim _id As Integer = SavedData.SelectToken("KittyIds")
        // Dim _kitty = AllKitties.Where(Function(f) f.KittyUID = _id)(0)
        // If _kitty.Record.Item(_date) = _amt Then
        // _good.Add(i.Key, i.Value)
        // End If
        // End If
        // Next

        // For Each i In _good
        // distinct.Remove(i.Key)
        // Next

        // For Each i In _good
        // Dim f = System.Text.RegularExpressions.Regex.Replace(i.Key, "\d", "")
        // If f <> "" Then
        // 'Contains letter
        // _letters.Add(i.Key, i.Value)
        // End If
        // Next
        // Dim d = ""

        // For Each i In _letters
        // _good.Remove(i.Key)
        // Next


        // For Each i In distinct("")

        // Dim SavedData As Linq.JObject = Linq.JObject.Parse(i)

        // SavedData.SelectToken("Notes")
        // Dim _date = SavedData.SelectToken("TrnsDate")
        // Dim _mode = SavedData.SelectToken("Mode")
        // Dim _acc = SavedData.SelectToken("Account")
        // Dim _amt = SavedData.SelectToken("Amount")
        // Dim _ref = SavedData.SelectToken("RefNo")
        // Dim _id = SavedData.SelectToken("KittyIds")
        // Dim _note = SavedData.SelectToken("Notes")
        // Dim _structure = SavedData.SelectToken("Structure")

        // SqlCommand($"Insert Into Transaction_Data (TrnsDate,Mode,Amount,Account,RefNo,KittyIds,Notes,Structure)" &
        // $"Values('{_date}','{_mode}','{_amt}','{_acc}','{_ref}','{_id}','{_note}','{_structure}')")
        // Next

        // distinct.Remove("")

        // '_good.Add(_letters.First.Key, _letters.First.Value)
        // '_good.Add(_letters.Last.Key, _letters.Last.Value)

        // Dim sdf As String = ""
        // For Each i In distinct.Values
        // For Each j In i
        // sdf += j + "|,|"
        // Next
        // Next


        // Dim ewq As String = Str(sdf)

        // Dim sorted = From pair In _good
        // Order By pair.Key.Length

        // For Each i In distinct.First.Value

        // If i = "" Then Exit Sub

        // Dim SavedData As Linq.JObject = Linq.JObject.Parse(i)

        // SavedData.SelectToken("Notes")
        // Dim _date = SavedData.SelectToken("TrnsDate")
        // Dim _mode = SavedData.SelectToken("Mode")
        // Dim _acc = SavedData.SelectToken("Account")
        // Dim _amt = SavedData.SelectToken("Amount")
        // Dim _ref = SavedData.SelectToken("RefNo")
        // Dim _id = SavedData.SelectToken("KittyIds")
        // Dim _note = SavedData.SelectToken("Notes")
        // SqlCommand($"Insert Into Transaction_Data (TrnsDate,Mode,Amount,Account,RefNo,KittyIds,Notes)" &
        // $"Values('{_date}','{_mode}','{_amt}','{_acc}','{_ref}','{_id}','{_note}')")
        // Next

        // Dim s = ""
        // End Sub

    }
}
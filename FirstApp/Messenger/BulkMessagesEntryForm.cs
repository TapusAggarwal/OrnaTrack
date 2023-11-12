using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class BulkMessagesEntryForm
    {
        private readonly Dictionary<int, Dictionary<string, List<Kitty>>> Kitties = new Dictionary<int, Dictionary<string, List<Kitty>>>();
        private readonly List<Kitty> SelectedMatured = new List<Kitty>();
        private readonly List<Kitty> SelectedAvailed = new List<Kitty>();
        private readonly List<Kitty> SelectedInActive = new List<Kitty>();
        private readonly Dictionary<int, List<Kitty>> instalmentsLeft = new Dictionary<int, List<Kitty>>();
        private readonly Dictionary<int, List<Kitty>> instalmentsPending = new Dictionary<int, List<Kitty>>();

        private readonly List<Kitty> SelectedKitties = new List<Kitty>();

        public BulkMessagesEntryForm()
        {
            InitializeComponent();
        }

        private void KittyItemsVisibility(bool state)
        {
            KittyTypeCList.Visible = state;
            MaturedChB.Visible = state;
            AvailedChB.Visible = state;
            InActiveCB.Visible = state;
            InstalmentsLeftCList.Visible = state;
        }

        private void KittySelectionChB_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerSelectionChB.Checked & KittySelectionChB.Checked == true)
            {
                CustomerSelectionChB.Checked = false;
            }

            CustomerSelectionChB.Enabled = true;
            KittySelectionChB.Enabled = false;

            if (KittySelectionChB.Checked)
            {
                KittyTypeCList.Visible = true;
                Kitties.Clear();
                {
                    ref var withBlock = ref this;
                    withBlock.Cursor = Cursors.AppStarting;
                    withBlock.Refresh();
                }

                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select KittyUID From Kitty_Data");
                while (dr.Read())
                {
                    var _temp = new Kitty(UID: Conversions.ToInteger(dr["KittyUID"]), InitializeKitty: true, completely: true);
                    if (!Kitties.ContainsKey(_temp.KittyType))
                    {
                        var _hashMap = new Dictionary<string, List<Kitty>>() { { "active", new List<Kitty>() }, { "matured", new List<Kitty>() }, { "inactive", new List<Kitty>() }, { "availed", new List<Kitty>() } };
                        Kitties.Add(_temp.KittyType, _hashMap);
                    }
                    if (_temp.IsAvailed)
                    {
                        Kitties[_temp.KittyType]["availed"].Add(_temp);
                    }
                    else if (_temp.IsMatured())
                    {
                        Kitties[_temp.KittyType]["matured"].Add(_temp);
                    }
                    else if (_temp.IsInactive)
                    {
                        Kitties[_temp.KittyType]["inactive"].Add(_temp);
                    }
                    else if (_temp.GivenAmount() > 0)
                    {
                        Kitties[_temp.KittyType]["active"].Add(_temp);
                    }
                }

                dr.Close();

                KittyTypeCList.Items.Clear();
                int total = 0;
                foreach (var i in Kitties)
                    total += i.Value["active"].Count;
                KittyTypeCList.Items.Add($"All({total})");

                foreach (var i in Kitties)
                {
                    int _sum = i.Value.Values.Sum(f => f.Count);
                    KittyTypeCList.Items.Add($"{i.Key} ({_sum})");
                }

                {
                    ref var withBlock1 = ref this;
                    withBlock1.Cursor = Cursors.Default;
                    withBlock1.Refresh();
                }

                GC.Collect();
            }

            else
            {
                KittyItemsVisibility(state: false);
            }
        }

        private void CustomerSelectionChB_CheckedChanged(object sender, EventArgs e)
        {
            if (KittySelectionChB.Checked & CustomerSelectionChB.Checked == true)
                KittySelectionChB.Checked = false;

            CustomerSelectionChB.Enabled = false;
            KittySelectionChB.Enabled = true;

            if (CustomerSelectionChB.Checked)
            {
                for (int i = 0, loopTo = KittyTypeCList.Items.Count - 1; i <= loopTo; i++)
                    KittyTypeCList.SetItemChecked(i, false);
                KittyTypeCList.Visible = false;
            }
        }

        private void UpdateInstalmentsLeft(int AddSelection = -1, int RemoveSelection = -1)
        {

            var x = new List<int>();
            foreach (var i in KittyTypeCList.CheckedItems)
            {

                try
                {
                    if (KittyTypeCList.GetItemChecked(KittyTypeCList.Items.IndexOf(i)))
                    {
                        x.Add(Conversions.ToInteger(Conversion.Int(i.ToString().Split('(')[0])));
                    }
                }
                catch (Exception ex)
                {
                }

            }

            try
            {
                if (AddSelection != -1)
                {
                    x.Add(AddSelection);
                }
                else if (RemoveSelection != -1)
                {
                    x.Remove(RemoveSelection);
                }
            }
            catch (Exception ex)
            {
            }


            x = x.Distinct().ToList();

            SelectedMatured.Clear();
            SelectedAvailed.Clear();
            SelectedInActive.Clear();

            var _active = new List<Kitty>();

            foreach (var i in x)
            {
                SelectedMatured.AddRange(Kitties[i]["matured"]);
                SelectedAvailed.AddRange(Kitties[i]["availed"]);
                SelectedInActive.AddRange(Kitties[i]["inactive"]);
                _active.AddRange(Kitties[i]["active"]);
            }

            if (SelectedMatured.Count > 0)
            {
                MaturedChB.Enabled = true;
                MaturedChB.Text = $"Matured ({SelectedMatured.Count})";
            }
            else
            {
                MaturedChB.Enabled = false;
                MaturedChB.Text = "Matured";
            }

            if (SelectedAvailed.Count > 0)
            {
                AvailedChB.Enabled = true;
                AvailedChB.Text = $"Availed ({SelectedAvailed.Count})";
            }
            else
            {
                AvailedChB.Enabled = false;
                AvailedChB.Text = "Availed";
            }

            if (SelectedInActive.Count > 0)
            {
                InActiveCB.Enabled = true;
                InActiveCB.Text = $"InActive ({SelectedInActive.Count})";
            }
            else
            {
                InActiveCB.Enabled = false;
                InActiveCB.Text = "InActive";
            }

            InstalmentsLeftCList.Items.Clear();
            instalmentsLeft.Clear();

            foreach (var i in _active)
            {
                if (instalmentsLeft.ContainsKey(i.GetInstalments_LeftForMaturity()))
                {
                    instalmentsLeft[i.GetInstalments_LeftForMaturity()].Add(i);
                }
                else
                {
                    instalmentsLeft.Add(i.GetInstalments_LeftForMaturity(), new List<Kitty>() { i });
                }
            }

            instalmentsLeft.Remove(0);

            var sorted = from pair in instalmentsLeft
                         orderby pair.Key
                         select pair;

            int total = 0;
            foreach (var i in sorted)
            {
                total += i.Value.Count;
                if (i.Key == 1)
                {
                    InstalmentsLeftCList.Items.Add($"{i.Key} Instalment Left ({i.Value.Count})");
                }
                else
                {
                    InstalmentsLeftCList.Items.Add($"{i.Key} Instalments Left ({i.Value.Count})");
                }
            }
            InstalmentsLeftCList.Items.Insert(0, $"All ({total})");
            InstalmentsPendingCList.Visible = false;

            UpdateInstalmentsPending();

        }

        private void UpdateInstalmentsPending(int AddSelection = -1, int RemoveSelection = -1)
        {
            var x = new List<int>();
            foreach (var i in InstalmentsLeftCList.CheckedItems)
            {

                try
                {
                    if (InstalmentsLeftCList.GetItemChecked(InstalmentsLeftCList.Items.IndexOf(i)))
                    {
                        x.Add(Conversions.ToInteger(Conversion.Int(i.ToString().Split(' ')[0])));
                    }
                }
                catch (Exception ex)
                {
                }

            }

            try
            {
                if (AddSelection != -1)
                {
                    x.Add(AddSelection);
                }
                else if (RemoveSelection != -1)
                {
                    x.Remove(RemoveSelection);
                }
            }
            catch (Exception ex)
            {
            }

            InstalmentsPendingCList.Items.Clear();
            instalmentsPending.Clear();

            x = x.Distinct().ToList();

            foreach (var i in x)
            {
                foreach (var _kitty in instalmentsLeft[i])
                {
                    if (instalmentsPending.ContainsKey(_kitty.GetInstalmentsPending()))
                    {
                        instalmentsPending[_kitty.GetInstalmentsPending()].Add(_kitty);
                    }
                    else
                    {
                        instalmentsPending.Add(_kitty.GetInstalmentsPending(), new List<Kitty>() { _kitty });
                    }
                }
            }

            var sorted = from pair in instalmentsPending
                         orderby pair.Key
                         select pair;

            int total = 0;
            foreach (var i in sorted)
            {
                total += i.Value.Count;
                if (i.Key == 1)
                {
                    InstalmentsPendingCList.Items.Add($"{i.Key} Instalment Pending ({i.Value.Count})");
                }
                else
                {
                    InstalmentsPendingCList.Items.Add($"{i.Key} Instalments Pending ({i.Value.Count})");
                }
            }
            InstalmentsPendingCList.Items.Insert(0, $"All ({total})");

            UpdateSelectedKitty();

        }

        private void UpdateSelectedKitty(int AddSelection = -1, int RemoveSelection = -1)
        {
            SelectedKitties.Clear();

            var x = new List<int>();
            foreach (var i in InstalmentsPendingCList.CheckedItems)
            {

                try
                {
                    if (InstalmentsPendingCList.GetItemChecked(InstalmentsPendingCList.Items.IndexOf(i)))
                    {
                        x.Add(Conversions.ToInteger(Conversion.Int(i.ToString().Split(' ')[0])));
                    }
                }
                catch (Exception ex)
                {
                }

            }

            try
            {
                if (AddSelection != -1)
                {
                    x.Add(AddSelection);
                }
                else if (RemoveSelection != -1)
                {
                    x.Remove(RemoveSelection);
                }
            }
            catch (Exception ex)
            {
            }

            x = x.Distinct().ToList();

            foreach (var i in x)
            {
                foreach (var _kitty in instalmentsPending[i])
                    SelectedKitties.Add(_kitty);
            }

            if (MaturedChB.Checked)
            {
                SelectedKitties.AddRange(SelectedMatured);
            }
            if (AvailedChB.Checked)
            {
                SelectedKitties.AddRange(SelectedAvailed);
            }
            if (InActiveCB.Checked)
            {
                SelectedKitties.AddRange(SelectedInActive);
            }

            if (SelectedKitties.Count == 0)
            {
                SelectedCustomersLB.Text = 0.ToString();
                PreviewBT.Enabled = false;
                SendButton.Enabled = false;
            }
            else
            {
                SelectedCustomersLB.Text = SelectedKitties.Count.ToString();
                PreviewBT.Enabled = true;
                SendButton.Enabled = true;
            }


        }

        private void InstalmentsPendingCList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (InstalmentsPendingCList.Items[e.Index].ToString().Split(' ')[0].Trim() == "All" && e.NewValue == CheckState.Checked)
            {
                for (int i = 1, loopTo = InstalmentsPendingCList.Items.Count - 1; i <= loopTo; i++)
                    InstalmentsPendingCList.SetItemChecked(i, true);
            }
            else if (InstalmentsPendingCList.Items[e.Index].ToString().Split(' ')[0].Trim() == "All" && e.NewValue == CheckState.Unchecked && e.CurrentValue == CheckState.Checked)
            {
                if (InstalmentsPendingCList.CheckedItems.Count == InstalmentsPendingCList.Items.Count)
                {
                    for (int i = 1, loopTo1 = InstalmentsPendingCList.Items.Count - 1; i <= loopTo1; i++)
                        InstalmentsPendingCList.SetItemChecked(i, false);
                }
            }

            if (e.NewValue == CheckState.Unchecked)
            {
                if (InstalmentsPendingCList.Items[e.Index].ToString().Split(' ')[0].Trim() != "All" && e.NewValue == CheckState.Unchecked)
                {
                    InstalmentsPendingCList.Refresh();
                    InstalmentsPendingCList.ItemCheck -= InstalmentsPendingCList_ItemCheck;
                    InstalmentsPendingCList.SetItemChecked(0, false);
                    InstalmentsPendingCList.ItemCheck += InstalmentsPendingCList_ItemCheck;
                }
            }


            int Selection = -1;
            try
            {
                Selection = Conversions.ToInteger(Conversion.Int(InstalmentsPendingCList.Items[e.Index].ToString().Split(' ')[0].Trim()));
            }
            catch (Exception ex)
            {
            }

            if (Selection == -1)
                return;


            if (e.NewValue == CheckState.Checked)
            {
                UpdateSelectedKitty(Selection);
            }
            else
            {
                UpdateSelectedKitty(-1, Selection);
            }

        }

        private void InstalmentsLeftCList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // PreviewBT.Enabled = False
            if (InstalmentsLeftCList.Items[e.Index].ToString().Split(' ')[0].Trim() == "All" && e.NewValue == CheckState.Checked)
            {
                for (int i = 1, loopTo = InstalmentsLeftCList.Items.Count - 1; i <= loopTo; i++)
                    InstalmentsLeftCList.SetItemChecked(i, true);
            }
            else if (InstalmentsLeftCList.Items[e.Index].ToString().Split(' ')[0].Trim() == "All" && e.NewValue == CheckState.Unchecked && e.CurrentValue == CheckState.Checked)
            {
                if (InstalmentsLeftCList.CheckedItems.Count == InstalmentsLeftCList.Items.Count)
                {
                    for (int i = 1, loopTo1 = InstalmentsLeftCList.Items.Count - 1; i <= loopTo1; i++)
                        InstalmentsLeftCList.SetItemChecked(i, false);
                }
            }

            if (e.NewValue == CheckState.Unchecked)
            {
                if (InstalmentsLeftCList.Items[e.Index].ToString().Split(' ')[0].Trim() != "All" && e.NewValue == CheckState.Unchecked)
                {
                    InstalmentsLeftCList.Refresh();
                    InstalmentsLeftCList.ItemCheck -= InstalmentsLeftCList_ItemCheck;
                    InstalmentsLeftCList.SetItemChecked(0, false);
                    InstalmentsLeftCList.ItemCheck += InstalmentsLeftCList_ItemCheck;
                }
                if (InstalmentsLeftCList.CheckedItems.Count == 1)
                {
                    InstalmentsPendingCList.Visible = false;
                }
            }

            if (e.NewValue == CheckState.Checked && InstalmentsLeftCList.CheckedItems.Count == 0)
            {
                InstalmentsPendingCList.Visible = true;
            }

            int Selection = -1;
            try
            {
                Selection = Conversions.ToInteger(Conversion.Int(InstalmentsLeftCList.Items[e.Index].ToString().Split(' ')[0].Trim()));
            }
            catch (Exception ex)
            {
            }

            if (Selection == -1)
                return;

            if (e.NewValue == CheckState.Checked)
            {
                UpdateInstalmentsPending(Selection);
            }
            else
            {
                UpdateInstalmentsPending(-1, Selection);
            }

        }

        private void KittyTypeCList_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (KittyTypeCList.Items[e.Index].ToString().Split('(')[0].Trim() == "All" && e.NewValue == CheckState.Checked)
            {
                for (int i = 1, loopTo = KittyTypeCList.Items.Count - 1; i <= loopTo; i++)
                    KittyTypeCList.SetItemChecked(i, true);
            }
            else if (KittyTypeCList.Items[e.Index].ToString().Split('(')[0].Trim() == "All" && e.NewValue == CheckState.Unchecked && e.CurrentValue == CheckState.Checked)
            {
                if (KittyTypeCList.CheckedItems.Count == KittyTypeCList.Items.Count)
                {
                    for (int i = 1, loopTo1 = KittyTypeCList.Items.Count - 1; i <= loopTo1; i++)
                        KittyTypeCList.SetItemChecked(i, false);
                }
            }

            if (e.NewValue == CheckState.Unchecked)
            {
                if (KittyTypeCList.Items[e.Index].ToString().Split('(')[0].Trim() != "All" && e.NewValue == CheckState.Unchecked)
                {
                    KittyTypeCList.Refresh();
                    KittyTypeCList.ItemCheck -= KittyTypeCList_ItemCheck;
                    KittyTypeCList.SetItemChecked(0, false);
                    KittyTypeCList.ItemCheck += KittyTypeCList_ItemCheck;
                }
                if (KittyTypeCList.CheckedItems.Count == 1)
                {
                    KittyItemsVisibility(state: false);
                    KittyTypeCList.Visible = true;
                }
            }

            if (e.NewValue == CheckState.Checked && KittyTypeCList.CheckedItems.Count == 0)
            {
                KittyItemsVisibility(state: true);
            }

            int Selection = -1;
            try
            {
                Selection = Conversions.ToInteger(Conversion.Int(KittyTypeCList.Items[e.Index].ToString().Split('(')[0].Trim()));
            }
            catch (Exception ex)
            {
            }

            if (Selection == -1)
                return;

            if (e.NewValue == CheckState.Checked)
            {
                UpdateInstalmentsLeft(Selection);
            }
            else
            {
                UpdateInstalmentsLeft(-1, Selection);
            }

        }

        private void PreviewBT_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.PreviewCustomers.PreviewList = SelectedKitties;
            My.MyProject.Forms.PreviewCustomers.Show();
        }

        private void MaturedChB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedKitty();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            using (var Fm = new MessageAndImageSender())
            {
                Fm.SelectedKitties = SelectedKitties;
                Fm.ShowDialog();
            }
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            var Fm = new MessagesPreviewForm();
            Fm.ShowDialog();
        }

    }
}
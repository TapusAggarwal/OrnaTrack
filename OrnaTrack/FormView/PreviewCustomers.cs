using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class PreviewCustomers
    {

        public List<Kitty> PreviewList = new List<Kitty>();

        public PreviewCustomers()
        {
            InitializeComponent();
        }

        private List<Task<KittyModeControl>> ListOF_KittyModeControl(List<Kitty> KittyList)
        {
            if (KittyList.Count == 0)
                return null;

            var T_List = new List<Task<KittyModeControl>>();

            foreach (Kitty _kitty in KittyList)
            {
                T_List.Add(Task.Run(() =>
                    {
                        var CoustmerPanel = new KittyModeControl();
                        CoustmerPanel.CoustName = _kitty.Owner.FullName();
                        CoustmerPanel.PhNo = _kitty.Owner.PhNo(",");
                        CoustmerPanel.SetImage = "";
                        if (_kitty.Status() != "Partial")
                        {
                            CoustmerPanel.Status = _kitty.Status();
                        }
                        else
                        {
                            CoustmerPanel.InstalmentsPending = _kitty.GetInstalmentsPending();
                            CoustmerPanel.InstalmentsLeft = _kitty.GetInstalments_LeftForMaturity();
                        }
                        CoustmerPanel.KittyType = _kitty.KittyType.ToString();
                        try
                        {
                            CoustmerPanel.KittyNo = _kitty.KittyNo.ToString();
                        }
                        catch (Exception ex)
                        {
                            CoustmerPanel.KittyType = "";
                        }
                        CoustmerPanel.CoustID = Conversions.ToString(_kitty.Owner.CustomerID);
                        CoustmerPanel.KittyID = _kitty.KittyUID.ToString();
                        return CoustmerPanel;
                    }));
            }

            return T_List;

        }

        private async void PreviewCustomers_Load(object sender, EventArgs e)
        {
            if (PreviewList.Count == 0)
                return;
            object T_List = null;
            {
                ref var withBlock = ref this;
                withBlock.Cursor = Cursors.AppStarting;
                withBlock.Refresh();
            }

            KeyPreview = true;

            T_List = ListOF_KittyModeControl(PreviewList);

            FlowLayoutPanel1.Controls.Clear();

            if (Conversions.ToBoolean(T_List is not null && ((dynamic)T_List).Count))
            {

                var res = await Task.WhenAll(T_List);
                FlowLayoutPanel1.Visible = false;
                FlowLayoutPanel1.Controls.Clear();
                int a = 0;
                foreach (var i in (IEnumerable)res)
                {
                    a += 1;
                    FlowLayoutPanel1.Controls.Add((Control)i);
                    KittyModeControl x = (KittyModeControl)i;
                    x.DetailsButton_Clicked += ControlButton_Clicked;
                    x.SrNo = a.ToString();
                }
                FlowLayoutPanel1.Visible = true;
                GC.Collect();

            }

            {
                ref var withBlock1 = ref this;
                withBlock1.Cursor = Cursors.Default;
                withBlock1.Refresh();
            }

            FlowLayoutPanel1.Select();
        }

        public void ControlButton_Clicked(int CustomerID, int KittyID)
        {
            using (var Fm = new PreviewKitty() { _kitty = new Kitty(KittyID, true, true) })
            {
                Fm.ShowDialog();
            }
        }

        private void PreviewCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show(FlowLayoutPanel1.VerticalScroll.Value)
            FlowLayoutPanel1.VerticalScroll.SmallChange = 240;
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
    }
}
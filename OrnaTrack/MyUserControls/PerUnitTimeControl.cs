using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FirstApp
{
    public partial class PerUnitTimeControl
    {
        private int _totalAmount = -1;
        private int _totalCount = -1;

        public PerUnitTimeControl()
        {
            InitializeComponent();
        }

        public void MakeOneMonthControl(Dictionary<DateTime, List<Kitty>> _thisMonthDates)
        {
            DateLB.Text = _thisMonthDates.First().Key.ToString("MMMM,yyyy");
            int _amt = 0;
            int _count = 0;
            foreach (var i in _thisMonthDates)
            {
                var _cntrl = new PerUnitTimeControl();
                _cntrl.MakeOneDayControl(i.Key, i.Value);
                _cntrl.Panel2.Size = (Size)new Point(_cntrl.Width - 30, _cntrl.Panel2.Height);
                FlowLayoutPanel1.Controls.Add(_cntrl);
                _amt += _cntrl._totalAmount;
                _count += _cntrl._totalCount;
            }
            _totalCount = _count;
            _totalAmount = _amt;
            AmtLB.Text = $"Total:{_amt.ToCurrency()}";
            InfoLB.Text = $"Kitty:{_count}";
        }

        public void MakeOneDayControl(DateTime _date, List<Kitty> _list)
        {
            DateLB.Text = _date.ToString("M");
            int _amt = 0;
            int _count = 0;
            foreach (var i in _list)
            {
                _amt += i.Record[_date];
                _count += 1;
                var _cntrl = new OneDayControl();
                _cntrl.NameLB.Text = i.Owner.FullName();
                _cntrl.DateLB.Text = DateLB.Text;
                _cntrl.AmtLB.Text = i.Record[_date].ToCurrency();
                _cntrl._kitty = i;
                FlowLayoutPanel1.Controls.Add(_cntrl);
            }
            _totalCount = _count;
            _totalAmount = _amt;
            AmtLB.Text = $"Total:{_amt.ToCurrency()}";
            InfoLB.Text = $"Kitty:{_count}";
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel1.Visible = !FlowLayoutPanel1.Visible;
            if (IconButton1.IconChar == FontAwesome.Sharp.IconChar.ArrowDown)
            {
                IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            }
            else
            {
                IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            }
        }

    }
}
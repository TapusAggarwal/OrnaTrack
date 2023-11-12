using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class UserControl1
    {

        private string _title;

        [Browsable(true)]
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                HeaderLB.Text = value;
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        public void AddControl(Control _cntrl)
        {
            FlowLayoutPanel1.Controls.Add(_cntrl);
        }

        public void AutoReSize()
        {
            int count = FlowLayoutPanel1.Controls.Count;
            if (count > 0)
            {
                Size = (Size)new Point(Width, Height + FlowLayoutPanel1.Controls[FlowLayoutPanel1.Controls.Count - 1].Height + 5);
            }
        }

    }
}
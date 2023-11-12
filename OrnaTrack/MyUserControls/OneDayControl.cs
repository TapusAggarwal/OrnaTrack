using System;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class OneDayControl
    {
        public Kitty _kitty;

        public OneDayControl()
        {
            InitializeComponent();
        }

        private void Panel1_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            using (var Fm = new PreviewKitty() { _kitty = _kitty })
            {
                Fm.ShowDialog();
            }
            Cursor = Cursors.Default;
        }

    }
}
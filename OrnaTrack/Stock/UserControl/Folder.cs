using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FirstApp
{

    public partial class Folder : UserControl
    {

        private Color _backColor;
        private IconChar _icon;

        [System.ComponentModel.Browsable(true)]
        public override Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                BackPanel.BackColor = value;
            }
        }

        [System.ComponentModel.Browsable(true)]
        public IconChar Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                Btn.IconChar = value;
                _icon = value;
                Invalidate();
            }
        }

        public Folder()
        {
            InitializeComponent();
            BackColor = _BackColor;
            BackColor = _BackColor;
            BackColor = _BackColor;
            BackColor = _BackColor;
            BackColor = _BackColor;
        }

    }
}
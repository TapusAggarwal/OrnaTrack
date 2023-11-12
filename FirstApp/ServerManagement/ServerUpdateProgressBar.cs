using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class ServerUpdateProgressBar
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                TitleLB.Text = $"#{_srno}. {value}";
            }
        }

        private int _srno;
        public int SrNo
        {
            get
            {
                return _srno;
            }
            set
            {
                _srno = value;
                TitleLB.Text = $"#{value}. {_title}";
            }
        }

        public ServerUpdateProgressBar()
        {

            // This call is required by the designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
        }

        public string Cmd { get; set; }
        public string TagData { get; set; }
        public char ExpectedChar { get; set; }

        public ServerUpdateProgressBar(string _cmdi, int _tagData, char _expectedChar = '$')
        {

            // This call is required by the designer.
            InitializeComponent();
            Cmd = _cmdi;
            TagData = _tagData.ToString();
            ExpectedChar = _expectedChar;

            // Add any initialization after the InitializeComponent() call.

        }

        private void TitleLB_TextChanged(object sender, EventArgs e)
        {
            var textSize = TextRenderer.MeasureText(TitleLB.Text, new Font("Century Gothic", 12.0f, FontStyle.Bold));
            Size = (Size)new Point(97 + textSize.Width, Height);
        }

    }
}
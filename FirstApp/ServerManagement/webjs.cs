using System;
using System.Drawing;
using System.Net;

namespace FirstApp
{

    public partial class webjs
    {
        public webjs()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateImage();
        }

        public void UpdateImage()
        {
            var req = WebRequest.Create($"http://{My.MySettingsProperty.Settings.connection_url}?purpose=recent_image");
            req.Method = "POST";
            using (var request = req.GetResponse())
            {
                using (var stream = request.GetResponseStream())
                {
                    ImageBox.Image = new Bitmap(Image.FromStream(stream));
                }
            }
        }

    }
}
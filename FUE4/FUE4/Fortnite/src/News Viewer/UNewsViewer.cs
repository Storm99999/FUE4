using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUE4.Fortnite.src.News_Viewer
{
    public static class UNewsViewer
    {
        public static void Get(PictureBox picture)
        {
            picture.ImageLocation = JsonConvert.DeserializeObject<fnapi>(new WebClient().DownloadString("https://fortnite-api.com/v2/news/br")).data.image;
        }
        public class Data
        {
            public string image { get; set; }
        }

        public class fnapi
        {
            public Data data { get; set; }
        }
    }
}

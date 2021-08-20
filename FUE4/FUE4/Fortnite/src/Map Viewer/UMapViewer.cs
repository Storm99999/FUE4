using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUE4.Fortnite.src.Map_Viewer
{
    public static class UMapViewer
    {
        public static void Get(PictureBox picture)
        {
            picture.ImageLocation = "https://fortnite-api.com/images/map_en.png";
        }
    }
}

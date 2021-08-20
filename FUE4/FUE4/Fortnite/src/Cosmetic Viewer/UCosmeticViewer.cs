using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUE4.Fortnite.src.Cosmetic_Viewer
{
    public static class UCosmeticViewer
    {
        public static void ExportCIDInfo(string CID)
        {
            var client = new WebClient();
            string json = client.DownloadString($"https://benbot.app/api/v1/cosmetics/br/" + CID);
            string icon = ((dynamic)JObject.Parse(json)).icons.icon;
            string series = ((dynamic)JObject.Parse(json)).series;
            string path = ((dynamic)JObject.Parse(json)).path;
            string description = ((dynamic)JObject.Parse(json)).description;
            string variants = ((dynamic)JObject.Parse(json)).variants;
            StreamWriter stream = new StreamWriter("ExportedCID.txt");
            stream.BaseStream.Seek(0, SeekOrigin.Begin);
            stream.Write
                (
                $"◸ Exported By UE4.dll ◹\n\n CID Info: \n\n\n\n\n\n Icon: {icon}\n Series: {series}\n Path: {path}\n Description: {description}\n Variants: {variants}\n\n\n\n◺                                                          ◿"
                );
            stream.Close();
        }
    }
}

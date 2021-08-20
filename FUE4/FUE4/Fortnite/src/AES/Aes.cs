using FUE4.Utils.src.ColorConsole;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FUE4.Fortnite.src.AES
{
    public static class Aes
    {
        public static void WriteAES()
        {
            var client = new WebClient();
            string json = client.DownloadString("https://benbot.app/api/v1/aes");
            string benbotaes = ((dynamic)JObject.Parse(json)).mainKey;
            ColorfulConsole.WriteLine(benbotaes, "UE4");
        }

        public static string AesReturner()
        {
            var client = new WebClient();
            string json = client.DownloadString("https://benbot.app/api/v1/aes");
            string benbotaes = ((dynamic)JObject.Parse(json)).mainKey;

            return benbotaes;
        }
    }
}

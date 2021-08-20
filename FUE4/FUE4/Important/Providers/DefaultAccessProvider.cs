using FUE4.Important.Endpoints;
using FUE4.Utils.src.ColorConsole;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUE4.Important.Providers
{
    public static class DefaultAccessProvider
    {
        public static void SetBrowserDomain(WebBrowser browser, Uri url)
        {
            browser.Url = url;
        }
        
        public static void ProvideStatsExport(string accountID, string outputFile)
        {
            // long code after all I'll make this public later. you can fork or make a pull request with more cooler code.
            string fStats = new WebClient().DownloadString($"{Endpoint.FortniteAPIv2}/stats/br/{accountID}");
            string accID = ((dynamic)JObject.Parse(fStats)).data.account.id;
            string accountName = ((dynamic)JObject.Parse(fStats)).data.account.name;
            int BattlePassLevel = ((dynamic)JObject.Parse(fStats)).data.battlepass.level;
            int Score = ((dynamic)JObject.Parse(fStats)).data.stats.all.overall.score;

            string result = 
                $"◸ Exported By UE4.dll ◹\n\n Account ID: {accID}\n\n\n\n\n\n Account Name: {accountName}\n BattlePass Level: {BattlePassLevel}\n Score: {Score}\n\n\n\n◺                                                          ◿";

            File.WriteAllText(outputFile, result);
            ColorfulConsole.WriteLine($"Successfully exported {accountName}'s Stats.", "FUE4");
        }
    }
}

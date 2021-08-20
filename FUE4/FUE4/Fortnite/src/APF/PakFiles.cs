using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUE4.Fortnite.src.APF
{
    public static class PakFiles
    {
            public static string GetDirectory()
            {
                ///Finds Epics Program Data Directory
                if (Directory.Exists(@"C:\ProgramData\Epic"))
                {
                    return @"C:\ProgramData\Epic";
                }
                if (Directory.Exists(@"D:\ProgramData\Epic"))
                {
                    return @"D:\ProgramData\Epic";
                }
                if (Directory.Exists(@"E:\ProgramData\Epic"))
                {
                    return @"E:\ProgramData\Epic";
                }
                if (Directory.Exists(@"F:\ProgramData\Epic"))
                {
                    return @"F:\ProgramData\Epic";
                }
                return "error"; ///Returns Error If It Can't Find it
            }
            public static void Findinstall(string pakString)///Reads Epicdata Json And Checks If Its Fortnite Install Path
            {
                string EpicData = GetDirectory();
                if (File.Exists(EpicData + @"\UnrealEngineLauncher\LauncherInstalled.dat"))
                {
                    var jsonObject = JObject.Parse(File.ReadAllText(EpicData + @"\UnrealEngineLauncher\LauncherInstalled.dat")); ///Formats The Json
                    foreach (var Installs in jsonObject["InstallationList"]) ///Go Throughs Every Json Value
                    {
                        if (Directory.Exists(Installs["InstallLocation"] + @"\FortniteGame")) ///Checks If Path Contains The FortniteGame Folder
                        {
                         pakString = Installs["InstallLocation"] + @"\FortniteGame\Content\Paks";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Couldn't Find LauncherInstalled.dat Make Sure You Have Epic Games Installed!"); ///Writes This Error If It Can't Find The File Called LauncherInstalled.dat
                }
            }
        }
    }

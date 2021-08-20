# FUE4
A Fortnite DLL which you can use to get stats, aes, news. Quickly.


# How To Use
* Create a Visual Studio 2019 Project. (.NET Framework, Windows forms or Console).
* Right click on the project and click add, then on Add Reference.
* Select FUE4.dll, you downloaded it before making the project.
* Click Ok.


# AES Grabber Example

```cs
    string AesKey = FUE4.Fortnite.src.AES.Aes.AesReturner();
    MessageBox.Show(AesKey);
  ```
  # Map Viewer Example
  
  ```cs
    FUE4.Fortnite.src.Map_Viewer.UMapViewer.Get(pictureBox1);
  ```
  ^ Requires WinForms.
  
  # News Viewer Example
  
  ```cs
    FUE4.Fortnite.src.News_Viewer.UNewsViewer.Get(pictureBox1);
  ```
  ^ Requires WinForms.
  
  # Edit Unreal Asset Example
  ```cs
    FUE4.Fortnite.src.Editor.UnrealAssetEditor.Edit("UASSET HERE", "SEARCH 1 HERE", "REPLACE 1 HERE");
  ```
  
  # Stats Export Example
  
  Stats export is not completely finished, I'll update the code when it's completely done. (you can still use this)
  
    ```cs
    FUE4.Important.Providers.DefaultAccessProvider.ProvideStatsExport("EPIC ACCOUNT ID (FORTNITE)", "MyStats.txt");
  ```

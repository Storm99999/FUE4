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

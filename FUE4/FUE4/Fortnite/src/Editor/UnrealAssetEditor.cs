using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUE4.Fortnite.src.Editor
{
    public static class UnrealAssetEditor
    {
        public static byte[] Edit(byte[] unEdited, string search1, string replace1)
        {
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream(unEdited))
            {
                search1 = StringToHex(search1);
                replace1 = StringToHex(replace1);
                byte[] array = ConvertHexStringToByteArray(search1);
                byte[] array2 = ConvertHexStringToByteArray(replace1);
                array2 = SameLength(array, array2);
                int val = IndexOfSequence(unEdited, array);
                int val2 = IndexOfSequence(unEdited, array2);
                memoryStream.Position = (long)Math.Max(val, val2);
                memoryStream.Write(array2, 0, array2.Length);
                result = memoryStream.ToArray();
            }
            return result;
        }

        private static byte[] ConvertHexStringToByteArray(string hexString)
        {
            bool flag = hexString.Contains(" ");
            bool flag3 = flag;
            if (flag3)
            {
                hexString = hexString.Replace(" ", "");
            }
            bool flag2 = hexString.Length % 2 != 0;
            bool flag4 = flag2;
            if (flag4)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "ERR", hexString));
            }
            byte[] array = new byte[hexString.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                string s = hexString.Substring(i * 2, 2);
                array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }
            return array;
        }

        private static byte[] SameLength(byte[] search, byte[] replace)
        {
            List<byte> list = new List<byte>(replace);
            int num = search.Length - replace.Length;
            for (int i = 0; i < num; i++)
            {
                list.Add(0);
            }
            return list.ToArray();
        }

        private static string StringToHex(string hexstring)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char value in hexstring)
            {
                stringBuilder.Append(Convert.ToInt32(value).ToString("x") + " ");
            }
            return stringBuilder.ToString();
        }

        private static int IndexOfSequence(byte[] buffer, byte[] pattern)
        {
            int num = Array.IndexOf<byte>(buffer, pattern[0], 0);
            while (num >= 0 && num <= buffer.Length - pattern.Length)
            {
                byte[] array = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, num, array, 0, pattern.Length);
                bool flag = array.SequenceEqual(pattern);
                bool flag2 = flag;
                if (flag2)
                {
                    return num;
                }
                num = Array.IndexOf<byte>(buffer, pattern[0], num + 1);
            }
            return -1;
        }

    }
}

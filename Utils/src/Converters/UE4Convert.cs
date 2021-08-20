using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUE4.Utils.src.Converters
{
    public static class UE4Convert
    {
        public static string ByteToHex(byte[] bytes)
        {
            char[] c = new char[bytes.Length * 2];
            byte b;
            for (int bx = 0, cx = 0; bx < bytes.Length; ++bx, ++cx)
            {
                b = ((byte)(bytes[bx] >> 4));
                c[cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);

                b = ((byte)(bytes[bx] & 0x0F));
                c[++cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);
            }
            return new string(c);
        }

        public static byte[] ConvertHexStringToByteArray(string hexString)
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

        public static string StringToHex(string hexstring)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char value in hexstring)
            {
                stringBuilder.Append(Convert.ToInt32(value).ToString("x") + " ");
            }
            return stringBuilder.ToString();
        }
    }
}

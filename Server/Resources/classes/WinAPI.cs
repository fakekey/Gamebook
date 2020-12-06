using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Server
{
    class WinAPI
    {
        public const int HOR_Positive = 0X1;

        public const int HOR_NEGATIVE = 0X2;

        public const int VER_POSITIVE = 0X4;

        public const int VER_NEGATIVE = 0X8;

        public const int CENTER = 0X10;

        public const int BLEND = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }
    }
}

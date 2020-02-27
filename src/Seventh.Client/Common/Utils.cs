using System;
using System.Text;

namespace Seventh.Client.Common
{
    internal static class Utils
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        public static string GetUnixTime()
        {
            var ts = DateTime.UtcNow - UnixEpoch;
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        public static string EscapeRfc3986(string data)
        {
            var sb = new StringBuilder();
            int num;
            for (var i = 0; i < data.Length; i += num)
            {
                num = Math.Min(data.Length - i, 32766);
                sb.Append(Uri.EscapeDataString(data.Substring(i, num)));
            }

            EncodeChars.ForEach(c => sb.Replace(c.ToString(), Uri.HexEscape(c)));
            return sb.ToString();
        }

        private static readonly char[] EncodeChars = new char[5]
        {
            '!',
            '*',
            '\'',
            '(',
            ')'
        };
    }
}
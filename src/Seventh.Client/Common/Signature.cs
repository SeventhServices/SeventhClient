using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Seventh.Client.Common
{
    public class Signature
    {
        public Signature(IEnumerable<KeyValuePair<string, string>> @params, string apiName)
        {
            _data = $"{apiName}?{GetParamsData(@params)}";
        }

        public Signature(IEnumerable<KeyValuePair<string, string>> @params, string apiName,
            string uuid) : this(@params, apiName)
        {
            _key = $"{_key}&{uuid}";
        }

        private readonly string _key = SecretKey.SigKey;

        private readonly string _data;

        public static string GetListParamSignatureData<T>(IEnumerable<T> listParams)
        {
            return "[" + string.Join(",", (from e in listParams
                select $"\"{e}\"").ToArray()) + "]";
        }

        private string GetParamsData(IEnumerable<KeyValuePair<string, string>> @params)
        {
            return string.Join("&", (from p in @params.OrderBy(p => p.Key, StringComparer.Ordinal)
                select $"{p.Key}={p.Value}").ToArray());
        }

        public static string MakeSignature(string key, string data)
        {
            var bytes = Encoding.UTF8.GetBytes(key);
            var bytes2 = Encoding.UTF8.GetBytes(Utils.EscapeRfc3986(data));

            using var hmacSha1 = new HMACSHA1(bytes);
            var inArray = hmacSha1.ComputeHash(bytes2);
            return Uri.EscapeDataString(Convert.ToBase64String(inArray));
        }

        public override string ToString()
        {
            return MakeSignature(_key, _data);
        }
    }
}
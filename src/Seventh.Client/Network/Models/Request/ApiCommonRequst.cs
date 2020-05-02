using Seventh.Client.Common;
using Seventh.Client.Common.Params;

namespace Seventh.Client.Network.Models.Request
{
    public class ApiCommonRequest : ApiRequest
    {
        public int Rev { get; set; } = RequestParams.Rev;
        public string Ver { get; set; } = RequestParams.Version;
        public string Ts { get; set; } = Utils.GetUnixTime();
        public string Os { get; set; } = RequestParams.Os;
        public string Blt { get; set; } = RequestParams.Version;
        public string Device { get; set; } = RequestParams.Device;
        public string Platform { get; set; } = RequestParams.Platform;
        // ReSharper disable once IdentifierTypo
        public string Osversion { get; set; } = RequestParams.OsVersion;
        public int Jb { get; set; } = RequestParams.Jb;
    }
}
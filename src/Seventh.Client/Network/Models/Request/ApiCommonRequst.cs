using Seventh.Client.Common;
using Seventh.Client.Options;

namespace Seventh.Client.Network.Models.Request
{
    public class ApiCommonRequest : ApiRequest
    {
        public int Rev { get; set; } = DefaultOptions.ParamOptions.Rev;
        public int MaterRev { get; set; } = DefaultOptions.ParamOptions.MaterRev;
        public string Ver { get; set; } = DefaultOptions.ParamOptions.Version;
        public string Ts { get; set; } = Utils.GetUnixTime();
        public string Os { get; set; } = DefaultOptions.ParamOptions.Os;
        public string Blt { get; set; } = DefaultOptions.ParamOptions.Blt;
        public string Device { get; set; } = DefaultOptions.ParamOptions.Device;
        public string Platform { get; set; } = DefaultOptions.ParamOptions.Platform;
        // ReSharper disable once IdentifierTypo
        public string Osversion { get; set; } = DefaultOptions.ParamOptions.OsVersion;
        public int Jb { get; set; } = DefaultOptions.ParamOptions.Jb;
    }
}
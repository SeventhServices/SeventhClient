using Seventh.Client.Common;

namespace Seventh.Client.Options
{
    public static class DefaultOptions
    {
        public static class UriOptions
        {
            public static string ApiBaseUrl = UriConst.SeventhApiBaseUrl;
            public static string AssetDownloadBaseUrl = UriConst.SeventhApiBaseUrl;
        }

        public static class ParamOptions
        {
            public static string Version { get; set; } = "7.6.1";
            public static string Pid { get; set; }
            public static string Uuid { get; set; }
            public static int MaterRev { get; set; } = 7;
            public static int Rev { get; set; } = 474;
            public static string Blt { get; set; } = Version;
            public static string Os { get; set; } = "android";
            public static string Device { get; set; } = "Android";
            public static string Platform { get; set; } = "xiaomi 10";
            public static string OsVersion { get; set; } = "10";
            public static int Jb { get; set; } = 0;

            public static int SubRev { get; set; } = 3;
        }
    }
}

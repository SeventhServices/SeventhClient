using SeventhServices.Client.Common.Params;

namespace SeventhServices.Client.Network.Models.Request.Setup
{
    public class ResourceResultRequest : ApiUserRequest
    {
        public const string Path = "setup/resource/result";
        public override string ApiName { get; set; } = Path;

        public int UserRev { get; set; } = RequestParams.Rev;

        public string DownloadType { get; set; } = "0";
    }
}
using Seventh.Client.Common.Enums;

namespace Seventh.Client.Network.Models.Request.Setup
{
    public class ResourceResultRequest : ApiUserRequest
    {
        public ResourceResultRequest(int userRev, DownloadType downloadType = DownloadType.Difference)
        {
            UserRev = userRev;
            DownloadType = downloadType;
        }

        public const string Path = "setup/resource/result";
        public override string ApiName { get; set; } = Path;

        public int UserRev { get; set; }
        public DownloadType DownloadType { get; set; }
    }
}
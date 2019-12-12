using System.Collections.Generic;

namespace SeventhServices.Client.Network.Models.Request.Present
{
    public class PresentResultRequest : ApiUserRequest
    {
        public const string Path = "present/result";
        public override string ApiName { get; set; } = Path;

        public IEnumerable<long> UserPresentIdList { get; set; }
        public long LatestUserPresentId { get; set; }
        public long LatestInterimUserPresentId { get; set; }
        public int CardDestinationId { get; set; }
        public int SceneType { get; set; }
        public int SellFlg { get; set; }
    }
}
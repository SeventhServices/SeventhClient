namespace SeventhServices.Client.Network.Models.Request
{
    public class MyPageRequest : ApiUserRequest
    {
        public const string Path = "mypage";
        public override string ApiName { get; set; } = Path;

        public int SubRev = 3;
    }
}
namespace Seventh.Client.Network.Models.Request
{
    public class MyPageRequest : ApiUserRequest
    {
        public MyPageRequest(int subRev = 3)
        {
            SubRev = subRev;
        }

        public const string Path = "mypage";
        public override string ApiName { get; set; } = Path;

        public int SubRev { get; set; }
    }
}
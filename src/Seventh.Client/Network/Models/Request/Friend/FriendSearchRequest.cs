namespace Seventh.Client.Network.Models.Request.Friend
{
    public class FriendSearchRequest :ApiUserRequest
    {
        public FriendSearchRequest(string searchParam, int page = 1)
        {
            SearchParam = searchParam;
            Page = page;
        }

        public const string Path = "friend/search";
        public override string ApiName { get; set; } = Path;

        public string SearchParam { get; set; }

        public int Page { get; set; }
    }
}
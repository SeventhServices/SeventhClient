namespace SeventhServices.Client.Network.Models.Response.Present
{
    public class PresentMainResponse : ApiResult
    {
        public PresentBox PresentBox { get; set; }
    }
    public class PresentBox
    {
        public UserPresent[] UserPresentList { get; set; }
        public InterimPresent[] InterimPresentList { get; set; }
        public UserStatus UserStatus { get; set; }
    }
    public class UserStatus
    {
        public int FriendPoint { get; set; }
    }

    public class UserPresent : Present
    {
        public long PresentedAt { get; set; }
    }

    public class InterimPresent : Present
    {
        public long PresentedAt { get; set; }
    }

    public class Present
    {
        public int UserPresentId { get; set; }
        public int PresentType { get; set; }
        public int PresentId { get; set; }
        public int PresentNum { get; set; }
        public string Message { get; set; }
    }
}
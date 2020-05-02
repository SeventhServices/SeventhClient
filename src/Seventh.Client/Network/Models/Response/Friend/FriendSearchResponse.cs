namespace Seventh.Client.Network.Models.Response.Friend
{
    public class FriendSearchResponse : ApiUserResponse
    {
        public FriendSearch FriendSearch { get; set; }
    }

    public class FriendSearch
    {
        public Searchlist[] SearchList { get; set; }
    }

    public class Searchlist
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Level { get; set; }
        public int ProfileCardId { get; set; }
        public int LastLoginTime { get; set; }
        public string Comment { get; set; }
        public int RelationType { get; set; }
        public int CurrentFriendNum { get; set; }
        public int MaxFriendNum { get; set; }
        public HonorInfo[] HonorInfoList { get; set; }
    }

    public class HonorInfo
    {
        public int HonorId { get; set; }
    }


}
namespace Seventh.Client.Network.Models.Response.Event
{
    public class EventRankingUserResponse : ApiUserResponse
    {
        public EventRankingUser EventRankingUser { get; set; }
    }

    public class EventRankingUser
    {
        public int PickupId { get; set; }
        public UserRanking UserRanking { get; set; }
        public Borderlist[] BorderList { get; set; }
        public bool ExistPreviousPage { get; set; }
        public bool ExistNextPage { get; set; }
        public int MaxRank { get; set; }
    }

    public class UserRanking
    {
        public EventParticipant[] EventParticipants { get; set; }
    }

    public class EventParticipant
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Level { get; set; }
        public int ProfileCardId { get; set; }
        public int Rank { get; set; }
        public int Score { get; set; }
        public int IdolClass { get; set; }
        public string UpdateTime { get; set; }
        public Honorinfolist[] HonorInfoList { get; set; }
    }

    public class Honorinfolist
    {
        public int HonorId { get; set; }
        public int Rank { get; set; }
        public int CharacterId { get; set; }
    }

    public class Borderlist
    {
        public int BorderRank { get; set; }
        public int Border { get; set; }
        public bool IsMyRank { get; set; }
    }

}

using Seventh.Client.Common.Enums;

namespace Seventh.Client.Network.Models.Request.Event
{
    public class EventRankingUserRequest : ApiUserRequest
    {
        public EventRankingUserRequest(OpenEventType eventType, 
            RankingCategory rankingType = RankingCategory.TotalPointRanking)
        {
            EventType = eventType;
            RankingType = rankingType;
        }

        public const string Path = "event/ranking/user";
        public override string ApiName { get; set; } = Path;

        public OpenEventType EventType { get; set; }

        public RankingCategory RankingType { get; set; }

        public long MusicId { get; set; }

        public Difficulty Difficulty { get; set; }

        public int MaxRank { get; set; } = 1;

        public long PickupUserId { get; set; }

        public int CharacterId { get; set; }

        public int Friend { get; set; }
    }
}
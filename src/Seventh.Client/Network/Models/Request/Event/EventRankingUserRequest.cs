using Seventh.Client.Common.Enums;

namespace Seventh.Client.Network.Models.Request.Event
{
    public class EventRankingUserRequest : ApiUserRequest
    {
        public EventRankingUserRequest(OpenEventType eventType, 
            RankingCategory rankingType, long maxRank,
            int musicId, Difficulty difficulty) 
            : this(eventType,rankingType, maxRank)
        {
            MusicId = musicId;
            Difficulty = difficulty;
        }

        public EventRankingUserRequest(OpenEventType eventType, 
            RankingCategory rankingType = RankingCategory.TotalPointRanking,
            long maxRank = 1)
        {
            EventType = eventType;
            RankingType = rankingType;
            MaxRank = maxRank;
        }

        public const string Path = "event/ranking/user";
        public override string ApiName { get; set; } = Path;

        public OpenEventType EventType { get; set; }

        public RankingCategory RankingType { get; set; }

        public int MusicId { get; set; }

        public Difficulty Difficulty { get; set; }

        public long MaxRank { get; set; }

        public long PickupUserId { get; set; }

        public int CharacterId { get; set; }

        public int Friend { get; set; }
    }
}
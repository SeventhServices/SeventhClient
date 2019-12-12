using SeventhServices.Client.Common.Enums;

namespace SeventhServices.Client.Network.Models.Response.Event
{
    public class EventStatusResponse : ApiResult
    {
        public EventStatus EventStatus { get; set; }
    }
    public class EventStatus
    {
        public RewardCategory[] RewardCategories { get; set; }
        public RankingCategory[] RankingCategories { get; set; }
        public long TotalPoint { get; set; }
        public long TotalPointRank { get; set; }
        public HighScoreRanking[] HighScoreRanking { get; set; }
        public long MaxVoltage { get; set; }
        public long MaxVoltageRank { get; set; }
        public long MaxWinningStreak{ get; set; }
        public long CurrentWinningStreak{ get; set; }
        public long[] ChairmanshipIds{ get; set; }
        public long SelectedCharacterId{ get; set; }
        public long EachIdolTotalPointRank{ get; set; }
        public long EachIdolClass{ get; set; }
        public long[] RareRivalCardIds{ get; set; }
        public long TeamId{ get; set; }
        public long TeamRankingPoint{ get; set; }
        public long TeamRank{ get; set; }
    }
    public class HighScoreRanking
    {
        public int HighScoreMusicId { get; set; }
        public Difficulty HighScoreDifficulty { get; set; }
    }
}
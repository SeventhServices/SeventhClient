
using Seventh.Client.Network.Models.Request;

namespace Seventh.Client.Network.Models.Response.Event.Raid
{
    public class EventRaidTopResponse : ApiUserResponse
    {
        public RaidMain RaidMain { get; set; }
    }

    public class RaidMain
    {
        public EventInfo EventInfo { get; set; }
        public UserEventStatus UserEventStatus { get; set; }
        public bool IsGachaReady { get; set; }
    }

    public class EventInfo
    {
        public string BackgroundName { get; set; }
        public int NumRule { get; set; }
        public long EndTime { get; set; }
        public bool IsOpenEvent { get; set; }
        public bool HasUnreceivedRaidMissionReward { get; set; }
        public string EventTopBgm { get; set; }
    }

    public class UserEventStatus
    {
        public int DiscoveryCount { get; set; }
        public int MaxDiscoveryCount { get; set; }
        public int BattleCount { get; set; }
        public int MaxBattleCount { get; set; }
        public int HelpCount { get; set; }
        public long TotalPoint { get; set; }
        public long TotalPointRank { get; set; }
        public NextReward NextReward { get; set; }
        public long RaidPoint { get; set; }
        public bool CanGetPoint { get; set; }
        public int GachaNeedPoint { get; set; }
    }

    public class NextReward
    {
        public int Border { get; set; }
        public int RewardType { get; set; }
        public int RewardId { get; set; }
        public int RewardNum { get; set; }
    }
}
using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response.Event.Raid
{
    public class EventRaidBoardNextStepResponse : ApiUserResponse
    {
        public RaidBoardNextStep RaidBoardNextStep { get; set; }
    }

    public class RaidBoardNextStep : ApiNormalErrorResponse
    {
        public AppearBossInfo AppearBossInfo { get; set; }
        public bool IsIllegal { get; set; }
        public UserBoard UserBoard { get; set; }
        public bool OpenRareArea { get; set; }
        public UserStatusForCharismaChange UserStatus { get; set; }
        public bool IsBossLimit { get; set; }
        public int ExistBossType { get; set; }
        public bool HasRequest { get; set; }
        public int NowBattleCount { get; set; }
        public int NowDiscoverCount { get; set; }
    }

    public class AppearBossInfo
    {
        public long RaidBossBattleId { get; set; }
        public long RaidBossPartyId { get; set; }
    }
}
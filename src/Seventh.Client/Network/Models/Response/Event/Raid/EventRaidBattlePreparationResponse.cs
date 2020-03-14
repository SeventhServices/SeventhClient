using Seventh.Client.Common.Enums;

namespace Seventh.Client.Network.Models.Response.Event.Raid
{
    public class EventRaidBattlePreparationResponse : ApiResult
    {
        public RaidBattlePreparation RaidBattlePreparation { get; set; }
    }

    public class RaidBattlePreparation : ApiNormalErrorResult
    {
        public int NowHp { get; set; }
        public long LimitTime { get; set; }
        public int MaxHp { get; set; }
        public int RaidBossPartyId { get; set; }
        public bool IsFree { get; set; }
        public RaidRequestType RequestedType { get; set; }
        public bool CanRequest { get; set; }
        public int BattleUserCount { get; set; }
        public int Win { get; set; }
        public bool HasFriend { get; set; }
    }
}
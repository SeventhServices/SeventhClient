using Seventh.Client.Common.Enums;

namespace Seventh.Client.Network.Models.Response.Event.Raid
{
    public class EventRaidListResponse : ApiResult
    {
        public Raidlist RaidList { get; set; }
    }

    public class Raidlist
    {
        public string BackgroundName { get; set; }
        public TabCategory[] TabCategoryList { get; set; }
    }

    public class TabCategory
    {
        public RaidBossCategory Category { get; set; }
        public int MaxRaidBossInfoNum { get; set; }
        public RaidBossInfo[] RaidBossInfoList { get; set; }
    }

    public class RaidBossInfo
    {
        public int RaidBossBattleId { get; set; }
        public int RaidBossPartyId { get; set; }
        public int MaxHp { get; set; }
        public int NowHp { get; set; }
        public int EndTime { get; set; }
        public string DiscoveryUserName { get; set; }
        public bool IsFriend { get; set; }
        public int UpdateTime { get; set; }
    }

}
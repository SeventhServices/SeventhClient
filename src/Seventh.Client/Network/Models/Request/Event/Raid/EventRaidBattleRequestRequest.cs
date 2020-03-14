using Seventh.Client.Common.Enums;

namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidBattleRequestRequest : ApiUserRequest
    {
        public EventRaidBattleRequestRequest(RaidRequestType type, long raidBossBattleId)
        {
            Type = type;
            RaidBossBattleId = raidBossBattleId;
        }

        public const string Path = "raid/battle/request";
        public override string ApiName { get; set; } = Path;

        public RaidRequestType Type { get; set; }
        public long RaidBossBattleId { get; set; }
    }
}
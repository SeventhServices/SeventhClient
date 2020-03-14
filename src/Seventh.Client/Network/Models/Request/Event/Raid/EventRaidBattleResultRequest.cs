namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidBattleResultRequest : ApiUserRequest
    {
        public EventRaidBattleResultRequest(long raidBossBattleId, 
            int useRaidBattleItem = 0)
        {
            RaidBossBattleId = raidBossBattleId;
            UseRaidBattleItem = useRaidBattleItem;
        }

        public const string Path = "raid/battle/result";
        public override string ApiName { get; set; } = Path;

        public long RaidBossBattleId { get; set; }
        public int UseRaidBattleItem { get; set; }
    }
}
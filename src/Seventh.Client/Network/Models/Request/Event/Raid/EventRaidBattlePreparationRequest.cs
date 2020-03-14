namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidBattlePreparationRequest : ApiUserRequest
    {
        public EventRaidBattlePreparationRequest(long raidBossBattleId)
        {
            RaidBossBattleId = raidBossBattleId;
        }

        public const string Path = "raid/battle/preparation";
        public override string ApiName { get; set; } = Path;

        public long RaidBossBattleId { get; set; }
    }
}
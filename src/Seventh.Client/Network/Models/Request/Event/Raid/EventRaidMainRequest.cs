namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidMainRequest : ApiUserRequest
    {
        public const string Path = "raid/main";
        public override string ApiName { get; set; } = Path;
    }
}
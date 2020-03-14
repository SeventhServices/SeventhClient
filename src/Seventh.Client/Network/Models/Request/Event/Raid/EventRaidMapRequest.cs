namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidMapRequest : ApiUserRequest
    {
        public const string Path = "raid/map";
        public override string ApiName { get; set; } = Path;

    }
}
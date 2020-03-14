namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidListRequest : ApiUserRequest
    {
        public const string Path = "raid/list";
        public override string ApiName { get; set; } = Path;

    }
}
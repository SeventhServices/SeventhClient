namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidTopRequest : ApiUserRequest
    {
        public const string Path = "raid/top";
        public override string ApiName { get; set; } = Path;

    }

}
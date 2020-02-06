using SeventhServices.Client.Common.Enums;

namespace SeventhServices.Client.Network.Models.Request.Event
{
    public class EventStatusRequest : ApiUserRequest
    {
        public EventStatusRequest(OpenEventType eventType)
        {
            EventType = eventType;
        }

        public const string Path = "event/status";
        public override string ApiName { get; set; } = Path;

        public OpenEventType EventType { get; set; }
    }
}
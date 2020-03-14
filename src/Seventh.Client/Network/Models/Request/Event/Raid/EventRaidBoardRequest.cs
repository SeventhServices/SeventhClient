namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidBoardRequest : ApiUserRequest
    {
        public EventRaidBoardRequest(int boardId)
        {
            BoardId = boardId;
        }

        public const string Path = "raid/board";
        public override string ApiName { get; set; } = Path;

        public int BoardId { get; set; }
    }
}
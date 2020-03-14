namespace Seventh.Client.Network.Models.Request.Event.Raid
{
    public class EventRaidBoardNextStepRequest : ApiUserRequest
    {
        public EventRaidBoardNextStepRequest(int boardId, int pageId, int userSquareId)
        {
            BoardId = boardId;
            PageId = pageId;
            UserSquareId = userSquareId;
        }

        public const string Path = "raid/board/nextstep";
        public override string ApiName { get; set; } = Path;

        public int BoardId { get; set; }
        public int PageId { get; set; }
        public int UserSquareId { get; set; }
    }
}
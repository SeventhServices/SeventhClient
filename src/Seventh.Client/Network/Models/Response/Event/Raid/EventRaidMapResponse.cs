namespace Seventh.Client.Network.Models.Response.Event.Raid
{
    public class EventRaidMapResponse : ApiResult
    {
        public RaidMap RaidMap { get; set; }
    }

    public class RaidMap
    {
        public Version[] Versions { get; set; }
        public ScoutMapBoard[] ScoutMapBoards { get; set; }
        public bool HasRaidRequest { get; set; }
    }

    public class Version
    {
        public int VersionId { get; set; }
        public int Status { get; set; }
        public Page[] Pages { get; set; }
    }

    public class Page
    {
        public int PageId { get; set; }
    }

    public class ScoutMapBoard
    {
        public int BoardId { get; set; }
        public int ClearCount { get; set; }
        public bool CanSelect { get; set; }
    }
}
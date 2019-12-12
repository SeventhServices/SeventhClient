namespace SeventhServices.Client.Network.Models.Request.Present
{
    public class PresentMainRequest :ApiUserRequest
    {
        public const string Path = "present/main";
        public override string ApiName { get; set; } = Path;

        public int DestinationDormitoryId { get; set; }
    }
}
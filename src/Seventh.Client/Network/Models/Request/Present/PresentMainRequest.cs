namespace Seventh.Client.Network.Models.Request.Present
{
    public class PresentMainRequest :ApiUserRequest
    {
        public PresentMainRequest(int destinationDormitoryId)
        {
            DestinationDormitoryId = destinationDormitoryId;
        }

        public const string Path = "present/main";
        public override string ApiName { get; set; } = Path;

        public int DestinationDormitoryId { get; set; }
    }
}
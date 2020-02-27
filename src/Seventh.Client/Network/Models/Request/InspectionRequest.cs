namespace Seventh.Client.Network.Models.Request
{
    public class InspectionRequest : ApiUserRequest
    {
        public const string Path = "inspection";
        public override string ApiName { get; set; } = Path;
    }
}
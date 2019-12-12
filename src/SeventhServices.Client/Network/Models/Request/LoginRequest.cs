namespace SeventhServices.Client.Network.Models.Request
{
    public class LoginRequest : ApiUserRequest
    {
        public const string Path = "login";
        public override string ApiName { get; set; } = Path;
    }
}
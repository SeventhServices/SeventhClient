namespace Seventh.Client.Network.Models.Request.Player
{
    public class PlayerMainRequest : ApiUserRequest
    {
        public PlayerMainRequest(long userId)
        {
            UserId = userId;
        }

        public const string Path = "player/main";
        public override string ApiName { get; set; } = Path;

        public long UserId { get; set; }
    }
}
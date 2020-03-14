namespace Seventh.Client.Network.Models.Response.Shared
{
    public class UserStatus
    {
        public long UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public int Level { get; set; }
        public long Exp { get; set; }
        public int UserTypeId { get; set; }
        public int Charisma { get; set; }
        public int MaxCharisma { get; set; }
        public int Money { get; set; }
        public int Coin { get; set; }
        public int FreeCoin { get; set; }
        public int SeventhPoint { get; set; }
        public int CostumeTicket { get; set; }
        public int CardNum { get; set; }
        public int MaxCardNum { get; set; }
        public int WinNum { get; set; }
        public int LoseNum { get; set; }
        public int MaxFriendNum { get; set; }
        public int ProfileCardId { get; set; }
        public int CharismaRecoveryTime { get; set; }
        public int RaidRequestType { get; set; }
        public bool PrivateLessonFlg { get; set; }
        public bool GreetingFlg { get; set; }
        public bool GachaChanceVariationFlg { get; set; }
        public int FavoritePlayId { get; set; }
    }
}
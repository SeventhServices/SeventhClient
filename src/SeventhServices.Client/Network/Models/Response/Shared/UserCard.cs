namespace SeventhServices.Client.Network.Models.Response.Shared
{
    public class UserCard
    {
        public int UserCardId { get; set; }
        public int CardId { get; set; }
        public int Level { get; set; }
        public int LevelMax { get; set; }
        public int Exp { get; set; }
        public int IntimatePoint { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int[] SparkleExpList { get; set; }
    }
}
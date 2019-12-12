namespace SeventhServices.Client.Network.Models.Response.Shared
{
    public class UnitCard
    {
        public long Group { get; set; }
        public long Position { get; set; }
        public long UserCardId { get; set; }
        public virtual UserCard UserCard { get; set; }
    }
}
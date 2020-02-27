using System.Collections.Generic;

namespace Seventh.Client.Network.Models.Response.Shared
{
    public class UserUnitBase<T> where  T : class
    {
        public virtual int GroupCount { get; set; }
        public virtual int PositionCount { get; set; }
        public int MaxCount { get; set; }
        public string UnitName { get; set; }
        public T[] UnitCardList { get; set; }
        public IEnumerable<T> ActiveList { get; set; }
        public bool HasMotivationMax { get; set; }
    }
}
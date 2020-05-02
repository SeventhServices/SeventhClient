using System;
using System.Collections.Generic;
using System.Text;
using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response.Event.Raid
{
    public class EventRaidBoardResponse : ApiUserResponse
    {
        public RaidBoard RaidBoard { get; set; }
    }

    public class RaidBoard : ApiNormalErrorResponse
    {
        public UserStatusForCharismaChange UserStatus { get; set; }
        public UserBoard UserBoard { get; set; }
        public bool IsBossLimit { get; set; }
        public bool HasRequest { get; set; }
        public int NowBattleCount { get; set; }
        public int MaxBattleCount { get; set; }
        public int NowDiscoverCount { get; set; }
        public int MaxDiscoverCount { get; set; }
    }
}

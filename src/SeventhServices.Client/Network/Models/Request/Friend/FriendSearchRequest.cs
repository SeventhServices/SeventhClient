﻿using SeventhServices.Client.Common.Enums;
using SeventhServices.Client.Network.Models.Abstractions;

namespace SeventhServices.Client.Network.Models.Request.Friend
{
    public class FriendSearchRequest :ApiUserRequest
    {
        public const string Path = "friend/search";
        public override string ApiName { get; set; } = Path;

        public string SearchParam { get; set; }

        public int Page { get; set; } = 1;
    }
}
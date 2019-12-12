using SeventhServices.Client.Common;
using SeventhServices.Client.Common.Params;
using SeventhServices.Client.Network.Models.Abstractions;
using SeventhServices.Client.Network.Models.Extensions;

namespace SeventhServices.Client.Network.Models.Request
{
    public class ApiUserRequest : ApiCommonRequest, IUseAccount
    {
        public string Uuid { get; set; } = RequestParams.Uuid;
        public string Pid { get; set; } = RequestParams.Pid;
    }
}
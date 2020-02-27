using Seventh.Client.Common.Params;
using Seventh.Client.Network.Models.Abstractions;

namespace Seventh.Client.Network.Models.Request
{
    public class ApiUserRequest : ApiCommonRequest, IUseAccount
    {
        public string Uuid { get; set; } = RequestParams.Uuid;
        public string Pid { get; set; } = RequestParams.Pid;
    }
}
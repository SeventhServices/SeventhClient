using Seventh.Client.Common.Params;

namespace Seventh.Client.Network.Models.Request
{
    public class ApiUserRequest : ApiCommonRequest
    {
        public string Uuid { get; set; } = RequestParams.Uuid;
        public string Pid { get; set; } = RequestParams.Pid;
    }
}
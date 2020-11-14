using Seventh.Client.Options;

namespace Seventh.Client.Network.Models.Request
{
    public class ApiUserRequest : ApiCommonRequest
    {
        public string Uuid { get; set; } = DefaultOptions.ParamOptions.Uuid;
        public string Pid { get; set; } =  DefaultOptions.ParamOptions.Pid;
    }
}
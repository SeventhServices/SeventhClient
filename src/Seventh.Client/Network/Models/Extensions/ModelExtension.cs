using Seventh.Client.Network.Models.Request;

namespace Seventh.Client.Network.Models.Extensions
{
    public static class ModelExtension
    {
        public static T UseAccount<T>(this T request, string pid, string uuid) where T : ApiUserRequest
        {
            request.Pid = pid;
            request.Uuid = uuid;
            return request;
        }
    }
}
using Seventh.Client.Network.Models.Abstractions;

namespace Seventh.Client.Network.Models.Extensions
{
    public static class ModelExtension
    {
        public static void UseAccount(this IUseAccount request, string pid, string uuid)
        {
            request.Pid = pid;
            request.Uuid = uuid;
        }
    }
}
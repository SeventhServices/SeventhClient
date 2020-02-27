using System.Threading.Tasks;
using WebApiClient.Attributes;
using WebApiClient.Contexts;

namespace Seventh.Client.Network.Attribute
{
    internal sealed class SeventhHeaderAttribute : ApiActionAttribute
    {
        private readonly string _host;
        private readonly string _userAgent;

        public SeventhHeaderAttribute(string host = "api.t7s.jp",
            string userAgent = "Dalvik/2.1.0 (Linux; U; Android 10; xiaomi 9 Build/LMY49I)")
        {
            _host = host;
            _userAgent = userAgent;
        }



        public override Task BeforeRequestAsync(ApiActionContext context)
        {

            context.RequestMessage.Headers.Add("Expect", "100-continue");
            context.RequestMessage.Headers.Remove("User-Agent");
            context.RequestMessage.Headers.Add("User-Agent", _userAgent);
            context.RequestMessage.Headers.Add("Host", _host);
            context.RequestMessage.Headers.Add("Connection", "Keep-Alive");
            context.RequestMessage.Headers.Add("Accept-Encoding", "gzip,deflate,br");

            return Task.CompletedTask;
        }
    }
}
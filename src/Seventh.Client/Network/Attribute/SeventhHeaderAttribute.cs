using System.Threading.Tasks;
using Seventh.Client.Common.Params;
using WebApiClient.Attributes;
using WebApiClient.Contexts;

namespace Seventh.Client.Network.Attribute
{
    internal sealed class SeventhHeaderAttribute : ApiActionAttribute
    {
        private readonly string _host;
        private readonly string _userAgent;

        public SeventhHeaderAttribute(string host,
            string userAgent)
        {
            _host = host;
            _userAgent = userAgent;
        }

        public SeventhHeaderAttribute(string host)
        {
            _host = host;
            _userAgent = $"t7s/{RequestParams.Version} CFNetwork/1125.2 Darwin/19.4.0";
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
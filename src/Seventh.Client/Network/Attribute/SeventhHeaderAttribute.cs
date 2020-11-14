using System.Threading.Tasks;
using Seventh.Client.Options;
using WebApiClientCore;
using WebApiClientCore.Attributes;

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
            _userAgent = $"t7s/{DefaultOptions.ParamOptions.Blt} CFNetwork/1125.2 Darwin/19.4.0";
        }

        public override Task OnRequestAsync(ApiRequestContext context)
        {
            var requestHeaders = context.HttpContext.RequestMessage.Headers;
            requestHeaders.Add("Expect", "100-continue");
            requestHeaders.Remove("User-Agent");
            requestHeaders.Add("User-Agent", _userAgent);
            requestHeaders.Add("Host", _host);
            requestHeaders.Add("Connection", "Keep-Alive");
            requestHeaders.Add("Accept-Encoding", "gzip,deflate,br");
            return Task.CompletedTask;
        }
    }
}
using System.Threading.Tasks;
using Seventh.Client.Common;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Seventh.Client.Network.Interfaces
{
    public interface ICheckUpdateApiClient : IHttpApi
    {
        [HttpGet]
        [HttpHost(UriConst.ApkFrom1AppCheckUrl)]
        Task<string> From1App();

        [HttpGet]
        [HttpHost(UriConst.ApkFromQooApp)]
        Task<string> FromQooApp();
    }
}
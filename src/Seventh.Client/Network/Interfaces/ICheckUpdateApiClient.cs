using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Seventh.Client.Common;
using Seventh.Client.Network.Attribute;
using Seventh.Client.Network.Models.Request;
using Seventh.Client.Network.Models.Response;
using WebApiClient;
using WebApiClient.Attributes;

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

        ITask<HttpResponseFile> DownloadUpdateAsync([Uri, Required] string uri);

        [HttpHost(UriConst.SeventhApiBaseUrl)]
        [SeventhHeader("api.t7s.jp")]
        [HttpPost(InspectionRequest.Path)]
        [TraceFilter(OutputTarget = OutputTarget.Console)]
        ITask<InspectionResponse> Inspection([SignatureFormContent] InspectionRequest inspectionRequest);
    }
}
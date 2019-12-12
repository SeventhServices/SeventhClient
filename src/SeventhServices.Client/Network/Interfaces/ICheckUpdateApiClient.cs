using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using SeventhServices.Client.Common;
using SeventhServices.Client.Network.Attribute;
using SeventhServices.Client.Network.Models.Request;
using SeventhServices.Client.Network.Models.Response;
using WebApiClient;
using WebApiClient.Attributes;

namespace SeventhServices.Client.Network.Interfaces
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
        [SeventhHeader]
        [HttpPost(InspectionRequest.Path)]
        [TraceFilter(OutputTarget = OutputTarget.Console)]
        ITask<InspectionResponse> Inspection([SignatureFormContent] InspectionRequest inspectionRequest);
    }
}
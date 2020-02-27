using System.ComponentModel.DataAnnotations;
using System.IO;
using Seventh.Client.Common;
using WebApiClient;
using WebApiClient.Attributes;

namespace Seventh.Client.Network.Interfaces
{
    [HttpHost(UriConst.SeventhAssetDownloadBaseUrl)]
    public interface IAssetDownloadClient : IHttpApi
    {
        [HttpGet]
        ITask<HttpResponseFile> FileResponse([Uri, Required] string uri);

        [HttpGet]
        ITask<Stream> FileStream([Uri, Required] string uri);

        [HttpGet]
        ITask<byte[]> FileBytes([Uri, Required] string uri);


        [HttpGet("resource/images/card/l/{fileName}")]
        ITask<HttpResponseFile> LargeCard(string fileName);
    }
}
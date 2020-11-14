using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.Http;
using Seventh.Client.Common;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Seventh.Client.Network.Interfaces
{
    [HttpHost(UriConst.SeventhAssetDownloadBaseUrl)]
    public interface IAssetDownloadClient : IHttpApi
    {
        [HttpGet]
        ITask<HttpRequestMessage> FileResponse([Uri, Required] string uri);

        [HttpGet]
        ITask<Stream> FileStream([Uri, Required] string uri);

        [HttpGet]
        ITask<byte[]> FileBytes([Uri, Required] string uri);

        [HttpGet("resource/images/card/l/{fileName}")]
        ITask<HttpRequestMessage> LargeCard(string fileName);
    }
}
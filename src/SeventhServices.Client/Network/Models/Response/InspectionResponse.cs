using SeventhServices.Client.Network.Models.Response.Shared;

namespace SeventhServices.Client.Network.Models.Response
{
    public class InspectionResponse : ApiResult
    {
        public Inspection Inspection { get; set; }

    }

    public class Inspection
    {
        public Downloadconfig DownloadConfig { get; set; }
        public bool Review { get; set; }
        public string Url { get; set; }
    }


}
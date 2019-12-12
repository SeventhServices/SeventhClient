using SeventhServices.Client.Network.Models.Response.Shared;

namespace SeventhServices.Client.Network.Models.Response.Setup
{
    public class ResourceResultResponse : ApiResult
    {
        public Updateresource UpdateResource { get; set; }
    }

    public class Updateresource
    {
        public int Revision { get; set; }
        public string[] ModifyList { get; set; }
        public string[] OneByOneModifyList { get; set; }
        public string[] DeleteList { get; set; }
        public int DownloadSize { get; set; }
        public Downloadconfig DownloadConfig { get; set; }
        public string ImagePath { get; set; }
        public int ImageRev { get; set; }
        public object[] ForceScenarioFileNameList { get; set; }
    }

}
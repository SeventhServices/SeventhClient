using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response.Setup
{
    public class ResourceResultResponse : ApiUserResponse
    {
        public UpdateResource UpdateResource { get; set; }
    }

    public class UpdateResource
    {
        public int Revision { get; set; }
        public string[] ModifyList { get; set; }
        public string[] OneByOneModifyList { get; set; }
        public string[] DeleteList { get; set; }
        public int DownloadSize { get; set; }
        public DownloadConfig DownloadConfig { get; set; }
        public string ImagePath { get; set; }
        public int ImageRev { get; set; }
        public object[] ForceScenarioFileNameList { get; set; }
    }

}
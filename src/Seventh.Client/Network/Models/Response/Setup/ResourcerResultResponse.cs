using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response.Setup
{
    public class ResourceResultResponse : ApiUserResponse
    {
        public Tutorial Tutorial { get; set; }
        public UpdateResource UpdateResource { get; set; }
    }

    public class UpdateResource
    {
        public int DownloadType { get; set; }
        public int MasterRevision { get; set; }
        public string MasterPath { get; set; }
        public int MasterSize { get; set; }
        public int Revision { get; set; }
        public string MetaPath { get; set; }
        public int MetaSize { get; set; }
        public int ResourceSize { get; set; }
        public DownloadConfig DownloadConfig { get; set; }
        public int ImageRev { get; set; }
        public string[] Zips { get; set; }
        public string[] FeatureScenarios { get; set; }
    }

}
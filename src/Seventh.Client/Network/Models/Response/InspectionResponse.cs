﻿using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response
{
    public class InspectionResponse : ApiResponse
    {
        public Inspection Inspection { get; set; }

    }

    public class Inspection
    {
        public DownloadConfig DownloadConfig { get; set; }
        public bool Review { get; set; }
        public string Url { get; set; }
    }


}
using Newtonsoft.Json;

namespace Seventh.Client.Network.Models.Response
{
    public abstract class ApiResponse : ApiErrorResponse
    {
        [JsonProperty("Is_Development")]
        public bool IsDevelopment { get; set; } = true;

        public long Ts { get; set; }

        public string Sig { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace Seventh.Client.Network.Models.Response
{
    public abstract class ApiResponse : ApiErrorResponse
    {
        [JsonPropertyName("Is_Development")]
        public bool IsDevelopment { get; set; } = true;
        public long Ts { get; set; }
        public long Rts { get; set; }
        public string Sig { get; set; }
    }
}
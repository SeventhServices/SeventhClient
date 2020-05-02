namespace Seventh.Client.Network.Models.Response
{
    public abstract class ApiErrorResponse
    {
        public Error Error { get; set; }
    }

    public class Error
    {
        public int ErrorCode { get; set; }
        public string ToUrl { get; set; }
        public string ErrorMessage { get; set; }
    }
}
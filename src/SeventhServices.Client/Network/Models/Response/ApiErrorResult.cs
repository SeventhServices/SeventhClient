namespace SeventhServices.Client.Network.Models.Response
{
    public abstract class ApiErrorResult
    {
        public bool Result { get; set; }

        public Error Error { get; set; }
    }

    public class Error
    {

        public int ErrorCode { get; set; }

        public string ToUrl { get; set; }

        public string ErrorMessage { get; set; }
    }
}
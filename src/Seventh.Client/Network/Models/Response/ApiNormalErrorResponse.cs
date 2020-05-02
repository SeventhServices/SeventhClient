namespace Seventh.Client.Network.Models.Response
{
    public class ApiNormalErrorResponse
    {
        public NormalError NormalError { get; set; }
    }
    public class NormalError
    {
        public long NormalErrorCode { get; set; }
        public string NormalErrorMessage { get; set; }
    }
}
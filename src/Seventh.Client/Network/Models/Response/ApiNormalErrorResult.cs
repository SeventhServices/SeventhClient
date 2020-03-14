namespace Seventh.Client.Network.Models.Response
{
    public class ApiNormalErrorResult
    {
        public NormalError NormalError { get; set; }
    }
    public class NormalError
    {
        public long NormalErrorCode { get; set; }
        public string NormalErrorMessage { get; set; }
    }
}
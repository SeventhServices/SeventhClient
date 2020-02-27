namespace Seventh.Client.Network.Models.Response
{
    public abstract class ApiResult : ApiErrorResult
    {

        public bool IsDevelopment { get; set; }

        public long Ts { get; set; }

        public string Pid { get; set; }

        public int Rev { get; set; }

        public string Sig { get; set; }
    }
}
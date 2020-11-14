namespace Seventh.Client.Network.Models.Response
{
    public abstract class ApiUserResponse : ApiResponse
    {
        public int Pid { get; set; }
        public int Rev { get; set; }
    }
}
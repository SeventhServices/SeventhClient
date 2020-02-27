using Seventh.Client.Common;
using Seventh.Client.Network.Attribute;
using Seventh.Client.Network.Models.Request;
using Seventh.Client.Network.Models.Request.Event;
using Seventh.Client.Network.Models.Request.Friend;
using Seventh.Client.Network.Models.Request.Present;
using Seventh.Client.Network.Models.Request.Setup;
using Seventh.Client.Network.Models.Response;
using Seventh.Client.Network.Models.Response.Event;
using Seventh.Client.Network.Models.Response.Friend;
using Seventh.Client.Network.Models.Response.Present;
using Seventh.Client.Network.Models.Response.Setup;
using WebApiClient;
using WebApiClient.Attributes;

namespace Seventh.Client.Network.Interfaces
{
    [TraceFilter(OutputTarget = OutputTarget.Console)]
    [HttpHost(UriConst.SeventhApiBaseUrl)]
    [SeventhHeader]
    public interface ISeventhApiClient : IHttpApi
    {
        [HttpPost(InspectionRequest.Path)]
        ITask<InspectionResponse> Inspection([SignatureFormContent] InspectionRequest inspectionRequest);

        [HttpPost(LoginRequest.Path)]
        ITask<LoginResponse> Login([SignatureFormContent] LoginRequest loginRequest);

        [HttpPost(ResourceResultRequest.Path)]
        ITask<ResourceResultResponse> ResourceResult([SignatureFormContent] ResourceResultRequest resourceResultRequest);

        [HttpPost(EventStatusRequest.Path)]
        ITask<EventStatusResponse> EventStatus([SignatureFormContent] EventStatusRequest statusRequest);

        [HttpPost(EventRankingUserRequest.Path)]
        ITask<EventRankingUserResponse> EventRankingUser([SignatureFormContent] EventRankingUserRequest rankingUserRequest);

        [HttpPost(FriendSearchRequest.Path)]
        ITask<FriendSearchResponse> FriendSearch([SignatureFormContent]  FriendSearchRequest friendSearchRequest);

        [HttpPost(PresentMainRequest.Path)]
        ITask<PresentMainResponse> PresentMain([SignatureFormContent]  PresentMainRequest presentMainRequest);

        [HttpPost(PresentResultRequest.Path)]
        ITask<PresentMainResponse> PresentResult([SignatureFormWithListContent]  PresentResultRequest presentMainRequest);

        [HttpPost(MyPageRequest.Path)]
        ITask<MyPageResponse> MyPage([SignatureFormContent]  MyPageRequest myPageRequest);
    }
}
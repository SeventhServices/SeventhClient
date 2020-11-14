using Seventh.Client.Common;
using Seventh.Client.Network.Attribute;
using Seventh.Client.Network.Models.Request;
using Seventh.Client.Network.Models.Request.Event;
using Seventh.Client.Network.Models.Request.Friend;
using Seventh.Client.Network.Models.Request.Player;
using Seventh.Client.Network.Models.Request.Present;
using Seventh.Client.Network.Models.Request.Setup;
using Seventh.Client.Network.Models.Response;
using Seventh.Client.Network.Models.Response.Event;
using Seventh.Client.Network.Models.Request.Event.Raid;
using Seventh.Client.Network.Models.Response.Event.Raid;
using Seventh.Client.Network.Models.Response.Friend;
using Seventh.Client.Network.Models.Response.Present;
using Seventh.Client.Network.Models.Response.Setup;
using WebApiClientCore.Attributes;
using WebApiClientCore;

namespace Seventh.Client.Network.Interfaces
{
    [LoggingFilter]
    [HttpHost(UriConst.SeventhApiBaseUrl)]
    [SeventhHeader("api.t7s.jp")]
    public interface ISeventhApiClient : IHttpApi
    {
        #region Commmon
        [HttpPost(InspectionRequest.Path)]
        ITask<InspectionResponse> Inspection([SignatureFormContent] InspectionRequest inspectionRequest);

        [HttpPost(LoginRequest.Path)]
        ITask<LoginResponse> Login([SignatureFormContent] LoginRequest loginRequest);

        [HttpPost(MyPageRequest.Path)]
        ITask<MyPageResponse> MyPage([SignatureFormContent]  MyPageRequest myPageRequest);

        #endregion

        #region Player
        //[HttpPost(PlayerMainRequest.Path)]
        //ITask<PlayerMainResponse> PlayerMain([SignatureFormContent]  PlayerMainRequest friendSearchRequest);
        #endregion

        #region Friend
        [HttpPost(FriendSearchRequest.Path)]
        ITask<FriendSearchResponse> FriendSearch([SignatureFormContent]  FriendSearchRequest friendSearchRequest);

        #endregion

        #region Present
        [HttpPost(PresentMainRequest.Path)]
        ITask<PresentMainResponse> PresentMain([SignatureFormContent]  PresentMainRequest presentMainRequest);

        [HttpPost(PresentResultRequest.Path)]
        ITask<PresentMainResponse> PresentResult([SignatureFormWithListContent]  PresentResultRequest presentMainRequest);

        #endregion

        #region Setup
        [HttpPost(ResourceResultRequest.Path)]
        ITask<ResourceResultResponse> ResourceResult([SignatureFormContent] ResourceResultRequest resourceResultRequest);

        #endregion

        #region Ing



        #endregion

        #region Event

        [HttpPost(EventStatusRequest.Path)]
        ITask<EventStatusResponse> EventStatus([SignatureFormContent] EventStatusRequest statusRequest);

        [HttpPost(EventRankingUserRequest.Path)]
        ITask<EventRankingUserResponse> EventRankingUser([SignatureFormContent] EventRankingUserRequest rankingUserRequest);

        #region Raid
        //[HttpPost(EventRaidMainRequest.Path)]
        //ITask<EventRaidMainResponse> EventRaidMain([SignatureFormContent] EventRaidMainRequest raidBoardRequest);

        [HttpPost(EventRaidTopRequest.Path)]
        ITask<EventRaidTopResponse> EventRaidTop([SignatureFormContent] EventRaidTopRequest raidTopRequest);

        [HttpPost(EventRaidBoardRequest.Path)]
        ITask<EventRaidBoardResponse> EventRaidBoard([SignatureFormContent] EventRaidBoardRequest raidBoardRequest);

        [HttpPost(EventRaidBoardNextStepRequest.Path)]
        ITask<EventRaidBoardNextStepResponse> EventRaidBoardNextStep([SignatureFormContent] EventRaidBoardNextStepRequest raidBoardNextStepRequest);

        [HttpPost(EventRaidMapRequest.Path)]
        ITask<EventRaidMapResponse> EventRaidMap([SignatureFormContent] EventRaidMapRequest raidMapRequest);

        [HttpPost(EventRaidListRequest.Path)]
        ITask<EventRaidListResponse> EventRaidList([SignatureFormContent] EventRaidListRequest raidListRequest);

        [HttpPost(EventRaidBattlePreparationRequest.Path)]
        ITask<EventRaidBattlePreparationResponse> EventRaidBattlePreparation([SignatureFormContent] EventRaidBattlePreparationRequest raidBattlePreparationRequest);

        [HttpPost(EventRaidBattleResultRequest.Path)]
        ITask<EventRaidBattleResultResponse> EventRaidBattleResult([SignatureFormContent] EventRaidBattleResultRequest raidBattleResultRequest);

        [HttpPost(EventRaidBattleRequestRequest.Path)]
        ITask<EventRaidBattleRequestResponse> EventRaidBattleRequest([SignatureFormContent] EventRaidBattleRequestRequest raidBattleRequestRequest);

        #endregion

        #endregion
    }
}
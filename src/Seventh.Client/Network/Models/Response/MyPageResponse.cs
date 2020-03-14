using Seventh.Client.Common.Enums;
using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response
{
    public class MyPageResponse : ApiResult
    {
        public MyPage MyPage { get; set; }
        public ForcePopup[] ForcePopupList { get; set; }
    }

    public class MyPage
    {
        public int SubRev { get; set; }
        public UserStatusForMyPage UserStatus { get; set; }
        public LoginBonus[] LoginBonusList { get; set; }
        public Acquisition Acquisition { get; set; }
        public IngInfoForMyPage IngInfo { get; set; }
        public Banner[] Banner { get; set; }
        public EventInfo EventInfo { get; set; }
        public bool ShowGeolocation { get; set; }
        public bool HasRaidRequest { get; set; }
        public int InformationNum { get; set; }
        public int[] BadgeList { get; set; }
        public PresentForMyPage Present { get; set; }
        public CharacterForMyPage Character { get; set; }
        public Background[] Background { get; set; }
        public int UpdateInfoPage { get; set; }
        public string UpdateInfoVersion { get; set; }
        public string[] DeleteList { get; set; }
        public bool ShowWebview { get; set; }
    }

    public class UserStatusForMyPage
    {
        public int Coin { get; set; }
        public int FreeCoin { get; set; }
    }

    public class IngInfoForMyPage
    {
        public long TicketNum { get; set; }
        public bool IsLessonTime { get; set; }
        public long MailNum { get; set; }
        public int IngTotalLevel { get; set; }
        public bool IsLevelMax { get; set; }
        public float NextLevelRate { get; set; }
        public NextReward[] NextRewardList { get; set; }
    }

    public class Acquisition
    {
        public UserItemForMyPage[] UserItemList { get; set; }
    }

    public class UserItemForMyPage
    {
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }

    public class LoginBonus
    {
        public string LoginBonusName { get; set; }
        public int LoginBonusId { get; set; }
        public int LoginCount { get; set; }
        public bool IsComplete { get; set; }
        public string Deadline { get; set; }
    }

    public class ForcePopup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public string SceneName { get; set; }
        public string Url { get; set; }
        public string UrlParam { get; set; }
        public string Label { get; set; }
    }

    
    public class EventInfo
    {
        public EventCp EventCp { get; set; }
        public EventBanner EventBanner { get; set; }
    }

    public class EventCp
    {
        public int CurrentNum { get; set; }
        public int MaxNum { get; set; }
        public int RecoveryTime { get; set; }
        public int RecoverySecond { get; set; }
        public OpenEventType Type { get; set; }
    }

    public class EventBanner
    {
        public OpenEventBanner[] OpenEventBannerList { get; set; }
        public ClosedEventBannerList[] ClosedEventBannerList { get; set; }
    }

    public class OpenEventBanner
    {
        public OpenEventType Type { get; set; }
        public string ImgPath { get; set; }
        public long EndTime { get; set; }
    }

    public class ClosedEventBannerList
    {
        public OpenEventType Type { get; set; }
        public string ImgPath { get; set; }
        public long EndTime { get; set; }
    }

    public class PresentForMyPage
    {
        public int PresentNum { get; set; }
    }

    public class CharacterForMyPage
    {
        public int CardId { get; set; }
        public int[] CharaVoiceIds { get; set; }
    }

    public class NextReward
    {
        public int RewardType { get; set; }
        public int RewardId { get; set; }
        public int RewardNum { get; set; }
    }

    public class Banner
    {
        public string Url { get; set; }
        public string ImgPath { get; set; }
    }

    public class Background
    {
        public int Id { get; set; }
        public string Filename { get; set; }
    }
}
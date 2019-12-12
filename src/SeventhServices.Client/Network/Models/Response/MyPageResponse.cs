using SeventhServices.Client.Network.Models.Response.Shared;

namespace SeventhServices.Client.Network.Models.Response
{
    public class MyPageResponse : ApiResult
    {

        public MyPage MyPage { get; set; }

        public ForcePopup[] ForcePopupList { get; set; }

    }

    public class MyPage
    {
        public int SubRev { get; set; }
        public LoginBonus[] LoginBonusList { get; set; }
        public Acquisition Acquisition { get; set; }
        public UserStatus UserStatus { get; set; }
    }

    public class Acquisition
    {
        public Useritemlist[] UserItemList { get; set; }
    }

    public class Useritemlist
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
}
using System.Collections.Generic;
using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response
{
    public class LoginResponse : ApiResult
    {
        public Login Login { get; set; }
        public Tutorial Tutorial { get; set; }
    }

    public class Login
    {
        public UserStatus UserStatus { get; set; }
        public UserCard[] UserCardList { get; set; }
        public UserCardPotential[] UserCardPotential { get; set; }
        public object[] IntimateMaxFaceIdList { get; set; }
        public object[] EvolvedCardIdList { get; set; }
        public UserUnit[] UserUnitList { get; set; }
        public UserItem[] UserItemList { get; set; }
        public object[] UserDressList { get; set; }
        public long CharismaRecoverySecond { get; set; }
        public UserEventUnit[] UserEventUnitList { get; set; }
        public UserMedleyUnit[] UserMedleyUnitList { get; set; }
        public DownloadConfig DownloadConfig { get; set; }
        public UserOrnament[] UserOrnamentList { get; set; }
        public IngCharacter[] IngCharacterList { get; set; }
        public Terminfo TermInfo { get; set; }
        public UserStockCard[] UserStockCardList { get; set; }
        public long[] DeleteFirstViewList { get; set; }
    }

    public class UserEventUnit : UserUnitBase<UserCard>
    {

    }

    public class UserMedleyTeam : UserUnitBase<MedleyUnitCard>
    {
        public override int GroupCount { get; set; }
        public override int PositionCount { get; set; }
    }

    public class MedleyUnitCard : UnitCard
    {
        public override UserCard UserCard { get; set; }
    }


    public class Terminfo
    {
        public int Revision { get; set; }
        public string Description { get; set; }
        public string RevisionDescription { get; set; }
        public string Url { get; set; }
    }

    public class UserCardPotential
    {
        public int PotentialGroup { get; set; }
        public Potentiallist[] PotentialList { get; set; }
    }

    public class Potentiallist
    {
        public int CardTypeId { get; set; }
        public int Potential { get; set; }
    }

    public class UserUnit
    {
        public int UserUnitId { get; set; }
        public string UnitName { get; set; }
        public bool MainUnitFlg { get; set; }
        public bool DefenseUnitFlg { get; set; }
        public int UnitFlg { get; set; }
        public UnitCard[] UnitCardList { get; set; }
        public CharacterDress[] CharacterDressList { get; set; }
    }

    public class UserItem
    {
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }

    public class IngCharacter
    {
        public int CharacterId { get; set; }
        public int IngLevel { get; set; }
        public int Tension { get; set; }
    }

    public class Tutorial
    {
        public bool TutorialFlg { get; set; }
        public int TutorialId { get; set; }
    }

    public class UserStockCard
    {
        public long CardId { get; set; }
        public long Num { get; set; }
    }

    public class UserOrnament
    {
        public long CharacterId { get; set; }
        public long EquipmentCount { get; set; }
        public long SlotPosition { get; set; }
        public long OrnamentId { get; set; }
        public long UserOrnamentId { get; set; }
    }

    public class UserMedleyUnit
    {
        public UserMedleyTeam[] TeamList { get; set; }
        public bool CanLiveStart { get; set; }
        public bool HasMotivationMax { get; set; }
        public List<MedleyUnitCard> Leaders { get; set; }
    }


}



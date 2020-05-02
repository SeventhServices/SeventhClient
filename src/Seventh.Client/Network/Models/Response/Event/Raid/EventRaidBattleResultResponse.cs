using Seventh.Client.Common.Enums;
using Seventh.Client.Network.Models.Response.Shared;

namespace Seventh.Client.Network.Models.Response.Event.Raid
{
    public class EventRaidBattleResultResponse : ApiUserResponse
    {
        public RaidBattleResult RaidBattleResult { get; set; }
    }

    public class RaidBattleResult : ApiNormalErrorResponse
    {
        public Battle Battle { get; set; }
    }

    public class Battle
    {
        public Result Result { get; set; }
        public string BossName { get; set; }
        public Unit PlayerUnit { get; set; }
        public Unit EnemyUnit { get; set; }
        public CardTypeEffect CardTypeEffect { get; set; }
        public Combo Combo { get; set; }
        public Turn[] Turn { get; set; }
    }

    public class Result
    {
        public Reward Reward { get; set; }
        public LevelUpInfo LevelUpInfo { get; set; }
        public RaidBattleWinOrLose WinOrLose { get; set; }
        public bool CanContinue { get; set; }
        public UserStatusForResult UserStatus { get; set; }
        public RaidResultInfo RaidResultInfo { get; set; }
    }

    public class LevelUpInfo
    {
        public int BeforeLevel { get; set; }
        public int BeforeCharisma {get; set; }
        public int BeforeMaxCharisma { get; set; }
        public int BeforeMaxFriend { get; set; }
    }

    public class Reward
    {
        public int RewardExp { get; set; }
        public int RewardMoney { get; set; }
    }

    public class UserStatusForResult 
        : UserStatusForCharismaChange
    {
        public int Level { get; set; }
        public int MaxFriendNum { get; set; }
        public int Exp { get; set; }
        public int SubExp { get; set; }
        public int Money { get; set; }
    }

    public class RaidResultInfo
    {
        public int RequestedType { get; set; }
        public EventPointReward EventPointReward { get; set; }
        public bool CanRequest { get; set; }
        public bool HasFriend { get; set; }
    }

    public class EventPointReward
    {
        public int TotalEventPoint { get; set; }
        public int GetEventPoint { get; set; }
        public int DiscoveryPoint { get; set; }
        public int FinalBlowPoint { get; set; }
        public int WinCount { get; set; }
    }

    public class Unit
    {
        public int BaseHp { get; set; }
        public int MaxHp { get; set; }
        public int BaseAtk { get; set; }
        public int CardTypeId { get; set; }
        public Team[] TeamList { get; set; }
    }

    public class Team
    {
        public int No { get; set; }
        public Card[] CardList { get; set; }
    }

    public class Card
    {
        public int CardId { get; set; }
        public int BaseHp { get; set; }
        public int BaseAtk { get; set; }
    }

    public class CardTypeEffect
    {
        public TypeEffect[] PlayerTypeEffectList { get; set; }
        public TypeEffect[] EnemyTypeEffectList { get; set; }
    }

    public class TypeEffect
    {
        public int EffectType { get; set; }
        public int[] PositionList { get; set; }
        public int EffectHp { get; set; }
        public Effect[] EffectList { get; set; }
    }

    public class Effect
    {
        public int Position { get; set; }
        public int Rate { get; set; }
        public int Hp { get; set; }
    }

    public class Combo
    {
        public BattleCombo[] PlayerComboList { get; set; }
        public BattleCombo[] EnemyComboList { get; set; }
    }

    public class BattleCombo
    {
        public int ComboId { get; set; }
        public int[] PositionList { get; set; }
        public int? EffectHp { get; set; }
        public float EffectHpRate { get; set; }
        public int? EffectAtk { get; set; }
        public float EffectAtkRate { get; set; }
    }

    public class Turn
    {
        public int TurnNum { get; set; }
        public int Attacker { get; set; }
        public int Team { get; set; }
        public int[] Damage { get; set; }
        public int BeforeHp { get; set; }
        public int AfterHp { get; set; }
        public SkillEffect[] SkillEffectList { get; set; }
        public SkillActivated[] SkillActivatedList { get; set; }
        public int TotalDamage { get; set; }
    }

    public class SkillEffect
    {
        public BattleSkillType SkillType { get; set; }
        public int SkillId { get; set; }
        public int Position { get; set; }
    }

    public class SkillActivated
    {
        public BattleSkillType SkillType { get; set; }
        public int SkillId { get; set; }
        public int Position { get; set; }
        public BuffEffectType Effect { get; set; }
        public long? EffectVolume { get; set; }
    }
}
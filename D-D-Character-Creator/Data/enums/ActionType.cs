using System.Xml.Serialization;

namespace D_D_Character_Creator.Data.enums
{
    public enum ActionType
    {
        [XmlEnum(Name = "Default")]
        DetectAction = 0,
        [XmlEnum(Name = "Action")]
        Action = 1,
        [XmlEnum(Name = "Bonus")]
        BonusAction = 2,
        [XmlEnum(Name = "Reaction")]
        Reaction = 3,
        [XmlEnum(Name = "Move")]
        MoveAction = 4,
        [XmlEnum(Name = "Other")]
        Other = 5,
        [XmlEnum(Name = "Hidden")]
        ForceHidden = 6
    }
}

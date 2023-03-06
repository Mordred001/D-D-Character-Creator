using System.Xml.Serialization;

namespace D_D_Character_Creator.Data.enums
{
    [Flags]
    public enum Ability
    {
        [XmlEnum(Name = "None")]
        None = 0,
        [XmlEnum(Name = "Strength")]
        Strength = 1,
        [XmlEnum(Name = "Constitution")]
        Constitution = 2,
        [XmlEnum(Name = "Dexterity")]
        Dexterity = 3,
        [XmlEnum(Name = "Intelligence")]
        Intelligence = 4,
        [XmlEnum(Name = "Wisdom")]
        Wisdom = 5,
        [XmlEnum(Name = "Charisma")]
        Charisma = 6
    }

}

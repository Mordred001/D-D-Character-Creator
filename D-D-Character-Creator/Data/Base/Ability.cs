using System;
using System.Xml.Serialization;

namespace D_D_Character_Creator.Data.Base
{
    [Flags]
    public enum Ability {
        [XmlEnum(Name = "None")]
        None = 0,
        [XmlEnum(Name = "Strength")]
        Strength = 1, 
        [XmlEnum(Name = "Constitution")]
        Constitution = 2, 
        [XmlEnum(Name = "Dexterity")]
        Dexterity = 4, 
        [XmlEnum(Name = "Intelligence")]
        Intelligence = 8, 
        [XmlEnum(Name = "Wisdom")]
        Wisdom = 16, 
        [XmlEnum(Name = "Charisma")]
        Charisma = 32
    }
}

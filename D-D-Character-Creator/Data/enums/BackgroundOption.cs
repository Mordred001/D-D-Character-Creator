using System.Xml.Serialization;

namespace D_D_Character_Creator.Data.enums
{
    [Flags]
    public enum BackgroundOption
    {
        [XmlEnum(Name = "None")]
        None = 0,
        [XmlEnum(Name = "Bond")]
        Bond = 1,
        [XmlEnum(Name = "Ideal")]
        Ideal = 2,
        [XmlEnum(Name = "Flaw")]
        Flaw = 3,
        [XmlEnum(Name = "Trait")]
        Trait = 4
    }
}

﻿using System;
using System.Xml.Serialization;

namespace D_D_Character_Creator.Data.Descriptions
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
        Flaw = 4,
        [XmlEnum(Name = "Trait")]
        Trait = 8
    }
}

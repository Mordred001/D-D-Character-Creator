﻿using System;
using System.Xml.Serialization;

namespace D_D_Character_Creator.Data.Keywords
{
    [XmlInclude(typeof(Versatile)),
    XmlInclude(typeof(Range))]
    public class Keyword: IComparable<Keyword>
    {
        
        public String Name { get; set; }
        public Keyword() 
        {
            Name = "";
        }
        public Keyword(String keyword)
        {
            Name = keyword.ToLowerInvariant();
        }
        public virtual int CompareTo(Keyword other)
        {
            return Name.CompareTo(other.Name);
        }
        public override bool Equals(object other)
        {
            if (other is Keyword ) return Name == ((Keyword)other).Name;
            return false;
        }
        public override int GetHashCode()
        {
 	        return Name.GetHashCode();
        }
        public override string ToString()
        {
            return char.ToUpper(Name[0]) + Name.Substring(1);
        }
        public void check()
        {
            Name = Name.ToLowerInvariant();
        }
    }
}

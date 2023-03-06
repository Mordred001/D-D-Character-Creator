﻿using D_D_Character_Creator.Data.Base;

namespace D_D_Character_Creator.Data.Keywords
{
    public class Save: Keyword
    {
        public Ability Throw { get; set; }
        public Save(): base("save")
        {
            Throw = Ability.None;
        }
        public Save(Ability savingThrow)
            : base("save")
        {
            Throw = savingThrow;
        }
        public override int CompareTo(Keyword other)
        {
            if (Name != other.Name) return Name.CompareTo(other.Name);
            if (other is Material)
            {
                Material o = (Material)other;
                return Throw.CompareTo(o.Components);
            }
            return 1;

        }
        public override bool Equals(object other)
        {
            if (other is Save) return Name.Equals(((Save)other).Name) && Throw == ((Save)other).Throw;
            return false;
        }
        public override int GetHashCode()
        {
            return (Name + "_" + Throw).GetHashCode();
        }
        public override string ToString()
        {
            return "Save (" + Throw.ToString() + ")";
        }
    }
}

using System;

namespace D_D_Character_Creator.Data.Common
{
    public class Choice
    {
        public String UniqueID { get; set; }
        public String Value { get; set; }
        public Choice() {
        }
        public Choice(String ID, String value)
        {
            UniqueID = ID;
            Value = value;
        }

    }
}

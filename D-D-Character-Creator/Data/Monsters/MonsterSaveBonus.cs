﻿using D_D_Character_Creator.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator.Data.Monsters
{
    public class MonsterSaveBonus
    {
        public Ability Ability { get; set; }
        public int Bonus { get; set; }
        public String Text { get; set; }
        public override string ToString()
        {
            return Ability.ToString() + " " + Bonus.ToString("+#;-#;+0") + (Text != null && Text != "" ? " (" + Text + ")" : "");
        }

        public string ToString(Monster monster)
        {
            if (Ability != Ability.None) return Ability.ToString().Substring(0, 3) + " " + (monster.getAbility(Ability) / 2 - 5 + Bonus).ToString("+#;-#;+0") + (Text != null && Text != "" ? " (" + Text + ")" : "");
            return ToString();
        }
    }
}

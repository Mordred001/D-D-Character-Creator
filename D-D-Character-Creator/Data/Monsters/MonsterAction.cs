﻿using D_D_Character_Creator.Data.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator.Data.Monsters
{
    public class MonsterAction : MonsterTrait
    {
        public MonsterAction(string name, string text, int attack, string damage): base(name, text)
        {

            AttackBonus = attack;
            Damage = damage;
        }
        public MonsterAction()
        {

        }
        public int AttackBonus { get; set; }
        public string Damage { get; set; }
    }
}

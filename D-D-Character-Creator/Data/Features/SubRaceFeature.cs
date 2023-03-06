﻿using System;
using System.Collections.Generic;

namespace D_D_Character_Creator.Data.Features
{
    public class SubRaceFeature: Feature
    {
        public List<String> Races;
        public SubRaceFeature() : base() 
        {
            Action = Base.ActionType.ForceHidden;
            Races =new List<string>();
        }
        public SubRaceFeature(string name, string text, String Race, int level = 1, bool hidden = false)
            : base(name, text, level, hidden)
        {
            Action = Base.ActionType.ForceHidden;
            Races = new List<string>();
            Races.Add(Race);
        }
        public override string Displayname()
        {
            return "Subrace Feature";
        }
    }
}

﻿using D_D_Character_Creator.Data.Common;
using System;
using System.Collections.Generic;

namespace D_D_Character_Creator.Data.Features
{
    public class LanguageChoiceFeature : Feature
    {
        public int Amount { get; set; }
        public String UniqueID { get; set; }
        public LanguageChoiceFeature()
            : base(null, null, 1, true)
        {
            Action = Base.ActionType.ForceHidden;
            Amount = 1;
        }
        public LanguageChoiceFeature(string name, string text, string uniqueID, int amount = 1, int level = 1, bool hidden = false)
            : base(name, text, level, hidden)
        {
            Action = Base.ActionType.ForceHidden;
            Amount = amount;
            UniqueID = uniqueID;
        }
        
        public List<Language> getLanguages(IChoiceProvider provider, DnDContext context)
        {
            List<Language> res = new List<Language>();
            int offset = provider.GetChoiceOffset(this, UniqueID, Amount);
            for (int c = 0; c < Amount; c++)
            {
                String counter = "";
                if (c + offset > 0) counter = "_" + (c + offset).ToString();
                Choice cho = provider.GetChoice(UniqueID + counter);
                if (cho != null && cho.Value != "") res.Add(context.GetLanguage(cho.Value, Source));
            }
            return res;
        }
        public override string Displayname()
        {
            return "Language Choice Feature";
        }
    }
}

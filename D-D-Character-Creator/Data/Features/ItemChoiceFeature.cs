﻿using D_D_Character_Creator.Data.Common;
using System;
using System.Collections.Generic;

namespace D_D_Character_Creator.Data.Features
{
    public class ItemChoiceFeature: FreeItemAndGoldFeature
    {
        public int Amount { get; set; }
        public String UniqueID { get; set; }

            public ItemChoiceFeature()
            : base()
        {
            Action = Base.ActionType.ForceHidden;
            Amount = 1;
        }
        public ItemChoiceFeature(string name, string text, string uniqueID, Item choice1, Item choice2, int cp = 0, int sp = 0, int gp = 0, int amount = 1, int level = 1, bool hidden = true)
        : base(name, text, choice1, choice2, cp, sp, gp, level, hidden)
        {
            Action = Base.ActionType.ForceHidden;
            Amount = amount;
            UniqueID = uniqueID;
        }
        public ItemChoiceFeature(string name, string text, string uniqueID, Item choice1, Item choice2, Item choice3, int cp = 0, int sp = 0, int gp = 0, int amount = 1, int level = 1, bool hidden = true)
            : base(name, text, choice1, choice2, choice3, cp, sp, gp, level, hidden)
        {
            Action = Base.ActionType.ForceHidden;
            Amount = amount;
            UniqueID = uniqueID;
        }
        public ItemChoiceFeature(string name, string text, string uniqueID, Item choice1, Item choice2, Item choice3, Item choice4, int cp = 0, int sp = 0, int gp = 0, int amount = 1, int level = 1, bool hidden = true)
            : base(name, text, choice1, choice2, choice3, choice4, cp, sp, gp, level, hidden)
        {
            Action = Base.ActionType.ForceHidden;
            Amount = amount;
            UniqueID = uniqueID;
        }
        public override IEnumerable<Item> getItems(IChoiceProvider provider, DnDContext context)
        {
            List<Item> res = new List<Item>();
            int offset = provider.GetChoiceOffset(this, UniqueID, Amount);
            for (int c = 0; c < Amount; c++)
            {
                String counter = "";
                if (c + offset > 0) counter = "_" + (c + offset).ToString();
                Choice cho = provider.GetChoice(UniqueID + counter);
                if (cho != null && cho.Value != "") res.Add(context.GetItem(cho.Value, Source));
            }
            return res;
        }
        public override string Displayname()
        {
            return "Item Choice Feature";
        }
    }
}

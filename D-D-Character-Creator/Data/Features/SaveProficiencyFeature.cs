using D_D_Character_Creator.Data.Base;

namespace D_D_Character_Creator.Data.Features
{
    public class SaveProficiencyFeature: Feature 
    {
        public Ability Ability { get; set; }
        public SaveProficiencyFeature()
            : base()
        {
            Action = Base.ActionType.ForceHidden;
            Ability = Ability.None;
        }
        public SaveProficiencyFeature(string name, string text, Ability ability, int level = 1, bool hidden = true)
            : base(name, text, level, hidden)
        {
            Action = Base.ActionType.ForceHidden;
            Ability = ability;
        }
        public override string Displayname()
        {
            return "Save Proficiency Feature";
        }
    }
}

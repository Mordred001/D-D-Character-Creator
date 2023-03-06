namespace D_D_Character_Creator.Data.Features
{
    public class SpellModifyFeature: Feature
    {
        public string Spells { get; set; }
        public SpellModifyFeature():base()
        {
            Action = Base.ActionType.ForceHidden;
            Spells = "";
        }
        public SpellModifyFeature(string name, string text, string spells, int level = 1, bool hidden = false)
            : base(name, text, level, hidden)
        {
            Action = Base.ActionType.ForceHidden;
            Spells = spells;
        }
        public override string Displayname()
        {
            return "Spell Modify Feature";
        }
    }
}

using D_D_Character_Creator.Data.Base;

namespace D_D_Character_Creator.Data.Items
{
    public class Scroll: Item
    {
        public Spell Spell;
        public Scroll()
        {

        }
        public Scroll(Spell spell) : base()
        {
            Spell = spell;
            Name = spell.Name;
            Price = new Price();
            Weight = 0;
            
        }
        public override string ToString()
        {
            return "Scroll of " + Name;
        }
    }
}

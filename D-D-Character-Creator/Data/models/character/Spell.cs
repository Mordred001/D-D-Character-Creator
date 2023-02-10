using D_D_Character_Creator.Data.models.common;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.character
{
    public class Spell
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpellLevel { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string Duration { get; set; }
        public Description Description { get; set; }
        public ICollection<Description> Descriptions { get; set; }

        public ICollection<Damage> Damages { get; set; }
    }
}

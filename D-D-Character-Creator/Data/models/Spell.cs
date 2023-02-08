using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
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
        public string Description { get; set; }
        public string? Damage { get; set; }
    }
}

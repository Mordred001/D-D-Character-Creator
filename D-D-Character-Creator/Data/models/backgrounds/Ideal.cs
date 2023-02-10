using System.ComponentModel.DataAnnotations;
using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.common;

namespace D_D_Character_Creator.Data.models.backgrounds
{
    public class Ideal
    {
        [Key]
        public int Id { get; set; }
        public int DiceRoll { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
        public ICollection<Alignment> Alignments { get; set; }
    }
}

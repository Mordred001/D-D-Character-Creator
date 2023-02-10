using D_D_Character_Creator.Data.models.common;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.backgrounds
{
    public class Bond
    {
        [Key]
        public int Id { get; set; }
        public int DiceRoll { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }

    }
}

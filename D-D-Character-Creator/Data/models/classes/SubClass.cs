using System.ComponentModel.DataAnnotations;
using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.common;

namespace D_D_Character_Creator.Data.models.classes
{
    public class SubClass
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }

        public ICollection<SubClassLevel> SubClassesLevels { get; set; }
        public ICollection<Spell> Spells { get; set; }

    }
}

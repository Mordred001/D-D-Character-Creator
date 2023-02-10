using D_D_Character_Creator.Data.enums;
using D_D_Character_Creator.Data.models.classes;
using D_D_Character_Creator.Data.models.common;
using D_D_Character_Creator.Data.models.races;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.equipment
{
    public class ToolProficiency
    {
        [Key]
        public int Id { get; set; }
        public ProficiencyType Type { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
        public bool IsSelected { get; set; }
        public ICollection<CharacterClass> Classes { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}

using D_D_Character_Creator.Data.enums;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class ToolProficiency
    {
        [Key]
        public int Id { get; set; }
        public ProficiencyType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSelected { get; set; }
        public ICollection<CharacterClass> Classes { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}

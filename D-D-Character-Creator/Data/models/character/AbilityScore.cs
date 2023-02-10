using System.ComponentModel.DataAnnotations;
using D_D_Character_Creator.Data.models.common;

namespace D_D_Character_Creator.Data.models.character
{
    public class AbilityScore
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
        public ICollection<Skill> Skills { get; set; }

    }
}

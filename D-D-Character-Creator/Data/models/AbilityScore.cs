using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class AbilityScore
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Skill> Skills { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.common
{
    public class Skill
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
    }
}

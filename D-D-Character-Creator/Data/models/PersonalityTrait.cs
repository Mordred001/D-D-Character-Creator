using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class PersonalityTrait
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.common
{
    public class Features
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
        public string? Prerequisites { get; set; }
    }
}

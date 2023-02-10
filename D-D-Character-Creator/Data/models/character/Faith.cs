using D_D_Character_Creator.Data.models.common;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.character
{
    public class Faith
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
    }
}

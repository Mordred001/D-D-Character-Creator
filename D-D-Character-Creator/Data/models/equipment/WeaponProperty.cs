using D_D_Character_Creator.Data.models.common;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.equipment
{
    public class WeaponProperty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Prerequisites { get; set; }
        public Description Description { get; set; }
    }
}

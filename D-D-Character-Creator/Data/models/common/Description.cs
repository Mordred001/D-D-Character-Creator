using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.common
{
    public class Description
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}

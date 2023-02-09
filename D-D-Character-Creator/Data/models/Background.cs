using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class Background
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PersonalityTrait> PersonalityTraits { get; set; }
        public ICollection<Ideal> Ideals { get; set; }
        public ICollection<Bond> Bonds { get; set; }
        public ICollection<Flaw> Flaws { get; set; }

        public ICollection<SkillProficiency>? SkillProficiency { get;set; }
        public ICollection<ToolProficiency>? ToolProficiency { get;set; }
        public ICollection<Language>? Languages { get; set; }
        public ICollection<Equipment>? Equipment { get; set; }
        
    }
}

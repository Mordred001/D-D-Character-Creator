using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.common;
using D_D_Character_Creator.Data.models.equipment;
using D_D_Character_Creator.Data.models.races;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models.backgrounds
{
    public class Background
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PersonalityTrait> PersonalityTraits { get; set; }
        public ICollection<Ideal> Ideals { get; set; }
        public ICollection<Bond> Bonds { get; set; }
        public ICollection<Flaw> Flaws { get; set; }

        public ICollection<SkillProficiency>? SkillProficiency { get; set; }
        public ICollection<ToolProficiency>? ToolProficiency { get; set; }
        public ICollection<Language>? Languages { get; set; }
        public ICollection<Equipment>? Equipment { get; set; }
        public ICollection<Coinage>? Wealth { get; set; }
    }
}

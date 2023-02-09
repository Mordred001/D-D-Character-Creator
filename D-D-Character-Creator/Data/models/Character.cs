using D_D_Character_Creator.Data.enums;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public int HealthPoints { get; set; }
        public int Experience { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public Gender? Gender { get; set; }
        public string? HairColor { get; set; }
        public string? HairStyle { get; set; }
        public string? EyeColor { get; set; }
        public string? SkinColor { get; set; }

        // Foreign Classes
        public Faith? Faith { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public Race Race { get; set; }
        public Background Background { get; set; }
        public PersonalityTrait PersonalityTrait { get; set; }
        public Ideal Ideal { get; set; }
        public Bond Bond { get; set; }
        public Flaw Flaw { get; set; }
        public Alignment Alignment { get; set; }
        public ICollection<AbilityScore> Abilities { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<Features> Feats { get; set; }
        public string? CharacterPortrait { get; set; }
        public string? CharacterHistory { get; set; }
        public string? CharacterApprearance { get; set; }
        
    }
}

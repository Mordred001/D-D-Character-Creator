using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class CharacterClass
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HitDie { get; set; }
        //Proficiencies
        public ICollection<ArmorProficiency>? ArmorProficiencies { get; set; }
        public ICollection<WeaponProficiency>? WeaponProficiencies { get; set; }
        public ICollection<ToolProficiency>? ToolProficiencies { get; set; }
        public ICollection<SavingThrowProficiency>? SavingThrowProficiencies { get; set; }
        public ICollection<SkillProficiency>? SkillProficiencies { get; set; }

        //Equipment
        public ICollection<Equipment>? StartingEquipment { get; set; }

        //Features
        public ICollection<ClassLevel> ClassLevels { get; set; }
        public ICollection<SubClass>? SubClasses { get; set; }
        public ICollection<Spell>? Spells { get; set; }

    }
}

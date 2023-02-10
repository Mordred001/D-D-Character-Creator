using System.ComponentModel.DataAnnotations;
using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.common;
using D_D_Character_Creator.Data.models.equipment;

namespace D_D_Character_Creator.Data.models.classes
{
    public class CharacterClass
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
        public ICollection<Description> Descriptions { get; set; }
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

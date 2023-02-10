using D_D_Character_Creator.Data.enums;
using D_D_Character_Creator.Data.models.common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace D_D_Character_Creator.Data.models.equipment
{
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
        public float Cost { get; set; }
        public float Weight { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public string? Trait { get; set; }

        // Armor
        public ArmorType? ArmorType { get; set; }
        public int? ArmorClass { get; set; }
        public bool? DexModifer { get; set; }
        public bool? StealthModifer { get; set; }
        public int? MinimumStr { get; set; }

        // Mounts and Vehicles
        public string? Speed { get; set; }

        // Weapons
        public WeaponType? WeaponType { get; set; }
        public string? DamageDice { get; set; }
        public DamageType? DamageType { get; set; }
        public string? Range { get; set; }
        public string? SpecialRules { get; set; }
        public ICollection<WeaponProperty>? Properties { get; set; }
    }
}

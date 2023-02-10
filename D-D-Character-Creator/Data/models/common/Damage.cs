using D_D_Character_Creator.Data.enums;

namespace D_D_Character_Creator.Data.models.common
{
    public class Damage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public string DamageDice { get; set; }
        public DamageType DamageType { get; set; }
    }
}

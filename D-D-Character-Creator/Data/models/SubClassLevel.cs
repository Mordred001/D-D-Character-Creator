using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class SubClassLevel
    {
        [Key]
        public int Id { get; set; }
        public int SubClassLvl { get; set; }
        public ICollection<Features> Features { get; set; }
        public int? CantripsKnown { get; set; }
        public int? SpellsKnown { get; set; }
        public int? Circle1 { get; set; }
        public int? Circle2 { get; set; }
        public int? Circle3 { get; set; }
        public int? Circle4 { get; set; }
        public int? Circle5 { get; set; }
        public int? Circle6 { get; set; }
        public int? Circle7 { get; set; }
        public int? Circle8 { get; set; }
        public int? Circle9 { get; set; }

    }
}

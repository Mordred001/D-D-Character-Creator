using D_D_Character_Creator.Data.enums;
using System.ComponentModel.DataAnnotations;

namespace D_D_Character_Creator.Data.models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainDescription { get; set; }
        public string PhysicalDescription { get; set; }
        public string SocietyDescription { get; set; }
        public string RelationsDescription { get; set; }
        public string AlignmentDescription { get; set; }
        public string AdventurerDescription { get; set; }
        public int AgeStart { get; set; }
        public ICollection<Alignment> Alignments { get; set; }
        public RaceSize Size { get; set; }
        public int Speed { get; set; }
        public ICollection<Language> Languages { get; set; }


        //
        public ICollection<Features>? Features { get; set; }
        public ICollection<Skill>? Skill { get; set; }
        public int? StrBonus { get; set; }
        public int? DexBonus { get; set; }
        public int? ConBonus { get; set; }
        public int? IntBonus { get; set; }
        public int? WisBonus { get; set; }
        public int? ChaBonus { get; set; }

    }
}

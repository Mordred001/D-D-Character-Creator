using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace D_D_Character_Creator.Data.models.character
{
    public class Coinage
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        public float Coins
        {
            get
            {
                float coinage = PP * 10;
                coinage += GP;
                coinage += SP * 0.1f;
                coinage += CP * 0.01f;
                return coinage;
            }
            set
            {
                PP = (int)(value / 10);
                GP = (int)(value % 10);
                value = value % 10 - GP;
                SP = (int)(value * 10);
                value = value * 10 - SP;
                CP = (int)(value * 10);
            }
        }
        public int PP { get; set; }
        public int GP { get; set; }
        public int EP { get; set; }
        public int SP { get; set; }
        public int CP { get; set; }

    }
}

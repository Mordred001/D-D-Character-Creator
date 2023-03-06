using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.common;

namespace D_D_Character_Creator.Data.DTOs
{
    public class AbilityScores
    {
        public static XmlSerializer Serializer = new XmlSerializer(typeof(AbilityScores));
        public List<int> PointBuyCost = new List<int>();
        public int PointBuyPoints { get; set; }
        public int PointBuyMinScore { get; set; }
        public int PointBuyMaxScore { get; set; }
        public int DefaultMax { get; set; }
        public List<string> Arrays = new List<string>();
        [XmlIgnore]
        public string Filename { get; set; }

        public static int GetMod(int score)
        {
            return score - 10 >> 1;
        }
        public int GetPointBuyCost(int score)
        {
            if (score > PointBuyMaxScore) return -1;
            if (score < PointBuyMinScore) return -1;
            return PointBuyCost[score - PointBuyMinScore];
        }
        public int GetPointBuyPoints()
        {
            return PointBuyPoints;
        }

        public AbilityScores Clone()
        {
            using (MemoryStream mem = new MemoryStream())
            {
                Serializer.Serialize(mem, this);
                mem.Seek(0, SeekOrigin.Begin);
                AbilityScores r = (AbilityScores)Serializer.Deserialize(mem);
                return r;
            }
        }

        public List<AbilityScore> GetArrays()
        {
            List<AbilityScore> res = new List<AbilityScore>();
            foreach (string s in Arrays) res.Add(new AbilityScore(s));
            return res;
        }

        public int Max
        {
            get
            {
                if (DefaultMax == 0) DefaultMax = 20;
                return DefaultMax;
            }
        }


    }
}


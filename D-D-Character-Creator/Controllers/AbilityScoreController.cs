using D_D_Character_Creator.Data;
using D_D_Character_Creator.Data.enums;
using D_D_Character_Creator.Data.models.character;
using Microsoft.AspNetCore.Mvc;

namespace D_D_Character_Creator.Controllers
{
    public class AbilityScoreController : ControllerBase
    {
        private readonly DndDbContext _context;
        private readonly ILogger<AbilityScoreController> _logger;

        public AbilityScoreController(ILogger<AbilityScoreController> logger, DndDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public static List<AbilityScore> Generate()
        {
            Random random = new Random();
            return new List<AbilityScore>() {
                new AbilityScore
                {
                    Strength = random.Next(3, 18),
                    Dexterity = random.Next(3, 18),
                    Constitution = random.Next(3, 18),
                    Intelligence = random.Next(3, 18),
                    Wisdom = random.Next(3, 18),
                    Charisma = random.Next(3, 18)
                },
                new AbilityScore
                {
                    Strength = random.Next(3, 18),
                    Dexterity = random.Next(3, 18),
                    Constitution = random.Next(3, 18),
                    Intelligence = random.Next(3, 18),
                    Wisdom = random.Next(3, 18),
                    Charisma = random.Next(3, 18)
                },
                new AbilityScore
                {
                    Strength = random.Next(3, 18),
                    Dexterity = random.Next(3, 18),
                    Constitution = random.Next(3, 18),
                    Intelligence = random.Next(3, 18),
                    Wisdom = random.Next(3, 18),
                    Charisma = random.Next(3, 18)
                },
            };
        }
        public static List<AbilityScore> Generate8()
        {
            Random random = new Random();
            return new List<AbilityScore>() {
                new AbilityScore
                {
                    Strength = random.Next(8, 18),
                    Dexterity = random.Next(8, 18),
                    Constitution = random.Next(8, 18),
                    Intelligence = random.Next(8, 18),
                    Wisdom = random.Next(8, 18),
                    Charisma = random.Next(8, 18)
                },
                new AbilityScore
                {
                    Strength = random.Next(8, 18),
                    Dexterity = random.Next(8, 18),
                    Constitution = random.Next(8, 18),
                    Intelligence = random.Next(8, 18),
                    Wisdom = random.Next(8, 18),
                    Charisma = random.Next(8, 18)
                },
                new AbilityScore
                {
                    Strength = random.Next(8, 18),
                    Dexterity = random.Next(8, 18),
                    Constitution = random.Next(8, 18),
                    Intelligence = random.Next(8, 18),
                    Wisdom = random.Next(8, 18),
                    Charisma = random.Next(8, 18)
                },
            };
        }

    }
}

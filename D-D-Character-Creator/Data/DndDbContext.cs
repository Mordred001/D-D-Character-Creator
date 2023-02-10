using D_D_Character_Creator.Data.account;
using D_D_Character_Creator.Data.models.backgrounds;
using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.classes;
using D_D_Character_Creator.Data.models.common;
using D_D_Character_Creator.Data.models.equipment;
using D_D_Character_Creator.Data.models.races;
using D_D_Character_Creator.Data.seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace D_D_Character_Creator.Data
{
    public class DndDbContext : IdentityDbContext<User>
    {
        public DndDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new SpellData());

        }
        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<ArmorProficiency> ArmorProficiencies { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Bond> Bonds { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<ClassLevel> ClassLevels { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Faith> Faiths { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Flaw> Flaws { get; set; }
        public DbSet<Ideal> Ideals { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonalityTrait> PersonalityTraits { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<SavingThrowProficiency> SavingThrowProficiencies { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillProficiency> SkillProficiencies { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<SubClass> SubClasses { get; set; }
        public DbSet<SubClassLevel> SubClassLevels { get; set; }
        public DbSet<ToolProficiency> ToolProficiencies { get; set; }
        public DbSet<WeaponProficiency> WeaponProficiencies { get; set; }
        public DbSet<WeaponProperty> WeaponProperties { get; set; }

    }
}

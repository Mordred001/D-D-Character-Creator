using D_D_Character_Creator.Data.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D_D_Character_Creator.Data.seeders
{
    public class SpellData : IEntityTypeConfiguration<Spell>
    {
        public void Configure(EntityTypeBuilder<Spell> builder)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.dnd5eapi.co/");
            var results = client.GetAsync("spells").Result;

        }
    }
}

using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace D_D_Character_Creator.Data.seeders
{
    public class SpellData : IEntityTypeConfiguration<Spell>
    {
        public void Configure(EntityTypeBuilder<Spell> builder)
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory() + "/xml/Spells/");
            var doc = new XmlDocument();
            foreach (var file in files)
            {
                doc.LoadXml(File.ReadAllText(file));
                var json = JsonConvert.SerializeXmlNode(doc);
                dynamic data = JObject.Parse(json);
                var spell = new Spell
                {
                    Name = data.Spell.Name,
                    CastingTime = data.Spell.CastingTime,
                    Range = data.Spell.Range,
                    Duration = data.Spell.Duration,
                    SpellLevel = data.Spell.Level,
                    Description = new Description { Name = data.Spell.Name, Desc = data.Spell.Description }
                };

                if (Helpers.Helpers.HasProperty(data.Spell.Descriptions, "Description"))
                {
                    ICollection<Description> descs = new List<Description>();
                    foreach (var desc in data.Spell.Descriptions)
                    {
                        dynamic descriptor;
                        if (desc.Value is JArray)
                        {
                            foreach (var item in desc.Value)
                            {
                                descriptor = (JObject)item;
                                descs.Add(new Description { Name = descriptor.Name, Desc = descriptor.Text });
                            }
                        }
                        else
                        {
                            descriptor = (JObject)desc.Value;
                            var Desc = new Description { Name = descriptor.Name, Desc = descriptor.Text };
                            descs.Add(Desc);
                        }
                        if (descs.Count > 0)
                            spell.Descriptions = descs;
                    }
                }
                if (Helpers.Helpers.HasProperty(data.Spell.CantripDamage, "CantripDamage"))
                {
                    ICollection<Damage> damages = new List<Damage>();
                    foreach (var dam in data.Spell.CantripDamage)
                    {
                        dynamic damage;
                        if (dam.Value is JArray)
                        {
                            foreach (var item in dam.Value)
                            {
                                damage = (JObject)item;
                                damages.Add(new Damage { DamageDice = damage.Damage, Level = damage.Level, Name = data.Spell.Name });
                            }
                        }
                        else
                        {
                            damage = (JObject)dam.Value;

                            var dmg = new Damage { Level = damage.Level, Name = damage.Name, DamageDice = damage.Damage };
                            damages.Add(damage);
                        }

                    }
                    if (damages.Count > 0)
                        spell.Damages = damages;
                }
            }
        }

    }
}

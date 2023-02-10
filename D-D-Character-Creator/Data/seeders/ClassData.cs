using D_D_Character_Creator.Data.models.character;
using D_D_Character_Creator.Data.models.classes;
using D_D_Character_Creator.Data.models.common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace D_D_Character_Creator.Data.seeders
{
    public class ClassData : IEntityTypeConfiguration<CharacterClass>
    {
        public void Configure(EntityTypeBuilder<CharacterClass> builder)
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory() + "/xml/Classes/");
            var doc = new XmlDocument();
            foreach (var file in files)
            {
                doc.LoadXml(File.ReadAllText(file));
                var json = JsonConvert.SerializeXmlNode(doc);
                dynamic data = JObject.Parse(json);
                var characterClass = new CharacterClass
                {
                    Name = data.ClassDefinition.Name,
                    Description = new Description { Name = data.ClassDefinition.Name, Desc = data.ClassDefinition.Description },
                    HitDie = data.ClassDefinition.HitDie
                };

                if (Helpers.Helpers.HasProperty(data.ClassDefinition.Descriptions, "Description"))
                {
                    ICollection<Description> descs = new List<Description>();
                    foreach (var desc in data.ClassDefinition.Descriptions)
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
                            characterClass.Descriptions = descs;
                    }
                }
                if (Helpers.Helpers.HasProperty(data.ClassDefinition.CantripDamage, "CantripDamage"))
                {
                    ICollection<Damage> damages = new List<Damage>();
                    foreach (var dam in data.ClassDefinition.CantripDamage)
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
                        characterClass.Damages = damages;
                }
            }
        }

    }
}

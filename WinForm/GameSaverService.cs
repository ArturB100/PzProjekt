using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using PzProjekt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection;
using System.Text;

using System.Threading.Tasks;

namespace WinForm
{
    public class GameSaverService
    {
        static string filename = "saveGame.json";
        public static string SerializeToJson (object o)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            if (o is PlayableCharacters)
            {
                PlayableCharacters playableCharacters = (PlayableCharacters) o;
                for (int i=0; i<playableCharacters.Count; i++)
                {
                    Character character = playableCharacters[i];
                    // spells
                    foreach (var spell in character.Inventory.CharacterSpells)
                    {
                        spell.OnUse = null;
                        Debug.WriteLine("Saving spell...");
                    }

                    // weapon
                    if (character.Inventory.Weapon?.Effect != null)
                    {
                        character.Inventory.Weapon.Effect.ApplyEffect = null;
                    }

                }
                
            }

            return JsonConvert.SerializeObject (o, Formatting.Indented, settings);
        }

        public static void WriteToFile (object o)
        {
            
            string json = SerializeToJson (o);
            File.WriteAllText (filename, json);
        }

        public static T ReadFromFile <T>()
        {
            T data;
            try
            {
                string s = File.ReadAllText(filename);
                data = JsonConvert.DeserializeObject<T>(s);

                if (data is PlayableCharacters playableCharacters)
                {
                    for (int i=0;i<playableCharacters.Count;i++)
                    {
                        var character = playableCharacters[i];
                        foreach (Spell spell in  character.Inventory.CharacterSpells)
                        {
                            AssignSpellDelegate(spell);
                            Debug.WriteLine("Reading Spell ...");

                        }

                        if (character.Inventory.Weapon?.Effect != null)
                        {
                            Debug.WriteLine("Reading Weapon Effect ...");
                            Effect effect = character.Inventory.Weapon.Effect;
                            Weapon weapon = character.Inventory.Weapon;
                            // if (effect.ApplyEffectDelegateStr != null)
                            // {
                            //     AssignWeaponEffectApplyDelegate(weapon);
                            // }
                        }
                    }
                }

            } 
            catch (Exception e)
            {
                throw e;
            }
            return data;
        }

        private static void AssignSpellDelegate(Spell spell)
        {
            Type type = typeof(Spells); 
            MethodInfo methodInfo = type.GetMethod(spell.OnUseDelegate, BindingFlags.Static | BindingFlags.Public);
            if (methodInfo != null)
            {
                UseSpell useSpell = (UseSpell)Delegate.CreateDelegate(typeof(UseSpell), methodInfo);
                spell.OnUse = useSpell;
            }
        }

        // private static void AssignWeaponEffectApplyDelegate(Weapon weapon)
        // {
        //     if (weapon.Effect == null || weapon.Effect.ApplyEffect == null) return;
        //     Type type = typeof(Effects);
        //     MethodInfo methodInfo = type.GetMethod(weapon.Effect.ApplyEffectDelegateStr, BindingFlags.Static | BindingFlags.Public);
        //     if (methodInfo != null)
        //     {
        //         EffectAction effectAction = (EffectAction)Delegate.CreateDelegate(typeof(EffectAction), methodInfo);
        //         weapon.Effect.ApplyEffect = effectAction;
        //     }
        // }


    }

    public class BaseSpecifiedConcreteClassConverter : DefaultContractResolver
    {
        protected override Newtonsoft.Json.JsonConverter ResolveContractConverter(Type objectType)
        {
            if (typeof(InventoryItem).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                return null; // pretend TableSortRuleConvert is not specified (thus avoiding a stack overflow)
            return base.ResolveContractConverter(objectType);
        }
    }

    public class BaseConverter : Newtonsoft.Json.JsonConverter
    {
        static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(InventoryItem));
        }


        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            switch (jo["ObjType"].Value<int>())
            {
                case 1:
                    return JsonConvert.DeserializeObject<Armour>(jo.ToString(), SpecifiedSubclassConversion);
                case 2:
                    return JsonConvert.DeserializeObject<Weapon>(jo.ToString(), SpecifiedSubclassConversion);
                default:
                    throw new Exception();
            }
            throw new NotImplementedException();
        }

        public override bool CanWrite
        {
            get { return false; }
        }


        public override void WriteJson(JsonWriter writer, object? value, Newtonsoft.Json.JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }


    }
}

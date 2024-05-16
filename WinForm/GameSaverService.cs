using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using PzProjekt;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace WinForm
{
    public class GameSaverService
    {
        static string filename = "saveGame.json";
        public static string SerializeToJson (object o)
        {
            return JsonConvert.SerializeObject (o, Formatting.Indented);
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
            } 
            catch (Exception e)
            {
                throw e;
            }
            return data;
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
}

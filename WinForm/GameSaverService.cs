using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinForm
{
    public class GameSaverService
    {
        static string filename = "saveGame.json";
        public static string SerializeToJson (object o)
        {
            return JsonSerializer.Serialize (o);
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
                data = JsonSerializer.Deserialize<T>(s);
            } 
            catch (Exception e)
            {
                throw e;
            }
            return data;
        }
    }
}

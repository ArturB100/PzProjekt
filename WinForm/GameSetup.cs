using PzProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinForm
{
    public class GameSetup
    {
        public ArmourShop  ArmourShop { get; set; }



        public GameSetup() 
        { 
            DataFeeder dataFeeder = new DataFeeder();

            ArmourShop = new ArmourShop();
            ArmourShop.AddItems(dataFeeder.GetArmours());
            

        }

     
    }


    internal class DataFeeder
    {
        public DataFeeder() { }
        private List<Armour> helmets = new List<Armour>
         {
            new Armour(1, "Leather Helmet", 10, ArmourType.Helmet, 1),
            new Armour(3, "Iron Helmet", 20, ArmourType.Helmet, 3),
            new Armour(5, "Dragon Helmet", 50, ArmourType.Helmet, 5)
        };

        private List<Armour> chestplates = new List<Armour>
        {
            new Armour(1, "Leather Chestplate", 10, ArmourType.Chestplate, 1),
            new Armour(3, "Iron Chestplate", 20, ArmourType.Chestplate, 3),
            new Armour(5, "Dragon Chestplate", 50, ArmourType.Chestplate, 5)
        };

        private List<Armour> leggings = new List<Armour>
        {
            new Armour(1, "Leather Leggings", 10, ArmourType.Leggings, 1),
            new Armour(3, "Iron Leggings", 20, ArmourType.Leggings, 3),
            new Armour(5, "Dragon Leggings", 50, ArmourType.Leggings, 5)
        };

        private List<Armour> boots = new List<Armour>
        {
        new Armour(1, "Leather Boots", 10, ArmourType.Boots, 1),
        new Armour(3, "Iron Boots", 20, ArmourType.Boots, 3),
        new Armour(5, "Dragon Boots", 50, ArmourType.Boots, 5)
        };

        public  List<Armour> GetArmours () {
            List<Armour> results = new List<Armour> () ;
            results.AddRange (leggings);
            results.AddRange (boots);
            results.AddRange (helmets);
            results.AddRange(chestplates);
            return results ;
        }
            
     }
           
}


    


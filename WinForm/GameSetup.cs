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

        public WeaponShop WeaponShop { get; set; }

        public GameSetup() 
        { 
            DataFeeder dataFeeder = new DataFeeder();

            ArmourShop = new ArmourShop();
            ArmourShop.AddItems(dataFeeder.GetArmours());
            
            WeaponShop = new WeaponShop();
            WeaponShop.AddItems(dataFeeder.GetWeapons());

        }

     
    }


    internal class DataFeeder
    {
        public DataFeeder() { }
        
        List<Spell> spells = new List<Spell>
        {
            new Spell(1, "Teleportation", 2149, Spells.Teleport),
            new Spell(1, "Gale", 3820, Spells.Gale),
            new Spell(1, "Adulation", 15280, Spells.Adulation),
            new Spell(1, "Command", 15280, Spells.Command),
            new Spell(1, "Ghost Strike", 105289, Spells.GhostStrike),
            new Spell(1, "Weaken Armor", 115555, Spells.WeakenArmor),
            new Spell(1, "Rejuvinate", 188000, Spells.Rejuvinate),
            new Spell(1, "Fireball", 19857, Spells.Fireball),
        };

        List<Effect> effects = new List<Effect>
        {
            new Effect(1, "Freeze", 1000, null, null, Actions.Freeze),
            new Effect(1, "Weakness", 1000, Actions.BeginWeakness, Actions.EndWeakness, null),
            new Effect(1, "Poison", 1000, null, null, Actions.Poison),
        };
        
        private List<Armour> helmets = new List<Armour>
        {
            new Armour(1, "Peasant Helmet", 1200, ArmourType.Helmet, 20),
            new Armour(3, "Cutpurse Helmet", 2700, ArmourType.Helmet, 30),
            new Armour(5, "Brigand Helmet", 4800, ArmourType.Helmet, 40)
        };

        private List<Armour> chestplates = new List<Armour>
        {
            new Armour(1, "Peasant Chestplate", 3072, ArmourType.Chestplate, 32),
            new Armour(3, "Cutpurse Chestplate", 6912, ArmourType.Chestplate, 48),
            new Armour(5, "Brigand Chestplate", 12288, ArmourType.Chestplate, 64)
        };

        private List<Armour> leggings = new List<Armour>
        {
            new Armour(1, "Peasant Leggings", 108, ArmourType.Leggings, 6),
            new Armour(3, "Cutpurse Leggings", 243, ArmourType.Leggings, 9),
            new Armour(5, "Brigand Leggings", 432, ArmourType.Leggings, 12)
        };

        private List<Armour> boots = new List<Armour>
        {
            new Armour(1, "Peasant Boots", 48, ArmourType.Boots, 4),
            new Armour(3, "Cutpurse Boots", 108, ArmourType.Boots, 6),
            new Armour(5, "Brigand Boots", 192, ArmourType.Boots, 8)
        };

        public  List<Armour> GetArmours () {
            List<Armour> results = new List<Armour> () ;
            results.AddRange (leggings);
            results.AddRange (boots);
            results.AddRange (helmets);
            results.AddRange(chestplates);
            return results ;
        }




        public List<Weapon> GetWeapons ()
        {
            List<Weapon> results = new List<Weapon> ();
            results.Add(new Weapon(1, "dsadsa", 3, WeaponType.Sword, 100, 1000));
            return results;
        }
            
     }
           
}


    


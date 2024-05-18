using PzProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinForm
{
    public static class StaticToolClass
    {
        public static List<string> GetItemsAsString <T>(this List<T> sourceList)
        {
            List<string> result = new List<string>();
            foreach (T item in sourceList)
            {
                result.Add(item.ToStringWithProperties());
            }
            return result;
        }

        // used in the shops views
        public static List<string> GetStringListFromInventoryList <T> (this List<T> list) where T : InventoryItem
        {
            List<string> result = new List<string>();   
            foreach (T item in list)
            {
                result.Add($"Nazwa: {item.Name}, Min level: {item.MinLevel} {item.Statistics.ToString()}");
            }

            return result;
        }

        // this is used in the SelectedCharacterDetailsView
        public static string DisplayInformations (this Character character)
        {
            return $"{character.Name} \n {character.Parameters.Level} \n " +
                $"money: {character.Parameters.Money} \n" +
                $"helm: {character.Inventory.ArmourSet.Helmet.ToStringWithProperties()} \n" +
                $"zbroja: {character.Inventory.ArmourSet.Chestplate.ToStringWithProperties()} \n" +
                $"spodnie: {character.Inventory.ArmourSet.Leggings.ToStringWithProperties()} \n" +
                $"buty {character.Inventory.ArmourSet.Boots.ToStringWithProperties()} \n" +
                $"broń: {character.Inventory.Weapon.ToStringWithProperties()} \n" +
                $"czary: {character.Inventory.CharacterSpells}" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $" ";
        }

        // used in the shops views to display character details
        public static string DisplayInformationsInShop (this Character character)
        {
            return $"" +
                $"imie: {character.Name} \n " +
                $"level: {character.Parameters.Level} \n " +
                $"money: {character.Parameters.Money} \n" +    
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $" ";
        }

        public static string SpellDescription (this Spell s)
        {
            return $"{s.Name}, koszt: {s.ValueInGold}";
        }
    }

    
}

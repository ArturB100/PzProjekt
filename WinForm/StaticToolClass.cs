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
        // used in the shops views
        public static List<string> GetStringListFromInventoryList <T> (this List<T> list) where T : InventoryItem
        {
            List<string> result = new List<string>();   
            foreach (T item in list)
            {
                result.Add($"{item}");
            }

            return result;
        }

        // this is used in the SelectedCharacterDetailsView
        public static string DisplayInformations (this Character character)
        {
            String weaponName = "null";
            
            if(character.Inventory.Weapon != null)
            {
                weaponName = character.Inventory.Weapon.Name;
                
                if(character.Inventory.Weapon.Effect != null)
                {
                    weaponName += " effect: " + character.Inventory.Weapon.Effect.Name;
                }
            }
            
            return $"name: {character.Name} \n" +
                   $"lvl: {character.Parameters.Level} \n" + 
                   $"money: {character.Parameters.Money} \n" +
                   $"armour: | {character.Inventory.ArmourSet} \n" +
                   $"weapon: {weaponName} \n" +
                   $"spells: {character.Inventory.SpellsToString()}" +
                   $"statistics: | {character.BaseStatistics}";
        }

        // used in the shops views to display character details
        public static string DisplayInformationsInShop (this Character character)
        {
            return $"name: {character.Name} \n" + 
                   $"lvl: {character.Parameters.Level} \n" + 
                   $"money: {character.Parameters.Money} \n" + 
                   $"lvl: {character.Parameters.Level} \n" + 
                   $"statistics : | {character.BaseStatistics} \n";
        }
    }
}

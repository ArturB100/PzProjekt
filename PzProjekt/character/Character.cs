using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PzProjekt.exceptions;

namespace PzProjekt
{
    public class Character
    {
        public string Name { get; set; }
        public CharacterStatistics BaseStatistics { get; set; }
        public CharacterStatistics ActualStatistics { get; set; }
        public CharacterParameters Parameters { get; set; }
        public CharacterInventory Inventory { get; set; }
        public ActiveEffect? ActiveEffect { get; set; }
        public string? HeadImage { get; set; }
        
        public Character() 
        {
            BaseStatistics = new CharacterStatistics();
            ActualStatistics = BaseStatistics.Clone() as CharacterStatistics;
            
            Parameters = new CharacterParameters(this);
            Inventory = new CharacterInventory();
        }
        
        public Character(string name, CharacterStatistics baseStatistics, int level, Weapon weapon)
        {
            Name = name;
            BaseStatistics = baseStatistics;
            ActualStatistics = BaseStatistics.Clone() as CharacterStatistics;
            
            Parameters = new CharacterParameters(this);
            Inventory = new CharacterInventory();
            Inventory.Weapon = weapon;
        }

        public void Refill()
        {
            Parameters.Refill();
            Inventory.Refill();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
            
            Parameters.PointsToInvest = 10;
            
            Inventory = new CharacterInventory();
        }
        
        public Character(string name, CharacterStatistics baseStatistics, int level, Weapon weapon, ArmourSet armourSet)
        {
            Name = name;
            BaseStatistics = baseStatistics;
            ActualStatistics = BaseStatistics.Clone() as CharacterStatistics;
            
            Parameters = new CharacterParameters(this, level);
            Inventory = new CharacterInventory(weapon, armourSet);
        }
        
        public Character(string name, CharacterStatistics baseStatistics, int level, Weapon weapon, ArmourSet armourSet, List<Spell> spells)
        {
            Name = name;
            BaseStatistics = baseStatistics;
            ActualStatistics = BaseStatistics.Clone() as CharacterStatistics;
            
            Parameters = new CharacterParameters(this, level);
            Inventory = new CharacterInventory(weapon, armourSet);
            
            foreach (var spell in spells)
            {
                Inventory.AddSpell(spell);
            }
        }

        public void Refill()
        {
            Parameters.Refill();
            Inventory.Refill();
        }
    }
}

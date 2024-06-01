using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using PzProjekt.exceptions;

namespace PzProjekt
{
    public class Character : ICloneable
    {
        private const int BasePointsToInvest = 10;
        public string Name { get; set; }

        private CharacterStatistics _baseStatistics;
        
        public CharacterStatistics BaseStatistics
        {
            get => _baseStatistics;
            set
            {
                _baseStatistics = value;
            }
        }

        public CharacterParameters Parameters { get; set; }
        public CharacterInventory Inventory { get; set; }
        public ActiveEffect? ActiveEffect { get; set; }
        public string? HeadImage { get; set; }

        public Character()
        {
            BaseStatistics = new CharacterStatistics();

            Parameters = new CharacterParameters(this);

            Parameters.PointsToInvest = BasePointsToInvest;

            Inventory = new CharacterInventory(this);
        }

        public Character(string name, CharacterStatistics baseStatistics, int level, Weapon weapon, ArmourSet armourSet)
        {
            Name = name;
            BaseStatistics = baseStatistics;

            Parameters = new CharacterParameters(this, level);
            Inventory = new CharacterInventory(this, weapon, armourSet);
        }

        public Character(string name, CharacterStatistics baseStatistics, int level, Weapon weapon, ArmourSet armourSet,
            List<Spell> spells)
        {
            Name = name;
            BaseStatistics = baseStatistics;
            
            Parameters = new CharacterParameters(this, level);
            Inventory = new CharacterInventory(this, weapon, armourSet);
            Inventory.CharacterSpells = spells;
            Inventory.AvailableSpells = new List<Spell>(spells);
        }

        public void Refill()
        {
            Parameters.Refill();
            Inventory.Refill();
        }

        public void InvestPoint(int dictionaryIndex)
        {
            if (Parameters.PointsToInvest < 1)
            {
                throw new NoPointsToInvestException();
            }

            BaseStatistics.StatisticsDictionary[dictionaryIndex]++;
            Parameters.PointsToInvest -= 1;
        }

        public object Clone()
        {
            return new Character(Name, BaseStatistics, Parameters.Level, Inventory.Weapon.Clone() as Weapon,
                Inventory.ArmourSet.Clone() as ArmourSet, Inventory.CharacterSpells);
        }
    }
}

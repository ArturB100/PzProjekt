using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int ActualHP { get; set; }
        public Statistics CharacterStatistics { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int PointToInvest { get; set; }
        public Weapon EquipedWeapon { get; set; }
        public ArmourSet EquipedArmourSet { get; set; }
        public Inventory CharacterInventory { get; set; }
        public int CharacterMoney { get; set; }
        
        private int _minimalDamage;
        
        public int MinimalDamage
        {
            get => _minimalDamage;
            set
            {
                _minimalDamage = CharacterStatistics.Strength * 10;
            }
            
        } 
        
        private int _maximalDamage;

        public int MaximalDamage
        {
            get => _maximalDamage; 
            set
            {
                _maximalDamage = CharacterStatistics.Strength * 20;
            }
        }
        
        public Character(string name, Statistics characterStatistics, int level)
        {
            Name = name;
            CharacterStatistics = characterStatistics;
            Level = level;
            MaxHP = calculateMaxHP();
            ActualHP = MaxHP;
            _maximalDamage = CharacterStatistics.Strength * 20;
            _minimalDamage = CharacterStatistics.Strength * 10;
            CharacterMoney = 200;
        }
        
        private int calculateMaxHP()
        {
            return 100 + Level * 20 + CharacterStatistics.Agility * 20;
        }
        
        public void takeDamage(int damage)
        {
            ActualHP -= damage;
        }
        
        public int drawDamage()
        {
            return new Random().Next(MinimalDamage, MaximalDamage);
        }
    }
}

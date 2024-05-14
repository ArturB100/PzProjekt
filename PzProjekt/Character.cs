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
        public int MaxHP { get; set; }
        private int _actualHP;

        public int ActualHP
        {
            get => _actualHP;
            set
            {
                if (value < 0)
                {
                    _actualHP = 0;
                }
                else
                {
                    _actualHP = value;
                }
            }
        }
        public int MaxStamina { get; }
        private int _actualStamina;

        public int ActualStamina
        {
            get => _actualStamina;
            set
            {
                if (value < 0)
                {
                    _actualStamina = 0;
                }
                else if (value > MaxStamina)
                {
                    _actualStamina = MaxStamina;
                }
                else
                {
                    _actualStamina = value;
                }
            }
        }
        
        public Statistics CharacterStatistics { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int PointToInvest { get; set; }
        public Weapon EquipedWeapon { get; set; }
        public ArmourSet EquipedArmourSet { get; set; }
        public Inventory CharacterInventory { get; set; }

        public int PossibleDistance { get { return 50 + CharacterStatistics.Agility * 10; } }

        private int _charcterMoney;
        
        public int CharacterMoney
        {
            get => _charcterMoney;
            set
            {
                if (value < 0)
                {
                    throw new NoEnoughMoneyException();
                }

                _charcterMoney = value;
            }
        }
        
        public string? HeadImage { get; set; }

        public int MinimalDamage
        {
            get => CharacterStatistics.Strength * 10;
        } 
        
        public int MaximalDamage
        {
            get => CharacterStatistics.Strength * 20;
        }

        public int AttackRange
        {
            get => Level + CharacterStatistics.Agility;
        }

        private int _position;

        public int Position
        {
            get => _position;
            set
            {
                if (value < 0)
                {
                    _position = 0;
                }
                else if (value > 1000)
                {
                    _position = 1000;
                }
                else
                {
                    _position = value;
                }
            }
        }
        
        public List<ActiveEffect> ActiveEffects { get; set; }
        
        public bool HasArmor
        {
            get => EquipedArmourSet.ActualArmorPoints > 0;
        }
        
        public bool IsAlive 
        {
            get => ActualHP > 0;
        }
        
        public Character() 
        {
            CharacterStatistics = new Statistics();
            Level = 1;
            MaxHP = calculateMaxHP();
            ActualHP = MaxHP;
            CharacterMoney = 200;
            PointToInvest = 10;
        }
        
        public Character(string name, Statistics characterStatistics, int level)
        {
            Name = name;
            CharacterStatistics = characterStatistics;
            Level = level;
            MaxHP = calculateMaxHP();
            MaxStamina = calculateMaxStamina();
            Refill();
            CharacterMoney = 200;
        }
        
        private int calculateMaxHP()
        {
            return 100 + Level * 20 + CharacterStatistics.Vitality * 20;
        }

        private int calculateMaxStamina()
        {
            return 100 + Level * 20 + CharacterStatistics.Stamina * 20;
        }
        
        public void takeDamage(int damage)
        {
            if (EquipedArmourSet.ActualArmorPoints == 0)
            {
                ActualHP -= damage;
            }
            else
            {
                EquipedArmourSet.ActualArmorPoints -= damage;
            }
        }
        
        public int drawDamage()
        {
            return new Random().Next(EquipedWeapon.MinimalDamage + MinimalDamage, EquipedWeapon.MaximalDamage + MaximalDamage);
        }

        public void Refill()
        {
            ActualHP = MaxHP;
            ActualStamina = MaxStamina;
            EquipedArmourSet.ActualArmorPoints = EquipedArmourSet.MaxArmorPoints;
        }

        public void MoveLeft()
        {
            ActualStamina -= 20;
            Position -= PossibleDistance;
        }
        
        public void MoveRight()
        {
            ActualStamina -= 20;
            Position += PossibleDistance;
        }

        public void Sleep()
        {
            ActualStamina += Convert.ToInt32(MaxStamina * 0.2);
        }
    }
}

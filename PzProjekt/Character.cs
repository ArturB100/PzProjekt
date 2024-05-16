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
        public Effect Effect { get; set; }

        public string Name { get; set; }
        public int MaxHP { get; set; }

        private int _actualHP;


        public Character()
        {
            CharacterStatistics = new Statistics();
            EquipedArmourSet = new ArmourSet();
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
            EquipedArmourSet = new ArmourSet();
            Level = level;
            MaxHP = calculateMaxHP();
            MaxStamina = calculateMaxStamina();
            Refill();
            CharacterMoney = 200;
        }



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

        public int PossibleDistance { get { return 40 + 8 * CharacterStatistics.Agility; } }

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
            get => 50 + 10 * CharacterStatistics.Agility;
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
        
        public bool HasArmor
        {
            get => EquipedArmourSet?.ActualArmorPoints > 0;
        }
        
        public bool IsAlive 
        {
            get => ActualHP > 0;
        }

        public List<Spell> CharacterSpells { get; }
        public List<Spell> AvailableSpells { get; set; }

        public void AddSpell(Spell spell)
        {
            CharacterSpells.Add(spell);
            AvailableSpells.Add(spell);
        }
        
       
        
        public Character(string name, Statistics characterStatistics, int level, Weapon weapon)
        {
            Name = name;
            CharacterStatistics = characterStatistics;
            Level = level;
            MaxHP = calculateMaxHP();
            MaxStamina = calculateMaxStamina();
            CharacterMoney = 200;
            EquipedArmourSet = new ArmourSet();
            CharacterSpells = new List<Spell>();
            AvailableSpells = new List<Spell>();
            EquipedWeapon = weapon;
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
                
                Console.WriteLine(Name + " took " + damage + " damage!");
                Console.WriteLine("Actual " + Name + " HP: " + ActualHP + " / " + MaxHP);
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
            AvailableSpells = new List<Spell>(CharacterSpells);
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

        public void EquipArmour (Armour armour)
        {
            if (EquipedArmourSet == null)
            {
                EquipedArmourSet = new ArmourSet();
            }


            switch (armour.ArmourType)
            {
                case ArmourType.Helmet:
                    EquipedArmourSet.Helmet = armour;
                    break;
                case ArmourType.Chestplate:
                    EquipedArmourSet.Chestplate = armour;
                    break;
                case ArmourType.Leggings:
                    EquipedArmourSet.Leggings = armour;
                    break;
                case ArmourType.Boots:
                    EquipedArmourSet.Boots = armour;
                    break;
            }
        }

        
        public void InitializeAllObjects ()
        {
            if (EquipedArmourSet == null)
            {
                EquipedArmourSet = new ArmourSet();
            }
            
        }

        public string DisplayInfo ()
        {
            

            return $"{Name} \n {Level} \n " +
                $"helm: {EquipedArmourSet.Helmet.ToStringWithProperties()} \n" +
                $"zbroja: {EquipedArmourSet.Chestplate.ToStringWithProperties()} \n" +
                $"spodnie: {EquipedArmourSet.Leggings.ToStringWithProperties()} \n" +
                $"buty {EquipedArmourSet.Boots.ToStringWithProperties()} \n" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $" ";
        }
    }
}

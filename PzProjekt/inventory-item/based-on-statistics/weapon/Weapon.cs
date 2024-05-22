using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    [ToStringProperties]
    public class Weapon : InventoryItemBasedOnStatistics, ICloneable
    {
        public Effect? Effect { get; set; }
        public WeaponType WeaponType { get; set; }

        public Weapon(string name, int valueInGold, CharacterStatistics minimalStatistics, WeaponType weaponType, int minimalDamage, int maximalDamage) : base(name, valueInGold, minimalStatistics)
        {
            WeaponType = weaponType;
            MinimalDamage = minimalDamage;
            MaximalDamage = maximalDamage;
        }

        public int MinimalDamage { get; set; }
        public int MaximalDamage { get; set; }
        public object Clone()
        {
            return new Weapon(Name, ValueInGold, MinimalStatistics, WeaponType, MinimalDamage, MaximalDamage);
        }
        
        public override string ToString()
        {
            if (WeaponType == WeaponType.Sword)
            {
                return base.ToString() + " | Required agility: " + MinimalStatistics.Agility;
            }
            else
            {
                return base.ToString() + " | Required strength: " + MinimalStatistics.Strength;
            }
        }
    }
}

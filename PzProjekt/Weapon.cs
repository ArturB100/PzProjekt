﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Weapon : InventoryItem
    {
        public Effect? Effect { get; set; }
        public WeaponType WeaponType { get; set; }

        public Weapon(int minLevel, string name, int valueInGold, WeaponType weaponType, int minimalDamage, int maximalDamage) : base(minLevel, name, valueInGold)
        {
            WeaponType = weaponType;
            MinimalDamage = minimalDamage;
            MaximalDamage = maximalDamage;
        }

        public int MinimalDamage { get; set; }
        public int MaximalDamage { get; set; }
    }
}
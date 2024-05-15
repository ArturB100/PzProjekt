using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public abstract class Weapon : InventoryItem
    {
        public EffectType EffectType;
        
        protected Weapon(int minimalDamage, int maximalDamage, EffectType effectType)
        {
            MinimalDamage = minimalDamage;
            MaximalDamage = maximalDamage;
            EffectType = effectType;
        }
        
        public int MinimalDamage { get; set; }
        public int MaximalDamage { get; set; }
        public int Range { get; set; }
    }
}

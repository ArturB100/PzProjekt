using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public abstract class Weapon : InventoryItem
    {
        public event Effect Effect;
        
        public int MinimalDamage { get; set; }
        public int MaximalDamage { get; set; }
        
        public void TriggerSpecialAttack(Character enemy, Fight fight)
        {
            enemy.ActiveEffects.Add(new ActiveEffect(enemy,  fight, 3, Effect));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PzProjekt;

public delegate void UseSpell(Fight fight);

namespace PzProjekt
{
    [ToStringProperties]
    public class Spell : InventoryItem
    {
        public Spell(int minLevel, string name, int valueInGold, CharacterStatistics statistics, UseSpell onUse) : base(minLevel, name, valueInGold, statistics)
        {
            OnUse = onUse;
        }

        public Spell(int minLevel, string name, int valueInGold, UseSpell onUse) : base(minLevel, name, valueInGold)
        {
            OnUse = onUse;
        }

        public Spell() { }
        public Spell(int minLevel, string name, int valueInGold) : base(minLevel, name, valueInGold)
        {
        }

        public UseSpell OnUse;
        
        public void Use(Fight fight)
        {
            Console.WriteLine("Using spell: " + Name);
            OnUse?.Invoke(fight);
        }
    }
}

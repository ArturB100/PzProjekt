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
    public class Spell : InventoryItemBasedOnStatistics
    {
        public Spell(string name, int valueInGold, CharacterStatistics minimalStatistics, UseSpell onUse) : base(name, valueInGold, minimalStatistics)
        {
            OnUse = onUse;
        }

        public UseSpell OnUse;
        
        public void Use(Fight fight)
        {
            Console.WriteLine("Using spell: " + Name);
            OnUse?.Invoke(fight);
        }
    }
}

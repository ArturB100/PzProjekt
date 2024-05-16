using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PzProjekt;

public delegate void UseSpell(Fight fight);

namespace PzProjekt
{
    public class Spell : InventoryItem
    {
        public Spell(int minLevel, string name, int valueInGold, UseSpell onUse) : base(minLevel, name, valueInGold)
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

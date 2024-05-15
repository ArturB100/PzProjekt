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
        public event UseSpell OnUse;
        
        public void Use(Fight fight)
        {
            Console.WriteLine("Using spell: " + Name);
            OnUse?.Invoke(fight);
        }
    }
}

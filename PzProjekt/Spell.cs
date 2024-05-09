using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    abstract class Spell : InventoryItem
    {
        public string Description { get; set; }


        public abstract void UseSpell(Character owner, Character enemy);
        

    }
}

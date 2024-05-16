using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    abstract public class InventoryItem
    {
        public int MinLevel { get; set; }
        public string Name { get; set; }
        public int ValueInGold { get; set; }

        protected InventoryItem(int minLevel, string name, int valueInGold)
        {
            MinLevel = minLevel;
            Name = name;
            ValueInGold = valueInGold;
        }
    }
}

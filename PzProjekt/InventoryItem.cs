using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    [ToStringProperties]
    abstract public class InventoryItem
    {
       
        public int MinLevel { get; set; }
        public string Name { get; set; }
        public int ValueInGold { get; set; }

        public CharacterStatistics Statistics { get; set; }

        protected InventoryItem(int minLevel, string name, int valueInGold)
        {
            MinLevel = minLevel;
            Name = name;
            ValueInGold = valueInGold;

            Statistics = new CharacterStatistics();
        }

        protected InventoryItem(int minLevel, string name, int valueInGold, CharacterStatistics statistics)
        {
            MinLevel = minLevel;
            Name = name;
            ValueInGold = valueInGold;
            Statistics = statistics;
        }
    }
}

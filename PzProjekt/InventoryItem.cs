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
        public Statistics requiredStatistics { get; set; }
    }
}

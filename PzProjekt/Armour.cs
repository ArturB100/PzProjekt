using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Armour : InventoryItem
    {
        public ArmourType ArmourType { get; set; }
        public int ArmourPoints { get; set; }

        public Armour(int minLevel, string name, int valueInGold, ArmourType armourType, int armourPoints) : base(minLevel, name, valueInGold)
        {
            ArmourType = armourType;
            ArmourPoints = armourPoints;
        }
    }
}

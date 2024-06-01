using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    [ToStringProperties]
    public class Armour : InventoryItemBasedOnLevel
    {
        public ArmourType ArmourType { get; set; }
        public int ArmourPoints { get; set; }

        public Armour(int minLevel, string name, int valueInGold, ArmourType armourType, int armourPoints) : base(name, valueInGold, minLevel)
        {
            ArmourType = armourType;
            ArmourPoints = armourPoints;
        }
        
        public override string ToString()
        {
            return base.ToString() + " | Required lvl: " + MinLevel + " | Armour points: " + ArmourPoints;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    [ToStringProperties]
    public class Armour : InventoryItem
    {
        public ArmourType ArmourType { get; set; }
        public int ArmourPoints { get; set; }

        public Armour(int minLevel, string name, int valueInGold, ArmourType armourType, int armourPoints)
        {
            MinLevel = minLevel;
            Name = name;
            ValueInGold = valueInGold;
            ArmourType = armourType;
            ArmourPoints = armourPoints;
        }


        public Armour() 
        {
        }

       


    }
}

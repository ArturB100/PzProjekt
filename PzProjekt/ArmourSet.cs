using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class ArmourSet
    {
        public Armour Helmet { get; set; }
        public Armour Chestplate { get; set; }
        public Armour Leggings { get; set; }
        public Armour Boots { get; set; }
        
        public int ActualArmorPoints { get; set; }
        
        private int _maxArmorPoints;
        
        public int MaxArmorPoints { get => _maxArmorPoints;
            set
            {
                armourSet.Sum(armour => armour.ArmourPoints);
            } 
        }
        
        private List<Armour> armourSet = new List<Armour>();
    }
}

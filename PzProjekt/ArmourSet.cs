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
        
        private int _actualArmorPoints;

        public int ActualArmorPoints
        {
            get => _actualArmorPoints;
            set
            {
                _actualArmorPoints = value < 0 ? 0 : value;
            }
        }
        
        public int MaxArmorPoints 
        { 
            get => armourSet.Sum(armour => armour.ArmourPoints);
        }
        
        private List<Armour> armourSet = new List<Armour>();
    }
}

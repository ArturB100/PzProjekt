using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    [ToStringProperties]
    public class ArmourSet
    {
        public Armour Helmet { get; set; }
        public Armour Chestplate { get; set; }
        public Armour Leggings { get; set; }
        public Armour Boots { get; set; }
        
        private int _actualArmorPoints = 0;

        public ArmourSet()
        {
            armourSet.Add(Helmet);
            armourSet.Add(Chestplate);
            armourSet.Add(Leggings);
            armourSet.Add(Boots);
            ActualArmorPoints = MaxArmorPoints;
        }

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
            get => armourSet.Sum(armour => 
            {
                if (armour != null)
                {
                    return armour.ArmourPoints;
                }
                return 0;                   
            });
        }

        
        
        private List<Armour> armourSet = new List<Armour>();
    }
}

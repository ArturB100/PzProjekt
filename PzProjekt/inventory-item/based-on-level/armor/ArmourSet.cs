using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    [ToStringProperties]
    public class ArmourSet : ICloneable
    {
        public Armour? Helmet { get; set; }
        public Armour? Chestplate { get; set; }
        public Armour? Leggings { get; set; }
        public Armour? Boots { get; set; }
        
        private int _actualArmorPoints;

        public ArmourSet(Armour? helmet, Armour? chestplate, Armour? leggings, Armour? boots)
        {
            Helmet = helmet;
            Chestplate = chestplate;
            Leggings = leggings;
            Boots = boots;
            
            armourSet.Add(Helmet);
            armourSet.Add(Chestplate);
            armourSet.Add(Leggings);
            armourSet.Add(Boots);
            ActualArmorPoints = MaxArmorPoints;
        }

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
            get => ArmourList.Sum(armour => 
            {
                if (armour != null)
                {
                    return armour.ArmourPoints;
                }
                return 0;                   
            });
        }

        
        
        private List<Armour> armourSet = new List<Armour>();

        public List<Armour> ArmourList 
        {
            get
            {
                return new List<Armour>() { Helmet, Chestplate, Leggings, Boots};
            }
        }

        public object Clone()
        {
            return new ArmourSet(Helmet, Chestplate, Leggings, Boots);
        }

        public override string ToString()
        {
            String helmetName = Helmet == null ? "null" : Helmet.Name;
            String chestplateName = Chestplate == null ? "null" : Chestplate.Name;
            String leggingsName = Leggings == null ? "null" : Leggings.Name;
            String bootsName = Boots == null ? "null" : Boots.Name;
            
            return $"helmet: {helmetName} | " + 
                   $"chestplate: {chestplateName} | " + 
                   $"leggings: {leggingsName} | " + 
                   $"boots: {bootsName} | ";
        }
    }
}

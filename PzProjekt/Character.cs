using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int ActualHP { get; set; }
        public Statistics CharacterStatistics { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int PointToInvest { get; set; }
        public Weapon EquipedWeapon { get; set; }
        public ArmourSet EquipedArmourSet { get; set; }
        public Inventory CharacterInventory { get; set; }
    }
}

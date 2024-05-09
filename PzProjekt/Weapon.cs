using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public delegate void SpecialAttack(Character enemy);
    abstract public class Weapon : InventoryItem
    {
        public int Damage { get; set; }

        public event SpecialAttack specialAttack;



        public abstract void NormalAttack(Character enemy);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PzProjekt;



namespace PzProjekt
{
    public delegate void UseSpell(Fight fight);


    [ToStringProperties]
    public class Spell : InventoryItemBasedOnStatistics
    {
        public Spell(string name, int valueInGold, CharacterStatistics minimalStatistics, UseSpell onUse) : base(name, valueInGold, minimalStatistics)
        {
            if (onUse == null)
            {
                OnUse = (fight) => { };
            } 
            else
            {
                OnUse = onUse;
                OnUseDelegate = onUse.Method.Name;
            }
            
        }


        [JsonIgnore]
        public UseSpell OnUse;

        public string OnUseDelegate { get; set; }

        public void Use(Fight fight)
        {
            Console.WriteLine("Using spell: " + Name);
            OnUse?.Invoke(fight);
        }
        
        public override string ToString()
        {
            return base.ToString() + " | Required magica: " + MinimalStatistics.Magica;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PzProjekt.exceptions;

namespace PzProjekt
{
    [ToStringProperties]
    abstract public class InventoryItem
    {
        public string Name { get; set; }
        public int ValueInGold { get; set; }
        
        protected InventoryItem(string name, int valueInGold)
        {
            Name = name;
            ValueInGold = valueInGold;
        }
        
        public virtual bool CanBeBoughtByPlayer(Character character)
        {
            Debug.WriteLine(Name);
            if (character.Parameters.Money < ValueInGold)
            {
                throw new NoEnoughMoneyException();
            }

            return character.Parameters.Money >= ValueInGold;
        }

        public override string ToString()
        {
            return Name + " | Cost: " + ValueInGold;
        }
    }
}

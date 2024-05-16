using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Inventory
    {
        public List<InventoryItem>  InventoryItems { get; set; } = new List<InventoryItem>();



        public void AddItem (InventoryItem inventoryItem)
        {
            InventoryItems.Add(inventoryItem);
        }

        public string DisplayInfo ()
        {
            string allItemsInInventory = InventoryItems.Aggregate(new StringBuilder(), (result, item) => result.Append(item.ToString() + "\n")).ToString();
            return allItemsInInventory;
        }
       

    }
}

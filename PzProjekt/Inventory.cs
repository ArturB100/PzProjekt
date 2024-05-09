using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Inventory
    {
        public List<InventoryItem> inventoryItems;

        public List<InventoryItem> InventoryItems2
        {
            get { return inventoryItems; }
        }

        public InventoryItem this[int index]
        {
            get { return inventoryItems[index]; }
            set { inventoryItems[index] = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    class Inventory
    {
        List<IInventoryItem> gear;
        List<IInventoryItem> potions;
        List<IInventoryItem> sortedInventory;

        public Inventory()
        {
            this.gear = new List<IInventoryItem>();
            this.potions = new List<IInventoryItem>();
            this.sortedInventory = new List<IInventoryItem>();
        }

        public void addPotion(IPotion potion)
        {
            this.potions.Add(potion);
            this.sortedInventory.Add(potion);
        }

        public void addGear(IGear gear)
        {
            this.gear.Add(gear);
            this.sortedInventory.Add(gear);
        }

        public List<IInventoryItem> getOrderedAll(Comparer<IInventoryItem> comparer)
        {
            this.sortedInventory.Sort(comparer);
            return this.sortedInventory;
        }

        public List<IInventoryItem> getGear()
        {
            return this.gear;
        }

        public List<IInventoryItem> getPotions()
        {
            return this.potions;
        }
    }
}

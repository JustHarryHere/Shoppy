using System;
using System.Collections.Generic;

namespace Shoppy
{
    public class Basket
    {
        private List<Item> items;

        public Basket()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
         
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public List<Item> GetItems()
        {
            return new List<Item>(items);
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.price * item.ammount;
            }
            return total;
        }
    }
}
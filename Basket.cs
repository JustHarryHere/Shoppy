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

        public void ClearBasket()
        {
            foreach (var item in items)
            {
                item.quantity -= item.inbasket;
                JsonManager.UpdateItemInJson((SetItem)item);
                item.inbasket = 0;
            }
            items.Clear();
        }

        public void AddItem(Item item, int amount)
        {
            if (amount <= 0)
            {
                MessageBox.Show("Umm, there's nothing to add...");
                return;
            }
            if (amount + item.inbasket > item.quantity)
            {
                MessageBox.Show($"Asking for a bit too much there, buddy.");
                return;
            }
            else if (items.Contains(item))
            {
                item.inbasket += amount;
                MessageBox.Show($"Added {amount} {item.name} to basket. there're now {item.inbasket} {item.name} in basket.");
                return;
            }
            else
            {
                items.Add(item);
                item.inbasket += amount;
                MessageBox.Show($"Added {amount} {item.name} to basket. there's now {item.inbasket} {item.name} in basket.");
                return;
            }
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
            item.inbasket = 0;
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
                total += item.price * item.inbasket;
            }
            return total;
        }
    }
}
using System;

namespace Shopy
{
    public class Item
    {
        protected string name;
        protected double price;
        protected int quantity;
        protected string category;
        protected string description;
        protected string imagePath;
        protected int id;
        public Item(string name, double price, int quantity, string category, string description, string imagePath, int id)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.description = description;
            this.imagePath = imagePath;
            this.id = id;
        }

        public void ItemSettupName(string Input)
        {
            this.name = Input;
        }
        public void ItemSettupPrice(double Input)
        {
            this.price = Input;
        }
        public void ItemSettupQuantity(int Input)
        {
            this.quantity = Input;
        }
        public void BuyItem(int amount)
        {
            if (amount <= this.quantity)
            {
                this.quantity -= amount;
                PurchasedItems.AddPurchasedItem(this);
            }
            else
            {
                throw new Exception("Not enough items in stock.");
            }
        }
    }

    public class SetItem : Item
    {
        public SetItem(string name, double price, int quantity, string category, string description, string imagePath, int id)
            : base(name, price, quantity, category, description, imagePath, id)
        {
        }
        public void DisplayItemInfo()
        {

        }
    }

    public class SubmittedItem : Item
    {
        public SubmittedItem(string name, double price, int quantity, string category, string description, string imagePath, int id)
        : base(name, price, quantity, category, description, imagePath, id)
        {
        }
        public void SubmitItem()
        {

        }
    }

    public class AvailableItems : List<Item>
    {
        public void AddItem(Item item)
        {
            this.Add(item);
        }
    }

    public class PurchasedItems : List<Item>
    {
        public void AddPurchasedItem(Item item)
        {
            this.Add(item);
        }
    }
}


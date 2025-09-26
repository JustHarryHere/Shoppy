using System;
using System.Collections.Generic;

namespace Shoppy
{
    public abstract class Item
    {
        public string name;
        public double price;
        public int quantity;
        public string category;
        public string description;
        public string imagePath;
        public int id;
        public int ammount;
        public Item(string name, double price, int quantity, string category, string description, string imagePath, int id)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.description = description;
            this.imagePath = imagePath;
            this.id = id;
            this.ammount = 0;
        }

        public abstract void SeeItem();
    }

    public class SetItem : Item
    {
        public SetItem(string name, double price, int quantity, string category, string description, string imagePath, int id)
            : base(name, price, quantity, category, description, imagePath, id)
        {
        }
        public override void SeeItem()
        {
            // code to display item details
        }
        public void DisplayItemInfo()
        {
            
        }
    }

    public class SubmittedItem : Item
    {
        public SubmittedItem(string name, double price, int quantity, string category, string description, string imagePath, int id)
        : base(name, price, quantity, category, description, imagePath, id) { }
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
        public void ItemSettupCategory(string Input)
        {
            this.category = Input;
        }
        public void ItemSettupDescription(string Input)
        {
            this.description = Input;
        }
        public void ItemSettupImagePath(string Input)
        {
            this.imagePath = Input;
        }
        public void ItemSettup(int Input)
        {

        }
        public void SubmitItem()
        {
            if (this.name != null && this.price > 0 && this.quantity > 0)
            {
                // add the item to the available items list
            }
            else
            {
                throw new Exception("Item must have a name, price greater than 0, and quantity greater than 0.");
            }
        }
        public override void SeeItem()
        {
            // code to display item details
        }
    }
    public class AvailableItems : List<Item>
    {
        public void AddItem(Item item)
        {
            this.Add(item);
        }
    }

    public class UnavailableItems : List<Item>
    {
        public void unavailableItem(Item item)
        {
            this.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.Remove(item);
        }
    }

}
   



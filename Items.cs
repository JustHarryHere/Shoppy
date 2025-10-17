using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Shoppy
{


    public abstract class Item
    {
        public string name { get; set;}
        public double price { get; set; }
        public int quantity { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
        public int id {  get; set; }
        public int inbasket = 0;
        public abstract void EditItem();
    }

    public class SetItem : Item
    {
        public int id=0;
        public SetItem(string name, double price, int quantity, string category, string description, string imagePath)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.description = description;
            this.imagePath = imagePath;
        }
        public override void EditItem()
        {
            Form Editor = new LoginForm();


        }
        public void DisplayItemInfo()
        {
            
        }
    }

    public class UnavailableItems : List<Item>
    {
        public void AddItem(Item item)
        {
            this.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.Remove(item);
        }
    }
}   



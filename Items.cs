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

    public static class JsonManager
    {
        public static void SaveItemsToJson(string filePath, List<SetItem> items)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(items, options);
            File.WriteAllText(filePath, json);
        }
        public static List<SetItem> OpenItemsFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<SetItem>();

            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            var itemsElement = doc.RootElement.GetProperty("AvailableItems");
            return JsonSerializer.Deserialize<List<SetItem>>(itemsElement.GetRawText()) ?? new List<SetItem>();
        }

        public static void AddItemtoJson(string filePath, SetItem newItem)
        {
            var items = OpenItemsFromJson(filePath);
            items.Add(newItem);
            SaveItemsToJson(filePath, items);
        }

        public static void RemoveItemFromJson(string filePath, SetItem itemToRemove)
        {
            var items = OpenItemsFromJson(filePath);
            items.RemoveAll(i => i.id == itemToRemove.id);
            SaveItemsToJson(filePath, items);
        }

        public static void SaveUsersToJson(string filePath, List<User> users)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(filePath, json);
        }

        public static List<User> OpenUsersFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<User>();
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
    }
}   



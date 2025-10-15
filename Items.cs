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
        public abstract void SeeItem();
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
        public SubmittedItem() { }

        public void ItemSettup(string name,double price,int quantity ,string descryption)
        {
            this.name = name;
            this.id+=1;
            this.price = price;
            this.quantity = quantity;
            this.description= descryption;

        }
        public void SubmitItem()
        {
            if (this.name != null && this.price > 0 && this.quantity > 0)
            {
                // add the item to the available items list
                SetItem USI = new SetItem(this.name, this.price, this.quantity, this.category, this.description, this.imagePath);
            }
            else
            {
                MessageBox.Show("Please make sure all fields are entered to submit item");
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
            if (item.quantity > 0)
            {
                this.Add(item);
            }
        }

        public List<Item> CategoryFilter(string category)
        {
            AvailableItems Itemsofcategory = new AvailableItems();
            foreach (var item in this)
            {
                if (item.category == category)
                {
                    Itemsofcategory.Add(item);
                }
            }
            return Itemsofcategory;
        }

        public void ConvertlisttoAvailableItems(List<SetItem> items)
        {
            this.Clear();
            foreach (var item in items)
            {
                if (item.quantity > 0)
                {
                    this.Add(item);
                }
            }
        }

        public void ConvertAvIttoList(List<Item> items)
        {
            this.Clear();
            foreach (var item in items)
            {
                if (item.quantity > 0)
                {
                    this.Add(item);
                }
            }
        }

        public List<Item> SearchItems(string keyword)
        {
            AvailableItems SearchResults = new AvailableItems();
            foreach (var item in this)
            {
                if (item.name.Contains(keyword,StringComparison.OrdinalIgnoreCase) ||item.description.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||item.category.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    SearchResults.Add(item);
                }
            }
            return SearchResults;
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
    }
}   



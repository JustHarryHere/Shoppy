using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy
{
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
                if (item.name.Contains(keyword, StringComparison.OrdinalIgnoreCase) || item.description.Contains(keyword, StringComparison.OrdinalIgnoreCase) || item.category.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    SearchResults.Add(item);
                }
            }
            return SearchResults;
        }

        public List<string> GetCategories()
        {
            HashSet<string> categories = new HashSet<string>();
            foreach (var item in this)
            {
                categories.Add(item.category);
            }
            return categories.ToList();
        }

        public List<Item> IdFilter(int id)
        {
            AvailableItems items = new AvailableItems();
            foreach (var item in this)
            {
                if (item.id == id)
                {
                    items.Add(item);
                }
            }
            return items;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Shoppy
{
    public static class JsonManager
    {
        public static void SaveItemsToJson( List<SetItem> items)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var wrapper = new { AvailableItems = items };
            var json = JsonSerializer.Serialize(wrapper, options);
            File.WriteAllText("data\\items.json", json);
        }
        public static List<SetItem> OpenItemsFromJson()
        {
            if (!File.Exists("data\\items.json"))
                return new List<SetItem>();

            var json = File.ReadAllText("data\\items.json");
            using var doc = JsonDocument.Parse(json);
            var itemsElement = doc.RootElement.GetProperty("AvailableItems");
            return JsonSerializer.Deserialize<List<SetItem>>(itemsElement.GetRawText()) ?? new List<SetItem>();
        }

        public static void AddItemtoJson( SetItem newItem)
        {
            var items = OpenItemsFromJson();
            items.Add(newItem);
            SaveItemsToJson( items);
        }

        public static void RemoveItemFromJson(SetItem itemToRemove)
        {
            var items = OpenItemsFromJson();
            items.RemoveAll(i => i.name == itemToRemove.name);
            SaveItemsToJson(items);
        }

        public static void UpdateItemInJson(SetItem updatedItem)
        {
            var items = OpenItemsFromJson();
            var index = items.FindIndex(i => i.name == updatedItem.name);
            if (index != -1)
            {
                items[index] = updatedItem;
                SaveItemsToJson(items);
            }
        }

        public static List<User> OpenNormalUsersFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<User>();

            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            JsonElement arrayElement;

            if (root.ValueKind == JsonValueKind.Object && root.TryGetProperty("Users", out var usersProp))
                arrayElement = usersProp;
            else if (root.ValueKind == JsonValueKind.Array)
                arrayElement = root;
            else
                return new List<User>();

            return JsonSerializer.Deserialize<List<User>>(arrayElement.GetRawText()) ?? new List<User>();
        }
        public static List<Admin> OpenAdminsFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<Admin>();

            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            JsonElement arrayElement;

            if (root.ValueKind == JsonValueKind.Object && root.TryGetProperty("Admins", out var adminsProp))
                arrayElement = adminsProp;
            else if (root.ValueKind == JsonValueKind.Array)
                arrayElement = root;
            else
                return new List<Admin>();

            return JsonSerializer.Deserialize<List<Admin>>(arrayElement.GetRawText()) ?? new List<Admin>();
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

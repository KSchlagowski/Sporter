using System.Collections.Generic;
using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Application.Interfaces
{
    public interface IItemService
    {
        string GetJsonTEST();
        Item GetItemById(int itemId);
        Item GetItemByBuyerId(int buyerId);
        List<Item> GetAllItems();
        List<Item> GetAllItems(int pageSize, int pageNo, string searchString);
        string GetAllItemsInJson();
        string GetAllItemsInJson(int pageSize, int pageNo, string searchString);
        IQueryable<Item> GetItemsByCategory(string category);
        IQueryable<Item> GetItemsByCoutry(string country);
        IQueryable<Item> GetItemsByCity(string city);
        IQueryable<Item> GetItemsBelowPrice(decimal maxPrice);
        IQueryable<Item> GetItemsAbovePrice(decimal minPrice);
        int AddItem(Item item);
        int AddItemInJson(string itemJson);
        int UpdateItem(Item item);
        void DeleteItem(int itemId);
        void DeleteItemAbsolute(int itemId);
    }
}
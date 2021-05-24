using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Application.Interfaces
{
    public interface IItemService
    {
        string GetJsonTEST();
        Item GetItemById(int itemId);
        Item GetItemByBuyerId(int buyerId);
        IQueryable<Item> GetAllActiveItems();
        IQueryable<Item> GetItemsByCategory(string category);
        IQueryable<Item> GetItemsByCoutry(string country);
        IQueryable<Item> GetItemsByCity(string city);
        IQueryable<Item> GetItemsBelowPrice(decimal maxPrice);
        IQueryable<Item> GetItemsAbovePrice(decimal minPrice);
        int AddItem(string itemJson);
        int UpdateItem(Item item);
        int DeleteItem(int itemId);
    }
}
using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Domain.Interfaces
{
    public interface IItemRepository
    {
        Item GetItemById(int itemId);
        Item GetItemByBuyerId(int buyerId);
        IQueryable<Item> GetAllActiveItems();
        IQueryable<Item> GetItemsByCategory(string category);
        IQueryable<Item> GetItemsByCoutry(string country);
        IQueryable<Item> GetItemsByCity(string city);
        IQueryable<Item> GetItemsBelowPrice(decimal maxPrice);
        IQueryable<Item> GetItemsAbovePrice(decimal minPrice);
        int AddItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int itemId);
        void DeleteItemAbsolute(int itemId);
    }
}
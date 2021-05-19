using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Domain.Interfaces
{
    public interface IItemRepository
    {
        ItemModel GetItemById(int itemId);
        ItemModel GetItemByBuyerId(int buyerId);
        IQueryable<ItemModel> GetAllActiveItems();
        IQueryable<ItemModel> GetItemsByCategory(string category);
        IQueryable<ItemModel> GetItemsByCoutry(string country);
        IQueryable<ItemModel> GetItemsByCity(string city);
        IQueryable<ItemModel> GetItemsBelowPrice(decimal maxPrice);
        IQueryable<ItemModel> GetItemsAbovePrice(decimal minPrice);
    }
}
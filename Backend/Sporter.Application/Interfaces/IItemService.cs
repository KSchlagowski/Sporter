using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Application.Interfaces
{
    public interface IItemService
    {
        string GetJsonTEST();
        ItemModel GetItemById(int itemId);
        ItemModel GetItemByBuyerId(int buyerId);
        IQueryable<ItemModel> GetAllActiveItems();
        IQueryable<ItemModel> GetItemsByCategory(string category);
        IQueryable<ItemModel> GetItemsByCoutry(string country);
        IQueryable<ItemModel> GetItemsByCity(string city);
        IQueryable<ItemModel> GetItemsBelowPrice(decimal maxPrice);
        IQueryable<ItemModel> GetItemsAbovePrice(decimal minPrice);
        int AddItem(string itemJson);
        int UpdateItem(ItemModel item);
        int DeleteItem(int itemId);
    }
}
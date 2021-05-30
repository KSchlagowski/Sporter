using System.Collections.Generic;
using System.Linq;
using Sporter.Application.ViewModels.Item;
using Sporter.Domain.Models;

namespace Sporter.Application.Interfaces
{
    public interface IItemService
    {
        ItemForListVm GetItemById(int itemId);
        ItemForListVm GetItemByBuyerId(int buyerId);
        ListItemForListVm GetAllItems();
        ListItemForListVm GetAllItems(int pageSize, int pageNo, string searchString);
        ListItemForListVm GetItemsByCategory(string category);
        ListItemForListVm GetItemsByCountry(string country);
        ListItemForListVm GetItemsByCity(string city);
        ListItemForListVm GetItemsBelowPrice(decimal maxPrice);
        ListItemForListVm GetItemsAbovePrice(decimal minPrice);
        int AddItem(NewItemVm item);
        void UpdateItem(NewItemVm item);
        void DeleteItem(int itemId);
        void DeleteItemAbsolute(int itemId);
    }
}
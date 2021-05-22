using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Sporter.Application.Interfaces;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepo;
        private readonly IJsonService _jsonService;

        public ItemService(IItemRepository itemRepo, IJsonService jsonService)
        {
            _itemRepo = itemRepo;
            _jsonService = jsonService;
        }

        public int AddItem(string itemJson)
        {
            var item = _jsonService.DeserializeFromJson<ItemModel>(itemJson);
            return _itemRepo.AddItem(item);
        }

        public int DeleteItem(int itemId)
        {
            return _itemRepo.DeleteItem(itemId);
        }

        public IQueryable<ItemModel> GetAllActiveItems()
        {
            return _itemRepo.GetAllActiveItems();
        }

        public ItemModel GetItemByBuyerId(int buyerId)
        {
            return _itemRepo.GetItemByBuyerId(buyerId);
        }

        public ItemModel GetItemById(int itemId)
        {
            return _itemRepo.GetItemById(itemId);
        }

        public IQueryable<ItemModel> GetItemsAbovePrice(decimal minPrice)
        {
            return _itemRepo.GetItemsAbovePrice(minPrice);
        }

        public IQueryable<ItemModel> GetItemsBelowPrice(decimal maxPrice)
        {
            return _itemRepo.GetItemsBelowPrice(maxPrice);
        }

        public IQueryable<ItemModel> GetItemsByCategory(string category)
        {
            return _itemRepo.GetItemsByCategory(category);
        }

        public IQueryable<ItemModel> GetItemsByCity(string city)
        {
            return _itemRepo.GetItemsByCity(city);
        }

        public IQueryable<ItemModel> GetItemsByCoutry(string country)
        {
            return _itemRepo.GetItemsByCoutry(country);
        }

        public string GetJsonTEST()
        {
            ItemModel item = new ItemModel()
            {
                Name = "Name",
                Category = "cat",
                Price = 2.0M,
                Country = "Poland",
                City = "Warsaw",
                PublishDate = System.DateTime.Now,
                ExpireDate = System.DateTime.Now,
                BuyerId = 3,
                IsAvailable = true
            };


            return _jsonService.SerializeToJson(item);
        }

        public int UpdateItem(ItemModel item)
        {
            throw new System.NotImplementedException();
        }
    }
}
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
            var item = _jsonService.DeserializeFromJson<Item>(itemJson);
            return _itemRepo.AddItem(item);
        }

        public int DeleteItem(int itemId)
        {
            return _itemRepo.DeleteItem(itemId);
        }

        public IQueryable<Item> GetAllActiveItems()
        {
            return _itemRepo.GetAllActiveItems();
        }

        public Item GetItemByBuyerId(int buyerId)
        {
            return _itemRepo.GetItemByBuyerId(buyerId);
        }

        public Item GetItemById(int itemId)
        {
            return _itemRepo.GetItemById(itemId);
        }

        public IQueryable<Item> GetItemsAbovePrice(decimal minPrice)
        {
            return _itemRepo.GetItemsAbovePrice(minPrice);
        }

        public IQueryable<Item> GetItemsBelowPrice(decimal maxPrice)
        {
            return _itemRepo.GetItemsBelowPrice(maxPrice);
        }

        public IQueryable<Item> GetItemsByCategory(string category)
        {
            return _itemRepo.GetItemsByCategory(category);
        }

        public IQueryable<Item> GetItemsByCity(string city)
        {
            return _itemRepo.GetItemsByCity(city);
        }

        public IQueryable<Item> GetItemsByCoutry(string country)
        {
            return _itemRepo.GetItemsByCoutry(country);
        }

        public string GetJsonTEST()
        {
            Item item = new Item()
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

        public int UpdateItem(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}
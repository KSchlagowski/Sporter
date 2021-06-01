using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Newtonsoft.Json.Linq;
using Sporter.Application.Interfaces;
using Sporter.Application.ViewModels.Item;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepo;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepo, IMapper mapper)
        {
            _itemRepo = itemRepo;
            _mapper = mapper;
        }

        public int AddItem(NewItemVm item)
        {
            throw new System.NotImplementedException();
        }


        public void DeleteItem(int itemId)
        {
            _itemRepo.DeleteItem(itemId);
        }

        public void DeleteItemAbsolute(int itemId)
        {
            _itemRepo.DeleteItemAbsolute(itemId);
        }

        public void UpdateItem(NewItemVm itemVm)
        {
            var item = _mapper.Map<Item>(itemVm);
            _itemRepo.UpdateItem(item);
        }

        public ListItemForListVm GetAllItems()
        {
            var items = _itemRepo.GetAllAvailableItems().ProjectTo<ItemForListVm>(_mapper.ConfigurationProvider).ToList();
            var itemsList = new ListItemForListVm()
            {
                Items = items,
                Count = items.Count()
            };

            return itemsList;
        }

        public ListItemForListVm GetAllItems(int pageSize, int pageNo, string searchString)
        {
            var items = _itemRepo.GetAllAvailableItems().Where(p => p.Name.StartsWith(searchString))
                .ProjectTo<ItemForListVm>(_mapper.ConfigurationProvider).ToList();
            var itemsToShow = items.Skip(pageSize*(pageNo - 1)).Take(pageSize).ToList();
            var itemsList = new ListItemForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Items = itemsToShow,
                Count = items.Count
            };

            return itemsList;
        }

        public ItemForListVm GetItemByBuyerId(int buyerId)
        {
            var item = _itemRepo.GetItemByBuyerId(buyerId);
            var itemVm = _mapper.Map<ItemForListVm>(item);
            return itemVm;
        }

        public ItemForListVm GetItemById(int itemId)
        {
            var item = _itemRepo.GetItemById(itemId);
            var itemVm = _mapper.Map<ItemForListVm>(item);
            return itemVm;
        }

        public ListItemForListVm GetItemsAbovePrice(decimal minPrice)
        {
            var items = _itemRepo.GetItemsAbovePrice(minPrice);
            var itemsVm = _mapper.Map<ListItemForListVm>(items);
            return itemsVm;
        }

        public ListItemForListVm GetItemsByCategory(string category)
        {
            var items = _itemRepo.GetItemsByCategory(category);
            var itemsVm = _mapper.Map<ListItemForListVm>(items);
            return itemsVm;
        }

        public ListItemForListVm GetItemsByCountry(string country)
        {
            var items = _itemRepo.GetItemsByCountry(country);
            var itemsVm = _mapper.Map<ListItemForListVm>(items);
            return itemsVm;
        }

        public ListItemForListVm GetItemsByCity(string city)
        {
            var items = _itemRepo.GetItemsByCategory(city);
            var itemsVm = _mapper.Map<ListItemForListVm>(items);
            return itemsVm;
        }

        public ListItemForListVm GetItemsBelowPrice(decimal maxPrice)
        {
            var items = _itemRepo.GetItemsBelowPrice(maxPrice);
            var itemsVm = _mapper.Map<ListItemForListVm>(items);
            return itemsVm;
        }
    }
}
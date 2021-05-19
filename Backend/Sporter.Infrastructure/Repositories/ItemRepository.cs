using System.Linq;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        
        public ItemRepository(Context context) =>
            _context = context;

        public IQueryable<ItemModel> GetAllActiveItems() =>
            _context.ItemModels.Where(i => i.IsAvailable);

        public ItemModel GetItemByBuyerId(int buyerId) =>
            _context.ItemModels.FirstOrDefault(i => i.BuyerId == buyerId && i.IsAvailable);

        public ItemModel GetItemById(int itemId) =>
            _context.ItemModels.FirstOrDefault(i => i.Id == itemId && i.IsAvailable);

        public IQueryable<ItemModel> GetItemsAbovePrice(decimal minPrice) =>
            _context.ItemModels.Where(i => i.Price > minPrice && i.IsAvailable);

        public IQueryable<ItemModel> GetItemsBelowPrice(decimal maxPrice) =>
            _context.ItemModels.Where(i => i.Price < maxPrice && i.IsAvailable);

        public IQueryable<ItemModel> GetItemsByCategory(string category) =>
            _context.ItemModels.Where(i => i.Category == category && i.IsAvailable);

        public IQueryable<ItemModel> GetItemsByCity(string city) =>
            _context.ItemModels.Where(i => i.City == city && i.IsAvailable);

        public IQueryable<ItemModel> GetItemsByCoutry(string country) =>
            _context.ItemModels.Where(i => i.Country == country && i.IsAvailable);
    }
}
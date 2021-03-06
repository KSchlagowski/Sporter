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

        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public void DeleteItem(int itemId)
        {
            var result = _context.Items.SingleOrDefault(i => i.Id == itemId && i.IsAvailable);

            if (result != null)
            {
                var item = result;
                item.IsAvailable = false;
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
        }

        public void DeleteItemAbsolute(int itemId)
        {
            var item = _context.Items.Find(itemId);
            _context.Items.Remove(item);
            _context.SaveChanges();
        }

        public IQueryable<Item> GetAllAvailableItems() =>
            _context.Items.Where(i => i.IsAvailable);

        public Item GetItemByBuyerId(int buyerId) =>
            GetAllAvailableItems().FirstOrDefault(i => i.BuyerId == buyerId);

        public Item GetItemById(int itemId) =>
            GetAllAvailableItems().FirstOrDefault(i => i.Id == itemId);

        public IQueryable<Item> GetItemsAbovePrice(decimal minPrice) =>
            GetAllAvailableItems().Where(i => i.Price >= minPrice);

        public IQueryable<Item> GetItemsBelowPrice(decimal maxPrice) =>
            GetAllAvailableItems().Where(i => i.Price <= maxPrice);

        public IQueryable<Item> GetItemsByCategory(string category) =>
            GetAllAvailableItems().Where(i => i.Category == category);

        public IQueryable<Item> GetItemsByCity(string city) =>
            GetAllAvailableItems().Where(i => i.City == city);

        public IQueryable<Item> GetItemsByCountry(string country) =>
            GetAllAvailableItems().Where(i => i.Country == country);

        public void UpdateItem(Item item)
        {
            _context.Attach(item);
            _context.Entry(item).Property("Name").IsModified = true;
            _context.Entry(item).Property("Category").IsModified = true;
            _context.Entry(item).Property("Price").IsModified = true;
            _context.Entry(item).Property("Country").IsModified = true;
            _context.Entry(item).Property("City").IsModified = true;
            _context.Entry(item).Property("ExpireDate").IsModified = true;
            _context.Entry(item).Property("BuyerId").IsModified = true;

            _context.SaveChanges();
        }
    }
}
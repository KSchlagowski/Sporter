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

        public int DeleteItem(int itemId)
        {
            var result = _context.Items.SingleOrDefault(i => i.Id == itemId && i.IsAvailable);

            if (result != null)
            {
                var item = result;
                item.IsAvailable = false;
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();

                return itemId;
            }

            return -1;
        }

        public IQueryable<Item> GetAllActiveItems() =>
            _context.Items.Where(i => i.IsAvailable);

        public Item GetItemByBuyerId(int buyerId) =>
            _context.Items.FirstOrDefault(i => i.BuyerId == buyerId && i.IsAvailable);

        public Item GetItemById(int itemId) =>
            _context.Items.FirstOrDefault(i => i.Id == itemId && i.IsAvailable);

        public IQueryable<Item> GetItemsAbovePrice(decimal minPrice) =>
            _context.Items.Where(i => i.Price > minPrice && i.IsAvailable);

        public IQueryable<Item> GetItemsBelowPrice(decimal maxPrice) =>
            _context.Items.Where(i => i.Price < maxPrice && i.IsAvailable);

        public IQueryable<Item> GetItemsByCategory(string category) =>
            _context.Items.Where(i => i.Category == category && i.IsAvailable);

        public IQueryable<Item> GetItemsByCity(string city) =>
            _context.Items.Where(i => i.City == city && i.IsAvailable);

        public IQueryable<Item> GetItemsByCoutry(string country) =>
            _context.Items.Where(i => i.Country == country && i.IsAvailable);

        public int UpdateItem(Item item)
        {
            var result = _context.Items.SingleOrDefault(i => i.Id == item.Id && i.IsAvailable);

            if (result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();

                return item.Id;
            }

            return -1;
        }
    }
}
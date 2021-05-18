using System;

namespace Sporter.Domain.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int BuyerId { get; set; }

        public virtual AuctionModel Auction { get; set; }
    }
}

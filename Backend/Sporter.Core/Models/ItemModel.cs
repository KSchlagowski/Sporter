using System;

namespace Sporter.Core.Models
{
    public class ItemModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
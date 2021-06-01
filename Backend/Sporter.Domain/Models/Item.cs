using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sporter.Domain.Models
{
    [Serializable]
    public class Item
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
        public bool IsAvailable { get; set; }

        [JsonIgnore]
        public virtual ICollection<ItemTag> ItemTags { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}

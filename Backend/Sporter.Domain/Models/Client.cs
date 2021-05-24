using System.Collections;
using System.Collections.Generic;

namespace Sporter.Domain.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public virtual ClientContactInformation ClientContactInformation { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
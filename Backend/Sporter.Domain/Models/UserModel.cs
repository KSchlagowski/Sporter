using System.Collections.Generic;

namespace Sporter.Domain.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get => $"{Name} {Surname}"; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public ICollection<AuctionModel> Auctions { get; set; }
    }
}
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
       
        public bool IsActive { get; set; }
    }
}
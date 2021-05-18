using System;
using System.ComponentModel.DataAnnotations;

namespace Sporter.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
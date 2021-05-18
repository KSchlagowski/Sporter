namespace Sporter.Domain.Models
{
    public class UserModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get => $"{Name} {Surname}"; }
        public string PhoneNumber { get; set; }
    }
}
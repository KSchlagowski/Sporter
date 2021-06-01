namespace Sporter.Domain.Models
{
    public class ClientContactInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
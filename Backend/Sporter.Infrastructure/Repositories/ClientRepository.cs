using System.Linq;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;

        public ClientRepository(Context context) =>
            _context = context;

        public int AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address.Id;
        }

        public int AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return client.Id;
        }

        public int AddClientContactInforamtion(ClientContactInformation contactInformation)
        {
            _context.ClientContactInformations.Add(contactInformation);
            _context.SaveChanges();
            return contactInformation.Id;
        }

        public void DeleteAddress(int addressId)
        {
            var address = _context.Addresses.Find(addressId);
            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }

        public void DeleteClient(int clientId)
        {
            var result = _context.Clients.SingleOrDefault(i => i.Id == clientId && i.IsActive);

            if (result != null)
            {
                var client = result;
                client.IsActive = false;
                _context.Entry(result).CurrentValues.SetValues(client);
                _context.SaveChanges();
            }
        }

        public void DeleteClientAbsolute(int clientId)
        {
            var client = _context.Clients.Find(clientId);
            
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }

        public void DeleteClientContactInformation(int contactInformationId)
        {
            var contact = _context.ClientContactInformations.Find(contactInformationId);
            _context.ClientContactInformations.Remove(contact);
            _context.SaveChanges();
        }

        public Address GetAddress(int addressId) =>
            _context.Addresses.FirstOrDefault(i => i.Id == addressId);
        
        public IQueryable<Client> GetAllActiveClients() =>
            _context.Clients.Where(i => i.IsActive);

        public Client GetClientById(int clientId) =>
            GetAllActiveClients().FirstOrDefault(i => i.Id == clientId);

        public ClientContactInformation GetClientContactInformation(int contactInformationId) =>
            _context.ClientContactInformations.FirstOrDefault(i => i.Id == contactInformationId);

        public void UpdateAddress(Address address)
        {
            _context.Attach(address);
            _context.Entry(address).Property("Street").IsModified = true;
            _context.Entry(address).Property("BuildingNumber").IsModified = true;
            _context.Entry(address).Property("FlatNumber").IsModified = true;
            _context.Entry(address).Property("ZipCode").IsModified = true;
            _context.Entry(address).Property("City").IsModified = true;
            _context.Entry(address).Property("Country").IsModified = true;

            _context.SaveChanges();
        }

        public void UpdateClient(Client client)
        {
            _context.Attach(client);
            _context.Entry(client).Property("Name").IsModified = true;
            _context.Entry(client).Property("PhoneNumber").IsModified = true;

            _context.SaveChanges();
        }

        public void UpdateClientContactInformation(ClientContactInformation contactInformation)
        {
            _context.Attach(contactInformation);
            _context.Entry(contactInformation).Property("FirstName").IsModified = true;
            _context.Entry(contactInformation).Property("LastName").IsModified = true;
            _context.Entry(contactInformation).Property("Email").IsModified = true;
            
            _context.SaveChanges();
        }
    }
}
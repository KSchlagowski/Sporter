using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Domain.Interfaces
{
    public interface IClientRepository
    {
        Client GetClientById(int clientId);
        IQueryable<Client> GetAllActiveClients();
        ClientContactInformation GetClientContactInformation(int contactInformationId);
        Address GetAddress(int addressId);
        int AddClient(Client client);
        int AddClientContactInforamtion(ClientContactInformation contactInformation);
        int AddAddress(Address address);
        void UpdateClient(Client client);
        void UpdateClientContactInformation(ClientContactInformation contactInformation);
        void UpdateAddress(Address address);
        void DeleteClient(int clientId);
        void DeleteClientAbsolute(int clientId);
        void DeleteClientContactInformation(int contactInformationId);
        void DeleteAddress(int addressId);
    }
}
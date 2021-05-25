using System.Collections.Generic;
using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Application.Interfaces
{
    public interface IClientService
    {
        Client GetClient(int clientId);
        List<Client> GetAllClients();
        List<Client> GetAllClients(int pageSize, int pageNo, string searchString);
        ClientContactInformation GetClientContactInformation(int contactInformationId);
        Address GetAddress(int addressId);
        int AddClient(Client client);
        int AddClientContactInformation(ClientContactInformation contactInformation);
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
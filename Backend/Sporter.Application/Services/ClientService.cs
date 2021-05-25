using System.Collections.Generic;
using System.Linq;
using Sporter.Application.Interfaces;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepo;
        private readonly IJsonService _jsonService;

        public ClientService(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        public int AddAddress(Address address)
        {
            return _clientRepo.AddAddress(address);
        }

        public int AddClient(Client client)
        {
            return _clientRepo.AddClient(client);
        }

        public int AddClientContactInformation(ClientContactInformation contactInformation)
        {
            return _clientRepo.AddClientContactInforamtion(contactInformation);
        }

        public void DeleteAddress(int addressId)
        {
            _clientRepo.DeleteAddress(addressId);
        }

        public void DeleteClient(int clientId)
        {
            _clientRepo.DeleteClient(clientId);
        }

        public void DeleteClientAbsolute(int clientId)
        {
            _clientRepo.DeleteClientAbsolute(clientId);
        }

        public void DeleteClientContactInformation(int contactInformationId)
        {
            _clientRepo.DeleteClientContactInformation(contactInformationId);
        }

        public Address GetAddress(int addressId)
        {
            return _clientRepo.GetAddress(addressId);
        }

        public List<Client> GetAllClients()
        {
            return _clientRepo.GetAllActiveClients().ToList();
        }

        public List<Client> GetAllClients(int pageSize, int pageNo, string searchString)
        {
            var clients = _clientRepo.GetAllActiveClients().Where(p => p.Name.StartsWith(searchString));
            var clientsToShow = clients.Skip(pageSize*(pageNo - 1)).Take(pageSize).ToList();

            return clientsToShow;
        }

        public Client GetClient(int clientId)
        {
            return _clientRepo.GetClientById(clientId);
        }

        public ClientContactInformation GetClientContactInformation(int contactInformationId)
        {
            return _clientRepo.GetClientContactInformation(contactInformationId);
        }

        public void UpdateAddress(Address address)
        {
            _clientRepo.UpdateAddress(address);
        }

        public void UpdateClient(Client client)
        {
            _clientRepo.UpdateClient(client);
        }

        public void UpdateClientContactInformation(ClientContactInformation contactInformation)
        {
            _clientRepo.UpdateClientContactInformation(contactInformation);
        }
    }
}
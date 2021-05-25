using System.Collections.Generic;
using System.Linq;
using Sporter.Application.Interfaces;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Application.Services
{
    public class ClientJsonService : IClientJsonService
    {
        private readonly IClientRepository _clientRepo;
        private readonly IJsonService _jsonService;

        public ClientJsonService(IClientRepository clientRepo, IJsonService jsonService)
        {
            _clientRepo = clientRepo;
            _jsonService = jsonService;
        }

        public int AddAddressInJson(string addressJson)
        {
            var address = _jsonService.DeserializeFromJson<Address>(addressJson);
            return _clientRepo.AddAddress(address);
        }

        public int AddClientContactInforamtionInJson(string contactJson)
        {
            var contact = _jsonService.DeserializeFromJson<ClientContactInformation>(contactJson);
            return _clientRepo.AddClientContactInforamtion(contact);
        }

        public int AddClientInJson(string clientJson)
        {
            var client = _jsonService.DeserializeFromJson<Client>(clientJson);
            return _clientRepo.AddClient(client);
        }

        public string GetAddressInJson(int addressId)
        {
            var address = _clientRepo.GetAddress(addressId);
            var json = _jsonService.SerializeToJson<Address>(address);
            return json;
        }

        public string GetAllClientsInJson()
        {
            var clients = _clientRepo.GetAllActiveClients().ToList();
            var json = _jsonService.SerializeToJson<List<Client>>(clients);
            return json;
        }

        public string GetAllClientsInJson(int pageSize, int pageNo, string searchString)
        {
            var clients = _clientRepo.GetAllActiveClients().Where(p => p.Name.StartsWith(searchString));
            var clientsToShow = clients.Skip(pageSize*(pageNo - 1)).Take(pageSize).ToList();

            var json = _jsonService.SerializeToJson<List<Client>>(clientsToShow);
            return json;
        }

        public string GetClientContactInformationInJson(int contactInformationId)
        {
            var contact = _clientRepo.GetClientContactInformation(contactInformationId);
            var json = _jsonService.SerializeToJson<ClientContactInformation>(contact);
            return json;
        }

        public string GetClientInJson(int clientId)
        {
            var client = _clientRepo.GetClientById(clientId);
            var json = _jsonService.SerializeToJson<Client>(client);
            return json;
        }

        public void UpdateAddressInJson(string addressJson)
        {
            var address = _jsonService.DeserializeFromJson<Address>(addressJson);
            _clientRepo.UpdateAddress(address);
        }

        public void UpdateClientContactInformationInJson(string contactInformationJson)
        {
            var contact = _jsonService.DeserializeFromJson<ClientContactInformation>(contactInformationJson);
            _clientRepo.UpdateClientContactInformation(contact);
        }

        public void UpdateClientInJson(string clientJson)
        {
            var client = _jsonService.DeserializeFromJson<Client>(clientJson);
            _clientRepo.UpdateClient(client);
        }
    }
}
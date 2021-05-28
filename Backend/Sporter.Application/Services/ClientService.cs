using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Sporter.Application.Interfaces;
using Sporter.Application.ViewModels.Client;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepo;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepo, IMapper mapper)
        {
            _clientRepo = clientRepo;
            _mapper = mapper;
        }

        public int AddAddress(NewAddressVm addressVm)
        {
            var address = _mapper.Map<Address>(addressVm);
            var id = _clientRepo.AddAddress(address);
            return id;
        }

        public int AddClient(NewClientVm clientVm)
        {
            var client = _mapper.Map<Client>(clientVm);
            var id = _clientRepo.AddClient(client);
            return id;
        }

        public int AddClientContactInformation(NewClientContactInformationVm contactInformationVm)
        {
            var contact = _mapper.Map<ClientContactInformation>(contactInformationVm);
            var id = _clientRepo.AddClientContactInforamtion(contact);
            return id;
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

        public NewAddressVm GetAddressForEdit(int addressId)
        {
            var address = _clientRepo.GetClientById(addressId);
            var addressVm = _mapper.Map<NewAddressVm>(address);
            return addressVm;
        }

        public ListClientForListVm GetAllClients()
        {
            var clients = _clientRepo.GetAllActiveClients()
                .ProjectTo<ClientForListVm>(_mapper.ConfigurationProvider).ToList();
            
            var clientsList = new ListClientForListVm()
            {
                Clients = clients,
                Count = clients.Count
            };

            return clientsList;
        }

        public ListClientForListVm GetAllClients(int pageSize, int pageNo, string searchString)
        {
            var clients = _clientRepo.GetAllActiveClients().Where(p => p.Name.StartsWith(searchString))
                .ProjectTo<ClientForListVm>(_mapper.ConfigurationProvider).ToList();
            var clientsToShow = clients.Skip(pageSize*(pageNo - 1)).Take(pageSize).ToList();
            var clientsList = new ListClientForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Clients = clientsToShow,
                Count = clients.Count
            };

            return clientsList;
        }

        public NewClientVm GetClient(int clientId)
        {
            var client = _clientRepo.GetClientById(clientId);
            var clientVm = _mapper.Map<NewClientVm>(client);
            return clientVm;
        }

        public NewClientContactInformationVm GetClientContactInformationForEdit(int contactInformationId)
        {
            var contact = _clientRepo.GetClientContactInformation(contactInformationId);
            var contactVm = _mapper.Map<NewClientContactInformationVm>(contact);
            return contactVm;
        }

        public ClientDetailsVm GetClientDetails(int clientId)
        {
            var client = _clientRepo.GetClientById(clientId);
            var clientVm = _mapper.Map<ClientDetailsVm>(client);

            // clientVm.Addresses = new List<AddressForListVm>();

            // foreach(var address in client.Addresses)
            // {
            //     var add = new AddressForListVm()
            //     {
            //         Id = address.Id,
            //         ZipCode = address.ZipCode,
            //         City = address.City,
            //         Country = address.Country
            //     };

            //     clientVm.Addresses.Add(add);
            // }

            clientVm.Addresses = _mapper.Map<List<Address>, List<AddressForListVm>>(client.Addresses.ToList());

            return clientVm;
        }

        public NewClientVm GetClientForEdit(int id)
        {
            var client = _clientRepo.GetClientById(id);
            var clientVm = _mapper.Map<NewClientVm>(client);
            return clientVm;
        }

        public void UpdateAddress(NewAddressVm addressVm)
        {
            var address = _mapper.Map<Address>(addressVm);
            _clientRepo.UpdateAddress(address);
        }

        public void UpdateClient(NewClientVm clientVm)
        {
            var client = _mapper.Map<Client>(clientVm);
            _clientRepo.UpdateClient(client);
        }

        public void UpdateClientContactInformation(NewClientContactInformationVm contactInformationVm)
        {
            var contact = _mapper.Map<ClientContactInformation>(contactInformationVm);
            _clientRepo.UpdateClientContactInformation(contact);
        }
    }
}
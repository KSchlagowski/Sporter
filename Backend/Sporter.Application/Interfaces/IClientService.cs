using System.Collections.Generic;
using System.Linq;
using Sporter.Application.ViewModels.Client;
using Sporter.Domain.Models;

namespace Sporter.Application.Interfaces
{
    public interface IClientService
    {
        NewClientVm GetClient(int clientId);
        ListClientForListVm GetAllClients();
        ListClientForListVm GetAllClients(int pageSize, int pageNo, string searchString);
        ClientDetailsVm GetClientDetails(int clientId);
        NewAddressVm GetAddressForEdit(int addressId);
        NewClientContactInformationVm GetClientContactInformationForEdit(int contactInformationId);
        int AddClient(NewClientVm client);
        int AddClientContactInformation(NewClientContactInformationVm contactInformation);
        int AddAddress(NewAddressVm address);
        void UpdateClient(NewClientVm client);
        void UpdateClientContactInformation(NewClientContactInformationVm contactInformation);
        void UpdateAddress(NewAddressVm address);
        void DeleteClient(int clientId);
        void DeleteClientAbsolute(int clientId);
        void DeleteClientContactInformation(int contactInformationId);
        void DeleteAddress(int addressId);
        NewClientVm GetClientForEdit(int id);
    }
}
namespace Sporter.Application.Interfaces
{
    public interface IClientJsonService
    {
        string GetClientInJson(int clientId);
        string GetAllClientsInJson();
        string GetAllClientsInJson(int pageSize, int pageNo, string searchString);
        string GetClientContactInformationInJson(int contactInformationId);
        string GetAddressInJson(int addressId);
        int AddClientInJson(string clientJson);
        int AddClientContactInforamtionInJson(string contactJson);
        int AddAddressInJson(string addressJson);
        void UpdateClientInJson(string clientJson);
        void UpdateClientContactInformationInJson(string contactInformationJson);
        void UpdateAddressInJson(string addressJson);
    }
}
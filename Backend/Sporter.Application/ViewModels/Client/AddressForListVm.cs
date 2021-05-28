using AutoMapper;
using Sporter.Application.Mapping;

namespace Sporter.Application.ViewModels.Client
{
    public class AddressForListVm : IMapFrom<Sporter.Domain.Models.Address>
    {
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sporter.Domain.Models.Address, AddressForListVm>();
        }
    }
}
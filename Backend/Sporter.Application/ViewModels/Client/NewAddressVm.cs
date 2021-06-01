using AutoMapper;
using Sporter.Application.Mapping;

namespace Sporter.Application.ViewModels.Client
{
    public class NewAddressVm : IMapFrom<Sporter.Domain.Models.Address>
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string FlatNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewAddressVm, Sporter.Domain.Models.Address>();
        }
    }
}
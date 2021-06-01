using System.Collections.Generic;
using AutoMapper;
using Sporter.Application.Mapping;

namespace Sporter.Application.ViewModels.Client
{
    public class ClientDetailsVm : IMapFrom<Sporter.Domain.Models.Client>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<AddressForListVm> Addresses { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sporter.Domain.Models.Client, ClientDetailsVm>()
                .ForMember(s => s.FullName, opt => opt.MapFrom(d => d.ClientContactInformation.FirstName 
                + " " + d.ClientContactInformation.LastName))
                .ForMember(s => s.PhoneNumber, opt => opt.MapFrom(d => d.PhoneNumber))
                .ForMember(s => s.Email, opt => opt.MapFrom(d => d.ClientContactInformation.Email))
                .ForMember(s => s.Addresses, opt => opt.Ignore());
        }
    }
}
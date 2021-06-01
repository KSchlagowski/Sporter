using AutoMapper;
using Sporter.Application.Mapping;

namespace Sporter.Application.ViewModels.Client
{
    public class ClientForListVm : IMapFrom<Sporter.Domain.Models.Client>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sporter.Domain.Models.Client, ClientForListVm>();
        }
    }
}
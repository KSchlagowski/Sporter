using AutoMapper;
using Sporter.Application.Mapping;

namespace Sporter.Application.ViewModels.Client
{
    public class NewClientContactInformationVm : IMapFrom<Sporter.Domain.Models.ClientContactInformation>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewClientContactInformationVm, Sporter.Domain.Models.ClientContactInformation>()
                .ReverseMap();
        }
    }
}
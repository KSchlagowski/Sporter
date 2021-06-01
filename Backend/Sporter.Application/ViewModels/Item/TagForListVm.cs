using AutoMapper;
using Sporter.Application.Mapping;

namespace Sporter.Application.ViewModels.Item
{
    public class TagForListVm : IMapFrom<Sporter.Domain.Models.Tag>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TagForListVm, Sporter.Domain.Models.Tag>()
                .ReverseMap();
        }
    }
}
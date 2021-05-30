using System;
using AutoMapper;
using Sporter.Application.Mapping;

namespace Sporter.Application.ViewModels.Item
{
    public class NewItemVm : IMapFrom<Sporter.Domain.Models.Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public DateTime ExpireDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewItemVm, Sporter.Domain.Models.Item>()
                .ReverseMap();
        }
    }
}
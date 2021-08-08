using AutoMapper;
using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Mapping
{
    public class ClothesMappingProfile : Profile
    {
        public ClothesMappingProfile()
        {
            CreateMap<Shirt, Domain.Shirt>()
                .ForMember(shirtDomain => shirtDomain.Id, o => o.MapFrom(shirtModel => shirtModel.ID)).ReverseMap()
                .ForMember(shirtDomain => shirtDomain.ShirtName, o => o.MapFrom(shirtModel => shirtModel.ShirtName)).ReverseMap();
        }
    }
}
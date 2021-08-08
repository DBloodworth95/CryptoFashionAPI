using AutoMapper;
using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Mapping
{
    public class ShirtMappingProfile : Profile
    {
        public ShirtMappingProfile()
        {
            CreateMap<Shirt, Domain.Shirt>()
                .ForMember(shirtDomain => shirtDomain.Id, o => o.MapFrom(shirtModel => shirtModel.ID))
                .ForMember(shirtDomain => shirtDomain.ShirtName, o => o.MapFrom(shirtModel => shirtModel.ShirtName));
        }
    }
}
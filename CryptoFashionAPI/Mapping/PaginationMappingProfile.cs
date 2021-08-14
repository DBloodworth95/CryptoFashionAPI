using AutoMapper;
using CryptoFashionAPI.Api;
using CryptoFashionAPI.Domain;

namespace CryptoFashionAPI.Mapping
{
    public class PaginationMappingProfile : Profile
    {
        public PaginationMappingProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
        }
    }
}
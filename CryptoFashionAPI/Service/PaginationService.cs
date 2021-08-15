using AutoMapper;
using CryptoFashionAPI.Api;
using CryptoFashionAPI.Domain;

namespace CryptoFashionAPI.Service
{
    public class PaginationService : IPaginationService
    {
        private readonly IMapper _mapper;

        public PaginationService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PaginationFilter GetPaginationFilter(PaginationQuery paginationQuery)
        {
            return _mapper.Map<PaginationFilter>(paginationQuery);
        }
    }
}
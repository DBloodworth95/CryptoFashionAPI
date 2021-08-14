using CryptoFashionAPI.Api;
using CryptoFashionAPI.Domain;

namespace CryptoFashionAPI.Service
{
    public interface IPaginationService
    {
        PaginationFilter ApplyPaginationFilter(PaginationQuery paginationQuery);
    }
}
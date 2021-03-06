using System.Collections.Generic;
using System.Linq;
using CryptoFashionAPI.Api;
using CryptoFashionAPI.Domain;
using CryptoFashionAPI.Service;

namespace CryptoFashionAPI.Helper
{
    public class PaginationHelper
    {
        public static PagedResponse<T> GenerateResponse<T>(IUriService uriService, PaginationFilter paginationFilter,
            List<T> response, int totalRowCount)
        {
            var nextPage = paginationFilter.PageNumber >= 0
                ? uriService.GetAllShirtsUri(new PaginationQuery(paginationFilter.PageNumber + 1,
                    paginationFilter.PageSize)).ToString()
                : null;

            var previousPage = paginationFilter.PageNumber - 1 >= 0
                ? uriService.GetAllShirtsUri(new PaginationQuery(paginationFilter.PageNumber - 1,
                    paginationFilter.PageSize)).ToString()
                : null;

            return new PagedResponse<T>
            {
                Data = response,
                PageNumber = paginationFilter.PageNumber >= 0 ? paginationFilter.PageNumber : null,
                PageSize = paginationFilter.PageSize >= 0 ? paginationFilter.PageSize : null,
                NextPage = response.Any() ? nextPage : null,
                PreviousPage = previousPage,
                TotalRowCount = totalRowCount
            };
        }
    }
}
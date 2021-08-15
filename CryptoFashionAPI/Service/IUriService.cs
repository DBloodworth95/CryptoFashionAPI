using System;
using CryptoFashionAPI.Api;

namespace CryptoFashionAPI.Service
{
    public interface IUriService
    {
        Uri GetShirtUri(string id);

        Uri GetAllShirtsUri(PaginationQuery paginationQuery = null);
    }
}
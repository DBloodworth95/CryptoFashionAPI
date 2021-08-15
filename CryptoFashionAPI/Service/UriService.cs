using System;
using CryptoFashionAPI.Api;
using Microsoft.AspNetCore.WebUtilities;

namespace CryptoFashionAPI.Service
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetShirtUri(string id)
        {
            return new Uri(_baseUri + Route.GetShirt.Replace("{id}", id));
        }

        public Uri GetAllShirtsUri(PaginationQuery paginationQuery = null)
        {
            var uri = new Uri(_baseUri);

            if (paginationQuery == null)
            {
                return uri;
            }

            var modifiedUri = QueryHelpers.AddQueryString(_baseUri + Route.BaseClothes + Route.GetAllShirts,
                "pageNumber", paginationQuery.PageNumber.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", paginationQuery.PageSize.ToString());
            return new Uri(modifiedUri);
        }
    }
}
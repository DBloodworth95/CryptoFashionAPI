using System.Collections;
using System.Collections.Generic;

namespace CryptoFashionAPI.Api
{
    public class PagedResponse<T>
    {
        public IEnumerable<T> Data { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSzie { get; set; }

        public string NextPage { get; set; }

        public string PreviousPage { get; set; }

        public PagedResponse()
        {
        }

        public PagedResponse(IEnumerable<T> data)
        {
            Data = data;
        }
    }
}
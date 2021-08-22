using System.Collections.Generic;
using CryptoFashionAPI.Domain;

namespace CryptoFashionAPI.Service
{
    public interface IShoesService
    {
        Shoe GetShoe(int id);

        Shoe AddShoe(Shoe shoe);

        List<Shoe> GetAllShoes(PaginationFilter paginationFilter);

        void DeleteShoe(int id);

        void EditShoe(Shoe shoe);

        int GetShoeCount();
    }
}
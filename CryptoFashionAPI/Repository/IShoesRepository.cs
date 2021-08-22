using System.Collections.Generic;
using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Repository
{
    public interface IShoesRepository
    {
        Shoe GetShoe(int id);
        Shoe AddShoe(Shoe shoe);
        List<Shoe> GetAllShoes(int skip = 0, int pageSize = 0);
        void DeleteShoe(int id);
        Shoe EditShoe(Shoe shoe);
        int GetShoeCount();
    }
}
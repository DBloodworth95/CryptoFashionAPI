using System.Collections.Generic;
using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Repository
{
    public interface IClothesRepository
    {
        Shirt GetShirt(int id);
        Shirt AddShirt(Shirt shit);
        List<Shirt> GetAllShirts(int skip = 0, int pageSize = 0);
        void DeleteShirt(int id);
        Shirt EditShirt(Shirt shirt);
        int GetShirtCount();
    }
}
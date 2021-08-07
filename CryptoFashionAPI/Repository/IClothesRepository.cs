using System.Collections.Generic;
using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Repository
{
    public interface IClothesRepository
    {
        Shirt GetShirt(int id);
        Shirt AddShirt(Shirt shit);
        List<Shirt> GetAllShirts();
        void DeleteShirt(int id);
        void EditShirt(Shirt shirt);
    }
}
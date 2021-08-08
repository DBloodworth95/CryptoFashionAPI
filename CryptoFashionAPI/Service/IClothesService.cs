using System.Collections.Generic;
using CryptoFashionAPI.Domain;

namespace CryptoFashionAPI.Service
{
    public interface IClothesService
    {
        Shirt GetShirt(int id);
        Shirt AddShirt(Shirt shit);
        List<Shirt> GetAllShirts();
        void DeleteShirt(int id);
        void EditShirt(Shirt shirt);
    }
}
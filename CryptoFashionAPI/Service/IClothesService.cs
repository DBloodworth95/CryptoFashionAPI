using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Service
{
    public interface IClothesService
    {
        Shirt GetShirt(int id);
        Shirt AddShirt(Shirt shit);
    }
}
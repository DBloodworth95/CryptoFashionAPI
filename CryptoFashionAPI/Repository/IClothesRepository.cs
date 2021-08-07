using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Repository
{
    public interface IClothesRepository
    {
        Shirt GetShirt(int id);
        Shirt AddShirt(Shirt shit);
    }
}
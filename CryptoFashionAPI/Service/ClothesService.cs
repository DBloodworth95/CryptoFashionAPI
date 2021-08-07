using System.Collections.Generic;
using CryptoFashionAPI.Model;
using CryptoFashionAPI.Repository;

namespace CryptoFashionAPI.Service
{
    public class ClothesService : IClothesService
    {
        private readonly IClothesRepository _clothesRepository;

        public ClothesService(IClothesRepository clothesRepository)
        {
            _clothesRepository = clothesRepository;
        }

        public List<Shirt> GetAllShirts()
        {
            return _clothesRepository.GetAllShirts();
        }

        public Shirt GetShirt(int id)
        {
            return _clothesRepository.GetShirt(id);
        }

        public Shirt AddShirt(Shirt shirt)
        {
            return _clothesRepository.AddShirt(shirt);
        }
    }
}
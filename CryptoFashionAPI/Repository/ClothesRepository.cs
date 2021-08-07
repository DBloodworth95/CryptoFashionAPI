using System.Collections.Generic;
using System.Linq;
using CryptoFashionAPI.Context;
using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Repository
{
    public class ClothesRepository : IClothesRepository
    {
        private readonly ClothesDbContext _clothesDbContext;

        public ClothesRepository(ClothesDbContext clothesDbContext)
        {
            _clothesDbContext = clothesDbContext;
        }

        public List<Shirt> GetAllShirts()
        {
            return _clothesDbContext.Shirts.ToList();
        }

        public Shirt GetShirt(int id)
        {
            return _clothesDbContext.Shirts.First(s => s.ID == id);
        }

        public Shirt AddShirt(Shirt shirt)
        {
            _clothesDbContext.Add(shirt);
            _clothesDbContext.SaveChanges();

            return shirt;
        }

        public void DeleteShirt(int id)
        {
            var shirtToDelete = _clothesDbContext.Shirts.First(s => s.ID == id);
            _clothesDbContext.Shirts.Remove(shirtToDelete);
            _clothesDbContext.SaveChanges();
        }

        public void EditShirt(Shirt shirt)
        {
            var shirtToEdit = _clothesDbContext.Shirts.First(s => s.ID == shirt.ID);
            shirtToEdit.ShirtName = shirt.ShirtName;
            _clothesDbContext.SaveChanges();
        }
    }
}
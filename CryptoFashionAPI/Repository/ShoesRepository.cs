using System;
using System.Collections.Generic;
using CryptoFashionAPI.Context;
using System.Linq;
using CryptoFashionAPI.Model;

namespace CryptoFashionAPI.Repository
{
    public class ShoesRepository : IShoesRepository
    {
        private readonly ShoesDbContext _shoesDbContext;

        public ShoesRepository(ShoesDbContext shoesDbContext)
        {
            _shoesDbContext = shoesDbContext;
        }

        public Shoe GetShoe(int id)
        {
            return _shoesDbContext.Shoes.First(s => s.ID == id);
        }

        
        public Shoe AddShoe(Shoe shoe)
        {
            _shoesDbContext.Add(shoe);
            _shoesDbContext.SaveChanges();

            return shoe;
        }

        public List<Shoe> GetAllShoes(int skip = 0, int pageSize = 0)
        {
            if (skip == 0)
            {
                return _shoesDbContext.Shoes
                    .OrderBy(s => s.ID)
                    .Take(pageSize)
                    .ToList();
            }
            
            return _shoesDbContext.Shoes
                .OrderBy(s => s.ID)
                .Skip(skip)
                .Take(pageSize)
                .ToList();
        }

        public void DeleteShoe(int id)
        {
            var shoe = _shoesDbContext.Shoes.First(s => s.ID == id);
            _shoesDbContext.Shoes.Remove(shoe);
            _shoesDbContext.SaveChanges();
        }

        public Shoe EditShoe(Shoe shoe)
        {
            var shoeToEdit = _shoesDbContext.Shoes.First(s => s.ID == shoe.ID);
            shoeToEdit.Brand = shoe.Brand;
            shoeToEdit.ShoeName = shoe.ShoeName;
            _shoesDbContext.SaveChanges();
            return shoe;
        }

        public int GetShoeCount()
        {
            return _shoesDbContext.Shoes.Count();
        }
    }
}
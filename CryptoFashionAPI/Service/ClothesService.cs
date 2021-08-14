using System.Collections.Generic;
using AutoMapper;
using CryptoFashionAPI.Domain;
using CryptoFashionAPI.Repository;

namespace CryptoFashionAPI.Service
{
    public class ClothesService : IClothesService
    {
        private readonly IClothesRepository _clothesRepository;

        private readonly IMapper _mapper;

        public ClothesService(IClothesRepository clothesRepository, IMapper mapper)
        {
            _clothesRepository = clothesRepository;
            _mapper = mapper;
        }

        public List<Shirt> GetAllShirts(PaginationFilter paginationFilter)
        {
            if (paginationFilter == null)
            {
                return _mapper.Map<List<Shirt>>(_clothesRepository.GetAllShirts());
            }

            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;
            return _mapper.Map<List<Shirt>>(_clothesRepository.GetAllShirts(skip, paginationFilter.PageSize));
        }

        public Shirt GetShirt(int id)
        {
            return _mapper.Map<Shirt>(_clothesRepository.GetShirt(id));
        }

        public Shirt AddShirt(Shirt shirt)
        {
            var mappedShirt = _mapper.Map<Model.Shirt>(shirt);
            return _mapper.Map<Shirt>(_clothesRepository.AddShirt(mappedShirt));
        }

        public void DeleteShirt(int id)
        {
            _clothesRepository.DeleteShirt(id);
        }

        public void EditShirt(Shirt shirt)
        {
            var mappedShirt = _mapper.Map<Model.Shirt>(shirt);
            _mapper.Map<Shirt>(_clothesRepository.EditShirt(mappedShirt));
        }
    }
}
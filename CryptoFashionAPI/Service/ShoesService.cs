using System.Collections.Generic;
using AutoMapper;
using CryptoFashionAPI.Domain;
using CryptoFashionAPI.Repository;

namespace CryptoFashionAPI.Service
{
    public class ShoesService : IShoesService
    {
        private readonly IShoesRepository _shoesRepository;
        
        private readonly IMapper _mapper;

        public ShoesService(IShoesRepository shoesRepository, IMapper mapper)
        {
            _shoesRepository = shoesRepository;
            _mapper = mapper;
        }
        
        public Shoe GetShoe(int id)
        {
            return _mapper.Map<Shoe>(_shoesRepository.GetShoe(id));
        }

        public Shoe AddShoe(Shoe shoe)
        {
            var mappedShoe = _mapper.Map<Model.Shoe>(shoe);
            return _mapper.Map<Shoe>(_shoesRepository.AddShoe(mappedShoe));
        }

        public List<Shoe> GetAllShoes(PaginationFilter paginationFilter)
        {
            if (paginationFilter == null)
            {
                return _mapper.Map<List<Shoe>>(_shoesRepository.GetAllShoes());
            }

            int paginationFilterPageSize = paginationFilter.PageSize < 0
                ? paginationFilter.PageSize = 100
                : paginationFilter.PageSize;
            var skip = paginationFilter.PageNumber == 0 ? 0 : paginationFilter.PageNumber * paginationFilter.PageSize;

            return _mapper.Map<List<Shoe>>(_shoesRepository.GetAllShoes(skip, paginationFilterPageSize));
        }

        public void DeleteShoe(int id)
        {
            _shoesRepository.DeleteShoe(id);
        }

        public void EditShoe(Shoe shoe)
        {
            var mappedShoe = _mapper.Map<Model.Shoe>(shoe);
            _mapper.Map<Shoe>(_shoesRepository.EditShoe(mappedShoe));
        }

        public int GetShoeCount()
        {
            return _shoesRepository.GetShoeCount();
        }
    }
}
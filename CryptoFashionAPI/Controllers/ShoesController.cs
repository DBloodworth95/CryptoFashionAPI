using CryptoFashionAPI.Api;
using CryptoFashionAPI.Domain;
using CryptoFashionAPI.Helper;
using CryptoFashionAPI.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CryptoFashionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoesController : ControllerBase
    {
        private readonly IShoesService _shoesService;

        private readonly IPaginationService _paginationService;

        private readonly IUriService _uriService;

        private readonly ILogger<ShoesController> _logger;

        public ShoesController(IShoesService shoesService, IPaginationService paginationService,
            IUriService uriService, ILogger<ShoesController> logger)
        {
            _shoesService = shoesService;
            _paginationService = paginationService;
            _uriService = uriService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllShoes([FromQuery] PaginationQuery paginationQuery)
        {
            //Get Request. Get all shoes.
            
            //
            var paginationFilter = _paginationService.GetPaginationFilter(paginationQuery);
            var shoes = _shoesService.GetAllShoes(paginationFilter);
            var totalShoes = _shoesService.GetShoeCount();

            if (paginationFilter == null || paginationFilter.PageNumber == 0 || paginationFilter.PageSize < 0)
            {
                return Ok(new PagedResponse<Shoe>(shoes));
            }

            var paginatedShoes = PaginationHelper.GenerateResponse(_uriService, paginationFilter, shoes, totalShoes);

            return Ok(paginatedShoes);
        }
    }
}
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
    public class ClothesController : ControllerBase
    {
        private readonly IClothesService _clothesService;

        private readonly IPaginationService _paginationService;

        private readonly IUriService _uriService;

        private readonly ILogger<ClothesController> _logger;

        public ClothesController(IClothesService clothesService, IPaginationService paginationService,
            IUriService uriService
            , ILogger<ClothesController> logger)
        {
            _clothesService = clothesService;
            _paginationService = paginationService;
            _uriService = uriService;
            _logger = logger;
        }

        [HttpGet]
        [Route(Route.GetAllShirts)]
        public IActionResult GetAllShirts([FromQuery] PaginationQuery paginationQuery)
        {
            var paginationFilter = _paginationService.GetPaginationFilter(paginationQuery);
            var shirts = _clothesService.GetAllShirts(paginationFilter);
            var totalShirts = _clothesService.GetShirtCount();

            if (paginationFilter == null || paginationFilter.PageNumber < 0 || paginationFilter.PageSize < 0)
            {
                return Ok(new PagedResponse<Shirt>(shirts));
            }

            var paginatedShirts = PaginationHelper.GenerateResponse(_uriService, paginationFilter, shirts, totalShirts);
            return Ok(paginatedShirts);
        }

        [HttpGet]
        [Route(Route.GetShirt + "{id}", Name = RouteName.AddShirt)]
        public IActionResult GetShirt(int id)
        {
            return Ok(new ResponseEnvelope<Shirt>(_clothesService.GetShirt(id)));
        }

        [HttpPost]
        [Route(Route.AddShirt)]
        public IActionResult AddShirt(Shirt shirt)
        {
            var newShirt = _clothesService.AddShirt(shirt);

            var locationUri = _uriService.GetShirtUri(shirt.Id.ToString());
            return Created(locationUri, new ResponseEnvelope<Shirt>(newShirt));
        }

        [HttpDelete]
        [Route(Route.DeleteShirt + "{id}")]
        public IActionResult DeleteShirt(int id)
        {
            _clothesService.DeleteShirt(id);
            return Ok();
        }

        [HttpPut]
        [Route(Route.EditShirt)]
        public IActionResult EditShirt([FromBody] Shirt shirt)
        {
            _clothesService.EditShirt(shirt);
            return Ok();
        }
    }
}
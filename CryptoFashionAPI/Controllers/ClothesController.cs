using CryptoFashionAPI.Model;
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

        private readonly ILogger<ClothesController> _logger;

        public ClothesController(IClothesService clothesService, ILogger<ClothesController> logger)
        {
            _clothesService = clothesService;
            _logger = logger;
        }

        [HttpGet("{id}", Name = "GetShirt")]
        public IActionResult GetShirt(int id)
        {
            return Ok(_clothesService.GetShirt(id));
        }

        [HttpPost]
        public IActionResult AddShirt(Shirt shirt)
        {
            var newShirt = _clothesService.AddShirt(shirt);
            return CreatedAtRoute("AddShirt", new { newShirt.ID }, newShirt);
        }
    }
}
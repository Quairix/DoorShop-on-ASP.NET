using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using WA.Data;

namespace WA.Controllers
{
    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly IWARepository _repository;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IWARepository repository, ILogger<ProductsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAllProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get products: {ex}");
                return BadRequest("Failed to get products");
            }
        }

    }
}

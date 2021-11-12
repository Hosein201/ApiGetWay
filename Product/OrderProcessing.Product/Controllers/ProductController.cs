using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Product.Repository;
using System.Threading.Tasks;

namespace OrderProcessing.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductRepository Repository { get; }

        public ProductController(IProductRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await Repository.GetAllProducts();
            return Ok(products);
        }
    }
}

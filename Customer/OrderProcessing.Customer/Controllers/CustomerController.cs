using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Customer.Repository;
using System.Threading.Tasks;

namespace OrderProcessing.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public ICustomerRepository Repository { get; }

        public CustomerController(ICustomerRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await Repository.GetAllCustomers();
            return Ok(customers);
        }
    }
}

using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Core.Attributes;
using OrderProcessing.Mapper.Commands.Product;
using OrderProcessing.Mapper.Dto.Product;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.C.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IMediator Mediator { get; }

        public ProductController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost, UserAccess(role: Roles.Customer)]
        public async Task<IActionResult> Post(ProductInsertDto dto ,CancellationToken cancellationToken)
        {
            var commmand = Mapping.MapTo<ProductInsertDto, ProductInsertCommand>(dto);
            var result = await Mediator.Send(commmand, cancellationToken);

            return Ok(new ApiResult { Data = result, Errors = null, StatusCode = HttpStatusCode.OK, Success = true });
        }
    }
}

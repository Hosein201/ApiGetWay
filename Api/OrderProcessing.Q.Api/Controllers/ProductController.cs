using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Core.Attributes;
using OrderProcessing.Mapper.Queries.Product;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Q.Api.Controllers
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

        [HttpGet, UserAccess(role: Roles.Customer, active: true)]
        public async Task<IActionResult> Get(int take, int skip, CancellationToken cancellationToken)
        {

            var result = await Mediator.Send(new GetProductsQuery() { Skip = skip, Take = take }, cancellationToken);
            return Ok(new ApiResult() { Data = result, Errors = null, StatusCode = HttpStatusCode.OK, Success = true });
        }

        [HttpGet, UserAccess(role: Roles.Customer ,active:true)]
        public async Task<IActionResult> Get(Guid productId, CancellationToken cancellationToken)
        {
            var result = await Mediator.Send(new GetProdcutByIdQuery() { ProductId = productId }, cancellationToken);
            return Ok(new ApiResult() { Data = result, Errors = null, StatusCode = HttpStatusCode.OK, Success = true });
        }
    }
}

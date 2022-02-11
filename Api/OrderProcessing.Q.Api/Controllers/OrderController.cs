using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Core.Attributes;
using OrderProcessing.Mapper.Queries.Order;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Q.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet, UserAccess(role: Roles.Customer)]
        public async Task<IActionResult> Get(int take, int skip, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new GetOrdersQuery() { Skip = skip, Take = take }, cancellationToken);
            return Ok(new ApiResult() { Data = result, Errors = null, StatusCode = HttpStatusCode.OK, Success = true });
        }

        [HttpGet, UserAccess(role: Roles.Customer)]
        public async Task<IActionResult> Get(Guid orderId, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new GetOrderByIdQuery() { OrderId = orderId }, cancellationToken);
            return Ok(new ApiResult() { Data = result, Errors = null, StatusCode = HttpStatusCode.OK, Success = true });
        }
    }
}

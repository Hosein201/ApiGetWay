using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Core.Attributes;
using OrderProcessing.Mapper.Commands.Order;
using OrderProcessing.Mapper.Dto.Order;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.C.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator Mediator;
        public OrderController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost, UserAccess(role: Roles.Customer, active: true)]
        public async Task<IActionResult> Post(InsertOrderDto orderInsertDto, CancellationToken cancellationToken)
        {
            var command = Mapping.MapTo<InsertOrderDto, OrderInsertCommand>(orderInsertDto);
            var result = await Mediator.Send(command, cancellationToken);
            return Ok(new ApiResult() { Data = result, Errors = null, StatusCode = System.Net.HttpStatusCode.OK, Success = true });
        }
    }
}
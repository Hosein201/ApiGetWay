using MediatR;
using OrderProcessing.Mapper.Commands.Order;
using OrderProcessing.Mapper.Dto.Order;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Order.Commands.Handler
{
    public class OrderInsertCommandHandler : IRequestHandler<OrderInsertCommand, OrderResponseDto>
    {
        public Task<OrderResponseDto> Handle(OrderInsertCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

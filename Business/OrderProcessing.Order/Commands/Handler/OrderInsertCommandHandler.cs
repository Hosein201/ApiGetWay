using MediatR;
using OrderProcessing.Mapper.Commands.Order;
using OrderProcessing.Mapper.Dto.Order;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Order.Commands.Handler
{
    public class OrderInsertCommandHandler : IRequestHandler<OrderInsertCommand, ResponseOrderDto>
    {
        public Task<ResponseOrderDto> Handle(OrderInsertCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

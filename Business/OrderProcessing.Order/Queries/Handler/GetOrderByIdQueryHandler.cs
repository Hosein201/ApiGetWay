using MediatR;
using OrderProcessing.Mapper.Dto.Order;
using OrderProcessing.Mapper.Queries.Order;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Order.Queries.Handler
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, ResponseOrderDto>
    {
        public Task<ResponseOrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

using MediatR;
using OrderProcessing.Mapper.Dto.Order;
using OrderProcessing.Mapper.Queries.Order;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Order.Queries.Handler
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, List<ResponseOrderDto>>
    {
        public Task<List<ResponseOrderDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

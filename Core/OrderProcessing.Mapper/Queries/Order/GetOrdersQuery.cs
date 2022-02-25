using MediatR;
using OrderProcessing.Mapper.Dto.Order;
using System.Collections.Generic;

namespace OrderProcessing.Mapper.Queries.Order
{
    public class GetOrdersQuery : IRequest<List<ResponseOrderDto>>
    {
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}

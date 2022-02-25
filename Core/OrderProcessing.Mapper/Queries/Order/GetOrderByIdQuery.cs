using MediatR;
using OrderProcessing.Mapper.Dto.Order;
using System;

namespace OrderProcessing.Mapper.Queries.Order
{
    public class GetOrderByIdQuery : IRequest<ResponseOrderDto>
    {
        public Guid OrderId { get; set; }
    }
}

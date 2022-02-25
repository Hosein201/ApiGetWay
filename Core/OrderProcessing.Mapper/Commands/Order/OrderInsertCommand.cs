using MediatR;
using OrderProcessing.Mapper.Dto.Order;

namespace OrderProcessing.Mapper.Commands.Order
{
    public class OrderInsertCommand : IRequest<ResponseOrderDto>
    {
        public string ProductName { get; set; }
        public int Valume { get; set; }
        public int Code { get; set; }
    }
}

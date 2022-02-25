using Entity.Data.Interface;
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
        private readonly IDataAccess _dataAccess;

        public OrderInsertCommandHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<ResponseOrderDto> Handle(OrderInsertCommand request, CancellationToken cancellationToken)
        {
            //Map command to dto 
            await _dataAccess.OrderAccess.InsertOrder(new Entity.Models.Order(), cancellationToken);
            await _dataAccess.SaveChangesAsync(cancellationToken);
            // save entity 
            // insert to nosql with event or other event
            // update cache if  need
            throw new NotImplementedException();
        }
    }
}

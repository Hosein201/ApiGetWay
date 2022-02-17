using OrderProcessing.Mapper.Dto.Order;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Interface
{
    public interface IOrderRepository : IRepository<Models.Order.Order>
    {
        Task<ResponseOrderDto> InsertOrder(InsertOrderDto dto, CancellationToken cancellationToken);
        Task<List<ResponseOrderDto>> InsertOrders(List<InsertOrderDto> dtos, CancellationToken cancellationToken);
    }
}

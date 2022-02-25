using Entity.Models;
using OrderProcessing.Mapper.Dto.Order;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Interface
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<ResponseOrderDto> InsertOrder(Order model, CancellationToken cancellationToken);
        Task<List<ResponseOrderDto>> InsertOrders(List<Order> models, CancellationToken cancellationToken);
    }
}

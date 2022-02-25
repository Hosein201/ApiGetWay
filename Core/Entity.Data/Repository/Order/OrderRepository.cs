using Entity.Data.Interface;
using OrderProcessing.Mapper.Dto.Order;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Entity.Models;

namespace Entity.Data.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly AppDbContext _dbContext;

        public OrderRepository(AppDbContext dbContext)
            : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<ResponseOrderDto> InsertOrder(Order model, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new ResponseOrderDto());
        }

        public async Task<List<ResponseOrderDto>> InsertOrders(List<Order> models ,CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<ResponseOrderDto>());
        }
    }
}

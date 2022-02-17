using Entity.Data.Interface;
using OrderProcessing.Mapper.Dto.Order;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Repository.Order
{
    public class OrderRepository : Repository<Models.Order.Order>, IOrderRepository
    {
        private readonly AppDbContext _dbContext;

        public OrderRepository(AppDbContext dbContext)
            : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<ResponseOrderDto> InsertOrder(InsertOrderDto dto, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new ResponseOrderDto());
        }

        public async Task<List<ResponseOrderDto>> InsertOrders(List<InsertOrderDto> dtos ,CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<ResponseOrderDto>());
        }
    }
}

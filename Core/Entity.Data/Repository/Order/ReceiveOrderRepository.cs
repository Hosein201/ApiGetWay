using Entity.Data.Interface;

namespace Entity.Data.Repository.Order
{
    public class ReceiveOrderRepository : Repository<Models.Order.ReceiveOrder>, IReceiveOrderRepository
    {
        private readonly AppDbContext _dbContext;

        public ReceiveOrderRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}

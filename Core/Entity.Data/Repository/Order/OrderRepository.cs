using Entity.Data.Interface;

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
    }
}

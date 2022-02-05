using Entity.Data.Interface;

namespace Entity.Data.Repository.Order
{
    public class RejectOrderRepository : Repository<Models.Order.RejectOrder>, IRejectOrderRepository
    {
        private readonly AppDbContext _dbContext;

        public RejectOrderRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}

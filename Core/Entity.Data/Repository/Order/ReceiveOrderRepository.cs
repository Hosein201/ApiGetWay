using Entity.Data.Interface;
using Entity.Models;

namespace Entity.Data.Repository
{
    public class ReceiveOrderRepository : Repository<ReceiveOrder>, IReceiveOrderRepository
    {
        private readonly AppDbContext _dbContext;

        public ReceiveOrderRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}

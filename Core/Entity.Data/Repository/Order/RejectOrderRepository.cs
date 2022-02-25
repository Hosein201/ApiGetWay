using Entity.Data.Interface;
using Entity.Models;

namespace Entity.Data.Repository
{
    public class RejectOrderRepository : Repository<RejectOrder>, IRejectOrderRepository
    {
        private readonly AppDbContext _dbContext;

        public RejectOrderRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}

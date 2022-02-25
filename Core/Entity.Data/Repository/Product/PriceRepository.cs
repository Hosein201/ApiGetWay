using Entity.Data.Interface;
using Entity.Models;

namespace Entity.Data.Repository
{
    public class PriceRepository : Repository<Price>, IPriceRepository
    {
        private readonly AppDbContext _dbContext;
        public PriceRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

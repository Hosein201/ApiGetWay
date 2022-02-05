using Entity.Data.Interface;

namespace Entity.Data.Repository.Product
{
    public class PriceRepository : Repository<Models.Product.Price>, IPriceRepository
    {
        private readonly AppDbContext _dbContext;
        public PriceRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

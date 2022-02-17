using Entity.Data.Interface;

namespace Entity.Data.Repository.Product
{
    public class ProductRepository : Repository<Models.Product.Product>, IProductRepository
    {
        private readonly AppDbContext _dbContext;
        public ProductRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

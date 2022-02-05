using Entity.Data.Interface;

namespace Entity.Data.Repository.Product
{
    public class CategoryRepository : Repository<Models.Product.Category>, ICategoryRepository
    {
        private readonly AppDbContext _dbContext;
        public CategoryRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

using Entity.Data.Interface;
using Entity.Models;

namespace Entity.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _dbContext;
        public CategoryRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

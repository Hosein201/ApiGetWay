using Entity.Data.Interface;
using Entity.Models;

namespace Entity.Data.Repository
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        private readonly AppDbContext _dbContext;
        public SubCategoryRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

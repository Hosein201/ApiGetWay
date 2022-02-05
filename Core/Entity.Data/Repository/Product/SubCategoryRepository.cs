using Entity.Data.Interface;

namespace Entity.Data.Repository.Product
{
    public class SubCategoryRepository : Repository<Models.Product.SubCategory>, ISubCategoryRepository
    {
        private readonly AppDbContext _dbContext;
        public SubCategoryRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

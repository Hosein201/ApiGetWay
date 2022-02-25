using Entity.Data.Interface;
using OrderProcessing.Mapper.Dto.Product;
using System.Threading;
using System.Threading.Tasks;
using Entity.Models;

namespace Entity.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AppDbContext _dbContext;
        public ProductRepository(AppDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResponseProductDto> AddProduct(Product entity, CancellationToken cancellationToken)
        {
            await AddAsync(entity, cancellationToken);

            return new ResponseProductDto();
        }
    }
}

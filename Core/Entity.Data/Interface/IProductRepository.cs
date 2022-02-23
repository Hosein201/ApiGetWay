using Entity.Models;
using OrderProcessing.Mapper.Dto.Product;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<ResponseProductDto> AddProduct(Product entity, CancellationToken cancellationToken);
    }
}

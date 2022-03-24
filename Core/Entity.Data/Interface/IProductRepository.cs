using Entity.Models;
using Infrastructure;
using OrderProcessing.Mapper.Dto.Product;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Interface
{
    public interface IProductRepository : IRepository<Product>, IScopedDependency
    {
        Task<ResponseProductDto> AddProduct(Product entity, CancellationToken cancellationToken);
    }
}

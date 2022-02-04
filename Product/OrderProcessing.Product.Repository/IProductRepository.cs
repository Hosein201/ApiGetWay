using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderProcessing.Product.Repository
{
    public interface IProductRepository
    {
        Task<List<Entity.Models.Product.Product>> GetAllProducts();
    }
}

using Entity.Models;
using Infrastructure;

namespace Entity.Data.Interface
{
    public interface ICategoryRepository : IRepository<Category>, IScopedDependency
    {
    }
}

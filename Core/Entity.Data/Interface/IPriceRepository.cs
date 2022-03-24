using Entity.Models;
using Infrastructure;

namespace Entity.Data.Interface
{
    public interface IPriceRepository : IRepository<Price>, IScopedDependency
    {
    }
}

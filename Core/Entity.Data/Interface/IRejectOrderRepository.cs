using Entity.Models;
using Infrastructure;

namespace Entity.Data.Interface
{
    public interface IRejectOrderRepository : IRepository<RejectOrder>, IScopedDependency
    {
    }
}

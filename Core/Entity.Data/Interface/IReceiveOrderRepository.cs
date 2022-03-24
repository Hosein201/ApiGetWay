using Entity.Models;
using Infrastructure;

namespace Entity.Data.Interface
{
    public interface IReceiveOrderRepository : IRepository<ReceiveOrder>, IScopedDependency
    {
    }
}

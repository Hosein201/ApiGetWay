using Entity.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Interface
{
    public interface IPermissionRepository : IRepository<Permission>
    {
        Task AddPermissions(List<Permission> models, CancellationToken cancellationToken);
        Task UpdatePermissions();
        Task DeletePermissions();
        Task<List<Permission>> GetPermissionsByRole(string roleName, CancellationToken cancellationToken);
        Task<Permission> GetPermission(string controllerName, string actionName, string roleName, CancellationToken cancellationToken);
    }
}

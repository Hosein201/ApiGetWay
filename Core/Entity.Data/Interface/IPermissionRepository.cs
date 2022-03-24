using Entity.Models;
using Infrastructure;
using OrderProcessing.Mapper.Dto.Permission;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Interface
{
    public interface IPermissionRepository : IRepository<Permission>, IScopedDependency
    {
        Task AddPermissions(List<Permission> models, CancellationToken cancellationToken);
        void UpdatePermission(Guid id, string controllerName, string actionName, string roleName);
        void DeletePermission(Guid id, string controllerName, string actionName, string roleName);
        Task<List<GetPermissionDto>> GetPermissionsByRole(string roleName, CancellationToken cancellationToken);
        Task<GetPermissionDto> GetPermission(string controllerName, string actionName, string roleName, CancellationToken cancellationToken);
    }
}

using Entity.Data.Interface;
using Microsoft.EntityFrameworkCore;
using OrderProcessing.Mapper.Dto.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Repository
{
    public class PermissionRepository : Repository<Models.Permission>, IPermissionRepository
    {
        private readonly AppDbContext _dbContext;
        public PermissionRepository(AppDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetPermissionDto> GetPermission(string controllerName, string actionName, string roleName, CancellationToken cancellationToken)
        {
            return await TableNoTracking
                .Where(w => w.RoleName == roleName && w.Active && w.ControllerName == controllerName && w.ActionName == actionName)
                .Select(s => new GetPermissionDto
                {
                    ActionName = s.ActionName,
                    ControllerName = s.ControllerName,
                    FullUrl = s.FullUrl,
                    Active = s.Active,
                    RoleCode = s.RoleCode,
                    RoleName = s.RoleName
                }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<GetPermissionDto>> GetPermissionsByRole(string roleName, CancellationToken cancellationToken)
        {
            return await TableNoTracking
                .Where(w => w.RoleName == roleName && w.Active)
                .Select(s => new GetPermissionDto
                {
                    ActionName = s.ActionName,
                    ControllerName = s.ControllerName,
                    FullUrl = s.FullUrl,
                    Active = s.Active,
                    RoleCode = s.RoleCode,
                    RoleName = s.RoleName
                }).ToListAsync(cancellationToken);
        }

        public async Task AddPermissions(List<Models.Permission> models, CancellationToken cancellationToken)
        {
            //ToDo: remove permission
            await AddRangeAsync(models, cancellationToken);
        }

        public void DeletePermission(Guid id, string controllerName, string actionName, string roleName)
        {
            Delete(new Models.Permission { Id = id, ControllerName = controllerName, ActionName = actionName, RoleName = roleName });
        }

        public void UpdatePermission(Guid id, string controllerName, string actionName, string roleName)
        {
            Update(new Models.Permission { Id = id, ControllerName = controllerName, ActionName = actionName, RoleName = roleName });
        }
    }
}

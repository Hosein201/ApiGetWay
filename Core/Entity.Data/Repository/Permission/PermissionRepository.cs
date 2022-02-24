using Entity.Data.Interface;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Models.Permission> GetPermission(string controllerName, string actionName, string roleName, CancellationToken cancellationToken)
        {
            return await TableNoTracking.FirstOrDefaultAsync(w => w.RoleName == roleName && w.Active && w.ControllerName == controllerName && w.ActionName == actionName, cancellationToken);
        }

        public async Task<List<Models.Permission>> GetPermissionsByRole(string roleName, CancellationToken cancellationToken)
        {
            return await TableNoTracking.Where(w => w.RoleName == roleName && w.Active).ToListAsync(cancellationToken);
        }

        public async Task AddPermissions(List<Models.Permission> models, CancellationToken cancellationToken)
        {
            await AddRangeAsync(models, cancellationToken);
        }

        public Task DeletePermissions()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdatePermissions()
        {
            throw new System.NotImplementedException();
        }
    }
}

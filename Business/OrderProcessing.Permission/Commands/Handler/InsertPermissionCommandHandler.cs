using Entity.Data.Interface;
using MediatR;
using OrderProcessing.Mapper.Commands.Permission;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Permission.Commands.Handler
{
    public class InsertPermissionCommandHandler : IRequestHandler<InsertPermissionCommand>
    {
        private readonly IDataAccess dataAccess;
        public InsertPermissionCommandHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<Unit> Handle(InsertPermissionCommand request, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(request.Permissions, nameof(InsertPermissionCommand));

            List<Entity.Models.Permission> Permissions = new();
            foreach (var permissionDto in request.Permissions)
            {
                Permissions.Add(new Entity.Models.Permission
                {
                    ActionName = permissionDto.ActionName,
                    ControllerName = permissionDto.ControllerName,
                    Active = permissionDto.Active,
                    FullUrl = permissionDto.FullUrl,
                    RoleCode = permissionDto.RoleCode,
                    RoleName = permissionDto.RoleName
                });
            }

            await dataAccess.PermissionAccess.AddPermissions(Permissions, cancellationToken);
            await dataAccess.SaveChangesAsync(cancellationToken);

            //TODO: Add in caching with event 

            return Unit.Value;
        }
    }
}

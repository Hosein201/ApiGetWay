using Entity.Data.Interface;
using MediatR;
using OrderProcessing.Mapper.Dto.Permission;
using OrderProcessing.Mapper.Queries.Permission;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Permission.Queries.Handler
{
    public class GetPermissionsByRoleQueryHandler : IRequestHandler<GetPermissionsByRoleQuery, List<GetPermissionDto>>
    {
        private readonly IDataAccess dataAccess;

        public GetPermissionsByRoleQueryHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<List<GetPermissionDto>> Handle(GetPermissionsByRoleQuery request, CancellationToken cancellationToken)
        {
            //TODO: Get from caching

            return await dataAccess.PermissionAccess.GetPermissionsByRole(request.RoleName, cancellationToken);
        }
    }
}

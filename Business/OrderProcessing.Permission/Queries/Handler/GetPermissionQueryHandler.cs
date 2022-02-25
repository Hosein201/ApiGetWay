using Entity.Data.Interface;
using MediatR;
using OrderProcessing.Mapper.Dto.Permission;
using OrderProcessing.Mapper.Queries.Permission;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Permission.Queries.Handler
{
    public class GetPermissionQueryHandler : IRequestHandler<GetPermissionQuery, GetPermissionDto>
    {
        private readonly IDataAccess dataAccess;
        public GetPermissionQueryHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<GetPermissionDto> Handle(GetPermissionQuery request, CancellationToken cancellationToken)
        {
            //TODO: Get from caching

            return await dataAccess.PermissionAccess.GetPermission(request.ControllerName, request.ActionName, request.RoleName, cancellationToken);
        }
    }
}

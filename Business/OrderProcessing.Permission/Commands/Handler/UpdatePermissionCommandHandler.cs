using Entity.Data.Interface;
using MediatR;
using OrderProcessing.Mapper.Commands.Permission;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Permission.Commands.Handler
{
    public class UpdatePermissionCommandHandler : IRequestHandler<UpdatePermissionCommand>
    {
        private readonly IDataAccess dataAccess;

        public UpdatePermissionCommandHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<Unit> Handle(UpdatePermissionCommand request, CancellationToken cancellationToken)
        {
            dataAccess.PermissionAccess.UpdatePermission(request.Id, request.ControllerName, request.ActionName, request.RoleName);
           await dataAccess.SaveChangesAsync(cancellationToken);

            //TODO : update caching

            return Unit.Value;
        }
    }
}

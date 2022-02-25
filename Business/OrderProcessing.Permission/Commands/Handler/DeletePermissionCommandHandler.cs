using Entity.Data.Interface;
using MediatR;
using OrderProcessing.Mapper.Commands.Permission;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Permission.Commands.Handler
{
    public class DeletePermissionCommandHandler : IRequestHandler<DeletePermissionCommand>
    {
        private readonly IDataAccess dataAccess;

        public DeletePermissionCommandHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Task<Unit> Handle(DeletePermissionCommand request, CancellationToken cancellationToken)
        {
            dataAccess.PermissionAccess.DeletePermission(request.Id, request.ControllerName, request.ActionName, request.RoleName);
            dataAccess.SaveChangesAsync(cancellationToken);

            //TODO : delete  caching

            return null;
        }
    }
}

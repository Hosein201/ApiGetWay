using MediatR;
using OrderProcessing.Mapper.Commands.Permission;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Permission.Commands.Handler
{
    public class InsertPermissionCommandHandler : IRequestHandler<InsertPermissionCommand>
    {
        public Task<Unit> Handle(InsertPermissionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

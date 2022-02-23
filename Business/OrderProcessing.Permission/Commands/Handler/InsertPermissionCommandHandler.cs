using MediatR;
using OrderProcessing.Mapper.Commands.Permission;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Permission.Commands.Handler
{
    public class InsertPermissionCommandHandler : IRequestHandler<PermissionInsertCommand>
    {
        public Task<Unit> Handle(PermissionInsertCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

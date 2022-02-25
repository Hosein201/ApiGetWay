using MediatR;
using OrderProcessing.Mapper.Dto.Permission;
using System.Collections.Generic;

namespace OrderProcessing.Mapper.Commands.Permission
{
    public class InsertPermissionCommand : IRequest
    {
        public List<InsertPermissionDto> Permissions { get; set; }
    }
}

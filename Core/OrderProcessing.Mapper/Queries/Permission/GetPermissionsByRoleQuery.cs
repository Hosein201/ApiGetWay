using MediatR;
using OrderProcessing.Mapper.Dto.Permission;
using System.Collections.Generic;

namespace OrderProcessing.Mapper.Queries.Permission
{
    public class GetPermissionsByRoleQuery : IRequest<List<GetPermissionDto>>
    {
        public string RoleName { get; set; }
    }
}

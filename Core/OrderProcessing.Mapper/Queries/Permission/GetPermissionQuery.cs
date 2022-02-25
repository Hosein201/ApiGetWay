using MediatR;
using OrderProcessing.Mapper.Dto.Permission;

namespace OrderProcessing.Mapper.Queries.Permission
{
    public class GetPermissionQuery : IRequest<GetPermissionDto>
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string RoleName { get; set; }
    }
}

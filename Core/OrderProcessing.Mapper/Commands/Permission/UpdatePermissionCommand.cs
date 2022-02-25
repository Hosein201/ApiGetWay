using MediatR;
using System;

namespace OrderProcessing.Mapper.Commands.Permission
{
    public class UpdatePermissionCommand : IRequest
    {
        public Guid Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string FullUrl { get; set; }
        public int RoleCode { get; set; }
        public string RoleName { get; set; }
        public bool Active { get; set; }
    }
}

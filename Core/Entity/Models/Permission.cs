using System;

namespace Entity.Models
{
    public class Permission
    {
        public Permission()
        {
            Id = Guid.NewGuid();
            Active = true;
        }
        public Guid Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string FullUrl { get; set; }
        public int RoleCode { get; set; }
        public string RoleName { get; set; }
        public bool Active { get; set; }
    }
}

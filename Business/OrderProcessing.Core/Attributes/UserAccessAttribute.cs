using Infrastructure;
using System;

namespace OrderProcessing.Core.Attributes
{
    public class UserAccessAttribute : Attribute
    {
        public Roles Role { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public UserAccessAttribute(Roles role, int order = 0, bool active = true)
        {
            this.Role = role;
            this.Order = order;
            this.Active = active;
        }
    }
}

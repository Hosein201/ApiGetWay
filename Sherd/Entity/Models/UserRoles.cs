using Microsoft.AspNetCore.Identity;
using System;

namespace Entity.Models
{
    public class UserRoles : IdentityUserRole<Guid>, IEntity
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}

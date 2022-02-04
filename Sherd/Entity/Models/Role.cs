using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class Role : IdentityRole<Guid> , IEntity
    {
        public int Code { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Entity.Models
{
    public class Role : IdentityRole<int> , IEntity
    {
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}

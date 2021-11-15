using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Entity.Models
{
    public class User : IdentityUser<int>, IEntity
    {
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}

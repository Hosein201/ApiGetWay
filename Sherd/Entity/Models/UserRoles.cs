using Microsoft.AspNetCore.Identity;

namespace Entity.Models
{
    public class UserRoles : IdentityUserRole<int>, IEntity
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}

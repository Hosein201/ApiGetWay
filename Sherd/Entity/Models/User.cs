using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class User : IdentityUser<Guid>, IEntity
    {
        public User()
        {
            IsActive = true;
            RegisterDate = DateTime.UtcNow;
        }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
        public Customer.Customer Customer { get; set; }
    }
}

using System;

namespace Entity.Models.Customer
{
    public class Customer:IEntity
    {
        public Guid Id { get; set; }
        
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}

using System;

namespace Entity.Models.Order
{
    public class Order : IEntity
    {
        public Order() 
        {
            CreateDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class Order : IEntity
    {
        public Order()
        {
            Id = Guid.NewGuid();
            CreateDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string ProductName { get; set; }
        public int Valume { get; set; }
        public int Code { get; set; }
        public User User { get; set; }
        public ICollection<ReceiveOrder> ReceiveOrders { get; set; }
        public ICollection<RejectOrder> RejectOrders { get; set; }
    }
}

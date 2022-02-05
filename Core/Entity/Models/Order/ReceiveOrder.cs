using System;

namespace Entity.Models.Order
{
    public class ReceiveOrder : IEntity
    {
        public ReceiveOrder()
        {
            CreateDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}

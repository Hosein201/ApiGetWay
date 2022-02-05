using System;

namespace Entity.Models.Order
{
    public class RejectOrder : IEntity
    {
        public RejectOrder()
        {
            CreateDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}

using System;

namespace Entity.Models.Order
{
    public class RejectOrder : IEntity
    {
        public RejectOrder()
        {
            Id = Guid.NewGuid();
            CreateDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string ProductName { get; set; }
        public int Valume { get; set; }
        public DateTime RejectTime { get; set; }
        public string WriterName { get; set; }
        public Order Order { get; set; }
    }
}

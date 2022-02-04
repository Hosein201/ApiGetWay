using System;

namespace Entity.Models.Order
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }

    }
}

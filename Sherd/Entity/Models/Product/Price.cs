using System;

namespace Entity.Models.Product
{
    public class Price : IEntity
    {
        public Price()
        {
            CreateDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Dicount { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Product Product { get; set; }
    }
}

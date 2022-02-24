using System;

namespace Entity.Models
{
    public class Price : IEntity
    {
        public Price()
        {
            CreateDateTime = DateTime.UtcNow;
            UpdateDateTime = default(DateTime);
        }

        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Dicount { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        #region Reletions
        public Product Product { get; set; }
        #endregion
    }
}

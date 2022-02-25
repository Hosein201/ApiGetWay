using System;

namespace Entity.Models
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

        #region Reletions
        public Order Order { get; set; }
        #endregion
    }
}

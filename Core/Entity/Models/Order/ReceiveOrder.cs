using System;

namespace Entity.Models
{
    public class ReceiveOrder : IEntity
    {
        public ReceiveOrder()
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

using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class Product : IEntity
    {
        public Product()
        {
            CreateDateTime = DateTime.UtcNow;
            UpdateDateTime = default(DateTime);
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime{get; set;}

        #region Reletions
        public ICollection<Price> Prices { get; set; }
        public SubCategory SubCategory { get; set; }
        #endregion
    }
}

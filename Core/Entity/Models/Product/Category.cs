using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class Category : IEntity
    {
        public Category()
        {
            CreateDateTime = DateTime.UtcNow;
            IsActive = true;
            UpdateDateTime = default(DateTime);
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public bool IsActive { get; set; }

        #region Reletions
        public ICollection<SubCategory> SubCategories { get; set; }
        #endregion
    }
}

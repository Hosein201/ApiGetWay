using System;
using System.Collections.Generic;

namespace Entity.Models.Product
{
    public class Category : IEntity
    {
        public Category()
        {
            CreateDateTime = DateTime.UtcNow;
            IsActive = true;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsActive { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}

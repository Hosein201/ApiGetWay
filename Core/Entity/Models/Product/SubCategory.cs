using System;
using System.Collections.Generic;

namespace Entity.Models.Product
{
    public class SubCategory : IEntity
    {
        public SubCategory()
        {
            CreateDateTime = DateTime.UtcNow;
            IsActive = true;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
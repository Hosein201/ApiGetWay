using System;
using System.Collections.Generic;

namespace Entity.Models.Product
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<Price> Prices { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OrderProcessing.Product.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Entity.Product> products = new();
        public ProductRepository()
        {
            products.Add(new Entity.Product
            {
                Id = Guid.NewGuid(),
                Code = "P0001",
                Name = "Lenovo Laptop",
                Quantity_In_Stock = 15,
                Unit_Price = 125000
            });

            products.Add(new Entity.Product
            {
                Id = Guid.NewGuid(),
                Code = "P0002",
                Name = "DELL Laptop",
                Quantity_In_Stock = 25,
                Unit_Price = 135000
            });

            products.Add(new Entity.Product
            {
                Id = Guid.NewGuid(),
                Code = "P0003",
                Name = "HP Laptop",
                Quantity_In_Stock = 20,
                Unit_Price = 115000
            });
        }

        public Task<List<Entity.Product>> GetAllProducts()
        {
            return Task.FromResult(products);
        }
    }
}

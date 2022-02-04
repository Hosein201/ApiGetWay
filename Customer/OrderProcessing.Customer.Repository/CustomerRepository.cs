using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderProcessing.Customer.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Entity.Models.Customer.Customer> customers = new();
        public CustomerRepository()
        {
            customers.Add(new Entity.Models.Customer.Customer()
            {
                Id = Guid.NewGuid()               
            });

            customers.Add(new Entity.Models.Customer.Customer()
            {
                Id = Guid.NewGuid()
            });
        }

        public Task<List<Entity.Models.Customer.Customer>> GetAllCustomers()
        {
            return Task.FromResult(customers);
        }
    }
}

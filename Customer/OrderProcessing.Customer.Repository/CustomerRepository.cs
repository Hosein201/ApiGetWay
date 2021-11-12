using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderProcessing.Customer.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Entity.Customer> customers = new();
        public CustomerRepository()
        {
            customers.Add(new Entity.Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Hossein",
                LastName = "GolMohammadi",
                EmailAddress = "GolMohammadi@yahoo.com"
            });

            customers.Add(new Entity.Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Steve",
                LastName = "Smith",
                EmailAddress = "stevesmith@yahoo.com"
            });
        }

        public Task<List<Entity.Customer>> GetAllCustomers()
        {
            return Task.FromResult(customers);
        }
    }
}

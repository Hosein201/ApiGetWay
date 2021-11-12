﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderProcessing.Customer.Repository
{
    public interface ICustomerRepository
    {
        Task<List<Entity.Customer>> GetAllCustomers();
    }
}
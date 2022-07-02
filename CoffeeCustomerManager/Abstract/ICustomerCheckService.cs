using CoffeeCustomerManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManager.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}

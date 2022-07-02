using CoffeeCustomerManager.Abstract;
using CoffeeCustomerManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManager.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
            // return false;
        }
    }
}

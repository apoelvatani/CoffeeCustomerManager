using CoffeeCustomerManager.Abstract;
using CoffeeCustomerManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManager.Concrete
{
    class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService) // Dependies Injection
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
                base.Save(customer);
            else
                throw new Exception("Not a valid customer...!");
                // Console.WriteLine("Not a valid customer...!");
        }
    }
}

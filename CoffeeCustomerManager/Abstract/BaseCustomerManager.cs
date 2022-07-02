using CoffeeCustomerManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManager.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}

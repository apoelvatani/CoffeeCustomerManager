using CoffeeCustomerManager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCustomerManager.Entities
{
    public class Customer : IEntity
    {
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

    }
}

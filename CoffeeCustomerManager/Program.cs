using CoffeeCustomerManager.Abstract;
using CoffeeCustomerManager.Adapters;
using CoffeeCustomerManager.Concrete;
using CoffeeCustomerManager.Entities;
using System;
using System.Text;

namespace CoffeeCustomerManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { NationalityId = 123, FirstName = "Çetin", LastName = "Alican", YearOfBirth = 2018 });
        }
    }
}

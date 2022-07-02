using CoffeeCustomerManager.Abstract;
using CoffeeCustomerManager.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CoffeeCustomerManager.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName.ToString(new CultureInfo("tr-TR")), customer.LastName.ToString(new CultureInfo("tr-TR")), customer.YearOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

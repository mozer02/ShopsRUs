using ShopsRUs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application.FakeData
{
    public class Data
    {
        List<Customer> Products
        {
            get
            {
                return new List<Customer> {

                new Customer(firstName:"Ali",lastName:"Kemal",customerStatus:CustomerStatus.Employee,identityNumber:123456)
                {

                }.AddInvoice(new Invoice(description:"deneme")
            })
            }
        }
    }
}

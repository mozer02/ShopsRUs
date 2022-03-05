using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application.Services
{
    public class CreateInvoiceService : ICreateInvoiceService
    {
        public decimal OnProcess(InvoiceRequestDto request)
        {
            double discountCoefficient = 0;
            var discount = 0;
            int asd = 0;
            var price = 0;
            var customer = _customerRepository.GetQuery().FirstOrDefault(x => x.IdentityNumber == request.IdentityNumber);
            if (customer.Type == "employee ")
            {
                discountCoefficient = 0.3;
            }
            else if (customer.Type == "affiliate ")
            {
                discountCoefficient = 0.1;
            }
            else if (DateTime.Now - customer.OnCreatedDate > 2)
            {
                discountCoefficient = 0.05;
            }

            var invoice = new Invoice("ZORUNLU ŞEYLER");

            foreach (var product in request.Product.length)
            {
                for (int i = 0; i < product.Quantity; i++)
                {
                    var product = _productRepository.GetQuery().FirstOrDefault(x => x.Barcode == product.Barcode);
                    invoice.AddProduct(product);
                    if (product.Type != "groceries")
                    {
                        discount += product.Price * discountCoefficient;

                        price += product.Price - discount;
                    }
                    else
                    {
                        price += product.Price;
                    }
                }

            }
            asd = price / 100;
            price = price - asd * 5;
            discount += asd * 5;
        }
    }
}

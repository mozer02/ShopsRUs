using ShopsRUs.Application.FakeData;
using ShopsRUs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application
{
    public class CreateInvoiceService : ICreateInvoiceService
    {
        public decimal OnProcess(InvoiceRequestDto request)
        {
            var data = new Data();
            var customer = data.Customers.Find(x => x.IdentityNumber == request.IdentityNumber);
            double discountCoefficient = 0; // Müşteri Türüne göre İndirim Katsayısı
            double DiscountAmount = 0;//Toplam İndirim Tutarı
            double DiscountPrice = 0; //Toplam Fiyat (İndirimli Hali)
            double TotalPrice = 0;//Toplam Fiyat
            //var customer = _customerRepository.GetQuery().FirstOrDefault(x => x.IdentityNumber == request.IdentityNumber);
            if (customer.Status == 100)
            {
                discountCoefficient = 0.3;
            }
            else if (customer.Status == 101)
            {
                discountCoefficient = 0.1;
            }
            else if (customer.Status == 102 && (customer.OnCreatedDate - DateTime.Now).TotalDays > 720)
            {
                discountCoefficient = 0.05;
            }

            var invoice = new Invoice("Yeni Fatura Oluşturuldu...");
            
            foreach (var product in request.Products)
            {
                for (int i = 0; i < product.Quantity; i++)
                {
                    var currentProduct = data.Products.Find(x => x.Barcode == product.Barcode);
                    invoice.AddProduct(currentProduct);
                    if (currentProduct.ProductType != "Market")
                    {
                        DiscountAmount += currentProduct.ProductPrice * discountCoefficient;

                        DiscountPrice += currentProduct.ProductPrice - DiscountAmount;
                        TotalPrice += currentProduct.ProductPrice;
                    }
                    else
                    {
                        DiscountPrice += currentProduct.ProductPrice;
                        TotalPrice += currentProduct.ProductPrice;
                    }
                }

            }
           
            DiscountAmount += (int)TotalPrice / 100 * 5;
            DiscountPrice = DiscountPrice - DiscountAmount;

            var discount = new Discount((decimal)DiscountAmount);
            invoice.SetDiscount(discount);
            invoice.SetTotalPrice((decimal)DiscountPrice);

            customer.AddInvoice(invoice);
            
            return (decimal)DiscountPrice;
        }
    }
}

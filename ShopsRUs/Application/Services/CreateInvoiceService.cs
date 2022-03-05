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
            var data = new Data(); //Data oluştur
            var customer = data.Customers.Find(x => x.IdentityNumber == request.IdentityNumber); //Müşteriyi bul
            double discountCoefficient = 0; // Müşteri Türüne göre İndirim Katsayısı
            double DiscountAmount = 0;//Toplam İndirim Tutarı
            double TotalPrice = 0; //Toplam Fiyat
            double DiscountPrice = 0; // İndirilimli Toplam Fiyat

            if (customer.Status == 100) // Mağazaya Bağlıysa
            {
                discountCoefficient = 0.3;
            }
            else if (customer.Status == 101) // Mağazaya Üye ise
            {
                discountCoefficient = 0.1;
            }
            else if (customer.Status == 102 && (customer.OnCreatedDate - DateTime.Now).TotalDays > 720) // 2 yıldan uzun süredir müşteriyse
            {
                discountCoefficient = 0.05;
            }

            var invoice = new Invoice("Yeni Fatura Oluşturuldu..."); // Boş Fatura Oluştur

            foreach (var product in request.Products) //Ürünlerin içerisinde dön
            {
                for (int i = 0; i < product.Quantity; i++) // Ürün Miktarına göre kontrol et
                {
                    var currentProduct = data.Products.Find(x => x.Barcode == product.Barcode); // Ürünü data dan buluruz
                    invoice.AddProduct(currentProduct); // Faturaya ürün ekle
                    if (currentProduct.ProductType != "Market") // Ürün Market ürünü değil ise 
                    {

                        DiscountAmount += currentProduct.ProductPrice * discountCoefficient; // İndirilimli Toplam Fiyat hesapla

                        TotalPrice += currentProduct.ProductPrice; // Toplam fiyat hesapla
                    }
                    else
                    {
                        TotalPrice += currentProduct.ProductPrice; // Toplam Fiyat hesapla
                    }
                }

            }
            DiscountAmount += (int)TotalPrice / 100 * 5; // Faturada ki her 100 dolar üzeri alışveriş için indirim tutarını güncelle
            DiscountPrice = TotalPrice - DiscountAmount; //İndirimli tutarı hesapla

            var discount = new Discount((decimal)DiscountAmount); // İndirim tutarını İndirim tablosuna at
            invoice.SetDiscount(discount); // Faturaya İndirim tutarını ekle
            invoice.SetTotalPrice((decimal)TotalPrice); //Faturaya Toplam tutarı ekle

            customer.AddInvoice(invoice); //Müşteri tablosuna faturayı ekle

            return (decimal)DiscountPrice; // İndirimli tutarı gönder
        }
    }
}

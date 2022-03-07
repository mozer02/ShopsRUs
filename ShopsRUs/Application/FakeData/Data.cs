using ShopsRUs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application.FakeData
{
    public class Data
    {
        public List<Customer> Customers
        {
            get
            {
                return new List<Customer> //Yeni müşteri ekledik
                {
                    new Customer(firstName: "Muhammed", "Özer", CustomerStatus.Employee, identityNumber: 1234567),
                    new Customer(firstName: "Mert", "Corukoğlu", CustomerStatus.Affiliate, identityNumber: 7654321),
                    new Customer(firstName: "Mert", "Alptekin", CustomerStatus.DefaultCustomer, identityNumber: 1231233)
                };

            }

        }
        public List<ProductModel> Products 
        {
            get
            {
                return new List<ProductModel> //Ürünler Ekledik
                {
                    new ProductModel
                    {
                        Barcode = "1231231",
                        ProductName ="Kola",
                        ProductType = "Market",
                        ProductPrice = 20,

                    },
                    new ProductModel
                    {
                        Barcode = "12141245",
                        ProductName ="Mouse",
                        ProductType = "Teknoloji",
                        ProductPrice = 80,
                    },
                    new ProductModel
                    {
                        Barcode = "12312334",
                        ProductName ="Gömlek",
                        ProductType = "Kıyafet",
                        ProductPrice = 50,
                    },

                };

            }

        }

    }
}

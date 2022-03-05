using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public class Invoice:Entity
    {
        public string InvoiceNumber { get; private set; }
        public string Description { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Discount Discount { get; private set;}

        private List<ProductModel> products = new List<ProductModel>();
        public IReadOnlyList<ProductModel> Products => products;
        public Invoice(string description)
        {
            Id = Guid.NewGuid().ToString(); // Id oluşturuldu
            OnCreatedDate = DateTime.Now; //Oluşturulma tarihi atandı
            Description = description; //Açıklama eklendi
        }
        /// <summary>
        /// Fatura Numarası oluşturuldu
        /// </summary>
        /// <param name="invoiceCount"></param>
        public void SetInvoiceNumber(int invoiceCount)
        {
            InvoiceNumber = ("TR"+DateTime.Now.ToString("yyyy") + "0000" + invoiceCount);
        }
        /// <summary>
        /// İndirim tutarı atandı
        /// </summary>
        /// <param name="discount"></param>
        public void SetDiscount(Discount discount)
        {
            Discount = discount;
        }
        /// <summary>
        /// Toplam fiyat atandı
        /// </summary>
        /// <param name="totalPrice"></param>
        public void SetTotalPrice(decimal totalPrice)
        {
            TotalPrice = totalPrice;
        }
        /// <summary>
        /// Ürünler Atandı
        /// </summary>
        /// <param name="productModel"></param>
        public void AddProduct(ProductModel productModel)
        {
            products.Add(productModel);
        }
    }
}
